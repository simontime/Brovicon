using System.Diagnostics;

namespace Brovicon
{
    static class FFmpeg
    {
        public static IProgress<int>? Progress;

        public static double FindAudioPeak()
        {
            var maxVolume = 0.0;

            // Create process
            var process = new Process
            {
                StartInfo = {
                    WorkingDirectory = Path.Combine(Directory.GetCurrentDirectory(), "avs"),
                    FileName = Path.Combine(Directory.GetCurrentDirectory(), "avs", "ffmpeg.exe"),
                    ArgumentList =
                    {
                        // AviSynth script
                        "-i",
                        "script.avs",
                        // 'volumedetect' filter
                        "-af",
                        "volumedetect",
                        // Ignore video
                        "-vn",
                        // No file output
                        "-f",
                        "null",
                        "-"
                    },
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardError = true
                },
                EnableRaisingEvents = true,
            };

            // Triggered whenever a new line is written to stderr
            process.ErrorDataReceived += (sender, args) =>
            {
                // Log line to debug logger
                Debug.WriteLine(args.Data);

                if (args.Data != null && args.Data.Contains("max_volume"))
                {
                    // Find 'max_volume'
                    var volumeStart = args.Data.IndexOf("max_volume:") + 12;

                    // Find 'dB'
                    var db = args.Data.IndexOf("dB");

                    // Keep only what's between 'max_volume' and 'dB' (volume)
                    maxVolume = Convert.ToDouble(args.Data[volumeStart..db].Trim());
                }
            };

            // Start process
            process.Start();

            // Begin stderr reads
            process.BeginErrorReadLine();

            // Wait for process to exit
            process.WaitForExit();

            // Close process
            process.Close();

            // Return maximum volume
            return maxVolume;
        }

        public static void ConvertVideo
        (
            string outputFileName,
            string videoCodec,
            int    videoBitrate,
            string audioCodec,
            int    audioBitrate,
            bool   audioNormalise,
            bool   audioStereoMix,
            int    numFrames
        )
        {
            // Amount to boost volume by (in dB)
            var boost = 0.0;

            // Find volume peak for normalisation
            if (audioNormalise)
                boost = Math.Abs(FindAudioPeak());

            // Create process
            var process = new Process
            {
                StartInfo = {
                    WorkingDirectory = Path.Combine(Directory.GetCurrentDirectory(), "avs"),
                    FileName = Path.Combine(Directory.GetCurrentDirectory(), "avs", "ffmpeg.exe"),
                    ArgumentList =
                    {
                        // Force overwrite
                        "-y",
                        // AviSynth script
                        "-i",
                        "script.avs",
                        // Video codec
                        "-c:v",
                        videoCodec,
                        // Audio codec
                        "-c:a",
                        audioCodec,
                    },
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardError = true
                },
                EnableRaisingEvents = true,
            };

            // Add video bitrate conditionally
            if (videoBitrate != 0)
            {
                process.StartInfo.ArgumentList.Add("-b:v");
                process.StartInfo.ArgumentList.Add(videoBitrate.ToString());
            }

            // Add audio bitrate conditionally
            if (audioBitrate != 0)
            {
                process.StartInfo.ArgumentList.Add("-b:a");
                process.StartInfo.ArgumentList.Add(audioBitrate.ToString());
            }

            // Add normalisation conditionally
            if (audioNormalise && boost > 0.0)
            {
                process.StartInfo.ArgumentList.Add("-filter:a");
                process.StartInfo.ArgumentList.Add($"volume={boost}dB");
            }

            // Add stereo mix conditionally
            if (audioStereoMix)
            {
                process.StartInfo.ArgumentList.Add("-ac");
                process.StartInfo.ArgumentList.Add("2");
            }

            // Add output filename
            process.StartInfo.ArgumentList.Add(outputFileName);

            // Triggered whenever a new line is written to stderr
            process.ErrorDataReceived += (sender, args) =>
            {
                // Log line to debug logger
                Debug.WriteLine(args.Data);

                if (args.Data != null && args.Data.StartsWith("frame="))
                {
                    // Find 'fps=...'
                    var frameEnd = args.Data.IndexOf("fps");

                    // Keep only what's between 'frame' and 'fps' (frame number)
                    var frame = int.Parse(args.Data[6..frameEnd].Trim());

                    // Update progress
                    if (Progress != null)
                        Progress.Report(frame);
                }
            };

            // Triggered when conversion finished
            process.Exited += (sender, args) =>
            {
                // Done
                if (Progress != null)
                    Progress.Report(numFrames);
            };

            // Start conversion
            process.Start();

            // Begin stderr reads
            process.BeginErrorReadLine();
        }
    }
}
