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
            this.boxOutputResolution = new System.Windows.Forms.ComboBox();
            this.boxOutputFrameRate = new System.Windows.Forms.ComboBox();
            this.chkNoiseReduction = new System.Windows.Forms.CheckBox();
            this.dlgInputFile = new System.Windows.Forms.OpenFileDialog();
            this.txtOutputFilename = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblPercentage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInputFilename = new System.Windows.Forms.TextBox();
            this.grpProcessing = new System.Windows.Forms.GroupBox();
            this.grpProcessingAudio = new System.Windows.Forms.GroupBox();
            this.chkNormaliseAudio = new System.Windows.Forms.CheckBox();
            this.chkMixStereo = new System.Windows.Forms.CheckBox();
            this.grpProcessingVideo = new System.Windows.Forms.GroupBox();
            this.lblForce = new System.Windows.Forms.Label();
            this.chkForceProgressive = new System.Windows.Forms.CheckBox();
            this.chkForceInterlaced = new System.Windows.Forms.CheckBox();
            this.grpFileInformation = new System.Windows.Forms.GroupBox();
            this.grpVideoInformationOutput = new System.Windows.Forms.GroupBox();
            this.lblInfoOutputAudioBitRate = new System.Windows.Forms.Label();
            this.lblInfoOutputVideoCodec = new System.Windows.Forms.Label();
            this.lblInfoOutputAudioSampling = new System.Windows.Forms.Label();
            this.lblInfoOutputVideoBitRate = new System.Windows.Forms.Label();
            this.lblInfoOutputAudioCodec = new System.Windows.Forms.Label();
            this.lblInfoOutputVideoDimensions = new System.Windows.Forms.Label();
            this.grpVideoInformationInput = new System.Windows.Forms.GroupBox();
            this.lblInfoInputAudioBitRate = new System.Windows.Forms.Label();
            this.lblInfoInputAudioSampling = new System.Windows.Forms.Label();
            this.lblInfoInputAudioCodec = new System.Windows.Forms.Label();
            this.lblInfoInputVideoDimensions = new System.Windows.Forms.Label();
            this.lblInfoInputVideoBitRate = new System.Windows.Forms.Label();
            this.lblInfoInputVideoCodec = new System.Windows.Forms.Label();
            this.dlgOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpOutputEncoding = new System.Windows.Forms.GroupBox();
            this.lblOutputAudioBitRate = new System.Windows.Forms.Label();
            this.boxOutputAudioBitRate = new System.Windows.Forms.ComboBox();
            this.lblOutputVideoBitRate = new System.Windows.Forms.Label();
            this.boxOutputVideoBitRate = new System.Windows.Forms.ComboBox();
            this.boxOutputAudioCodec = new System.Windows.Forms.ComboBox();
            this.lblOutputVideoCodec = new System.Windows.Forms.Label();
            this.lblOutputAudioCodec = new System.Windows.Forms.Label();
            this.boxOutputVideoCodec = new System.Windows.Forms.ComboBox();
            this.grpOutputPresentation = new System.Windows.Forms.GroupBox();
            this.lblOutputFrameRate = new System.Windows.Forms.Label();
            this.lblOutputResolution = new System.Windows.Forms.Label();
            this.boxResizeMode = new System.Windows.Forms.ComboBox();
            this.boxStretch = new System.Windows.Forms.ComboBox();
            this.boxCrop = new System.Windows.Forms.ComboBox();
            this.lblStretch = new System.Windows.Forms.Label();
            this.lblCrop = new System.Windows.Forms.Label();
            this.grpResize = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.grpProcessing.SuspendLayout();
            this.grpProcessingAudio.SuspendLayout();
            this.grpProcessingVideo.SuspendLayout();
            this.grpFileInformation.SuspendLayout();
            this.grpVideoInformationOutput.SuspendLayout();
            this.grpVideoInformationInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpOutputEncoding.SuspendLayout();
            this.grpOutputPresentation.SuspendLayout();
            this.grpResize.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxOutputResolution
            // 
            this.boxOutputResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOutputResolution.FormattingEnabled = true;
            this.boxOutputResolution.Items.AddRange(new object[] {
            "720x480",
            "720x576",
            "1280x720",
            "1440x1080",
            "1920x1080",
            "3840x2160"});
            this.boxOutputResolution.Location = new System.Drawing.Point(74, 20);
            this.boxOutputResolution.Margin = new System.Windows.Forms.Padding(2);
            this.boxOutputResolution.Name = "boxOutputResolution";
            this.boxOutputResolution.Size = new System.Drawing.Size(109, 23);
            this.boxOutputResolution.TabIndex = 0;
            this.boxOutputResolution.SelectedIndexChanged += new System.EventHandler(this.boxOutputResolution_SelectedIndexChanged);
            // 
            // boxOutputFrameRate
            // 
            this.boxOutputFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOutputFrameRate.Enabled = false;
            this.boxOutputFrameRate.FormattingEnabled = true;
            this.boxOutputFrameRate.Items.AddRange(new object[] {
            "23.976p",
            "24p",
            "25p",
            "29.97p",
            "30p",
            "50p",
            "59.94p",
            "60p",
            "50i",
            "59.94i",
            "60i"});
            this.boxOutputFrameRate.Location = new System.Drawing.Point(259, 20);
            this.boxOutputFrameRate.Margin = new System.Windows.Forms.Padding(2);
            this.boxOutputFrameRate.Name = "boxOutputFrameRate";
            this.boxOutputFrameRate.Size = new System.Drawing.Size(76, 23);
            this.boxOutputFrameRate.TabIndex = 1;
            this.boxOutputFrameRate.SelectedIndexChanged += new System.EventHandler(this.boxOutputFrameRate_SelectedIndexChanged);
            // 
            // chkNoiseReduction
            // 
            this.chkNoiseReduction.AutoSize = true;
            this.chkNoiseReduction.Location = new System.Drawing.Point(9, 19);
            this.chkNoiseReduction.Margin = new System.Windows.Forms.Padding(2);
            this.chkNoiseReduction.Name = "chkNoiseReduction";
            this.chkNoiseReduction.Size = new System.Drawing.Size(110, 19);
            this.chkNoiseReduction.TabIndex = 2;
            this.chkNoiseReduction.Text = "Noise reduction";
            this.chkNoiseReduction.UseVisualStyleBackColor = true;
            // 
            // dlgInputFile
            // 
            this.dlgInputFile.Filter = "All files|*.*";
            // 
            // txtOutputFilename
            // 
            this.txtOutputFilename.Location = new System.Drawing.Point(60, 33);
            this.txtOutputFilename.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutputFilename.Name = "txtOutputFilename";
            this.txtOutputFilename.Size = new System.Drawing.Size(270, 23);
            this.txtOutputFilename.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(334, 5);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(25, 25);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.progressBar,
            this.lblPercentage});
            this.statusStrip.Location = new System.Drawing.Point(0, 597);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip.Size = new System.Drawing.Size(369, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(250, 16);
            this.progressBar.Step = 1;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(12, 17);
            this.lblPercentage.Text = "-";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(8, 10);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(38, 15);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "Input:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(8, 37);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(48, 15);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "Output:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 32);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInputFilename
            // 
            this.txtInputFilename.Location = new System.Drawing.Point(60, 6);
            this.txtInputFilename.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputFilename.Name = "txtInputFilename";
            this.txtInputFilename.Size = new System.Drawing.Size(270, 23);
            this.txtInputFilename.TabIndex = 9;
            // 
            // grpProcessing
            // 
            this.grpProcessing.Controls.Add(this.grpProcessingAudio);
            this.grpProcessing.Controls.Add(this.grpProcessingVideo);
            this.grpProcessing.Location = new System.Drawing.Point(11, 207);
            this.grpProcessing.Margin = new System.Windows.Forms.Padding(2);
            this.grpProcessing.Name = "grpProcessing";
            this.grpProcessing.Padding = new System.Windows.Forms.Padding(2);
            this.grpProcessing.Size = new System.Drawing.Size(347, 120);
            this.grpProcessing.TabIndex = 12;
            this.grpProcessing.TabStop = false;
            this.grpProcessing.Text = "Processing";
            // 
            // grpProcessingAudio
            // 
            this.grpProcessingAudio.Controls.Add(this.chkNormaliseAudio);
            this.grpProcessingAudio.Controls.Add(this.chkMixStereo);
            this.grpProcessingAudio.Location = new System.Drawing.Point(4, 70);
            this.grpProcessingAudio.Name = "grpProcessingAudio";
            this.grpProcessingAudio.Size = new System.Drawing.Size(339, 45);
            this.grpProcessingAudio.TabIndex = 7;
            this.grpProcessingAudio.TabStop = false;
            this.grpProcessingAudio.Text = "Audio";
            // 
            // chkNormaliseAudio
            // 
            this.chkNormaliseAudio.AutoSize = true;
            this.chkNormaliseAudio.Location = new System.Drawing.Point(9, 19);
            this.chkNormaliseAudio.Margin = new System.Windows.Forms.Padding(2);
            this.chkNormaliseAudio.Name = "chkNormaliseAudio";
            this.chkNormaliseAudio.Size = new System.Drawing.Size(113, 19);
            this.chkNormaliseAudio.TabIndex = 5;
            this.chkNormaliseAudio.Text = "Normalise audio";
            this.chkNormaliseAudio.UseVisualStyleBackColor = true;
            // 
            // chkMixStereo
            // 
            this.chkMixStereo.AutoSize = true;
            this.chkMixStereo.Location = new System.Drawing.Point(126, 19);
            this.chkMixStereo.Margin = new System.Windows.Forms.Padding(2);
            this.chkMixStereo.Name = "chkMixStereo";
            this.chkMixStereo.Size = new System.Drawing.Size(95, 19);
            this.chkMixStereo.TabIndex = 11;
            this.chkMixStereo.Text = "Mix to stereo";
            this.chkMixStereo.UseVisualStyleBackColor = true;
            // 
            // grpProcessingVideo
            // 
            this.grpProcessingVideo.Controls.Add(this.lblForce);
            this.grpProcessingVideo.Controls.Add(this.chkNoiseReduction);
            this.grpProcessingVideo.Controls.Add(this.chkForceProgressive);
            this.grpProcessingVideo.Controls.Add(this.chkForceInterlaced);
            this.grpProcessingVideo.Location = new System.Drawing.Point(4, 19);
            this.grpProcessingVideo.Name = "grpProcessingVideo";
            this.grpProcessingVideo.Size = new System.Drawing.Size(339, 45);
            this.grpProcessingVideo.TabIndex = 6;
            this.grpProcessingVideo.TabStop = false;
            this.grpProcessingVideo.Text = "Video";
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.Location = new System.Drawing.Point(124, 20);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(39, 15);
            this.lblForce.TabIndex = 11;
            this.lblForce.Text = "Force:";
            // 
            // chkForceProgressive
            // 
            this.chkForceProgressive.AutoSize = true;
            this.chkForceProgressive.Location = new System.Drawing.Point(250, 19);
            this.chkForceProgressive.Margin = new System.Windows.Forms.Padding(2);
            this.chkForceProgressive.Name = "chkForceProgressive";
            this.chkForceProgressive.Size = new System.Drawing.Size(86, 19);
            this.chkForceProgressive.TabIndex = 10;
            this.chkForceProgressive.Text = "Progressive";
            this.chkForceProgressive.UseVisualStyleBackColor = true;
            this.chkForceProgressive.CheckedChanged += new System.EventHandler(this.chkForceProgressive_CheckedChanged);
            // 
            // chkForceInterlaced
            // 
            this.chkForceInterlaced.AutoSize = true;
            this.chkForceInterlaced.Location = new System.Drawing.Point(168, 19);
            this.chkForceInterlaced.Margin = new System.Windows.Forms.Padding(2);
            this.chkForceInterlaced.Name = "chkForceInterlaced";
            this.chkForceInterlaced.Size = new System.Drawing.Size(78, 19);
            this.chkForceInterlaced.TabIndex = 9;
            this.chkForceInterlaced.Text = "Interlaced";
            this.chkForceInterlaced.UseVisualStyleBackColor = true;
            this.chkForceInterlaced.CheckedChanged += new System.EventHandler(this.chkForceInterlaced_CheckedChanged);
            // 
            // grpFileInformation
            // 
            this.grpFileInformation.Controls.Add(this.grpVideoInformationOutput);
            this.grpFileInformation.Controls.Add(this.grpVideoInformationInput);
            this.grpFileInformation.Location = new System.Drawing.Point(11, 61);
            this.grpFileInformation.Margin = new System.Windows.Forms.Padding(2);
            this.grpFileInformation.Name = "grpFileInformation";
            this.grpFileInformation.Padding = new System.Windows.Forms.Padding(2);
            this.grpFileInformation.Size = new System.Drawing.Size(347, 142);
            this.grpFileInformation.TabIndex = 13;
            this.grpFileInformation.TabStop = false;
            this.grpFileInformation.Text = "File information";
            // 
            // grpVideoInformationOutput
            // 
            this.grpVideoInformationOutput.Controls.Add(this.lblInfoOutputAudioBitRate);
            this.grpVideoInformationOutput.Controls.Add(this.lblInfoOutputVideoCodec);
            this.grpVideoInformationOutput.Controls.Add(this.lblInfoOutputAudioSampling);
            this.grpVideoInformationOutput.Controls.Add(this.lblInfoOutputVideoBitRate);
            this.grpVideoInformationOutput.Controls.Add(this.lblInfoOutputAudioCodec);
            this.grpVideoInformationOutput.Controls.Add(this.lblInfoOutputVideoDimensions);
            this.grpVideoInformationOutput.Location = new System.Drawing.Point(175, 18);
            this.grpVideoInformationOutput.Margin = new System.Windows.Forms.Padding(2);
            this.grpVideoInformationOutput.Name = "grpVideoInformationOutput";
            this.grpVideoInformationOutput.Padding = new System.Windows.Forms.Padding(2);
            this.grpVideoInformationOutput.Size = new System.Drawing.Size(168, 120);
            this.grpVideoInformationOutput.TabIndex = 15;
            this.grpVideoInformationOutput.TabStop = false;
            this.grpVideoInformationOutput.Text = "Output";
            // 
            // lblInfoOutputAudioBitRate
            // 
            this.lblInfoOutputAudioBitRate.AutoSize = true;
            this.lblInfoOutputAudioBitRate.Location = new System.Drawing.Point(6, 99);
            this.lblInfoOutputAudioBitRate.Name = "lblInfoOutputAudioBitRate";
            this.lblInfoOutputAudioBitRate.Size = new System.Drawing.Size(0, 15);
            this.lblInfoOutputAudioBitRate.TabIndex = 11;
            // 
            // lblInfoOutputVideoCodec
            // 
            this.lblInfoOutputVideoCodec.AutoSize = true;
            this.lblInfoOutputVideoCodec.Location = new System.Drawing.Point(6, 18);
            this.lblInfoOutputVideoCodec.Name = "lblInfoOutputVideoCodec";
            this.lblInfoOutputVideoCodec.Size = new System.Drawing.Size(127, 15);
            this.lblInfoOutputVideoCodec.TabIndex = 6;
            this.lblInfoOutputVideoCodec.Text = "No output file selected";
            // 
            // lblInfoOutputAudioSampling
            // 
            this.lblInfoOutputAudioSampling.AutoSize = true;
            this.lblInfoOutputAudioSampling.Location = new System.Drawing.Point(6, 84);
            this.lblInfoOutputAudioSampling.Name = "lblInfoOutputAudioSampling";
            this.lblInfoOutputAudioSampling.Size = new System.Drawing.Size(0, 15);
            this.lblInfoOutputAudioSampling.TabIndex = 10;
            // 
            // lblInfoOutputVideoBitRate
            // 
            this.lblInfoOutputVideoBitRate.AutoSize = true;
            this.lblInfoOutputVideoBitRate.Location = new System.Drawing.Point(6, 48);
            this.lblInfoOutputVideoBitRate.Name = "lblInfoOutputVideoBitRate";
            this.lblInfoOutputVideoBitRate.Size = new System.Drawing.Size(0, 15);
            this.lblInfoOutputVideoBitRate.TabIndex = 7;
            // 
            // lblInfoOutputAudioCodec
            // 
            this.lblInfoOutputAudioCodec.AutoSize = true;
            this.lblInfoOutputAudioCodec.Location = new System.Drawing.Point(6, 69);
            this.lblInfoOutputAudioCodec.Name = "lblInfoOutputAudioCodec";
            this.lblInfoOutputAudioCodec.Size = new System.Drawing.Size(0, 15);
            this.lblInfoOutputAudioCodec.TabIndex = 9;
            // 
            // lblInfoOutputVideoDimensions
            // 
            this.lblInfoOutputVideoDimensions.AutoSize = true;
            this.lblInfoOutputVideoDimensions.Location = new System.Drawing.Point(6, 33);
            this.lblInfoOutputVideoDimensions.Name = "lblInfoOutputVideoDimensions";
            this.lblInfoOutputVideoDimensions.Size = new System.Drawing.Size(0, 15);
            this.lblInfoOutputVideoDimensions.TabIndex = 8;
            // 
            // grpVideoInformationInput
            // 
            this.grpVideoInformationInput.Controls.Add(this.lblInfoInputAudioBitRate);
            this.grpVideoInformationInput.Controls.Add(this.lblInfoInputAudioSampling);
            this.grpVideoInformationInput.Controls.Add(this.lblInfoInputAudioCodec);
            this.grpVideoInformationInput.Controls.Add(this.lblInfoInputVideoDimensions);
            this.grpVideoInformationInput.Controls.Add(this.lblInfoInputVideoBitRate);
            this.grpVideoInformationInput.Controls.Add(this.lblInfoInputVideoCodec);
            this.grpVideoInformationInput.Location = new System.Drawing.Point(4, 18);
            this.grpVideoInformationInput.Margin = new System.Windows.Forms.Padding(2);
            this.grpVideoInformationInput.Name = "grpVideoInformationInput";
            this.grpVideoInformationInput.Padding = new System.Windows.Forms.Padding(2);
            this.grpVideoInformationInput.Size = new System.Drawing.Size(168, 120);
            this.grpVideoInformationInput.TabIndex = 14;
            this.grpVideoInformationInput.TabStop = false;
            this.grpVideoInformationInput.Text = "Input";
            // 
            // lblInfoInputAudioBitRate
            // 
            this.lblInfoInputAudioBitRate.AutoSize = true;
            this.lblInfoInputAudioBitRate.Location = new System.Drawing.Point(6, 99);
            this.lblInfoInputAudioBitRate.Name = "lblInfoInputAudioBitRate";
            this.lblInfoInputAudioBitRate.Size = new System.Drawing.Size(0, 15);
            this.lblInfoInputAudioBitRate.TabIndex = 5;
            // 
            // lblInfoInputAudioSampling
            // 
            this.lblInfoInputAudioSampling.AutoSize = true;
            this.lblInfoInputAudioSampling.Location = new System.Drawing.Point(6, 84);
            this.lblInfoInputAudioSampling.Name = "lblInfoInputAudioSampling";
            this.lblInfoInputAudioSampling.Size = new System.Drawing.Size(0, 15);
            this.lblInfoInputAudioSampling.TabIndex = 4;
            // 
            // lblInfoInputAudioCodec
            // 
            this.lblInfoInputAudioCodec.AutoSize = true;
            this.lblInfoInputAudioCodec.Location = new System.Drawing.Point(6, 69);
            this.lblInfoInputAudioCodec.Name = "lblInfoInputAudioCodec";
            this.lblInfoInputAudioCodec.Size = new System.Drawing.Size(0, 15);
            this.lblInfoInputAudioCodec.TabIndex = 3;
            // 
            // lblInfoInputVideoDimensions
            // 
            this.lblInfoInputVideoDimensions.AutoSize = true;
            this.lblInfoInputVideoDimensions.Location = new System.Drawing.Point(6, 33);
            this.lblInfoInputVideoDimensions.Name = "lblInfoInputVideoDimensions";
            this.lblInfoInputVideoDimensions.Size = new System.Drawing.Size(0, 15);
            this.lblInfoInputVideoDimensions.TabIndex = 2;
            // 
            // lblInfoInputVideoBitRate
            // 
            this.lblInfoInputVideoBitRate.AutoSize = true;
            this.lblInfoInputVideoBitRate.Location = new System.Drawing.Point(6, 48);
            this.lblInfoInputVideoBitRate.Name = "lblInfoInputVideoBitRate";
            this.lblInfoInputVideoBitRate.Size = new System.Drawing.Size(0, 15);
            this.lblInfoInputVideoBitRate.TabIndex = 1;
            // 
            // lblInfoInputVideoCodec
            // 
            this.lblInfoInputVideoCodec.AutoSize = true;
            this.lblInfoInputVideoCodec.Location = new System.Drawing.Point(6, 18);
            this.lblInfoInputVideoCodec.Name = "lblInfoInputVideoCodec";
            this.lblInfoInputVideoCodec.Size = new System.Drawing.Size(119, 15);
            this.lblInfoInputVideoCodec.TabIndex = 0;
            this.lblInfoInputVideoCodec.Text = "No input file selected";
            // 
            // dlgOutputFile
            // 
            this.dlgOutputFile.Filter = "AVI|*.avi|MKV|*.mkv|MOV|*.mov|MP4|*.mp4|MXF|*.mxf";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.grpOutputEncoding);
            this.grpOutput.Controls.Add(this.grpOutputPresentation);
            this.grpOutput.Location = new System.Drawing.Point(11, 387);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(2);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(2);
            this.grpOutput.Size = new System.Drawing.Size(347, 158);
            this.grpOutput.TabIndex = 14;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // grpOutputEncoding
            // 
            this.grpOutputEncoding.Controls.Add(this.lblOutputAudioBitRate);
            this.grpOutputEncoding.Controls.Add(this.boxOutputAudioBitRate);
            this.grpOutputEncoding.Controls.Add(this.lblOutputVideoBitRate);
            this.grpOutputEncoding.Controls.Add(this.boxOutputVideoBitRate);
            this.grpOutputEncoding.Controls.Add(this.boxOutputAudioCodec);
            this.grpOutputEncoding.Controls.Add(this.lblOutputVideoCodec);
            this.grpOutputEncoding.Controls.Add(this.lblOutputAudioCodec);
            this.grpOutputEncoding.Controls.Add(this.boxOutputVideoCodec);
            this.grpOutputEncoding.Location = new System.Drawing.Point(4, 77);
            this.grpOutputEncoding.Margin = new System.Windows.Forms.Padding(2);
            this.grpOutputEncoding.Name = "grpOutputEncoding";
            this.grpOutputEncoding.Padding = new System.Windows.Forms.Padding(2);
            this.grpOutputEncoding.Size = new System.Drawing.Size(339, 77);
            this.grpOutputEncoding.TabIndex = 22;
            this.grpOutputEncoding.TabStop = false;
            this.grpOutputEncoding.Text = "Encoding";
            // 
            // lblOutputAudioBitRate
            // 
            this.lblOutputAudioBitRate.AutoSize = true;
            this.lblOutputAudioBitRate.Enabled = false;
            this.lblOutputAudioBitRate.Location = new System.Drawing.Point(173, 52);
            this.lblOutputAudioBitRate.Name = "lblOutputAudioBitRate";
            this.lblOutputAudioBitRate.Size = new System.Drawing.Size(82, 15);
            this.lblOutputAudioBitRate.TabIndex = 25;
            this.lblOutputAudioBitRate.Text = "Audio bit rate:";
            // 
            // boxOutputAudioBitRate
            // 
            this.boxOutputAudioBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOutputAudioBitRate.Enabled = false;
            this.boxOutputAudioBitRate.FormattingEnabled = true;
            this.boxOutputAudioBitRate.Items.AddRange(new object[] {
            "8 kbps",
            "16 kbps",
            "24 kbps",
            "32 kbps",
            "48 kbps",
            "64 kbps",
            "96 kbps",
            "128 kbps",
            "160 kbps",
            "192 kbps",
            "224 kbps",
            "256 kbps",
            "320 kbps",
            "384 kbps",
            "448 kbps",
            "512 kbps"});
            this.boxOutputAudioBitRate.Location = new System.Drawing.Point(259, 48);
            this.boxOutputAudioBitRate.Margin = new System.Windows.Forms.Padding(2);
            this.boxOutputAudioBitRate.Name = "boxOutputAudioBitRate";
            this.boxOutputAudioBitRate.Size = new System.Drawing.Size(76, 23);
            this.boxOutputAudioBitRate.TabIndex = 24;
            this.boxOutputAudioBitRate.SelectedIndexChanged += new System.EventHandler(this.boxOutputAudioBitRate_SelectedIndexChanged);
            // 
            // lblOutputVideoBitRate
            // 
            this.lblOutputVideoBitRate.AutoSize = true;
            this.lblOutputVideoBitRate.Enabled = false;
            this.lblOutputVideoBitRate.Location = new System.Drawing.Point(6, 52);
            this.lblOutputVideoBitRate.Name = "lblOutputVideoBitRate";
            this.lblOutputVideoBitRate.Size = new System.Drawing.Size(80, 15);
            this.lblOutputVideoBitRate.TabIndex = 22;
            this.lblOutputVideoBitRate.Text = "Video bit rate:";
            // 
            // boxOutputVideoBitRate
            // 
            this.boxOutputVideoBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOutputVideoBitRate.Enabled = false;
            this.boxOutputVideoBitRate.FormattingEnabled = true;
            this.boxOutputVideoBitRate.Items.AddRange(new object[] {
            "0.5 Mbps",
            "1 Mbps",
            "1.5 Mbps",
            "2 Mbps",
            "2.5 Mbps",
            "3 Mbps",
            "4 Mbps",
            "5 Mbps",
            "6 Mbps",
            "7 Mbps",
            "8 Mbps",
            "9 Mbps",
            "10 Mbps",
            "12 Mbps",
            "15 Mbps",
            "20 Mbps",
            "25 Mbps",
            "30 Mbps",
            "40 Mbps",
            "50 Mbps",
            "100 Mbps",
            "150 Mbps",
            "200 Mbps"});
            this.boxOutputVideoBitRate.Location = new System.Drawing.Point(92, 48);
            this.boxOutputVideoBitRate.Margin = new System.Windows.Forms.Padding(2);
            this.boxOutputVideoBitRate.Name = "boxOutputVideoBitRate";
            this.boxOutputVideoBitRate.Size = new System.Drawing.Size(76, 23);
            this.boxOutputVideoBitRate.TabIndex = 23;
            this.boxOutputVideoBitRate.SelectedIndexChanged += new System.EventHandler(this.boxOutputVideoBitRate_SelectedIndexChanged);
            // 
            // boxOutputAudioCodec
            // 
            this.boxOutputAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOutputAudioCodec.FormattingEnabled = true;
            this.boxOutputAudioCodec.Items.AddRange(new object[] {
            "AAC",
            "AC3",
            "MP2",
            "MP3",
            "PCM_S16BE",
            "PCM_S16LE",
            "PCM_S24BE",
            "PCM_S24LE"});
            this.boxOutputAudioCodec.Location = new System.Drawing.Point(259, 18);
            this.boxOutputAudioCodec.Margin = new System.Windows.Forms.Padding(2);
            this.boxOutputAudioCodec.Name = "boxOutputAudioCodec";
            this.boxOutputAudioCodec.Size = new System.Drawing.Size(76, 23);
            this.boxOutputAudioCodec.TabIndex = 19;
            this.boxOutputAudioCodec.SelectedIndexChanged += new System.EventHandler(this.boxOutputAudioCodec_SelectedIndexChanged);
            // 
            // lblOutputVideoCodec
            // 
            this.lblOutputVideoCodec.AutoSize = true;
            this.lblOutputVideoCodec.Location = new System.Drawing.Point(6, 22);
            this.lblOutputVideoCodec.Name = "lblOutputVideoCodec";
            this.lblOutputVideoCodec.Size = new System.Drawing.Size(75, 15);
            this.lblOutputVideoCodec.TabIndex = 16;
            this.lblOutputVideoCodec.Text = "Video codec:";
            // 
            // lblOutputAudioCodec
            // 
            this.lblOutputAudioCodec.AutoSize = true;
            this.lblOutputAudioCodec.Location = new System.Drawing.Point(173, 22);
            this.lblOutputAudioCodec.Name = "lblOutputAudioCodec";
            this.lblOutputAudioCodec.Size = new System.Drawing.Size(77, 15);
            this.lblOutputAudioCodec.TabIndex = 20;
            this.lblOutputAudioCodec.Text = "Audio codec:";
            // 
            // boxOutputVideoCodec
            // 
            this.boxOutputVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOutputVideoCodec.FormattingEnabled = true;
            this.boxOutputVideoCodec.Items.AddRange(new object[] {
            "DNxHD",
            "DV",
            "H264",
            "HEVC",
            "MPEG2VIDEO",
            "ProRes"});
            this.boxOutputVideoCodec.Location = new System.Drawing.Point(92, 18);
            this.boxOutputVideoCodec.Margin = new System.Windows.Forms.Padding(2);
            this.boxOutputVideoCodec.Name = "boxOutputVideoCodec";
            this.boxOutputVideoCodec.Size = new System.Drawing.Size(76, 23);
            this.boxOutputVideoCodec.TabIndex = 17;
            this.boxOutputVideoCodec.SelectedIndexChanged += new System.EventHandler(this.boxOutputVideoCodec_SelectedIndexChanged);
            // 
            // grpOutputPresentation
            // 
            this.grpOutputPresentation.Controls.Add(this.lblOutputFrameRate);
            this.grpOutputPresentation.Controls.Add(this.boxOutputFrameRate);
            this.grpOutputPresentation.Controls.Add(this.boxOutputResolution);
            this.grpOutputPresentation.Controls.Add(this.lblOutputResolution);
            this.grpOutputPresentation.Location = new System.Drawing.Point(4, 20);
            this.grpOutputPresentation.Margin = new System.Windows.Forms.Padding(2);
            this.grpOutputPresentation.Name = "grpOutputPresentation";
            this.grpOutputPresentation.Padding = new System.Windows.Forms.Padding(2);
            this.grpOutputPresentation.Size = new System.Drawing.Size(339, 53);
            this.grpOutputPresentation.TabIndex = 15;
            this.grpOutputPresentation.TabStop = false;
            this.grpOutputPresentation.Text = "Presentation";
            // 
            // lblOutputFrameRate
            // 
            this.lblOutputFrameRate.AutoSize = true;
            this.lblOutputFrameRate.Enabled = false;
            this.lblOutputFrameRate.Location = new System.Drawing.Point(188, 24);
            this.lblOutputFrameRate.Name = "lblOutputFrameRate";
            this.lblOutputFrameRate.Size = new System.Drawing.Size(66, 15);
            this.lblOutputFrameRate.TabIndex = 21;
            this.lblOutputFrameRate.Text = "Frame rate:";
            // 
            // lblOutputResolution
            // 
            this.lblOutputResolution.AutoSize = true;
            this.lblOutputResolution.Location = new System.Drawing.Point(6, 24);
            this.lblOutputResolution.Name = "lblOutputResolution";
            this.lblOutputResolution.Size = new System.Drawing.Size(66, 15);
            this.lblOutputResolution.TabIndex = 15;
            this.lblOutputResolution.Text = "Resolution:";
            // 
            // boxResizeMode
            // 
            this.boxResizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxResizeMode.FormattingEnabled = true;
            this.boxResizeMode.Items.AddRange(new object[] {
            "No resizing",
            "Crop",
            "Stretch",
            "Crop then stretch",
            "Stretch then crop"});
            this.boxResizeMode.Location = new System.Drawing.Point(9, 20);
            this.boxResizeMode.Margin = new System.Windows.Forms.Padding(2);
            this.boxResizeMode.Name = "boxResizeMode";
            this.boxResizeMode.Size = new System.Drawing.Size(119, 23);
            this.boxResizeMode.TabIndex = 19;
            this.boxResizeMode.SelectedIndexChanged += new System.EventHandler(this.boxResizeMode_SelectedIndexChanged);
            // 
            // boxStretch
            // 
            this.boxStretch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxStretch.Enabled = false;
            this.boxStretch.FormattingEnabled = true;
            this.boxStretch.Items.AddRange(new object[] {
            "4:3",
            "14:9",
            "16:10",
            "16:9",
            "1.85:1",
            "2.35:1",
            "2.39:1"});
            this.boxStretch.Location = new System.Drawing.Point(283, 20);
            this.boxStretch.Margin = new System.Windows.Forms.Padding(2);
            this.boxStretch.Name = "boxStretch";
            this.boxStretch.Size = new System.Drawing.Size(56, 23);
            this.boxStretch.TabIndex = 18;
            // 
            // boxCrop
            // 
            this.boxCrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCrop.Enabled = false;
            this.boxCrop.FormattingEnabled = true;
            this.boxCrop.Items.AddRange(new object[] {
            "4:3",
            "14:9",
            "16:10",
            "16:9",
            "1.85:1",
            "2.35:1",
            "2.39:1"});
            this.boxCrop.Location = new System.Drawing.Point(171, 20);
            this.boxCrop.Margin = new System.Windows.Forms.Padding(2);
            this.boxCrop.Name = "boxCrop";
            this.boxCrop.Size = new System.Drawing.Size(56, 23);
            this.boxCrop.TabIndex = 17;
            // 
            // lblStretch
            // 
            this.lblStretch.AutoSize = true;
            this.lblStretch.Enabled = false;
            this.lblStretch.Location = new System.Drawing.Point(232, 24);
            this.lblStretch.Name = "lblStretch";
            this.lblStretch.Size = new System.Drawing.Size(47, 15);
            this.lblStretch.TabIndex = 16;
            this.lblStretch.Text = "Stretch:";
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.Enabled = false;
            this.lblCrop.Location = new System.Drawing.Point(132, 24);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(36, 15);
            this.lblCrop.TabIndex = 15;
            this.lblCrop.Text = "Crop:";
            // 
            // grpResize
            // 
            this.grpResize.Controls.Add(this.boxStretch);
            this.grpResize.Controls.Add(this.boxResizeMode);
            this.grpResize.Controls.Add(this.lblCrop);
            this.grpResize.Controls.Add(this.lblStretch);
            this.grpResize.Controls.Add(this.boxCrop);
            this.grpResize.Location = new System.Drawing.Point(11, 331);
            this.grpResize.Margin = new System.Windows.Forms.Padding(2);
            this.grpResize.Name = "grpResize";
            this.grpResize.Padding = new System.Windows.Forms.Padding(2);
            this.grpResize.Size = new System.Drawing.Size(347, 52);
            this.grpResize.TabIndex = 22;
            this.grpResize.TabStop = false;
            this.grpResize.Text = "Resize";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(10, 550);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(349, 41);
            this.btnConvert.TabIndex = 23;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 619);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.grpResize);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpFileInformation);
            this.Controls.Add(this.grpProcessing);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInputFilename);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtOutputFilename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Brovicon";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpProcessing.ResumeLayout(false);
            this.grpProcessingAudio.ResumeLayout(false);
            this.grpProcessingAudio.PerformLayout();
            this.grpProcessingVideo.ResumeLayout(false);
            this.grpProcessingVideo.PerformLayout();
            this.grpFileInformation.ResumeLayout(false);
            this.grpVideoInformationOutput.ResumeLayout(false);
            this.grpVideoInformationOutput.PerformLayout();
            this.grpVideoInformationInput.ResumeLayout(false);
            this.grpVideoInformationInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutputEncoding.ResumeLayout(false);
            this.grpOutputEncoding.PerformLayout();
            this.grpOutputPresentation.ResumeLayout(false);
            this.grpOutputPresentation.PerformLayout();
            this.grpResize.ResumeLayout(false);
            this.grpResize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}