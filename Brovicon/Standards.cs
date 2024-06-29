namespace Brovicon
{
    static class Standards
    {
        // Interlacing - field dominance
        public enum FieldOrder
        {
            Auto,
            Upper,
            Lower
        }

        public class NTSC : IStandard
        {
            // NTSC rates only
            public string[] GetAllowedFrameRates() => new string[] {
                "23.976p",
                "24p",
                "29.97p",
                "30p",
                "59.94p",
                "60p"
            };

            public int GetWidth() => 720;
            public int GetHeight() => 480;
        }

        public class PAL : IStandard
        {
            // PAL rates only
            public string[] GetAllowedFrameRates() => new string[] {
                "25p",
                "50p"
            };

            public int GetWidth() => 720;
            public int GetHeight() => 576;
        }

        public class HD_720 : IStandard
        {
            // All combinations allowed            
            public string[] GetAllowedFrameRates() => new string[] {
                "23.976p",
                "24p",
                "25p",
                "29.97p",
                "30p",
                "50p",
                "59.94p",
                "60p"
            };

            public int GetWidth() => 1280;
            public int GetHeight() => 720;
        }

        public class HD_1440_1080 : IStandard
        {
            // All combinations allowed            
            public string[] GetAllowedFrameRates() => new string[] {
                "23.976p",
                "24p",
                "25p",
                "29.97p",
                "30p",
                "50p",
                "59.94p",
                "60p"
            };

            public int GetWidth() => 1440;
            public int GetHeight() => 1080;
        }


        public class HD_1920_1080 : IStandard
        {
            // All combinations allowed            
            public string[] GetAllowedFrameRates() => new string[] {
                "23.976p",
                "24p",
                "25p",
                "29.97p",
                "30p",
                "50p",
                "59.94p",
                "60p",
            };

            public int GetWidth() => 1920;
            public int GetHeight() => 1080;
        }

        public class UHD_2880_2160 : IStandard
        {
            // All combinations allowed
            public string[] GetAllowedFrameRates() => new string[] {
                "23.976p",
                "24p",
                "25p",
                "29.97p",
                "30p",
                "50p",
                "59.94p",
                "60p",
            };

            public int GetWidth() => 2880;
            public int GetHeight() => 2160;
        }

        public class UHD_3840_2160 : IStandard
        {
            // All combinations allowed
            public string[] GetAllowedFrameRates() => new string[] {
                "23.976p",
                "24p",
                "25p",
                "29.97p",
                "30p",
                "50p",
                "59.94p",
                "60p",
            };

            public int GetWidth() => 3840;
            public int GetHeight() => 2160;
        }
    }
}
