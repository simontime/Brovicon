using static Brovicon.Standards;

namespace Brovicon
{
    public partial class Main : Form
    {
        bool                        isVideoLoaded = false;
        MediaInfo.MediaInfoWrapper? videoInformation;
        IStandard?                  videoStandard;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // No resize
            boxResizeMode.SelectedIndex = 0;

            // Set FieldOrder enum data source for combo box
            boxFieldOrder.DataSource = Enum.GetValues(typeof(FieldOrder));

            // Ensure dependencies exist
            if (!File.Exists("avs/ffmpeg.exe"))
            {
                MessageBox.Show("Error: Please ensure AviSynth/FFmpeg dependencies are in the 'avs' folder.");
                Application.Exit();
            }
        }

        // Triggered when 'Input' button pressed
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Show open file dialogue
            var res = dlgInputFile.ShowDialog();

            // 'OK' when file selected
            if (res == DialogResult.OK)
            {
                // Set filename text
                txtInputFilename.Text = dlgInputFile.FileName;

                // Get video info
                (videoInformation, var info) = VideoUtils.GetFormattedVideoInformation(dlgInputFile.FileName);

                // Set video labels
                lblInfoInputVideoCodec.Text = info.videoCodec;
                lblInfoInputVideoDimensions.Text = info.videoDimensions;
                lblInfoInputVideoBitRate.Text = info.videoBitRate;

                // Set audio labels
                lblInfoInputAudioCodec.Text = info.audioCodec;
                lblInfoInputAudioSampling.Text = info.audioSampling;
                lblInfoInputAudioBitRate.Text = info.audioBitRate;

                // Video is now loaded
                isVideoLoaded = true;
            }
        }

        // Triggered when 'Output' button pressed
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Show save file dialogue
            var res = dlgOutputFile.ShowDialog();

            // Set filename text if file selected
            if (res == DialogResult.OK)
            {
                txtOutputFilename.Text = dlgOutputFile.FileName;

                // Set video labels
                lblInfoOutputVideoCodec.Text = boxOutputVideoCodec.Text;
                lblInfoOutputVideoDimensions.Text = boxOutputResolution.Text;
                lblInfoOutputVideoBitRate.Text = boxOutputVideoBitRate.Text;

                // Set audio labels
                lblInfoOutputAudioCodec.Text = boxOutputAudioCodec.Text;
                lblInfoOutputAudioSampling.Text = (boxOutputAudioCodec.Text == string.Empty) ? string.Empty : "48.0 kHz, " + (chkMixStereo.Checked ? "2 ch." : "? ch.");
                lblInfoOutputAudioBitRate.Text = boxOutputAudioBitRate.Text;
            }
        }

        // Triggered when 'Force Interlaced' is toggled
        private void chkForceInterlaced_CheckedChanged(object sender, EventArgs e)
        {
            // Unchecks 'Force Progressive' if it is checked
            chkForceProgressive.Checked &= !chkForceInterlaced.Checked;

            // Enables field order selector
            lblFieldOrder.Enabled = chkForceInterlaced.Checked;
            boxFieldOrder.Enabled = chkForceInterlaced.Checked;
        }

        // Triggered when 'Force Progressive' is toggled
        private void chkForceProgressive_CheckedChanged(object sender, EventArgs e)
        {
            // Unchecks 'Force Interlaced' if it is checked
            chkForceInterlaced.Checked &= !chkForceProgressive.Checked;

            // Disables field order selector
            lblFieldOrder.Enabled = false;
            boxFieldOrder.Enabled = false;
        }

        // Triggered when resize mode is changed
        private void boxResizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enables/disables the crop selector
            void setCrop(bool enabled)
            {
                lblCrop.Enabled = enabled;
                boxCrop.Enabled = enabled;
            }

            // Enables/disables the stretch selector
            void setStretch(bool enabled)
            {
                lblStretch.Enabled = enabled;
                boxStretch.Enabled = enabled;
            }

            // Toggles crop/stretch selectors based on resize mode selected
            switch (boxResizeMode.SelectedIndex)
            {
                case 1: // Crop only
                    setCrop(true);
                    setStretch(false);
                    break;
                case 2: // Stretch only
                    setStretch(true);
                    setCrop(false);
                    break;
                case 3: // Crop then stretch
                    setCrop(true);
                    setStretch(true);
                    break;
                case 4: // Stretch then crop
                    setStretch(true);
                    setCrop(true);
                    break;
                default: // Disable crop/stretch selectors if 'No resize' selected
                    setCrop(false);
                    setStretch(false);
                    break;
            }
        }

        // Triggered when output video codec is selected
        private void boxOutputVideoCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enables/disables the bit rate selector
            void setBitRate(bool enabled)
            {
                lblOutputVideoBitRate.Enabled = enabled;
                lblInfoOutputVideoBitRate.Visible = enabled;
                boxOutputVideoBitRate.Enabled = enabled;
            }

            // Toggles video bit rate selector based on codec selected
            switch (boxOutputVideoCodec.SelectedIndex)
            {
                case 0: case 1: case 5: // DNxHD, DV and ProRes use set bit rates
                    setBitRate(false);
                    break;
                default: // MPEG-2, H.264 and H.265 have adjustable bit rates
                    setBitRate(true);
                    break;
            }

            // Sets the output video codec string
            if (txtOutputFilename.Text != string.Empty)
                lblInfoOutputVideoCodec.Text = boxOutputVideoCodec.Text;
        }

        // Triggered when output audio codec is selected
        private void boxOutputAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enables/disables the bit rate selector
            void setBitRate(bool enabled)
            {
                lblOutputAudioBitRate.Enabled = enabled;
                lblInfoOutputAudioBitRate.Visible = enabled;
                boxOutputAudioBitRate.Enabled = enabled;
            }

            // Turns off bitrate selector if PCM selected, turns on otherwise
            setBitRate(boxOutputAudioCodec.SelectedIndex <= 4);

            // Sets the output audio codec and sampling strings
            if (txtOutputFilename.Text != string.Empty)
            {
                lblInfoOutputAudioCodec.Text = boxOutputAudioCodec.Text;
                lblInfoOutputAudioSampling.Text = (boxOutputAudioCodec.Text == string.Empty) ? string.Empty : (chkMixStereo.Checked ? "48.0 kHz, 2 ch." : lblInfoInputAudioSampling.Text);
            }
        }

        // Triggered when output resolution is selected
        private void boxOutputResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Choose standard based on selected output resolution
            switch (boxOutputResolution.SelectedIndex)
            {
                case 0: // NTSC
                    videoStandard = new Standards.NTSC();
                    break;
                case 1: // PAL
                    videoStandard = new Standards.PAL();
                    break;
                case 2: // HD 720
                    videoStandard = new Standards.HD_720();
                    break;
                case 3: // HD 1440x1080
                    videoStandard = new Standards.HD_1440_1080();
                    break;
                case 4: // HD 1920x1080
                    videoStandard = new Standards.HD_1920_1080();
                    break;
                case 5: // UHD/4K 2880x2160
                    videoStandard = new Standards.UHD_2880_2160();
                    break;
                case 6: // UHD/4K 3840x2160 (4K)
                    videoStandard = new Standards.UHD_3840_2160();
                    break;
                default: // Shouldn't ever be reached, defaults to 1920x1080
                    videoStandard = new Standards.HD_1920_1080();
                    break;
            }

            // Enable output frame rate selection
            lblOutputFrameRate.Enabled = true;
            boxOutputFrameRate.Enabled = true;

            // Add allowed frame rates for standard
            boxOutputFrameRate.Items.Clear();
            boxOutputFrameRate.Items.AddRange(videoStandard.GetAllowedFrameRates());

            // Sets the output dimensions string
            if (txtOutputFilename.Text != string.Empty)
            {
                if (boxOutputFrameRate.Text != string.Empty)
                    lblInfoOutputVideoDimensions.Text = boxOutputResolution.Text + "/" + boxOutputFrameRate.Text;
                else
                    lblInfoOutputVideoDimensions.Text = boxOutputResolution.Text;
            }
        }

        // Triggered when frame rate is selected
        private void boxOutputFrameRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets the output dimensions string
            if (txtOutputFilename.Text != string.Empty)
                lblInfoOutputVideoDimensions.Text = boxOutputResolution.Text + "/" + boxOutputFrameRate.Text;
        }

        // Triggered when video bit rate is selected
        private void boxOutputVideoBitRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets the output video bitrate string
            if (txtOutputFilename.Text != string.Empty)
                lblInfoOutputVideoBitRate.Text = boxOutputVideoBitRate.Text;
        }

        // Triggered when audio bit rate is selected
        private void boxOutputAudioBitRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sets the output audio bitrate string
            if (txtOutputFilename.Text != string.Empty)
                lblInfoOutputAudioBitRate.Text = boxOutputAudioBitRate.Text;
        }

        // Converts a description returned by VideoInfo to a decimal ratio
        double description2Ratio(string aspect, double width, double height)
        {
            if (aspect == "fullscreen")
                return 4.0 / 3.0;
            else if (aspect == "widescreen")
                return 16.0 / 9.0;
            else
                return width / height;
        }

        // Converts a string ratio (e.g., 4:3) to its decimal equivalent
        double string2Ratio(string ratio)
        {
            var split = ratio.Split(":");

            var n1 = Convert.ToDouble(split[0]);
            var n2 = Convert.ToDouble(split[1]);

            return n1 / n2;
        }

        // Converts a string representation of a bit rate to int
        private int string2BitRate(string bitRate)
        {
            var split = bitRate.Split(" ");
            
            // Get numeric amount
            var number = Convert.ToDouble(split[0]);

            // Scale to units
            if (split[1] == "kbps")
                number *= 1_000;
            else if (split[1] == "Mbps")
                number *= 1_000_000;

            return (int)number;
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (isVideoLoaded                            && 
                videoInformation         != null         &&
                videoStandard            != null         &&
                txtOutputFilename.Text   != string.Empty &&
                boxOutputResolution.Text != string.Empty &&
                boxOutputFrameRate.Text  != string.Empty &&
                boxOutputVideoCodec.Text != string.Empty &&
                boxOutputAudioCodec.Text != string.Empty)
            {
                // Input and output filenames
                var inputFilename  = txtInputFilename.Text;
                var outputFilename = txtOutputFilename.Text;

                // Processing options
                var processNoise   = chkNoiseReduction.Checked;
                var normaliseAudio = chkNormaliseAudio.Checked;
                var mixStereo      = chkMixStereo.Checked;

                // Sizing
                var cropRatio = double.NaN;
                var stretchRatio = double.NaN;

                var stretchFirst = boxResizeMode.SelectedIndex == 4;

                if (boxCrop.Enabled)
                    cropRatio = string2Ratio(boxCrop.Text);

                if (boxStretch.Enabled)
                    stretchRatio = string2Ratio(boxStretch.Text);

                // Dimensions and ratios
                var originalHeight = videoInformation.Height;
                var originalRatio  = description2Ratio(videoInformation.AspectRatio, videoInformation.Width, videoInformation.Height);
                var scaledWidth    = videoStandard.GetWidth();
                var scaledHeight   = videoStandard.GetHeight();

                // Target frame rate
                var targetFrameRate = Convert.ToDouble(boxOutputFrameRate.Text[..^1]);

                // Calculate original frame rate
                var originalFrameRate = videoInformation.Framerate;

                if (videoInformation.IsInterlaced)
                    originalFrameRate *= 2;

                // Don't do frame rate conversion if input and output equal
                if (originalFrameRate == targetFrameRate)
                    targetFrameRate = double.NaN;

                // Only perform interpolation if frame rate not an exact multiple
                var interpolate = originalFrameRate != targetFrameRate / 2 && targetFrameRate != originalFrameRate / 2;

                // Interlacing
                var deInterlace = videoInformation.IsInterlaced;

                // Override automatic detection
                if (chkForceInterlaced.Checked)
                    deInterlace = true;

                if (chkForceProgressive.Checked)
                    deInterlace = false;

                // Field order
                var fieldOrder = FieldOrder.Auto;

                if (boxFieldOrder.Enabled)
                    fieldOrder = (FieldOrder)boxFieldOrder.SelectedItem;

                // Codecs and bit rates
                var videoCodec   = boxOutputVideoCodec.Text.ToLower();
                var videoBitRate = 0;
                var audioCodec   = boxOutputAudioCodec.Text.ToLower();
                var audioBitRate = 0;

                if (boxOutputVideoBitRate.Enabled)
                    videoBitRate = string2BitRate(boxOutputVideoBitRate.Text);

                if (boxOutputAudioBitRate.Enabled)
                    audioBitRate = string2BitRate(boxOutputAudioBitRate.Text);

                // Calculate total number of frames
                var numFrames = 0;

                if (!double.IsNaN(targetFrameRate))
                    numFrames = (int)(videoInformation.Duration / 1_000.0 * targetFrameRate);
                else
                    numFrames = (int)(videoInformation.Duration / 1_000.0 * originalFrameRate);

                // Generate script
                var script = Scripting.GenerateAviSynthScript(
                    inputFilename,
                    deInterlace,
                    fieldOrder,
                    processNoise,
                    originalHeight,
                    originalRatio,
                    scaledWidth,
                    scaledHeight,
                    cropRatio,
                    stretchRatio,
                    stretchFirst,
                    targetFrameRate,
                    interpolate
                );

                // Write script to temporary file
                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "avs", "script.avs"), script);

                // Change status to 'Analysing...'
                lblStatus.Text = "Analysing...";

                // Disable 'Convert' button
                btnConvert.Enabled = false;

                // Update UI on progress
                FFmpeg.Progress = new Progress<int> (frame =>
                {
                    var percent = ((double)frame / numFrames) * 100.0;

                    // Conversion in progress
                    if (percent < 100.0)
                    {
                        lblStatus.Text     = "Converting...";
                        lblPercentage.Text = $"{percent:F1}%";

                        progressBar.Value  = (int)percent;
                    }
                    else if (lblStatus.Text != "Done") // Conversion done
                    {
                        lblStatus.Text     = "Done";
                        lblPercentage.Text = "100.0%";

                        progressBar.Value  = 100;

                        btnConvert.Enabled = true;

                        MessageBox.Show("Conversion complete!");
                    }
                });
                
                // Convert video
                await Task.Run(() => FFmpeg.ConvertVideo
                (
                    outputFilename,
                    videoCodec,
                    videoBitRate,
                    audioCodec,
                    audioBitRate,
                    normaliseAudio,
                    mixStereo,
                    numFrames
                ));
            }
        }
    }
}