using static Brovicon.Standards;

namespace Brovicon
{
    static class Scripting
    {
        // Plugin DLL filenames to import
        static readonly string[] PluginDLLs =
        {
            "FFMS2.dll",
            "masktools2.dll",
            "mvtools2.dll",
            "nnedi3.dll",
            "RgTools.dll",
            "fft3dfilter.dll",
            "hqdn3d.dll"
        };

        // Script filenames to import
        static readonly string[] Scripts =
        {
            "Zs_RF_Shared.avsi",
            "QTGMC.avsi",
            "TemporalDegrain.avs"
        };

        // Generates an AviSynth script given parameters
        public static string GenerateAviSynthScript
        (
            string     videoFileName,
            bool       deInterlace,
            FieldOrder fieldOrder,
            bool       deNoise,
            int        originalHeight,
            double     originalRatio,
            int        targetWidth,
            int        targetHeight,
            double     cropRatio,
            double     stretchRatio,
            bool       stretchFirst,
            double     targetFrameRate,
            bool       interpolate
        )
        {
            // String the script will be written to
            var script = string.Empty;

            // Emits a function call
            void callFunction(string function, params object[] args)
            {
                // Function name
                script += function;

                // Begin arguments
                if (args.Length > 0)
                    script += "(";

                // Iterate through arguments
                for (var i = 0; i < args.Length; i++)
                {
                    // Add argument separator
                    if (i > 0)
                        script += ", ";

                    if (args[i] is string) // Add quotes if argument is string
                    {
                        if (((string)args[i]).StartsWith("$")) // Verbatim
                            script += ((string)args[i])[1..];
                        else
                            script += "\"" + args[i] + "\"";
                    }
                    else // Add argument verbatim
                    {
                        script += args[i].ToString();
                    }
                }

                // End arguments
                if (args.Length > 0)
                    script += ")";

                // Add new line
                script += "\n";
            }

            // Add plugins to script
            foreach (var plugin in PluginDLLs)
                callFunction("LoadPlugin", plugin);

            // Add imported scripts to script
            foreach (var _script in Scripts)
                callFunction("Import", _script);

            // Import video
            callFunction("FFmpegSource2", videoFileName, "$atrack=-1");

            // De-interlace
            if (deInterlace)
            {
                // Set field order
                if (fieldOrder != FieldOrder.Auto)
                {
                    if (fieldOrder == FieldOrder.Upper)
                        callFunction("AssumeTFF");

                    if (fieldOrder == FieldOrder.Lower)
                        callFunction("AssumeBFF");
                }

                callFunction("QTGMC");
            }

            // De-noise
            if (deNoise)
                callFunction("TemporalDegrain");

            // Convert frame rate
            if (!double.IsNaN(targetFrameRate))
                callFunction(interpolate ? "ConvertFPS" : "ChangeFPS", targetFrameRate);

            /// Sizing

            // Working dimensions
            var width = originalHeight * originalRatio;
            var height = (double)originalHeight;

            // Stretch first if specified
            if (stretchFirst && !double.IsNaN(stretchRatio)) // Stretch first
            {
                // Check bounds
                if (originalRatio <= stretchRatio)
                    width = height * stretchRatio;
                else
                    height = width * (1.0 / stretchRatio);

                // Stretch to new ratio
                callFunction("Lanczos4Resize", (int)Math.Round(width), (int)Math.Round(height));
            }
            
            if (!double.IsNaN(cropRatio)) // Crop
            {
                var croppedWidth  = width;
                var croppedHeight = height;

                // Check which direction to crop
                if (originalRatio <= cropRatio)
                    croppedHeight = width * (1.0 / cropRatio);
                else
                    croppedWidth = height * cropRatio;

                // Calculate difference
                var cropHorizontal = (int)Math.Round((width  - croppedWidth)  / 2);
                var cropVertical   = (int)Math.Round((height - croppedHeight) / 2);

                // Crop
                callFunction("Crop", cropHorizontal, cropVertical, -cropHorizontal, -cropVertical);

                width  = croppedWidth;
                height = croppedHeight;
            }

            // Choose scale factor
            if (targetWidth > width || targetHeight > height)
            {
                var scaleHorizontal = targetWidth / width;
                var scaleVertical   = targetHeight / height;

                if (scaleHorizontal >= 4.0 || scaleVertical >= 4.0)
                    callFunction("nnedi3_rpow2", 8);
                else if (scaleHorizontal >= 2.0 || scaleVertical >= 2.0)
                    callFunction("nnedi3_rpow2", 4);
                else
                    callFunction("nnedi3_rpow2", 2);
            }

            if (!stretchFirst && !double.IsNaN(stretchRatio))
            {
                if (originalRatio <= stretchRatio)
                {
                    width = targetWidth;
                    height = targetWidth * (1.0 / stretchRatio);
                }
                else
                {
                    width = targetHeight * stretchRatio;
                    height = targetHeight;
                }
            }
            else
            {
                var widthScale  = targetWidth / width;
                var heightScale = targetHeight / height;

                if (widthScale < heightScale)
                {
                    width  *= widthScale;
                    height *= widthScale;
                }
                else
                {
                    width  *= heightScale;
                    height *= heightScale;
                }
            }

            // Resize
            callFunction("Lanczos4Resize", (int)Math.Round(width), (int)Math.Round(height));

            // Calculate difference between target size and current size
            var paddingHorizontal = (int)Math.Round((targetWidth  - width)  / 2);
            var paddingVertical   = (int)Math.Round((targetHeight - height) / 2);

            // Add black bars
            if (paddingHorizontal > 0 || paddingVertical > 0)
                callFunction("AddBorders", paddingHorizontal, paddingVertical, paddingHorizontal, paddingVertical);

            return script;
        }
    }
}
