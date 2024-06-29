namespace Brovicon
{
    partial class Main : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            boxOutputResolution = new ComboBox();
            boxOutputFrameRate = new ComboBox();
            chkNoiseReduction = new CheckBox();
            dlgInputFile = new OpenFileDialog();
            txtOutputFilename = new TextBox();
            btnOpen = new Button();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            lblPercentage = new ToolStripStatusLabel();
            lblInput = new Label();
            lblOutput = new Label();
            btnSave = new Button();
            txtInputFilename = new TextBox();
            grpProcessing = new GroupBox();
            grpProcessingAudio = new GroupBox();
            chkNormaliseAudio = new CheckBox();
            chkMixStereo = new CheckBox();
            grpProcessingVideo = new GroupBox();
            lblFieldOrder = new Label();
            boxFieldOrder = new ComboBox();
            lblForce = new Label();
            chkForceProgressive = new CheckBox();
            chkForceInterlaced = new CheckBox();
            grpFileInformation = new GroupBox();
            grpVideoInformationOutput = new GroupBox();
            lblInfoOutputAudioBitRate = new Label();
            lblInfoOutputVideoCodec = new Label();
            lblInfoOutputAudioSampling = new Label();
            lblInfoOutputVideoBitRate = new Label();
            lblInfoOutputAudioCodec = new Label();
            lblInfoOutputVideoDimensions = new Label();
            grpVideoInformationInput = new GroupBox();
            lblInfoInputAudioBitRate = new Label();
            lblInfoInputAudioSampling = new Label();
            lblInfoInputAudioCodec = new Label();
            lblInfoInputVideoDimensions = new Label();
            lblInfoInputVideoBitRate = new Label();
            lblInfoInputVideoCodec = new Label();
            dlgOutputFile = new SaveFileDialog();
            grpOutput = new GroupBox();
            grpOutputEncoding = new GroupBox();
            lblOutputAudioBitRate = new Label();
            boxOutputAudioBitRate = new ComboBox();
            lblOutputVideoBitRate = new Label();
            boxOutputVideoBitRate = new ComboBox();
            boxOutputAudioCodec = new ComboBox();
            lblOutputVideoCodec = new Label();
            lblOutputAudioCodec = new Label();
            boxOutputVideoCodec = new ComboBox();
            grpOutputPresentation = new GroupBox();
            lblOutputFrameRate = new Label();
            lblOutputResolution = new Label();
            boxResizeMode = new ComboBox();
            boxStretch = new ComboBox();
            boxCrop = new ComboBox();
            lblStretch = new Label();
            lblCrop = new Label();
            grpResize = new GroupBox();
            btnConvert = new Button();
            statusStrip.SuspendLayout();
            grpProcessing.SuspendLayout();
            grpProcessingAudio.SuspendLayout();
            grpProcessingVideo.SuspendLayout();
            grpFileInformation.SuspendLayout();
            grpVideoInformationOutput.SuspendLayout();
            grpVideoInformationInput.SuspendLayout();
            grpOutput.SuspendLayout();
            grpOutputEncoding.SuspendLayout();
            grpOutputPresentation.SuspendLayout();
            grpResize.SuspendLayout();
            SuspendLayout();
            // 
            // boxOutputResolution
            // 
            boxOutputResolution.DropDownStyle = ComboBoxStyle.DropDownList;
            boxOutputResolution.FormattingEnabled = true;
            boxOutputResolution.Items.AddRange(new object[] { "720x480", "720x576", "1280x720", "1440x1080", "1920x1080", "2880x2160", "3840x2160" });
            boxOutputResolution.Location = new Point(74, 20);
            boxOutputResolution.Margin = new Padding(2);
            boxOutputResolution.Name = "boxOutputResolution";
            boxOutputResolution.Size = new Size(109, 23);
            boxOutputResolution.TabIndex = 0;
            boxOutputResolution.SelectedIndexChanged += boxOutputResolution_SelectedIndexChanged;
            // 
            // boxOutputFrameRate
            // 
            boxOutputFrameRate.DropDownStyle = ComboBoxStyle.DropDownList;
            boxOutputFrameRate.Enabled = false;
            boxOutputFrameRate.FormattingEnabled = true;
            boxOutputFrameRate.Items.AddRange(new object[] { "23.976p", "24p", "25p", "29.97p", "30p", "50p", "59.94p", "60p", "50i", "59.94i", "60i" });
            boxOutputFrameRate.Location = new Point(259, 20);
            boxOutputFrameRate.Margin = new Padding(2);
            boxOutputFrameRate.Name = "boxOutputFrameRate";
            boxOutputFrameRate.Size = new Size(76, 23);
            boxOutputFrameRate.TabIndex = 1;
            boxOutputFrameRate.SelectedIndexChanged += boxOutputFrameRate_SelectedIndexChanged;
            // 
            // chkNoiseReduction
            // 
            chkNoiseReduction.AutoSize = true;
            chkNoiseReduction.Location = new Point(9, 19);
            chkNoiseReduction.Margin = new Padding(2);
            chkNoiseReduction.Name = "chkNoiseReduction";
            chkNoiseReduction.Size = new Size(110, 19);
            chkNoiseReduction.TabIndex = 2;
            chkNoiseReduction.Text = "Noise reduction";
            chkNoiseReduction.UseVisualStyleBackColor = true;
            // 
            // dlgInputFile
            // 
            dlgInputFile.Filter = "All files|*.*";
            // 
            // txtOutputFilename
            // 
            txtOutputFilename.Location = new Point(60, 33);
            txtOutputFilename.Margin = new Padding(2);
            txtOutputFilename.Name = "txtOutputFilename";
            txtOutputFilename.Size = new Size(270, 23);
            txtOutputFilename.TabIndex = 5;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(334, 5);
            btnOpen.Margin = new Padding(2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(25, 25);
            btnOpen.TabIndex = 6;
            btnOpen.Text = "...";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(28, 28);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, progressBar, lblPercentage });
            statusStrip.Location = new Point(0, 619);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 8, 0);
            statusStrip.Size = new Size(369, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(26, 17);
            lblStatus.Text = "Idle";
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(250, 16);
            progressBar.Step = 1;
            // 
            // lblPercentage
            // 
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(12, 17);
            lblPercentage.Text = "-";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(8, 10);
            lblInput.Margin = new Padding(2, 0, 2, 0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(38, 15);
            lblInput.TabIndex = 8;
            lblInput.Text = "Input:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(8, 37);
            lblOutput.Margin = new Padding(2, 0, 2, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(48, 15);
            lblOutput.TabIndex = 11;
            lblOutput.Text = "Output:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(334, 32);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(25, 25);
            btnSave.TabIndex = 10;
            btnSave.Text = "...";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtInputFilename
            // 
            txtInputFilename.Location = new Point(60, 6);
            txtInputFilename.Margin = new Padding(2);
            txtInputFilename.Name = "txtInputFilename";
            txtInputFilename.Size = new Size(270, 23);
            txtInputFilename.TabIndex = 9;
            // 
            // grpProcessing
            // 
            grpProcessing.Controls.Add(grpProcessingAudio);
            grpProcessing.Controls.Add(grpProcessingVideo);
            grpProcessing.Location = new Point(11, 207);
            grpProcessing.Margin = new Padding(2);
            grpProcessing.Name = "grpProcessing";
            grpProcessing.Padding = new Padding(2);
            grpProcessing.Size = new Size(347, 142);
            grpProcessing.TabIndex = 12;
            grpProcessing.TabStop = false;
            grpProcessing.Text = "Processing";
            // 
            // grpProcessingAudio
            // 
            grpProcessingAudio.Controls.Add(chkNormaliseAudio);
            grpProcessingAudio.Controls.Add(chkMixStereo);
            grpProcessingAudio.Location = new Point(4, 96);
            grpProcessingAudio.Name = "grpProcessingAudio";
            grpProcessingAudio.Size = new Size(339, 45);
            grpProcessingAudio.TabIndex = 7;
            grpProcessingAudio.TabStop = false;
            grpProcessingAudio.Text = "Audio";
            // 
            // chkNormaliseAudio
            // 
            chkNormaliseAudio.AutoSize = true;
            chkNormaliseAudio.Location = new Point(9, 19);
            chkNormaliseAudio.Margin = new Padding(2);
            chkNormaliseAudio.Name = "chkNormaliseAudio";
            chkNormaliseAudio.Size = new Size(113, 19);
            chkNormaliseAudio.TabIndex = 5;
            chkNormaliseAudio.Text = "Normalise audio";
            chkNormaliseAudio.UseVisualStyleBackColor = true;
            // 
            // chkMixStereo
            // 
            chkMixStereo.AutoSize = true;
            chkMixStereo.Location = new Point(126, 19);
            chkMixStereo.Margin = new Padding(2);
            chkMixStereo.Name = "chkMixStereo";
            chkMixStereo.Size = new Size(95, 19);
            chkMixStereo.TabIndex = 11;
            chkMixStereo.Text = "Mix to stereo";
            chkMixStereo.UseVisualStyleBackColor = true;
            // 
            // grpProcessingVideo
            // 
            grpProcessingVideo.Controls.Add(lblFieldOrder);
            grpProcessingVideo.Controls.Add(boxFieldOrder);
            grpProcessingVideo.Controls.Add(lblForce);
            grpProcessingVideo.Controls.Add(chkNoiseReduction);
            grpProcessingVideo.Controls.Add(chkForceProgressive);
            grpProcessingVideo.Controls.Add(chkForceInterlaced);
            grpProcessingVideo.Location = new Point(4, 19);
            grpProcessingVideo.Name = "grpProcessingVideo";
            grpProcessingVideo.Size = new Size(339, 71);
            grpProcessingVideo.TabIndex = 6;
            grpProcessingVideo.TabStop = false;
            grpProcessingVideo.Text = "Video";
            // 
            // lblFieldOrder
            // 
            lblFieldOrder.AutoSize = true;
            lblFieldOrder.Enabled = false;
            lblFieldOrder.Location = new Point(264, 19);
            lblFieldOrder.Name = "lblFieldOrder";
            lblFieldOrder.Size = new Size(66, 15);
            lblFieldOrder.TabIndex = 21;
            lblFieldOrder.Text = "Field order:";
            // 
            // boxFieldOrder
            // 
            boxFieldOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            boxFieldOrder.Enabled = false;
            boxFieldOrder.FormattingEnabled = true;
            boxFieldOrder.Items.AddRange(new object[] { "Auto", "Upper", "Lower" });
            boxFieldOrder.Location = new Point(266, 36);
            boxFieldOrder.Margin = new Padding(2);
            boxFieldOrder.Name = "boxFieldOrder";
            boxFieldOrder.Size = new Size(69, 23);
            boxFieldOrder.TabIndex = 20;
            // 
            // lblForce
            // 
            lblForce.AutoSize = true;
            lblForce.Location = new Point(124, 20);
            lblForce.Name = "lblForce";
            lblForce.Size = new Size(39, 15);
            lblForce.TabIndex = 11;
            lblForce.Text = "Force:";
            // 
            // chkForceProgressive
            // 
            chkForceProgressive.AutoSize = true;
            chkForceProgressive.Location = new Point(168, 41);
            chkForceProgressive.Margin = new Padding(2);
            chkForceProgressive.Name = "chkForceProgressive";
            chkForceProgressive.Size = new Size(86, 19);
            chkForceProgressive.TabIndex = 10;
            chkForceProgressive.Text = "Progressive";
            chkForceProgressive.UseVisualStyleBackColor = true;
            chkForceProgressive.CheckedChanged += chkForceProgressive_CheckedChanged;
            // 
            // chkForceInterlaced
            // 
            chkForceInterlaced.AutoSize = true;
            chkForceInterlaced.Location = new Point(168, 19);
            chkForceInterlaced.Margin = new Padding(2);
            chkForceInterlaced.Name = "chkForceInterlaced";
            chkForceInterlaced.Size = new Size(78, 19);
            chkForceInterlaced.TabIndex = 9;
            chkForceInterlaced.Text = "Interlaced";
            chkForceInterlaced.UseVisualStyleBackColor = true;
            chkForceInterlaced.CheckedChanged += chkForceInterlaced_CheckedChanged;
            // 
            // grpFileInformation
            // 
            grpFileInformation.Controls.Add(grpVideoInformationOutput);
            grpFileInformation.Controls.Add(grpVideoInformationInput);
            grpFileInformation.Location = new Point(11, 61);
            grpFileInformation.Margin = new Padding(2);
            grpFileInformation.Name = "grpFileInformation";
            grpFileInformation.Padding = new Padding(2);
            grpFileInformation.Size = new Size(347, 142);
            grpFileInformation.TabIndex = 13;
            grpFileInformation.TabStop = false;
            grpFileInformation.Text = "File information";
            // 
            // grpVideoInformationOutput
            // 
            grpVideoInformationOutput.Controls.Add(lblInfoOutputAudioBitRate);
            grpVideoInformationOutput.Controls.Add(lblInfoOutputVideoCodec);
            grpVideoInformationOutput.Controls.Add(lblInfoOutputAudioSampling);
            grpVideoInformationOutput.Controls.Add(lblInfoOutputVideoBitRate);
            grpVideoInformationOutput.Controls.Add(lblInfoOutputAudioCodec);
            grpVideoInformationOutput.Controls.Add(lblInfoOutputVideoDimensions);
            grpVideoInformationOutput.Location = new Point(175, 18);
            grpVideoInformationOutput.Margin = new Padding(2);
            grpVideoInformationOutput.Name = "grpVideoInformationOutput";
            grpVideoInformationOutput.Padding = new Padding(2);
            grpVideoInformationOutput.Size = new Size(168, 120);
            grpVideoInformationOutput.TabIndex = 15;
            grpVideoInformationOutput.TabStop = false;
            grpVideoInformationOutput.Text = "Output";
            // 
            // lblInfoOutputAudioBitRate
            // 
            lblInfoOutputAudioBitRate.AutoSize = true;
            lblInfoOutputAudioBitRate.Location = new Point(6, 99);
            lblInfoOutputAudioBitRate.Name = "lblInfoOutputAudioBitRate";
            lblInfoOutputAudioBitRate.Size = new Size(0, 15);
            lblInfoOutputAudioBitRate.TabIndex = 11;
            // 
            // lblInfoOutputVideoCodec
            // 
            lblInfoOutputVideoCodec.AutoSize = true;
            lblInfoOutputVideoCodec.Location = new Point(6, 18);
            lblInfoOutputVideoCodec.Name = "lblInfoOutputVideoCodec";
            lblInfoOutputVideoCodec.Size = new Size(127, 15);
            lblInfoOutputVideoCodec.TabIndex = 6;
            lblInfoOutputVideoCodec.Text = "No output file selected";
            // 
            // lblInfoOutputAudioSampling
            // 
            lblInfoOutputAudioSampling.AutoSize = true;
            lblInfoOutputAudioSampling.Location = new Point(6, 84);
            lblInfoOutputAudioSampling.Name = "lblInfoOutputAudioSampling";
            lblInfoOutputAudioSampling.Size = new Size(0, 15);
            lblInfoOutputAudioSampling.TabIndex = 10;
            // 
            // lblInfoOutputVideoBitRate
            // 
            lblInfoOutputVideoBitRate.AutoSize = true;
            lblInfoOutputVideoBitRate.Location = new Point(6, 48);
            lblInfoOutputVideoBitRate.Name = "lblInfoOutputVideoBitRate";
            lblInfoOutputVideoBitRate.Size = new Size(0, 15);
            lblInfoOutputVideoBitRate.TabIndex = 7;
            // 
            // lblInfoOutputAudioCodec
            // 
            lblInfoOutputAudioCodec.AutoSize = true;
            lblInfoOutputAudioCodec.Location = new Point(6, 69);
            lblInfoOutputAudioCodec.Name = "lblInfoOutputAudioCodec";
            lblInfoOutputAudioCodec.Size = new Size(0, 15);
            lblInfoOutputAudioCodec.TabIndex = 9;
            // 
            // lblInfoOutputVideoDimensions
            // 
            lblInfoOutputVideoDimensions.AutoSize = true;
            lblInfoOutputVideoDimensions.Location = new Point(6, 33);
            lblInfoOutputVideoDimensions.Name = "lblInfoOutputVideoDimensions";
            lblInfoOutputVideoDimensions.Size = new Size(0, 15);
            lblInfoOutputVideoDimensions.TabIndex = 8;
            // 
            // grpVideoInformationInput
            // 
            grpVideoInformationInput.Controls.Add(lblInfoInputAudioBitRate);
            grpVideoInformationInput.Controls.Add(lblInfoInputAudioSampling);
            grpVideoInformationInput.Controls.Add(lblInfoInputAudioCodec);
            grpVideoInformationInput.Controls.Add(lblInfoInputVideoDimensions);
            grpVideoInformationInput.Controls.Add(lblInfoInputVideoBitRate);
            grpVideoInformationInput.Controls.Add(lblInfoInputVideoCodec);
            grpVideoInformationInput.Location = new Point(4, 18);
            grpVideoInformationInput.Margin = new Padding(2);
            grpVideoInformationInput.Name = "grpVideoInformationInput";
            grpVideoInformationInput.Padding = new Padding(2);
            grpVideoInformationInput.Size = new Size(168, 120);
            grpVideoInformationInput.TabIndex = 14;
            grpVideoInformationInput.TabStop = false;
            grpVideoInformationInput.Text = "Input";
            // 
            // lblInfoInputAudioBitRate
            // 
            lblInfoInputAudioBitRate.AutoSize = true;
            lblInfoInputAudioBitRate.Location = new Point(6, 99);
            lblInfoInputAudioBitRate.Name = "lblInfoInputAudioBitRate";
            lblInfoInputAudioBitRate.Size = new Size(0, 15);
            lblInfoInputAudioBitRate.TabIndex = 5;
            // 
            // lblInfoInputAudioSampling
            // 
            lblInfoInputAudioSampling.AutoSize = true;
            lblInfoInputAudioSampling.Location = new Point(6, 84);
            lblInfoInputAudioSampling.Name = "lblInfoInputAudioSampling";
            lblInfoInputAudioSampling.Size = new Size(0, 15);
            lblInfoInputAudioSampling.TabIndex = 4;
            // 
            // lblInfoInputAudioCodec
            // 
            lblInfoInputAudioCodec.AutoSize = true;
            lblInfoInputAudioCodec.Location = new Point(6, 69);
            lblInfoInputAudioCodec.Name = "lblInfoInputAudioCodec";
            lblInfoInputAudioCodec.Size = new Size(0, 15);
            lblInfoInputAudioCodec.TabIndex = 3;
            // 
            // lblInfoInputVideoDimensions
            // 
            lblInfoInputVideoDimensions.AutoSize = true;
            lblInfoInputVideoDimensions.Location = new Point(6, 33);
            lblInfoInputVideoDimensions.Name = "lblInfoInputVideoDimensions";
            lblInfoInputVideoDimensions.Size = new Size(0, 15);
            lblInfoInputVideoDimensions.TabIndex = 2;
            // 
            // lblInfoInputVideoBitRate
            // 
            lblInfoInputVideoBitRate.AutoSize = true;
            lblInfoInputVideoBitRate.Location = new Point(6, 48);
            lblInfoInputVideoBitRate.Name = "lblInfoInputVideoBitRate";
            lblInfoInputVideoBitRate.Size = new Size(0, 15);
            lblInfoInputVideoBitRate.TabIndex = 1;
            // 
            // lblInfoInputVideoCodec
            // 
            lblInfoInputVideoCodec.AutoSize = true;
            lblInfoInputVideoCodec.Location = new Point(6, 18);
            lblInfoInputVideoCodec.Name = "lblInfoInputVideoCodec";
            lblInfoInputVideoCodec.Size = new Size(119, 15);
            lblInfoInputVideoCodec.TabIndex = 0;
            lblInfoInputVideoCodec.Text = "No input file selected";
            // 
            // dlgOutputFile
            // 
            dlgOutputFile.Filter = "AVI|*.avi|MKV|*.mkv|MOV|*.mov|MP4|*.mp4|MXF|*.mxf";
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(grpOutputEncoding);
            grpOutput.Controls.Add(grpOutputPresentation);
            grpOutput.Location = new Point(11, 409);
            grpOutput.Margin = new Padding(2);
            grpOutput.Name = "grpOutput";
            grpOutput.Padding = new Padding(2);
            grpOutput.Size = new Size(347, 158);
            grpOutput.TabIndex = 14;
            grpOutput.TabStop = false;
            grpOutput.Text = "Output";
            // 
            // grpOutputEncoding
            // 
            grpOutputEncoding.Controls.Add(lblOutputAudioBitRate);
            grpOutputEncoding.Controls.Add(boxOutputAudioBitRate);
            grpOutputEncoding.Controls.Add(lblOutputVideoBitRate);
            grpOutputEncoding.Controls.Add(boxOutputVideoBitRate);
            grpOutputEncoding.Controls.Add(boxOutputAudioCodec);
            grpOutputEncoding.Controls.Add(lblOutputVideoCodec);
            grpOutputEncoding.Controls.Add(lblOutputAudioCodec);
            grpOutputEncoding.Controls.Add(boxOutputVideoCodec);
            grpOutputEncoding.Location = new Point(4, 77);
            grpOutputEncoding.Margin = new Padding(2);
            grpOutputEncoding.Name = "grpOutputEncoding";
            grpOutputEncoding.Padding = new Padding(2);
            grpOutputEncoding.Size = new Size(339, 77);
            grpOutputEncoding.TabIndex = 22;
            grpOutputEncoding.TabStop = false;
            grpOutputEncoding.Text = "Encoding";
            // 
            // lblOutputAudioBitRate
            // 
            lblOutputAudioBitRate.AutoSize = true;
            lblOutputAudioBitRate.Enabled = false;
            lblOutputAudioBitRate.Location = new Point(173, 52);
            lblOutputAudioBitRate.Name = "lblOutputAudioBitRate";
            lblOutputAudioBitRate.Size = new Size(82, 15);
            lblOutputAudioBitRate.TabIndex = 25;
            lblOutputAudioBitRate.Text = "Audio bit rate:";
            // 
            // boxOutputAudioBitRate
            // 
            boxOutputAudioBitRate.DropDownStyle = ComboBoxStyle.DropDownList;
            boxOutputAudioBitRate.Enabled = false;
            boxOutputAudioBitRate.FormattingEnabled = true;
            boxOutputAudioBitRate.Items.AddRange(new object[] { "8 kbps", "16 kbps", "24 kbps", "32 kbps", "48 kbps", "64 kbps", "96 kbps", "128 kbps", "160 kbps", "192 kbps", "224 kbps", "256 kbps", "320 kbps", "384 kbps", "448 kbps", "512 kbps" });
            boxOutputAudioBitRate.Location = new Point(259, 48);
            boxOutputAudioBitRate.Margin = new Padding(2);
            boxOutputAudioBitRate.Name = "boxOutputAudioBitRate";
            boxOutputAudioBitRate.Size = new Size(76, 23);
            boxOutputAudioBitRate.TabIndex = 24;
            boxOutputAudioBitRate.SelectedIndexChanged += boxOutputAudioBitRate_SelectedIndexChanged;
            // 
            // lblOutputVideoBitRate
            // 
            lblOutputVideoBitRate.AutoSize = true;
            lblOutputVideoBitRate.Enabled = false;
            lblOutputVideoBitRate.Location = new Point(6, 52);
            lblOutputVideoBitRate.Name = "lblOutputVideoBitRate";
            lblOutputVideoBitRate.Size = new Size(80, 15);
            lblOutputVideoBitRate.TabIndex = 22;
            lblOutputVideoBitRate.Text = "Video bit rate:";
            // 
            // boxOutputVideoBitRate
            // 
            boxOutputVideoBitRate.DropDownStyle = ComboBoxStyle.DropDownList;
            boxOutputVideoBitRate.Enabled = false;
            boxOutputVideoBitRate.FormattingEnabled = true;
            boxOutputVideoBitRate.Items.AddRange(new object[] { "0.5 Mbps", "1 Mbps", "1.5 Mbps", "2 Mbps", "2.5 Mbps", "3 Mbps", "4 Mbps", "5 Mbps", "6 Mbps", "7 Mbps", "8 Mbps", "9 Mbps", "10 Mbps", "12 Mbps", "15 Mbps", "20 Mbps", "25 Mbps", "30 Mbps", "40 Mbps", "50 Mbps", "100 Mbps", "150 Mbps", "200 Mbps" });
            boxOutputVideoBitRate.Location = new Point(92, 48);
            boxOutputVideoBitRate.Margin = new Padding(2);
            boxOutputVideoBitRate.Name = "boxOutputVideoBitRate";
            boxOutputVideoBitRate.Size = new Size(76, 23);
            boxOutputVideoBitRate.TabIndex = 23;
            boxOutputVideoBitRate.SelectedIndexChanged += boxOutputVideoBitRate_SelectedIndexChanged;
            // 
            // boxOutputAudioCodec
            // 
            boxOutputAudioCodec.DropDownStyle = ComboBoxStyle.DropDownList;
            boxOutputAudioCodec.FormattingEnabled = true;
            boxOutputAudioCodec.Items.AddRange(new object[] { "AAC", "AC3", "MP2", "MP3", "PCM_S16BE", "PCM_S16LE", "PCM_S24BE", "PCM_S24LE" });
            boxOutputAudioCodec.Location = new Point(259, 18);
            boxOutputAudioCodec.Margin = new Padding(2);
            boxOutputAudioCodec.Name = "boxOutputAudioCodec";
            boxOutputAudioCodec.Size = new Size(76, 23);
            boxOutputAudioCodec.TabIndex = 19;
            boxOutputAudioCodec.SelectedIndexChanged += boxOutputAudioCodec_SelectedIndexChanged;
            // 
            // lblOutputVideoCodec
            // 
            lblOutputVideoCodec.AutoSize = true;
            lblOutputVideoCodec.Location = new Point(6, 22);
            lblOutputVideoCodec.Name = "lblOutputVideoCodec";
            lblOutputVideoCodec.Size = new Size(75, 15);
            lblOutputVideoCodec.TabIndex = 16;
            lblOutputVideoCodec.Text = "Video codec:";
            // 
            // lblOutputAudioCodec
            // 
            lblOutputAudioCodec.AutoSize = true;
            lblOutputAudioCodec.Location = new Point(173, 22);
            lblOutputAudioCodec.Name = "lblOutputAudioCodec";
            lblOutputAudioCodec.Size = new Size(77, 15);
            lblOutputAudioCodec.TabIndex = 20;
            lblOutputAudioCodec.Text = "Audio codec:";
            // 
            // boxOutputVideoCodec
            // 
            boxOutputVideoCodec.DropDownStyle = ComboBoxStyle.DropDownList;
            boxOutputVideoCodec.FormattingEnabled = true;
            boxOutputVideoCodec.Items.AddRange(new object[] { "DNxHD", "DV", "H264", "HEVC", "MPEG2VIDEO", "ProRes" });
            boxOutputVideoCodec.Location = new Point(92, 18);
            boxOutputVideoCodec.Margin = new Padding(2);
            boxOutputVideoCodec.Name = "boxOutputVideoCodec";
            boxOutputVideoCodec.Size = new Size(76, 23);
            boxOutputVideoCodec.TabIndex = 17;
            boxOutputVideoCodec.SelectedIndexChanged += boxOutputVideoCodec_SelectedIndexChanged;
            // 
            // grpOutputPresentation
            // 
            grpOutputPresentation.Controls.Add(lblOutputFrameRate);
            grpOutputPresentation.Controls.Add(boxOutputFrameRate);
            grpOutputPresentation.Controls.Add(boxOutputResolution);
            grpOutputPresentation.Controls.Add(lblOutputResolution);
            grpOutputPresentation.Location = new Point(4, 20);
            grpOutputPresentation.Margin = new Padding(2);
            grpOutputPresentation.Name = "grpOutputPresentation";
            grpOutputPresentation.Padding = new Padding(2);
            grpOutputPresentation.Size = new Size(339, 53);
            grpOutputPresentation.TabIndex = 15;
            grpOutputPresentation.TabStop = false;
            grpOutputPresentation.Text = "Presentation";
            // 
            // lblOutputFrameRate
            // 
            lblOutputFrameRate.AutoSize = true;
            lblOutputFrameRate.Enabled = false;
            lblOutputFrameRate.Location = new Point(188, 24);
            lblOutputFrameRate.Name = "lblOutputFrameRate";
            lblOutputFrameRate.Size = new Size(66, 15);
            lblOutputFrameRate.TabIndex = 21;
            lblOutputFrameRate.Text = "Frame rate:";
            // 
            // lblOutputResolution
            // 
            lblOutputResolution.AutoSize = true;
            lblOutputResolution.Location = new Point(6, 24);
            lblOutputResolution.Name = "lblOutputResolution";
            lblOutputResolution.Size = new Size(66, 15);
            lblOutputResolution.TabIndex = 15;
            lblOutputResolution.Text = "Resolution:";
            // 
            // boxResizeMode
            // 
            boxResizeMode.DropDownStyle = ComboBoxStyle.DropDownList;
            boxResizeMode.FormattingEnabled = true;
            boxResizeMode.Items.AddRange(new object[] { "No resizing", "Crop", "Stretch", "Crop then stretch", "Stretch then crop" });
            boxResizeMode.Location = new Point(9, 20);
            boxResizeMode.Margin = new Padding(2);
            boxResizeMode.Name = "boxResizeMode";
            boxResizeMode.Size = new Size(119, 23);
            boxResizeMode.TabIndex = 19;
            boxResizeMode.SelectedIndexChanged += boxResizeMode_SelectedIndexChanged;
            // 
            // boxStretch
            // 
            boxStretch.DropDownStyle = ComboBoxStyle.DropDownList;
            boxStretch.Enabled = false;
            boxStretch.FormattingEnabled = true;
            boxStretch.Items.AddRange(new object[] { "4:3", "14:9", "16:10", "16:9", "1.85:1", "2.35:1", "2.39:1" });
            boxStretch.Location = new Point(283, 20);
            boxStretch.Margin = new Padding(2);
            boxStretch.Name = "boxStretch";
            boxStretch.Size = new Size(56, 23);
            boxStretch.TabIndex = 18;
            // 
            // boxCrop
            // 
            boxCrop.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCrop.Enabled = false;
            boxCrop.FormattingEnabled = true;
            boxCrop.Items.AddRange(new object[] { "4:3", "14:9", "16:10", "16:9", "1.85:1", "2.35:1", "2.39:1" });
            boxCrop.Location = new Point(171, 20);
            boxCrop.Margin = new Padding(2);
            boxCrop.Name = "boxCrop";
            boxCrop.Size = new Size(56, 23);
            boxCrop.TabIndex = 17;
            // 
            // lblStretch
            // 
            lblStretch.AutoSize = true;
            lblStretch.Enabled = false;
            lblStretch.Location = new Point(232, 24);
            lblStretch.Name = "lblStretch";
            lblStretch.Size = new Size(47, 15);
            lblStretch.TabIndex = 16;
            lblStretch.Text = "Stretch:";
            // 
            // lblCrop
            // 
            lblCrop.AutoSize = true;
            lblCrop.Enabled = false;
            lblCrop.Location = new Point(132, 24);
            lblCrop.Name = "lblCrop";
            lblCrop.Size = new Size(36, 15);
            lblCrop.TabIndex = 15;
            lblCrop.Text = "Crop:";
            // 
            // grpResize
            // 
            grpResize.Controls.Add(boxStretch);
            grpResize.Controls.Add(boxResizeMode);
            grpResize.Controls.Add(lblCrop);
            grpResize.Controls.Add(lblStretch);
            grpResize.Controls.Add(boxCrop);
            grpResize.Location = new Point(11, 353);
            grpResize.Margin = new Padding(2);
            grpResize.Name = "grpResize";
            grpResize.Padding = new Padding(2);
            grpResize.Size = new Size(347, 52);
            grpResize.TabIndex = 22;
            grpResize.TabStop = false;
            grpResize.Text = "Resize";
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(10, 572);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(349, 41);
            btnConvert.TabIndex = 23;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 641);
            Controls.Add(btnConvert);
            Controls.Add(grpResize);
            Controls.Add(grpOutput);
            Controls.Add(grpFileInformation);
            Controls.Add(grpProcessing);
            Controls.Add(lblOutput);
            Controls.Add(btnSave);
            Controls.Add(txtInputFilename);
            Controls.Add(lblInput);
            Controls.Add(statusStrip);
            Controls.Add(btnOpen);
            Controls.Add(txtOutputFilename);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Brovicon";
            Load += Main_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            grpProcessing.ResumeLayout(false);
            grpProcessingAudio.ResumeLayout(false);
            grpProcessingAudio.PerformLayout();
            grpProcessingVideo.ResumeLayout(false);
            grpProcessingVideo.PerformLayout();
            grpFileInformation.ResumeLayout(false);
            grpVideoInformationOutput.ResumeLayout(false);
            grpVideoInformationOutput.PerformLayout();
            grpVideoInformationInput.ResumeLayout(false);
            grpVideoInformationInput.PerformLayout();
            grpOutput.ResumeLayout(false);
            grpOutputEncoding.ResumeLayout(false);
            grpOutputEncoding.PerformLayout();
            grpOutputPresentation.ResumeLayout(false);
            grpOutputPresentation.PerformLayout();
            grpResize.ResumeLayout(false);
            grpResize.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boxOutputResolution;
        private ComboBox boxOutputFrameRate;
        private CheckBox chkNoiseReduction;
        private OpenFileDialog dlgInputFile;
        private TextBox txtOutputFilename;
        private Button btnOpen;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripProgressBar progressBar;
        private ToolStripStatusLabel lblPercentage;
        private Label lblInput;
        private Label lblOutput;
        private Button btnSave;
        private TextBox txtInputFilename;
        private GroupBox grpProcessing;
        private GroupBox grpFileInformation;
        private Label lblInfoInputVideoCodec;
        private GroupBox grpVideoInformationOutput;
        private GroupBox grpVideoInformationInput;
        private SaveFileDialog dlgOutputFile;
        private Label lblInfoInputVideoDimensions;
        private Label lblInfoInputVideoBitRate;
        private Label lblInfoOutputAudioBitRate;
        private Label lblInfoOutputVideoCodec;
        private Label lblInfoOutputAudioSampling;
        private Label lblInfoOutputVideoBitRate;
        private Label lblInfoOutputAudioCodec;
        private Label lblInfoOutputVideoDimensions;
        private Label lblInfoInputAudioBitRate;
        private Label lblInfoInputAudioSampling;
        private Label lblInfoInputAudioCodec;
        private GroupBox grpOutput;
        private Label lblOutputResolution;
        private GroupBox grpOutputPresentation;
        private ComboBox boxCrop;
        private Label lblStretch;
        private Label lblCrop;
        private ComboBox boxResizeMode;
        private ComboBox boxStretch;
        private Label lblOutputVideoCodec;
        private ComboBox boxOutputAudioCodec;
        private ComboBox boxOutputVideoCodec;
        private Label lblOutputFrameRate;
        private Label lblOutputAudioCodec;
        private Label lblOutputAudioBitRate;
        private ComboBox boxOutputAudioBitRate;
        private ComboBox boxOutputVideoBitRate;
        private Label lblOutputVideoBitRate;
        private GroupBox grpResize;
        private GroupBox grpOutputEncoding;
        private Button btnConvert;
        private CheckBox chkNormaliseAudio;
        private CheckBox chkForceInterlaced;
        private CheckBox chkForceProgressive;
        private GroupBox grpProcessingAudio;
        private CheckBox chkMixStereo;
        private GroupBox grpProcessingVideo;
        private Label lblForce;
        private Label lblFieldOrder;
        private ComboBox boxFieldOrder;
    }
}