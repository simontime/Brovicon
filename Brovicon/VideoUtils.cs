using MediaInfo;

namespace Brovicon
{
    static class VideoUtils
    {
        public struct FormattedVideoInformation
        {
            public string videoCodec;
            public string videoDimensions;
            public string videoBitRate;
             
            public string audioCodec;
            public string audioSampling;
            public string audioBitRate;
        }

        // Returns frame rate formatted with interlacing information
        private static string GetFormattedFrameRateInformation(double frameRate, bool interlaced)
        {
            if (interlaced)
                return (frameRate * 2).ToString() + "i";
            else
                return frameRate.ToString() + "p";
        }

        // Returns clearer aspect ratio information
        private static string GetAspectRatioInformation(string aspect)
        {
            if (aspect == "fullscreen")
                return "4:3";
            else if (aspect == "widescreen")
                return "16:9";
            else
                return aspect;
        }

        public static Tuple<MediaInfoWrapper, FormattedVideoInformation> GetFormattedVideoInformation(string fileName)
        {
            // Create new MediaInfoWrapper object
            var mediaInfo = new MediaInfoWrapper(fileName);

            // Create new formatted struct
            var formattedInfo = new FormattedVideoInformation();

            // Check if file has video stream
            if (mediaInfo.HasVideo)
            {
                // Get video info
                formattedInfo.videoCodec = mediaInfo.VideoCodec;
                formattedInfo.videoDimensions = $"{mediaInfo.Width}x{mediaInfo.Height}/{GetFormattedFrameRateInformation(mediaInfo.Framerate, mediaInfo.IsInterlaced)}, {GetAspectRatioInformation(mediaInfo.AspectRatio)}";
                formattedInfo.videoBitRate = $"{mediaInfo.VideoRate / 1_000_000.0f:N1} Mbps"; ;
            }
            else
            {
                formattedInfo.videoCodec = "No video track";
            }

            // Check if file has audio stream
            if (mediaInfo.AudioStreams.Count > 0)
            {
                // Get audio info
                formattedInfo.audioCodec = mediaInfo.AudioCodec;
                formattedInfo.audioSampling = $"{mediaInfo.AudioSampleRate / 1_000.0f:F1} kHz, {mediaInfo.AudioChannels} ch.";
                formattedInfo.audioBitRate = $"{mediaInfo.AudioRate / 1_000.0f:N0} kbps";
            }
            else
            {
                formattedInfo.audioCodec = "No audio track";
            }

            return Tuple.Create(mediaInfo, formattedInfo);
        }
    }
}
