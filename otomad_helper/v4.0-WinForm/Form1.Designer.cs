﻿
namespace VegasScript {
	partial class ConfigForm {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.UserHelpLink = new System.Windows.Forms.LinkLabel();
			this.AboutBtn = new System.Windows.Forms.Button();
			this.OkBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.StaffLineColorDialog = new System.Windows.Forms.ColorDialog();
			this.Balloon = new System.Windows.Forms.ToolTip(this.components);
			this.AudioTuneMethodCombo = new System.Windows.Forms.ComboBox();
			this.AudioLockStretchPitchCheck = new System.Windows.Forms.CheckBox();
			this.StaffRelativeValueCheck = new System.Windows.Forms.CheckBox();
			this.PreviewTuneAudioCheck = new System.Windows.Forms.CheckBox();
			this.MidiStartSecondBox = new VegasScript.TimecodeBox();
			this.MidiEndSecondBox = new VegasScript.TimecodeBox();
			this.SourceStartTimeText = new VegasScript.TimecodeBox();
			this.SourceEndTimeText = new VegasScript.TimecodeBox();
			this.PreviewBeepDurationBox = new VegasScript.NumericUpDownWithUnit();
			this.StaffLineSpacingBox = new VegasScript.NumericUpDownWithUnit();
			this.StaffSurfacePositionBox = new VegasScript.NumericUpDownWithUnit();
			this.StaffSurfaceWidthBox = new VegasScript.NumericUpDownWithUnit();
			this.YtpMinLenBox = new VegasScript.NumericUpDownWithUnit();
			this.YtpMaxLenBox = new VegasScript.NumericUpDownWithUnit();
			this.PreviewBasePitchBtn = new System.Windows.Forms.Button();
			this.AudioStretchAttrCombo = new System.Windows.Forms.ComboBox();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitDiscardingChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whyOkBtnIsDisabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.troubleShootingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chineseToolStripMenuItem = new VegasScript.ToolStripRadioButtonMenuItem();
			this.tchineseToolStripMenuItem = new VegasScript.ToolStripRadioButtonMenuItem();
			this.englishToolStripMenuItem = new VegasScript.ToolStripRadioButtonMenuItem();
			this.japaneseToolStripMenuItem = new VegasScript.ToolStripRadioButtonMenuItem();
			this.russianToolStripMenuItem = new VegasScript.ToolStripRadioButtonMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Tabs = new System.Windows.Forms.TabControl();
			this.SourceTab = new System.Windows.Forms.TabPage();
			this.WarningInfoLabel = new System.Windows.Forms.Label();
			this.MidiConfigGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.ChooseMidiLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.ChooseMidiText = new System.Windows.Forms.TextBox();
			this.ChooseMidiBtn = new System.Windows.Forms.Button();
			this.MidiChannelLbl = new System.Windows.Forms.Label();
			this.MidiChannelCombo = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.MidiStartSecondLbl = new System.Windows.Forms.Label();
			this.MidiEndSecondLbl = new System.Windows.Forms.Label();
			this.MidiBpmLbl = new System.Windows.Forms.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.MidiDynamicMidiBpmCheck = new System.Windows.Forms.RadioButton();
			this.MidiMidiBpmCheck = new System.Windows.Forms.RadioButton();
			this.MidiProjectBpmCheck = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
			this.MidiBeatLbl = new System.Windows.Forms.Label();
			this.MidiBeatTxt = new System.Windows.Forms.Label();
			this.SourceConfigGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.ChooseSourceLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.ChooseSourceCombo = new System.Windows.Forms.ComboBox();
			this.ChooseSourceBtn = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.SourceStartTimeLbl = new System.Windows.Forms.Label();
			this.SourceEndTimeLbl = new System.Windows.Forms.Label();
			this.GenerateAtLbl = new System.Windows.Forms.Label();
			this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
			this.GenerateAtBeginRadio = new System.Windows.Forms.RadioButton();
			this.GenerateAtCursorRadio = new System.Windows.Forms.RadioButton();
			this.GenerateAtCustomRadio = new System.Windows.Forms.RadioButton();
			this.GenerateAtCustomText = new System.Windows.Forms.TextBox();
			this.AudioTab = new System.Windows.Forms.TabPage();
			this.AudioParamsGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.AudioFadeInLbl = new System.Windows.Forms.Label();
			this.AudioFadeInBox = new VegasScript.IntegerTrackWithBox();
			this.AudioFadeInCurveCombo = new System.Windows.Forms.ComboBox();
			this.AudioFadeOutLbl = new System.Windows.Forms.Label();
			this.AudioFadeOutBox = new VegasScript.IntegerTrackWithBox();
			this.AudioFadeOutCurveCombo = new System.Windows.Forms.ComboBox();
			this.AudioTuneGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.AudioTuneMethodLbl = new System.Windows.Forms.Label();
			this.AudioStretchAttrLbl = new System.Windows.Forms.Label();
			this.AudioLockAttrLbl = new System.Windows.Forms.Label();
			this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
			this.AudioReserveFormantCheck = new System.Windows.Forms.CheckBox();
			this.AudioBasePitchLbl = new System.Windows.Forms.Label();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.AudioMainKeyCombo = new System.Windows.Forms.ComboBox();
			this.AudioMainOctaveCombo = new System.Windows.Forms.ComboBox();
			this.AudioPreviewLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
			this.PreviewAudioBtn = new System.Windows.Forms.Button();
			this.AudioPreviewAttrLbl = new System.Windows.Forms.Label();
			this.AudioPreviewAttrLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.PreviewBeepWaveFormCombo = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.AudioConfigCheck = new System.Windows.Forms.CheckBox();
			this.AudioScratchCheck = new System.Windows.Forms.CheckBox();
			this.AudioLoopCheck = new System.Windows.Forms.CheckBox();
			this.AudioNormalizeCheck = new System.Windows.Forms.CheckBox();
			this.AudioFreezeLastFrameCheck = new System.Windows.Forms.CheckBox();
			this.AudioLegatoCheck = new System.Windows.Forms.CheckBox();
			this.VideoTab = new System.Windows.Forms.TabPage();
			this.VideoParamsGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.VideoFadeInLbl = new System.Windows.Forms.Label();
			this.VideoFadeInBox = new VegasScript.IntegerTrackWithBox();
			this.VideoFadeInCurveCombo = new System.Windows.Forms.ComboBox();
			this.VideoFadeOutLbl = new System.Windows.Forms.Label();
			this.VideoFadeOutBox = new VegasScript.IntegerTrackWithBox();
			this.VideoFadeOutCurveCombo = new System.Windows.Forms.ComboBox();
			this.VideoGlowLbl = new System.Windows.Forms.Label();
			this.VideoGlowBox = new VegasScript.IntegerTrackWithBox();
			this.VideoGlowCurveCombo = new System.Windows.Forms.ComboBox();
			this.VideoGlowBrightLbl = new System.Windows.Forms.Label();
			this.VideoGlowBrightBox = new VegasScript.IntegerTrackWithBox();
			this.VideoStartSizeLbl = new System.Windows.Forms.Label();
			this.VideoStartSizeBox = new VegasScript.IntegerTrackWithBox();
			this.VideoStartSizeCurveCombo = new System.Windows.Forms.ComboBox();
			this.VideoEndSizeLbl = new System.Windows.Forms.Label();
			this.VideoEndSizeBox = new VegasScript.IntegerTrackWithBox();
			this.VideoStartRotationLbl = new System.Windows.Forms.Label();
			this.VideoStartRotationBox = new VegasScript.IntegerTrackWithBox();
			this.VideoEndRotationLbl = new System.Windows.Forms.Label();
			this.VideoEndRotationBox = new VegasScript.IntegerTrackWithBox();
			this.VideoStartHorizontalTransLbl = new System.Windows.Forms.Label();
			this.VideoStartHorizontalTransBox = new VegasScript.IntegerTrackWithBox();
			this.VideoEndHorizontalTransLbl = new System.Windows.Forms.Label();
			this.VideoEndHorizontalTransBox = new VegasScript.IntegerTrackWithBox();
			this.VideoStartVerticalTransLbl = new System.Windows.Forms.Label();
			this.VideoStartVerticalTransBox = new VegasScript.IntegerTrackWithBox();
			this.VideoEndVerticalTransLbl = new System.Windows.Forms.Label();
			this.VideoEndVerticalTransBox = new VegasScript.IntegerTrackWithBox();
			this.VideoEffectsGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.VideoEffectLbl = new System.Windows.Forms.Label();
			this.VideoEffectInitialValueLbl = new System.Windows.Forms.Label();
			this.VideoEffectCombo = new System.Windows.Forms.ComboBox();
			this.VideoEffectInitialValueCombo = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.VideoConfigCheck = new System.Windows.Forms.CheckBox();
			this.VideoScratchCheck = new System.Windows.Forms.CheckBox();
			this.VideoLoopCheck = new System.Windows.Forms.CheckBox();
			this.VideoFreezeFirstFrameCheck = new System.Windows.Forms.CheckBox();
			this.VideoFreezeLastFrameCheck = new System.Windows.Forms.CheckBox();
			this.VideoLegatoCheck = new System.Windows.Forms.CheckBox();
			this.SheetTab = new System.Windows.Forms.TabPage();
			this.StaffParamsGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
			this.StaffClefLbl = new System.Windows.Forms.Label();
			this.StaffClefCombo = new System.Windows.Forms.ComboBox();
			this.StaffLineSpacingLbl = new System.Windows.Forms.Label();
			this.StaffSurfaceWidthLbl = new System.Windows.Forms.Label();
			this.StaffSurfacePositionLbl = new System.Windows.Forms.Label();
			this.StaffLineThicknessLbl = new System.Windows.Forms.Label();
			this.StaffLineThicknessBox = new VegasScript.NumericUpDownWithUnit();
			this.StaffLineColorLbl = new System.Windows.Forms.Label();
			this.StaffLineColorBtn = new System.Windows.Forms.Button();
			this.StaffNotesShiftLbl = new System.Windows.Forms.Label();
			this.StaffNotesShiftBox = new VegasScript.NumericUpDownWithUnit();
			this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
			this.StaffVisualizerConfigCheck = new System.Windows.Forms.CheckBox();
			this.StaffGenerateCheck = new System.Windows.Forms.CheckBox();
			this.SheetConfigInfoLabel = new System.Windows.Forms.Label();
			this.YtpTab = new System.Windows.Forms.TabPage();
			this.YtpParamsGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
			this.YtpMinLenLbl = new System.Windows.Forms.Label();
			this.YtpClipsCountLbl = new System.Windows.Forms.Label();
			this.YtpClipsCountBox = new VegasScript.NumericUpDownWithUnit();
			this.YtpMaxLenLbl = new System.Windows.Forms.Label();
			this.YtpEffectsGroup = new System.Windows.Forms.GroupBox();
			this.YtpEnableAllEffectsCheck = new System.Windows.Forms.CheckBox();
			this.YtpEffectsCheckList = new System.Windows.Forms.CheckedListBox();
			this.YtpSelectInfo = new System.Windows.Forms.Label();
			this.YtpLbl = new System.Windows.Forms.Label();
			this.HelperTab = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
			this.QuickSelectIntervalBtn = new VegasScript.CommandLinkButton();
			this.ReplaceClipsBtn = new VegasScript.CommandLinkButton();
			this.ChangeTuneMethodBtn = new VegasScript.CommandLinkButton();
			this.AutoLayoutTracksGroup = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
			this.AutoLayoutTracksLbl = new System.Windows.Forms.Label();
			this.AutoLayoutTracksSelectInfo = new System.Windows.Forms.Label();
			this.AutoLayoutTracksButtons = new System.Windows.Forms.TableLayoutPanel();
			this.GradientTracksBtn = new System.Windows.Forms.Button();
			this.AutoLayoutTracksBox3dBtn = new System.Windows.Forms.Button();
			this.AutoLayoutTracksGridBtn = new System.Windows.Forms.Button();
			this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
			this.TrackLegatoBtn = new System.Windows.Forms.Button();
			this.ClearTrackMotionBtn = new System.Windows.Forms.Button();
			this.ClearTrackEffectBtn = new System.Windows.Forms.Button();
			this.CloseAfterOpenHelperCheck = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
			this.HelperLbl = new System.Windows.Forms.Label();
			this.TrackLegatoMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.stackingTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.limitStretchLegatoTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stretchLegatoTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lengthenLegatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MidiCustomBpmCheck = new System.Windows.Forms.RadioButton();
			this.MidiCustomBpmBox = new VegasScript.NumericUpDownWithUnit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBeepDurationBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffLineSpacingBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffSurfacePositionBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffSurfaceWidthBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YtpMinLenBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.YtpMaxLenBox)).BeginInit();
			this.menu.SuspendLayout();
			this.panel1.SuspendLayout();
			this.Tabs.SuspendLayout();
			this.SourceTab.SuspendLayout();
			this.MidiConfigGroup.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel12.SuspendLayout();
			this.SourceConfigGroup.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel9.SuspendLayout();
			this.AudioTab.SuspendLayout();
			this.AudioParamsGroup.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.AudioTuneGroup.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel10.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.tableLayoutPanel17.SuspendLayout();
			this.AudioPreviewAttrLayoutPanel.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.VideoTab.SuspendLayout();
			this.VideoParamsGroup.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.VideoEffectsGroup.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.flowLayoutPanel7.SuspendLayout();
			this.SheetTab.SuspendLayout();
			this.StaffParamsGroup.SuspendLayout();
			this.tableLayoutPanel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StaffLineThicknessBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffNotesShiftBox)).BeginInit();
			this.flowLayoutPanel8.SuspendLayout();
			this.YtpTab.SuspendLayout();
			this.YtpParamsGroup.SuspendLayout();
			this.tableLayoutPanel16.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.YtpClipsCountBox)).BeginInit();
			this.YtpEffectsGroup.SuspendLayout();
			this.HelperTab.SuspendLayout();
			this.tableLayoutPanel11.SuspendLayout();
			this.AutoLayoutTracksGroup.SuspendLayout();
			this.tableLayoutPanel14.SuspendLayout();
			this.AutoLayoutTracksButtons.SuspendLayout();
			this.tableLayoutPanel15.SuspendLayout();
			this.tableLayoutPanel19.SuspendLayout();
			this.TrackLegatoMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MidiCustomBpmBox)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.UserHelpLink, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.AboutBtn, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.OkBtn, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.CancelBtn, 4, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 660);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 2);
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 42);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// UserHelpLink
			// 
			this.UserHelpLink.AutoSize = true;
			this.UserHelpLink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UserHelpLink.Location = new System.Drawing.Point(307, 5);
			this.UserHelpLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.UserHelpLink.Name = "UserHelpLink";
			this.UserHelpLink.Size = new System.Drawing.Size(78, 35);
			this.UserHelpLink.TabIndex = 3;
			this.UserHelpLink.TabStop = true;
			this.UserHelpLink.Text = "使用说明...";
			this.UserHelpLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UserHelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UserHelpLink_LinkClicked);
			// 
			// AboutBtn
			// 
			this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AboutBtn.Location = new System.Drawing.Point(393, 9);
			this.AboutBtn.Margin = new System.Windows.Forms.Padding(4);
			this.AboutBtn.Name = "AboutBtn";
			this.AboutBtn.Size = new System.Drawing.Size(75, 27);
			this.AboutBtn.TabIndex = 2;
			this.AboutBtn.Text = "关于(&A)";
			this.AboutBtn.UseVisualStyleBackColor = true;
			this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
			// 
			// OkBtn
			// 
			this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OkBtn.Location = new System.Drawing.Point(476, 9);
			this.OkBtn.Margin = new System.Windows.Forms.Padding(4);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(75, 27);
			this.OkBtn.TabIndex = 0;
			this.OkBtn.Text = "完成(&O)";
			this.OkBtn.UseVisualStyleBackColor = true;
			this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CancelBtn.Location = new System.Drawing.Point(559, 9);
			this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(75, 27);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "取消(&C)";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// StaffLineColorDialog
			// 
			this.StaffLineColorDialog.AnyColor = true;
			this.StaffLineColorDialog.Color = System.Drawing.Color.White;
			this.StaffLineColorDialog.FullOpen = true;
			// 
			// Balloon
			// 
			this.Balloon.AutomaticDelay = 0;
			this.Balloon.AutoPopDelay = 20000;
			this.Balloon.InitialDelay = 0;
			this.Balloon.IsBalloon = true;
			this.Balloon.ReshowDelay = 0;
			this.Balloon.ShowAlways = true;
			this.Balloon.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.Balloon.ToolTipTitle = "填写说明";
			// 
			// AudioTuneMethodCombo
			// 
			this.AudioTuneMethodCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioTuneMethodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AudioTuneMethodCombo.FormattingEnabled = true;
			this.AudioTuneMethodCombo.Items.AddRange(new object[] {
            "不调音",
            "移调效果插件",
            "弹性音调更改",
            "古典音调更改"});
			this.AudioTuneMethodCombo.Location = new System.Drawing.Point(78, 3);
			this.AudioTuneMethodCombo.Name = "AudioTuneMethodCombo";
			this.AudioTuneMethodCombo.Size = new System.Drawing.Size(518, 28);
			this.AudioTuneMethodCombo.TabIndex = 2;
			this.Balloon.SetToolTip(this.AudioTuneMethodCombo, "“移调效果插件”表示使用“音频 FX”中的“移调”效果插件改变音调，需要配置预设。\r\n“弹性音调更改”表示使用“Élastique”拉伸方式改变音调，也就是键盘上" +
        " +、- 键直接改变音调，\r\n有音高范围限制。");
			this.AudioTuneMethodCombo.SelectedIndexChanged += new System.EventHandler(this.AudioTuneMethodCombo_SelectedIndexChanged);
			// 
			// AudioLockStretchPitchCheck
			// 
			this.AudioLockStretchPitchCheck.AutoSize = true;
			this.AudioLockStretchPitchCheck.Location = new System.Drawing.Point(3, 3);
			this.AudioLockStretchPitchCheck.Name = "AudioLockStretchPitchCheck";
			this.AudioLockStretchPitchCheck.Size = new System.Drawing.Size(136, 24);
			this.AudioLockStretchPitchCheck.TabIndex = 0;
			this.AudioLockStretchPitchCheck.Text = "锁定伸缩与音调";
			this.Balloon.SetToolTip(this.AudioLockStretchPitchCheck, "采用重采样方式，随着速度变化而改变音高。如果使用的是“弹性音调\r\n更改”方法，那么将会禁用拉伸音频功能。");
			this.AudioLockStretchPitchCheck.UseVisualStyleBackColor = true;
			// 
			// StaffRelativeValueCheck
			// 
			this.StaffRelativeValueCheck.AutoSize = true;
			this.StaffRelativeValueCheck.Checked = true;
			this.StaffRelativeValueCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.StaffRelativeValueCheck.Location = new System.Drawing.Point(302, 6);
			this.StaffRelativeValueCheck.Name = "StaffRelativeValueCheck";
			this.StaffRelativeValueCheck.Size = new System.Drawing.Size(106, 24);
			this.StaffRelativeValueCheck.TabIndex = 6;
			this.StaffRelativeValueCheck.Text = "使用相对值";
			this.Balloon.SetToolTip(this.StaffRelativeValueCheck, "勾选后，下方所填参数的像素单位将以相对于 1920 × 1080\r\n的尺寸进行定位；反之则以项目尺寸定位。\r\n");
			this.StaffRelativeValueCheck.UseVisualStyleBackColor = true;
			// 
			// PreviewTuneAudioCheck
			// 
			this.PreviewTuneAudioCheck.AutoSize = true;
			this.PreviewTuneAudioCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviewTuneAudioCheck.Location = new System.Drawing.Point(188, 3);
			this.PreviewTuneAudioCheck.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.PreviewTuneAudioCheck.Name = "PreviewTuneAudioCheck";
			this.PreviewTuneAudioCheck.Size = new System.Drawing.Size(166, 28);
			this.PreviewTuneAudioCheck.TabIndex = 7;
			this.PreviewTuneAudioCheck.Text = "使音频调整到主音高";
			this.Balloon.SetToolTip(this.PreviewTuneAudioCheck, "勾选后，预听音频时会将音频素材调整到主音高中央 C。\r\n否则，预听标准音高将会播放原始音高所设定的音高。");
			this.PreviewTuneAudioCheck.UseVisualStyleBackColor = true;
			// 
			// MidiStartSecondBox
			// 
			this.MidiStartSecondBox.DoubleValue = 0D;
			this.MidiStartSecondBox.Enabled = false;
			this.MidiStartSecondBox.Location = new System.Drawing.Point(75, 3);
			this.MidiStartSecondBox.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
			this.MidiStartSecondBox.Name = "MidiStartSecondBox";
			this.MidiStartSecondBox.Size = new System.Drawing.Size(85, 27);
			this.MidiStartSecondBox.TabIndex = 3;
			this.Balloon.SetToolTip(this.MidiStartSecondBox, "用于截取 MIDI 音乐的一部分。\r\n单位：秒。");
			this.MidiStartSecondBox.Leave += new System.EventHandler(this.TrimTime_ValueChanged);
			// 
			// MidiEndSecondBox
			// 
			this.MidiEndSecondBox.DoubleValue = 0D;
			this.MidiEndSecondBox.Enabled = false;
			this.MidiEndSecondBox.Location = new System.Drawing.Point(250, 3);
			this.MidiEndSecondBox.Name = "MidiEndSecondBox";
			this.MidiEndSecondBox.Size = new System.Drawing.Size(85, 27);
			this.MidiEndSecondBox.TabIndex = 4;
			this.Balloon.SetToolTip(this.MidiEndSecondBox, "此处填写需要读取 MIDI 文件的时间长度。\r\n注意如果填写的值过小，将截去多余时间部分的音符。\r\n如果此处填写的值比起始秒数小或相等，则始终表示持续到整个音乐时" +
        "长末尾。\r\n单位：秒。");
			this.MidiEndSecondBox.Leave += new System.EventHandler(this.TrimTime_ValueChanged);
			// 
			// SourceStartTimeText
			// 
			this.SourceStartTimeText.DoubleValue = 0D;
			this.SourceStartTimeText.Location = new System.Drawing.Point(75, 3);
			this.SourceStartTimeText.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
			this.SourceStartTimeText.Name = "SourceStartTimeText";
			this.SourceStartTimeText.Size = new System.Drawing.Size(85, 27);
			this.SourceStartTimeText.TabIndex = 4;
			this.Balloon.SetToolTip(this.SourceStartTimeText, "此处填写媒体素材裁剪的开始时间。\r\n单位：秒。");
			this.SourceStartTimeText.Leave += new System.EventHandler(this.TrimTime_ValueChanged);
			// 
			// SourceEndTimeText
			// 
			this.SourceEndTimeText.DoubleValue = 0D;
			this.SourceEndTimeText.Location = new System.Drawing.Point(250, 3);
			this.SourceEndTimeText.Name = "SourceEndTimeText";
			this.SourceEndTimeText.Size = new System.Drawing.Size(85, 27);
			this.SourceEndTimeText.TabIndex = 5;
			this.Balloon.SetToolTip(this.SourceEndTimeText, "注意如果此处填写的数值比入点秒数小或相等，则始终表示持续到素材时间末尾。\r\n单位：秒。");
			this.SourceEndTimeText.Leave += new System.EventHandler(this.TrimTime_ValueChanged);
			// 
			// PreviewBeepDurationBox
			// 
			this.PreviewBeepDurationBox.Constrain = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.PreviewBeepDurationBox.EnableDecimalPlaces = true;
			this.PreviewBeepDurationBox.Location = new System.Drawing.Point(109, 3);
			this.PreviewBeepDurationBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			this.PreviewBeepDurationBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.PreviewBeepDurationBox.Name = "PreviewBeepDurationBox";
			this.PreviewBeepDurationBox.Size = new System.Drawing.Size(70, 27);
			this.PreviewBeepDurationBox.Suffix = "ms";
			this.PreviewBeepDurationBox.TabIndex = 5;
			this.Balloon.SetToolTip(this.PreviewBeepDurationBox, "预听标准音高所持续的时间。\r\n单位：毫秒。");
			this.PreviewBeepDurationBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// StaffLineSpacingBox
			// 
			this.StaffLineSpacingBox.Constrain = new decimal(new int[] {
            44,
            0,
            0,
            0});
			this.StaffLineSpacingBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffLineSpacingBox.Enabled = false;
			this.StaffLineSpacingBox.EnableDecimalPlaces = true;
			this.StaffLineSpacingBox.Location = new System.Drawing.Point(377, 3);
			this.StaffLineSpacingBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.StaffLineSpacingBox.Name = "StaffLineSpacingBox";
			this.StaffLineSpacingBox.Size = new System.Drawing.Size(219, 27);
			this.StaffLineSpacingBox.Suffix = "px";
			this.StaffLineSpacingBox.TabIndex = 7;
			this.Balloon.SetToolTip(this.StaffLineSpacingBox, "五线谱线与线之间的间距。\r\n单位：像素。");
			this.StaffLineSpacingBox.Value = new decimal(new int[] {
            44,
            0,
            0,
            0});
			// 
			// StaffSurfacePositionBox
			// 
			this.StaffSurfacePositionBox.Constrain = new decimal(new int[] {
            225,
            0,
            0,
            0});
			this.StaffSurfacePositionBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffSurfacePositionBox.Enabled = false;
			this.StaffSurfacePositionBox.EnableDecimalPlaces = true;
			this.StaffSurfacePositionBox.Location = new System.Drawing.Point(377, 36);
			this.StaffSurfacePositionBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.StaffSurfacePositionBox.Minimum = new decimal(new int[] {
            65536,
            0,
            0,
            -2147483648});
			this.StaffSurfacePositionBox.Name = "StaffSurfacePositionBox";
			this.StaffSurfacePositionBox.Size = new System.Drawing.Size(219, 27);
			this.StaffSurfacePositionBox.Suffix = "px";
			this.StaffSurfacePositionBox.TabIndex = 9;
			this.Balloon.SetToolTip(this.StaffSurfacePositionBox, "五线谱中间第三根线到屏幕中心的距离，上正下负。\r\n单位：像素。");
			this.StaffSurfacePositionBox.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
			// 
			// StaffSurfaceWidthBox
			// 
			this.StaffSurfaceWidthBox.Constrain = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			this.StaffSurfaceWidthBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffSurfaceWidthBox.Enabled = false;
			this.StaffSurfaceWidthBox.EnableDecimalPlaces = true;
			this.StaffSurfaceWidthBox.Location = new System.Drawing.Point(78, 36);
			this.StaffSurfaceWidthBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.StaffSurfaceWidthBox.Name = "StaffSurfaceWidthBox";
			this.StaffSurfaceWidthBox.Size = new System.Drawing.Size(218, 27);
			this.StaffSurfaceWidthBox.Suffix = "px";
			this.StaffSurfaceWidthBox.TabIndex = 8;
			this.Balloon.SetToolTip(this.StaffSurfaceWidthBox, "将在屏幕中间所填的宽度内显示音符，用于左右留白，给左侧的谱号留间距。\r\n单位：像素。");
			this.StaffSurfaceWidthBox.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			// 
			// YtpMinLenBox
			// 
			this.YtpMinLenBox.Constrain = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.YtpMinLenBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.YtpMinLenBox.EnableDecimalPlaces = true;
			this.YtpMinLenBox.Location = new System.Drawing.Point(78, 3);
			this.YtpMinLenBox.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
			this.YtpMinLenBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.YtpMinLenBox.Name = "YtpMinLenBox";
			this.YtpMinLenBox.Size = new System.Drawing.Size(218, 27);
			this.YtpMinLenBox.Suffix = "ms";
			this.YtpMinLenBox.TabIndex = 8;
			this.Balloon.SetToolTip(this.YtpMinLenBox, "指定单个轨道剪辑的最小长度。\r\n单位：毫秒。");
			this.YtpMinLenBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.YtpMinLenBox.ValueChanged += new System.EventHandler(this.YtpLenBox_ValueChanged);
			// 
			// YtpMaxLenBox
			// 
			this.YtpMaxLenBox.Constrain = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.YtpMaxLenBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.YtpMaxLenBox.EnableDecimalPlaces = true;
			this.YtpMaxLenBox.Location = new System.Drawing.Point(377, 3);
			this.YtpMaxLenBox.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
			this.YtpMaxLenBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.YtpMaxLenBox.Name = "YtpMaxLenBox";
			this.YtpMaxLenBox.Size = new System.Drawing.Size(219, 27);
			this.YtpMaxLenBox.Suffix = "ms";
			this.YtpMaxLenBox.TabIndex = 9;
			this.Balloon.SetToolTip(this.YtpMaxLenBox, "指定单个轨道剪辑的最大长度。\r\n单位：毫秒。");
			this.YtpMaxLenBox.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.YtpMaxLenBox.ValueChanged += new System.EventHandler(this.YtpLenBox_ValueChanged);
			// 
			// PreviewBasePitchBtn
			// 
			this.PreviewBasePitchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviewBasePitchBtn.Location = new System.Drawing.Point(2, 3);
			this.PreviewBasePitchBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
			this.PreviewBasePitchBtn.Name = "PreviewBasePitchBtn";
			this.PreviewBasePitchBtn.Size = new System.Drawing.Size(257, 23);
			this.PreviewBasePitchBtn.TabIndex = 1;
			this.PreviewBasePitchBtn.Text = "预听标准音高(&B)";
			this.PreviewBasePitchBtn.UseVisualStyleBackColor = true;
			this.PreviewBasePitchBtn.Click += new System.EventHandler(this.PreviewBasePitchBtn_MouseDown);
			// 
			// AudioStretchAttrCombo
			// 
			this.AudioStretchAttrCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioStretchAttrCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AudioStretchAttrCombo.FormattingEnabled = true;
			this.AudioStretchAttrCombo.Location = new System.Drawing.Point(78, 37);
			this.AudioStretchAttrCombo.Name = "AudioStretchAttrCombo";
			this.AudioStretchAttrCombo.Size = new System.Drawing.Size(518, 28);
			this.AudioStretchAttrCombo.TabIndex = 3;
			// 
			// menu
			// 
			this.menu.BackColor = System.Drawing.Color.Transparent;
			this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.helpToolStripMenuItem,
            this.languageToolStripMenuItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 4);
			this.menu.Size = new System.Drawing.Size(643, 30);
			this.menu.TabIndex = 2;
			this.menu.Text = "menuStrip1";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigToolStripMenuItem,
            this.resetConfigToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitDiscardingChangesToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(70, 24);
			this.fileMenuItem.Text = "文件(&F)";
			// 
			// saveConfigToolStripMenuItem
			// 
			this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
			this.saveConfigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
			this.saveConfigToolStripMenuItem.Text = "保存用户配置(&S)";
			// 
			// resetConfigToolStripMenuItem
			// 
			this.resetConfigToolStripMenuItem.Name = "resetConfigToolStripMenuItem";
			this.resetConfigToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
			this.resetConfigToolStripMenuItem.Text = "重置用户配置(&R)";
			this.resetConfigToolStripMenuItem.Click += new System.EventHandler(this.resetConfigToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 6);
			// 
			// exitDiscardingChangesToolStripMenuItem
			// 
			this.exitDiscardingChangesToolStripMenuItem.Name = "exitDiscardingChangesToolStripMenuItem";
			this.exitDiscardingChangesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.exitDiscardingChangesToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
			this.exitDiscardingChangesToolStripMenuItem.Text = "放弃更改并退出(&D)";
			this.exitDiscardingChangesToolStripMenuItem.Click += new System.EventHandler(this.exitDiscardingChangesToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Esc";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
			this.exitToolStripMenuItem.Text = "退出(&X)";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.whyOkBtnIsDisabledToolStripMenuItem,
            this.toolStripMenuItem2,
            this.checkUpdateToolStripMenuItem,
            this.updateInfoToolStripMenuItem,
            this.userHelpToolStripMenuItem,
            this.troubleShootingToolStripMenuItem,
            this.githubToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.helpToolStripMenuItem.Text = "帮助(&H)";
			// 
			// versionToolStripMenuItem
			// 
			this.versionToolStripMenuItem.Enabled = false;
			this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
			this.versionToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.versionToolStripMenuItem.Text = "版本号";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "Alt+A";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.aboutToolStripMenuItem.Text = "关于(&A)";
			// 
			// whyOkBtnIsDisabledToolStripMenuItem
			// 
			this.whyOkBtnIsDisabledToolStripMenuItem.Name = "whyOkBtnIsDisabledToolStripMenuItem";
			this.whyOkBtnIsDisabledToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.whyOkBtnIsDisabledToolStripMenuItem.Text = "为什么无法点击完成按钮？";
			this.whyOkBtnIsDisabledToolStripMenuItem.Visible = false;
			this.whyOkBtnIsDisabledToolStripMenuItem.Click += new System.EventHandler(this.WhyOkBtnIsDisabledToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 6);
			// 
			// checkUpdateToolStripMenuItem
			// 
			this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
			this.checkUpdateToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.checkUpdateToolStripMenuItem.Text = "检查更新(&U)";
			// 
			// updateInfoToolStripMenuItem
			// 
			this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
			this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.updateInfoToolStripMenuItem.Text = "更新说明";
			// 
			// userHelpToolStripMenuItem
			// 
			this.userHelpToolStripMenuItem.Name = "userHelpToolStripMenuItem";
			this.userHelpToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.userHelpToolStripMenuItem.Text = "使用说明";
			// 
			// troubleShootingToolStripMenuItem
			// 
			this.troubleShootingToolStripMenuItem.Name = "troubleShootingToolStripMenuItem";
			this.troubleShootingToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.troubleShootingToolStripMenuItem.Text = "疑难解答";
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			this.githubToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.githubToolStripMenuItem.Text = "仓库地址";
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chineseToolStripMenuItem,
            this.tchineseToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.japaneseToolStripMenuItem,
            this.russianToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
			this.languageToolStripMenuItem.Text = "&Language";
			// 
			// chineseToolStripMenuItem
			// 
			this.chineseToolStripMenuItem.Checked = true;
			this.chineseToolStripMenuItem.CheckOnClick = true;
			this.chineseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chineseToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
			this.chineseToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.chineseToolStripMenuItem.Text = "简体中文";
			// 
			// tchineseToolStripMenuItem
			// 
			this.tchineseToolStripMenuItem.CheckOnClick = true;
			this.tchineseToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tchineseToolStripMenuItem.Name = "tchineseToolStripMenuItem";
			this.tchineseToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.tchineseToolStripMenuItem.Text = "繁體中文";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.CheckOnClick = true;
			this.englishToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.englishToolStripMenuItem.Text = "English";
			// 
			// japaneseToolStripMenuItem
			// 
			this.japaneseToolStripMenuItem.CheckOnClick = true;
			this.japaneseToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
			this.japaneseToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.japaneseToolStripMenuItem.Text = "日本語";
			// 
			// russianToolStripMenuItem
			// 
			this.russianToolStripMenuItem.CheckOnClick = true;
			this.russianToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
			this.russianToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
			this.russianToolStripMenuItem.Text = "Русский";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.Tabs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.panel1.Size = new System.Drawing.Size(643, 630);
			this.panel1.TabIndex = 3;
			// 
			// Tabs
			// 
			this.Tabs.Controls.Add(this.SourceTab);
			this.Tabs.Controls.Add(this.AudioTab);
			this.Tabs.Controls.Add(this.VideoTab);
			this.Tabs.Controls.Add(this.SheetTab);
			this.Tabs.Controls.Add(this.YtpTab);
			this.Tabs.Controls.Add(this.HelperTab);
			this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tabs.Location = new System.Drawing.Point(8, 0);
			this.Tabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Tabs.Multiline = true;
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new System.Drawing.Size(627, 630);
			this.Tabs.TabIndex = 2;
			// 
			// SourceTab
			// 
			this.SourceTab.AutoScroll = true;
			this.SourceTab.BackColor = System.Drawing.SystemColors.Menu;
			this.SourceTab.Controls.Add(this.WarningInfoLabel);
			this.SourceTab.Controls.Add(this.MidiConfigGroup);
			this.SourceTab.Controls.Add(this.SourceConfigGroup);
			this.SourceTab.Location = new System.Drawing.Point(4, 29);
			this.SourceTab.Name = "SourceTab";
			this.SourceTab.Padding = new System.Windows.Forms.Padding(5);
			this.SourceTab.Size = new System.Drawing.Size(619, 597);
			this.SourceTab.TabIndex = 0;
			this.SourceTab.Text = "媒体";
			// 
			// WarningInfoLabel
			// 
			this.WarningInfoLabel.AutoSize = true;
			this.WarningInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.WarningInfoLabel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
			this.WarningInfoLabel.ForeColor = System.Drawing.Color.Red;
			this.WarningInfoLabel.Location = new System.Drawing.Point(5, 482);
			this.WarningInfoLabel.MaximumSize = new System.Drawing.Size(540, 0);
			this.WarningInfoLabel.Name = "WarningInfoLabel";
			this.WarningInfoLabel.Padding = new System.Windows.Forms.Padding(3);
			this.WarningInfoLabel.Size = new System.Drawing.Size(6, 32);
			this.WarningInfoLabel.TabIndex = 3;
			// 
			// MidiConfigGroup
			// 
			this.MidiConfigGroup.AutoSize = true;
			this.MidiConfigGroup.Controls.Add(this.tableLayoutPanel5);
			this.MidiConfigGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.MidiConfigGroup.Location = new System.Drawing.Point(5, 196);
			this.MidiConfigGroup.Name = "MidiConfigGroup";
			this.MidiConfigGroup.Padding = new System.Windows.Forms.Padding(5);
			this.MidiConfigGroup.Size = new System.Drawing.Size(609, 286);
			this.MidiConfigGroup.TabIndex = 2;
			this.MidiConfigGroup.TabStop = false;
			this.MidiConfigGroup.Text = "MIDI 属性";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.AutoSize = true;
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.ChooseMidiLbl, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.MidiChannelLbl, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.MidiChannelCombo, 0, 3);
			this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel3, 0, 5);
			this.tableLayoutPanel5.Controls.Add(this.MidiBpmLbl, 0, 6);
			this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel4, 0, 7);
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel12, 0, 4);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 8;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel5.Size = new System.Drawing.Size(599, 256);
			this.tableLayoutPanel5.TabIndex = 1;
			// 
			// ChooseMidiLbl
			// 
			this.ChooseMidiLbl.AutoSize = true;
			this.ChooseMidiLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChooseMidiLbl.Location = new System.Drawing.Point(3, 0);
			this.ChooseMidiLbl.Name = "ChooseMidiLbl";
			this.ChooseMidiLbl.Size = new System.Drawing.Size(593, 20);
			this.ChooseMidiLbl.TabIndex = 0;
			this.ChooseMidiLbl.Text = "选择 MIDI 文件";
			this.ChooseMidiLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.AutoSize = true;
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel6.Controls.Add(this.ChooseMidiText, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.ChooseMidiBtn, 1, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 20);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(599, 33);
			this.tableLayoutPanel6.TabIndex = 2;
			// 
			// ChooseMidiText
			// 
			this.ChooseMidiText.Dock = System.Windows.Forms.DockStyle.Top;
			this.ChooseMidiText.Location = new System.Drawing.Point(3, 3);
			this.ChooseMidiText.Name = "ChooseMidiText";
			this.ChooseMidiText.ReadOnly = true;
			this.ChooseMidiText.Size = new System.Drawing.Size(512, 27);
			this.ChooseMidiText.TabIndex = 2;
			this.ChooseMidiText.Text = "<未选择 MIDI 文件>";
			// 
			// ChooseMidiBtn
			// 
			this.ChooseMidiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChooseMidiBtn.Location = new System.Drawing.Point(521, 3);
			this.ChooseMidiBtn.Name = "ChooseMidiBtn";
			this.ChooseMidiBtn.Size = new System.Drawing.Size(75, 27);
			this.ChooseMidiBtn.TabIndex = 3;
			this.ChooseMidiBtn.Text = "浏览...";
			this.ChooseMidiBtn.UseVisualStyleBackColor = true;
			this.ChooseMidiBtn.Click += new System.EventHandler(this.ChooseMidiBtn_Click);
			// 
			// MidiChannelLbl
			// 
			this.MidiChannelLbl.AutoSize = true;
			this.MidiChannelLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiChannelLbl.Location = new System.Drawing.Point(3, 59);
			this.MidiChannelLbl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
			this.MidiChannelLbl.Name = "MidiChannelLbl";
			this.MidiChannelLbl.Size = new System.Drawing.Size(593, 20);
			this.MidiChannelLbl.TabIndex = 3;
			this.MidiChannelLbl.Text = "使用 MIDI 通道";
			this.MidiChannelLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// MidiChannelCombo
			// 
			this.MidiChannelCombo.Dock = System.Windows.Forms.DockStyle.Top;
			this.MidiChannelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MidiChannelCombo.Enabled = false;
			this.MidiChannelCombo.FormattingEnabled = true;
			this.MidiChannelCombo.Location = new System.Drawing.Point(3, 82);
			this.MidiChannelCombo.Name = "MidiChannelCombo";
			this.MidiChannelCombo.Size = new System.Drawing.Size(593, 28);
			this.MidiChannelCombo.TabIndex = 4;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.Controls.Add(this.MidiStartSecondLbl);
			this.flowLayoutPanel3.Controls.Add(this.MidiStartSecondBox);
			this.flowLayoutPanel3.Controls.Add(this.MidiEndSecondLbl);
			this.flowLayoutPanel3.Controls.Add(this.MidiEndSecondBox);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 152);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(593, 33);
			this.flowLayoutPanel3.TabIndex = 9;
			// 
			// MidiStartSecondLbl
			// 
			this.MidiStartSecondLbl.AutoSize = true;
			this.MidiStartSecondLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiStartSecondLbl.Location = new System.Drawing.Point(0, 0);
			this.MidiStartSecondLbl.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.MidiStartSecondLbl.Name = "MidiStartSecondLbl";
			this.MidiStartSecondLbl.Size = new System.Drawing.Size(69, 33);
			this.MidiStartSecondLbl.TabIndex = 0;
			this.MidiStartSecondLbl.Text = "起始秒数";
			this.MidiStartSecondLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MidiEndSecondLbl
			// 
			this.MidiEndSecondLbl.AutoSize = true;
			this.MidiEndSecondLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiEndSecondLbl.Location = new System.Drawing.Point(175, 0);
			this.MidiEndSecondLbl.Name = "MidiEndSecondLbl";
			this.MidiEndSecondLbl.Size = new System.Drawing.Size(69, 33);
			this.MidiEndSecondLbl.TabIndex = 2;
			this.MidiEndSecondLbl.Text = "终止秒数";
			this.MidiEndSecondLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MidiBpmLbl
			// 
			this.MidiBpmLbl.AutoSize = true;
			this.MidiBpmLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiBpmLbl.Location = new System.Drawing.Point(3, 197);
			this.MidiBpmLbl.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.MidiBpmLbl.Name = "MidiBpmLbl";
			this.MidiBpmLbl.Size = new System.Drawing.Size(593, 20);
			this.MidiBpmLbl.TabIndex = 10;
			this.MidiBpmLbl.Text = "设定 BPM 速度为";
			this.MidiBpmLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSize = true;
			this.flowLayoutPanel4.Controls.Add(this.MidiDynamicMidiBpmCheck);
			this.flowLayoutPanel4.Controls.Add(this.MidiMidiBpmCheck);
			this.flowLayoutPanel4.Controls.Add(this.MidiProjectBpmCheck);
			this.flowLayoutPanel4.Controls.Add(this.MidiCustomBpmCheck);
			this.flowLayoutPanel4.Controls.Add(this.MidiCustomBpmBox);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 220);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(593, 33);
			this.flowLayoutPanel4.TabIndex = 12;
			// 
			// MidiDynamicMidiBpmCheck
			// 
			this.MidiDynamicMidiBpmCheck.AutoSize = true;
			this.MidiDynamicMidiBpmCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiDynamicMidiBpmCheck.Location = new System.Drawing.Point(3, 3);
			this.MidiDynamicMidiBpmCheck.Name = "MidiDynamicMidiBpmCheck";
			this.MidiDynamicMidiBpmCheck.Size = new System.Drawing.Size(130, 27);
			this.MidiDynamicMidiBpmCheck.TabIndex = 0;
			this.MidiDynamicMidiBpmCheck.TabStop = true;
			this.MidiDynamicMidiBpmCheck.Text = "动态 MIDI 速度";
			this.MidiDynamicMidiBpmCheck.UseVisualStyleBackColor = true;
			this.MidiDynamicMidiBpmCheck.Visible = false;
			// 
			// MidiMidiBpmCheck
			// 
			this.MidiMidiBpmCheck.AutoSize = true;
			this.MidiMidiBpmCheck.Checked = true;
			this.MidiMidiBpmCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiMidiBpmCheck.Enabled = false;
			this.MidiMidiBpmCheck.Location = new System.Drawing.Point(139, 3);
			this.MidiMidiBpmCheck.Name = "MidiMidiBpmCheck";
			this.MidiMidiBpmCheck.Size = new System.Drawing.Size(96, 27);
			this.MidiMidiBpmCheck.TabIndex = 1;
			this.MidiMidiBpmCheck.TabStop = true;
			this.MidiMidiBpmCheck.Text = "MIDI 速度";
			this.MidiMidiBpmCheck.UseVisualStyleBackColor = true;
			// 
			// MidiProjectBpmCheck
			// 
			this.MidiProjectBpmCheck.AutoSize = true;
			this.MidiProjectBpmCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiProjectBpmCheck.Enabled = false;
			this.MidiProjectBpmCheck.Location = new System.Drawing.Point(241, 3);
			this.MidiProjectBpmCheck.Name = "MidiProjectBpmCheck";
			this.MidiProjectBpmCheck.Size = new System.Drawing.Size(90, 27);
			this.MidiProjectBpmCheck.TabIndex = 2;
			this.MidiProjectBpmCheck.Text = "项目速度";
			this.MidiProjectBpmCheck.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel12
			// 
			this.tableLayoutPanel12.AutoSize = true;
			this.tableLayoutPanel12.ColumnCount = 2;
			this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel12.Controls.Add(this.MidiBeatLbl, 0, 0);
			this.tableLayoutPanel12.Controls.Add(this.MidiBeatTxt, 1, 0);
			this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 121);
			this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
			this.tableLayoutPanel12.Name = "tableLayoutPanel12";
			this.tableLayoutPanel12.RowCount = 1;
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel12.Size = new System.Drawing.Size(593, 20);
			this.tableLayoutPanel12.TabIndex = 13;
			// 
			// MidiBeatLbl
			// 
			this.MidiBeatLbl.AutoSize = true;
			this.MidiBeatLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiBeatLbl.Location = new System.Drawing.Point(0, 0);
			this.MidiBeatLbl.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.MidiBeatLbl.Name = "MidiBeatLbl";
			this.MidiBeatLbl.Size = new System.Drawing.Size(69, 20);
			this.MidiBeatLbl.TabIndex = 3;
			this.MidiBeatLbl.Text = "节拍　　";
			this.MidiBeatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MidiBeatTxt
			// 
			this.MidiBeatTxt.AutoSize = true;
			this.MidiBeatTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiBeatTxt.Location = new System.Drawing.Point(75, 0);
			this.MidiBeatTxt.Name = "MidiBeatTxt";
			this.MidiBeatTxt.Size = new System.Drawing.Size(515, 20);
			this.MidiBeatTxt.TabIndex = 5;
			this.MidiBeatTxt.Text = "无";
			this.MidiBeatTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SourceConfigGroup
			// 
			this.SourceConfigGroup.AutoSize = true;
			this.SourceConfigGroup.Controls.Add(this.tableLayoutPanel3);
			this.SourceConfigGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.SourceConfigGroup.Location = new System.Drawing.Point(5, 5);
			this.SourceConfigGroup.Name = "SourceConfigGroup";
			this.SourceConfigGroup.Padding = new System.Windows.Forms.Padding(5);
			this.SourceConfigGroup.Size = new System.Drawing.Size(609, 191);
			this.SourceConfigGroup.TabIndex = 1;
			this.SourceConfigGroup.TabStop = false;
			this.SourceConfigGroup.Text = "素材属性";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.ChooseSourceLbl, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.GenerateAtLbl, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel9, 0, 4);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 5;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(599, 161);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// ChooseSourceLbl
			// 
			this.ChooseSourceLbl.AutoSize = true;
			this.ChooseSourceLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChooseSourceLbl.Location = new System.Drawing.Point(3, 0);
			this.ChooseSourceLbl.Name = "ChooseSourceLbl";
			this.ChooseSourceLbl.Size = new System.Drawing.Size(593, 20);
			this.ChooseSourceLbl.TabIndex = 0;
			this.ChooseSourceLbl.Text = "选择媒体素材";
			this.ChooseSourceLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.ChooseSourceCombo, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.ChooseSourceBtn, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 20);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(599, 34);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// ChooseSourceCombo
			// 
			this.ChooseSourceCombo.Dock = System.Windows.Forms.DockStyle.Top;
			this.ChooseSourceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ChooseSourceCombo.FormattingEnabled = true;
			this.ChooseSourceCombo.Items.AddRange(new object[] {
            "选中的媒体文件",
            "选中的轨道素材"});
			this.ChooseSourceCombo.Location = new System.Drawing.Point(3, 3);
			this.ChooseSourceCombo.Name = "ChooseSourceCombo";
			this.ChooseSourceCombo.Size = new System.Drawing.Size(512, 28);
			this.ChooseSourceCombo.TabIndex = 0;
			this.ChooseSourceCombo.SelectedIndexChanged += new System.EventHandler(this.ChooseSourceCombo_SelectedIndexChanged);
			// 
			// ChooseSourceBtn
			// 
			this.ChooseSourceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChooseSourceBtn.Location = new System.Drawing.Point(521, 3);
			this.ChooseSourceBtn.Name = "ChooseSourceBtn";
			this.ChooseSourceBtn.Size = new System.Drawing.Size(75, 28);
			this.ChooseSourceBtn.TabIndex = 1;
			this.ChooseSourceBtn.Text = "浏览...";
			this.ChooseSourceBtn.UseVisualStyleBackColor = true;
			this.ChooseSourceBtn.Click += new System.EventHandler(this.ChooseSourceBtn_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.SourceStartTimeLbl);
			this.flowLayoutPanel1.Controls.Add(this.SourceStartTimeText);
			this.flowLayoutPanel1.Controls.Add(this.SourceEndTimeLbl);
			this.flowLayoutPanel1.Controls.Add(this.SourceEndTimeText);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 57);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(593, 33);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// SourceStartTimeLbl
			// 
			this.SourceStartTimeLbl.AutoSize = true;
			this.SourceStartTimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SourceStartTimeLbl.Location = new System.Drawing.Point(0, 0);
			this.SourceStartTimeLbl.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.SourceStartTimeLbl.Name = "SourceStartTimeLbl";
			this.SourceStartTimeLbl.Size = new System.Drawing.Size(69, 33);
			this.SourceStartTimeLbl.TabIndex = 0;
			this.SourceStartTimeLbl.Text = "入点秒数";
			this.SourceStartTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SourceEndTimeLbl
			// 
			this.SourceEndTimeLbl.AutoSize = true;
			this.SourceEndTimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SourceEndTimeLbl.Location = new System.Drawing.Point(175, 0);
			this.SourceEndTimeLbl.Name = "SourceEndTimeLbl";
			this.SourceEndTimeLbl.Size = new System.Drawing.Size(69, 33);
			this.SourceEndTimeLbl.TabIndex = 2;
			this.SourceEndTimeLbl.Text = "出点秒数";
			this.SourceEndTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GenerateAtLbl
			// 
			this.GenerateAtLbl.AutoSize = true;
			this.GenerateAtLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GenerateAtLbl.Location = new System.Drawing.Point(3, 102);
			this.GenerateAtLbl.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.GenerateAtLbl.Name = "GenerateAtLbl";
			this.GenerateAtLbl.Size = new System.Drawing.Size(593, 20);
			this.GenerateAtLbl.TabIndex = 8;
			this.GenerateAtLbl.Text = "设定生成开始位置";
			this.GenerateAtLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// flowLayoutPanel9
			// 
			this.flowLayoutPanel9.AutoSize = true;
			this.flowLayoutPanel9.Controls.Add(this.GenerateAtBeginRadio);
			this.flowLayoutPanel9.Controls.Add(this.GenerateAtCursorRadio);
			this.flowLayoutPanel9.Controls.Add(this.GenerateAtCustomRadio);
			this.flowLayoutPanel9.Controls.Add(this.GenerateAtCustomText);
			this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 125);
			this.flowLayoutPanel9.Name = "flowLayoutPanel9";
			this.flowLayoutPanel9.Size = new System.Drawing.Size(593, 33);
			this.flowLayoutPanel9.TabIndex = 9;
			// 
			// GenerateAtBeginRadio
			// 
			this.GenerateAtBeginRadio.AutoSize = true;
			this.GenerateAtBeginRadio.Checked = true;
			this.GenerateAtBeginRadio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GenerateAtBeginRadio.Location = new System.Drawing.Point(3, 3);
			this.GenerateAtBeginRadio.Name = "GenerateAtBeginRadio";
			this.GenerateAtBeginRadio.Size = new System.Drawing.Size(105, 27);
			this.GenerateAtBeginRadio.TabIndex = 0;
			this.GenerateAtBeginRadio.TabStop = true;
			this.GenerateAtBeginRadio.Text = "项目开始处";
			this.GenerateAtBeginRadio.UseVisualStyleBackColor = true;
			// 
			// GenerateAtCursorRadio
			// 
			this.GenerateAtCursorRadio.AutoSize = true;
			this.GenerateAtCursorRadio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GenerateAtCursorRadio.Location = new System.Drawing.Point(114, 3);
			this.GenerateAtCursorRadio.Name = "GenerateAtCursorRadio";
			this.GenerateAtCursorRadio.Size = new System.Drawing.Size(75, 27);
			this.GenerateAtCursorRadio.TabIndex = 1;
			this.GenerateAtCursorRadio.Text = "光标处";
			this.GenerateAtCursorRadio.UseVisualStyleBackColor = true;
			// 
			// GenerateAtCustomRadio
			// 
			this.GenerateAtCustomRadio.AutoSize = true;
			this.GenerateAtCustomRadio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GenerateAtCustomRadio.Location = new System.Drawing.Point(195, 3);
			this.GenerateAtCustomRadio.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.GenerateAtCustomRadio.Name = "GenerateAtCustomRadio";
			this.GenerateAtCustomRadio.Size = new System.Drawing.Size(75, 27);
			this.GenerateAtCustomRadio.TabIndex = 3;
			this.GenerateAtCustomRadio.Text = "自定义";
			this.GenerateAtCustomRadio.UseVisualStyleBackColor = true;
			// 
			// GenerateAtCustomText
			// 
			this.GenerateAtCustomText.Enabled = false;
			this.GenerateAtCustomText.Location = new System.Drawing.Point(270, 3);
			this.GenerateAtCustomText.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.GenerateAtCustomText.Name = "GenerateAtCustomText";
			this.GenerateAtCustomText.Size = new System.Drawing.Size(85, 27);
			this.GenerateAtCustomText.TabIndex = 4;
			this.GenerateAtCustomText.Leave += new System.EventHandler(this.GenerateAtCustomText_Leave);
			// 
			// AudioTab
			// 
			this.AudioTab.AutoScroll = true;
			this.AudioTab.BackColor = System.Drawing.SystemColors.Menu;
			this.AudioTab.Controls.Add(this.AudioParamsGroup);
			this.AudioTab.Controls.Add(this.AudioTuneGroup);
			this.AudioTab.Controls.Add(this.flowLayoutPanel5);
			this.AudioTab.Location = new System.Drawing.Point(4, 29);
			this.AudioTab.Name = "AudioTab";
			this.AudioTab.Padding = new System.Windows.Forms.Padding(5);
			this.AudioTab.Size = new System.Drawing.Size(619, 597);
			this.AudioTab.TabIndex = 1;
			this.AudioTab.Text = "音频";
			// 
			// AudioParamsGroup
			// 
			this.AudioParamsGroup.AutoSize = true;
			this.AudioParamsGroup.Controls.Add(this.tableLayoutPanel2);
			this.AudioParamsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.AudioParamsGroup.Location = new System.Drawing.Point(5, 266);
			this.AudioParamsGroup.Name = "AudioParamsGroup";
			this.AudioParamsGroup.Padding = new System.Windows.Forms.Padding(5);
			this.AudioParamsGroup.Size = new System.Drawing.Size(609, 108);
			this.AudioParamsGroup.TabIndex = 2;
			this.AudioParamsGroup.TabStop = false;
			this.AudioParamsGroup.Text = "参数";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.AudioFadeInLbl, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.AudioFadeInBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.AudioFadeInCurveCombo, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.AudioFadeOutLbl, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.AudioFadeOutBox, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.AudioFadeOutCurveCombo, 2, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(599, 78);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// AudioFadeInLbl
			// 
			this.AudioFadeInLbl.AutoSize = true;
			this.AudioFadeInLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioFadeInLbl.Location = new System.Drawing.Point(3, 0);
			this.AudioFadeInLbl.Name = "AudioFadeInLbl";
			this.AudioFadeInLbl.Size = new System.Drawing.Size(69, 39);
			this.AudioFadeInLbl.TabIndex = 0;
			this.AudioFadeInLbl.Text = "渐入　　";
			this.AudioFadeInLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AudioFadeInBox
			// 
			this.AudioFadeInBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioFadeInBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.AudioFadeInBox.Location = new System.Drawing.Point(79, 4);
			this.AudioFadeInBox.Margin = new System.Windows.Forms.Padding(4);
			this.AudioFadeInBox.Name = "AudioFadeInBox";
			this.AudioFadeInBox.NumericUpDownWidth = 65;
			this.AudioFadeInBox.Size = new System.Drawing.Size(445, 31);
			this.AudioFadeInBox.TabIndex = 2;
			// 
			// AudioFadeInCurveCombo
			// 
			this.AudioFadeInCurveCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioFadeInCurveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AudioFadeInCurveCombo.FormattingEnabled = true;
			this.AudioFadeInCurveCombo.Items.AddRange(new object[] {
            "线性",
            "快速",
            "慢速",
            "平滑",
            "急剧"});
			this.AudioFadeInCurveCombo.Location = new System.Drawing.Point(531, 4);
			this.AudioFadeInCurveCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AudioFadeInCurveCombo.Name = "AudioFadeInCurveCombo";
			this.AudioFadeInCurveCombo.Size = new System.Drawing.Size(65, 28);
			this.AudioFadeInCurveCombo.TabIndex = 3;
			// 
			// AudioFadeOutLbl
			// 
			this.AudioFadeOutLbl.AutoSize = true;
			this.AudioFadeOutLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioFadeOutLbl.Location = new System.Drawing.Point(3, 39);
			this.AudioFadeOutLbl.Name = "AudioFadeOutLbl";
			this.AudioFadeOutLbl.Size = new System.Drawing.Size(69, 39);
			this.AudioFadeOutLbl.TabIndex = 1;
			this.AudioFadeOutLbl.Text = "渐出　　";
			this.AudioFadeOutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AudioFadeOutBox
			// 
			this.AudioFadeOutBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioFadeOutBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.AudioFadeOutBox.Location = new System.Drawing.Point(79, 43);
			this.AudioFadeOutBox.Margin = new System.Windows.Forms.Padding(4);
			this.AudioFadeOutBox.Name = "AudioFadeOutBox";
			this.AudioFadeOutBox.NumericUpDownWidth = 65;
			this.AudioFadeOutBox.Size = new System.Drawing.Size(445, 31);
			this.AudioFadeOutBox.TabIndex = 4;
			this.AudioFadeOutBox.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// AudioFadeOutCurveCombo
			// 
			this.AudioFadeOutCurveCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioFadeOutCurveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AudioFadeOutCurveCombo.FormattingEnabled = true;
			this.AudioFadeOutCurveCombo.Items.AddRange(new object[] {
            "线性",
            "快速",
            "慢速",
            "平滑",
            "急剧"});
			this.AudioFadeOutCurveCombo.Location = new System.Drawing.Point(531, 43);
			this.AudioFadeOutCurveCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AudioFadeOutCurveCombo.Name = "AudioFadeOutCurveCombo";
			this.AudioFadeOutCurveCombo.Size = new System.Drawing.Size(65, 28);
			this.AudioFadeOutCurveCombo.TabIndex = 5;
			// 
			// AudioTuneGroup
			// 
			this.AudioTuneGroup.AutoSize = true;
			this.AudioTuneGroup.Controls.Add(this.tableLayoutPanel7);
			this.AudioTuneGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.AudioTuneGroup.Location = new System.Drawing.Point(5, 41);
			this.AudioTuneGroup.Name = "AudioTuneGroup";
			this.AudioTuneGroup.Padding = new System.Windows.Forms.Padding(5);
			this.AudioTuneGroup.Size = new System.Drawing.Size(609, 225);
			this.AudioTuneGroup.TabIndex = 1;
			this.AudioTuneGroup.TabStop = false;
			this.AudioTuneGroup.Text = "调音";
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.AutoSize = true;
			this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Controls.Add(this.AudioTuneMethodLbl, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.AudioTuneMethodCombo, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.AudioStretchAttrLbl, 0, 1);
			this.tableLayoutPanel7.Controls.Add(this.AudioStretchAttrCombo, 1, 1);
			this.tableLayoutPanel7.Controls.Add(this.AudioLockAttrLbl, 0, 2);
			this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel10, 1, 2);
			this.tableLayoutPanel7.Controls.Add(this.AudioBasePitchLbl, 0, 3);
			this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel6, 1, 3);
			this.tableLayoutPanel7.Controls.Add(this.AudioPreviewLbl, 0, 4);
			this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel17, 1, 4);
			this.tableLayoutPanel7.Controls.Add(this.AudioPreviewAttrLbl, 0, 5);
			this.tableLayoutPanel7.Controls.Add(this.AudioPreviewAttrLayoutPanel, 1, 5);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 6;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.Size = new System.Drawing.Size(599, 195);
			this.tableLayoutPanel7.TabIndex = 2;
			// 
			// AudioTuneMethodLbl
			// 
			this.AudioTuneMethodLbl.AutoSize = true;
			this.AudioTuneMethodLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioTuneMethodLbl.Location = new System.Drawing.Point(3, 0);
			this.AudioTuneMethodLbl.Name = "AudioTuneMethodLbl";
			this.AudioTuneMethodLbl.Size = new System.Drawing.Size(69, 34);
			this.AudioTuneMethodLbl.TabIndex = 0;
			this.AudioTuneMethodLbl.Text = "调音方法";
			this.AudioTuneMethodLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AudioStretchAttrLbl
			// 
			this.AudioStretchAttrLbl.AutoSize = true;
			this.AudioStretchAttrLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioStretchAttrLbl.Location = new System.Drawing.Point(3, 34);
			this.AudioStretchAttrLbl.Name = "AudioStretchAttrLbl";
			this.AudioStretchAttrLbl.Size = new System.Drawing.Size(69, 34);
			this.AudioStretchAttrLbl.TabIndex = 6;
			this.AudioStretchAttrLbl.Text = "拉伸属性";
			this.AudioStretchAttrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AudioLockAttrLbl
			// 
			this.AudioLockAttrLbl.AutoSize = true;
			this.AudioLockAttrLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioLockAttrLbl.Location = new System.Drawing.Point(3, 68);
			this.AudioLockAttrLbl.Name = "AudioLockAttrLbl";
			this.AudioLockAttrLbl.Size = new System.Drawing.Size(69, 30);
			this.AudioLockAttrLbl.TabIndex = 8;
			this.AudioLockAttrLbl.Text = "锁定属性";
			this.AudioLockAttrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel10
			// 
			this.flowLayoutPanel10.AutoSize = true;
			this.flowLayoutPanel10.Controls.Add(this.AudioLockStretchPitchCheck);
			this.flowLayoutPanel10.Controls.Add(this.AudioReserveFormantCheck);
			this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel10.Location = new System.Drawing.Point(75, 68);
			this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel10.Name = "flowLayoutPanel10";
			this.flowLayoutPanel10.Size = new System.Drawing.Size(524, 30);
			this.flowLayoutPanel10.TabIndex = 4;
			// 
			// AudioReserveFormantCheck
			// 
			this.AudioReserveFormantCheck.AutoSize = true;
			this.AudioReserveFormantCheck.Location = new System.Drawing.Point(145, 3);
			this.AudioReserveFormantCheck.Name = "AudioReserveFormantCheck";
			this.AudioReserveFormantCheck.Size = new System.Drawing.Size(106, 24);
			this.AudioReserveFormantCheck.TabIndex = 1;
			this.AudioReserveFormantCheck.Text = "保持共振峰";
			this.AudioReserveFormantCheck.UseVisualStyleBackColor = true;
			// 
			// AudioBasePitchLbl
			// 
			this.AudioBasePitchLbl.AutoSize = true;
			this.AudioBasePitchLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioBasePitchLbl.Location = new System.Drawing.Point(3, 98);
			this.AudioBasePitchLbl.Name = "AudioBasePitchLbl";
			this.AudioBasePitchLbl.Size = new System.Drawing.Size(69, 34);
			this.AudioBasePitchLbl.TabIndex = 1;
			this.AudioBasePitchLbl.Text = "原始音高";
			this.AudioBasePitchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.AutoSize = true;
			this.flowLayoutPanel6.Controls.Add(this.AudioMainKeyCombo);
			this.flowLayoutPanel6.Controls.Add(this.AudioMainOctaveCombo);
			this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel6.Location = new System.Drawing.Point(75, 98);
			this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Size = new System.Drawing.Size(524, 34);
			this.flowLayoutPanel6.TabIndex = 5;
			// 
			// AudioMainKeyCombo
			// 
			this.AudioMainKeyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AudioMainKeyCombo.FormattingEnabled = true;
			this.AudioMainKeyCombo.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
			this.AudioMainKeyCombo.Location = new System.Drawing.Point(3, 3);
			this.AudioMainKeyCombo.Name = "AudioMainKeyCombo";
			this.AudioMainKeyCombo.Size = new System.Drawing.Size(60, 28);
			this.AudioMainKeyCombo.TabIndex = 3;
			// 
			// AudioMainOctaveCombo
			// 
			this.AudioMainOctaveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AudioMainOctaveCombo.FormattingEnabled = true;
			this.AudioMainOctaveCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.AudioMainOctaveCombo.Location = new System.Drawing.Point(69, 3);
			this.AudioMainOctaveCombo.Name = "AudioMainOctaveCombo";
			this.AudioMainOctaveCombo.Size = new System.Drawing.Size(60, 28);
			this.AudioMainOctaveCombo.TabIndex = 4;
			// 
			// AudioPreviewLbl
			// 
			this.AudioPreviewLbl.AutoSize = true;
			this.AudioPreviewLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioPreviewLbl.Location = new System.Drawing.Point(3, 132);
			this.AudioPreviewLbl.Name = "AudioPreviewLbl";
			this.AudioPreviewLbl.Size = new System.Drawing.Size(69, 29);
			this.AudioPreviewLbl.TabIndex = 9;
			this.AudioPreviewLbl.Text = "预听";
			this.AudioPreviewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel17
			// 
			this.tableLayoutPanel17.AutoSize = true;
			this.tableLayoutPanel17.ColumnCount = 2;
			this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel17.Controls.Add(this.PreviewBasePitchBtn, 0, 0);
			this.tableLayoutPanel17.Controls.Add(this.PreviewAudioBtn, 1, 0);
			this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel17.Location = new System.Drawing.Point(75, 132);
			this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel17.Name = "tableLayoutPanel17";
			this.tableLayoutPanel17.RowCount = 1;
			this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel17.Size = new System.Drawing.Size(524, 29);
			this.tableLayoutPanel17.TabIndex = 6;
			// 
			// PreviewAudioBtn
			// 
			this.PreviewAudioBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PreviewAudioBtn.Location = new System.Drawing.Point(265, 3);
			this.PreviewAudioBtn.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
			this.PreviewAudioBtn.Name = "PreviewAudioBtn";
			this.PreviewAudioBtn.Size = new System.Drawing.Size(257, 23);
			this.PreviewAudioBtn.TabIndex = 2;
			this.PreviewAudioBtn.Text = "预听音频(&P)";
			this.PreviewAudioBtn.UseVisualStyleBackColor = true;
			this.PreviewAudioBtn.Click += new System.EventHandler(this.PreviewAudioBtn_Click);
			// 
			// AudioPreviewAttrLbl
			// 
			this.AudioPreviewAttrLbl.AutoSize = true;
			this.AudioPreviewAttrLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioPreviewAttrLbl.Location = new System.Drawing.Point(3, 161);
			this.AudioPreviewAttrLbl.Name = "AudioPreviewAttrLbl";
			this.AudioPreviewAttrLbl.Size = new System.Drawing.Size(69, 34);
			this.AudioPreviewAttrLbl.TabIndex = 10;
			this.AudioPreviewAttrLbl.Text = "预听属性";
			this.AudioPreviewAttrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AudioPreviewAttrLayoutPanel
			// 
			this.AudioPreviewAttrLayoutPanel.AutoSize = true;
			this.AudioPreviewAttrLayoutPanel.Controls.Add(this.PreviewBeepWaveFormCombo);
			this.AudioPreviewAttrLayoutPanel.Controls.Add(this.PreviewBeepDurationBox);
			this.AudioPreviewAttrLayoutPanel.Controls.Add(this.PreviewTuneAudioCheck);
			this.AudioPreviewAttrLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AudioPreviewAttrLayoutPanel.Location = new System.Drawing.Point(75, 161);
			this.AudioPreviewAttrLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.AudioPreviewAttrLayoutPanel.Name = "AudioPreviewAttrLayoutPanel";
			this.AudioPreviewAttrLayoutPanel.Size = new System.Drawing.Size(524, 34);
			this.AudioPreviewAttrLayoutPanel.TabIndex = 7;
			// 
			// PreviewBeepWaveFormCombo
			// 
			this.PreviewBeepWaveFormCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PreviewBeepWaveFormCombo.FormattingEnabled = true;
			this.PreviewBeepWaveFormCombo.Items.AddRange(new object[] {
            "正弦波",
            "三角波",
            "方波",
            "锯齿波"});
			this.PreviewBeepWaveFormCombo.Location = new System.Drawing.Point(3, 3);
			this.PreviewBeepWaveFormCombo.Name = "PreviewBeepWaveFormCombo";
			this.PreviewBeepWaveFormCombo.Size = new System.Drawing.Size(100, 28);
			this.PreviewBeepWaveFormCombo.TabIndex = 3;
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.AutoSize = true;
			this.flowLayoutPanel5.Controls.Add(this.AudioConfigCheck);
			this.flowLayoutPanel5.Controls.Add(this.AudioScratchCheck);
			this.flowLayoutPanel5.Controls.Add(this.AudioLoopCheck);
			this.flowLayoutPanel5.Controls.Add(this.AudioNormalizeCheck);
			this.flowLayoutPanel5.Controls.Add(this.AudioFreezeLastFrameCheck);
			this.flowLayoutPanel5.Controls.Add(this.AudioLegatoCheck);
			this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(5, 5);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.flowLayoutPanel5.Size = new System.Drawing.Size(609, 36);
			this.flowLayoutPanel5.TabIndex = 0;
			// 
			// AudioConfigCheck
			// 
			this.AudioConfigCheck.AutoSize = true;
			this.AudioConfigCheck.Checked = true;
			this.AudioConfigCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AudioConfigCheck.Location = new System.Drawing.Point(3, 6);
			this.AudioConfigCheck.Name = "AudioConfigCheck";
			this.AudioConfigCheck.Size = new System.Drawing.Size(91, 24);
			this.AudioConfigCheck.TabIndex = 0;
			this.AudioConfigCheck.Text = "生成音频";
			this.AudioConfigCheck.UseVisualStyleBackColor = true;
			// 
			// AudioScratchCheck
			// 
			this.AudioScratchCheck.AutoSize = true;
			this.AudioScratchCheck.Location = new System.Drawing.Point(100, 6);
			this.AudioScratchCheck.Name = "AudioScratchCheck";
			this.AudioScratchCheck.Size = new System.Drawing.Size(91, 24);
			this.AudioScratchCheck.TabIndex = 1;
			this.AudioScratchCheck.Text = "拉伸音频";
			this.AudioScratchCheck.UseVisualStyleBackColor = true;
			// 
			// AudioLoopCheck
			// 
			this.AudioLoopCheck.AutoSize = true;
			this.AudioLoopCheck.Location = new System.Drawing.Point(197, 6);
			this.AudioLoopCheck.Name = "AudioLoopCheck";
			this.AudioLoopCheck.Size = new System.Drawing.Size(91, 24);
			this.AudioLoopCheck.TabIndex = 2;
			this.AudioLoopCheck.Text = "循环音频";
			this.AudioLoopCheck.UseVisualStyleBackColor = true;
			// 
			// AudioNormalizeCheck
			// 
			this.AudioNormalizeCheck.AutoSize = true;
			this.AudioNormalizeCheck.Checked = true;
			this.AudioNormalizeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AudioNormalizeCheck.Location = new System.Drawing.Point(294, 6);
			this.AudioNormalizeCheck.Name = "AudioNormalizeCheck";
			this.AudioNormalizeCheck.Size = new System.Drawing.Size(106, 24);
			this.AudioNormalizeCheck.TabIndex = 3;
			this.AudioNormalizeCheck.Text = "规范化音量";
			this.AudioNormalizeCheck.UseVisualStyleBackColor = true;
			// 
			// AudioFreezeLastFrameCheck
			// 
			this.AudioFreezeLastFrameCheck.AutoSize = true;
			this.AudioFreezeLastFrameCheck.Location = new System.Drawing.Point(406, 6);
			this.AudioFreezeLastFrameCheck.Name = "AudioFreezeLastFrameCheck";
			this.AudioFreezeLastFrameCheck.Size = new System.Drawing.Size(91, 24);
			this.AudioFreezeLastFrameCheck.TabIndex = 6;
			this.AudioFreezeLastFrameCheck.Text = "定格尾帧";
			this.AudioFreezeLastFrameCheck.UseVisualStyleBackColor = true;
			this.AudioFreezeLastFrameCheck.CheckedChanged += new System.EventHandler(this.AudioLegatoCheck_Or_AudioFreezeLastFrameCheck_CheckedChanged);
			// 
			// AudioLegatoCheck
			// 
			this.AudioLegatoCheck.AutoSize = true;
			this.AudioLegatoCheck.Location = new System.Drawing.Point(503, 6);
			this.AudioLegatoCheck.Name = "AudioLegatoCheck";
			this.AudioLegatoCheck.Size = new System.Drawing.Size(91, 24);
			this.AudioLegatoCheck.TabIndex = 7;
			this.AudioLegatoCheck.Text = "填补间隙";
			this.AudioLegatoCheck.UseVisualStyleBackColor = true;
			this.AudioLegatoCheck.CheckedChanged += new System.EventHandler(this.AudioLegatoCheck_Or_AudioFreezeLastFrameCheck_CheckedChanged);
			// 
			// VideoTab
			// 
			this.VideoTab.AutoScroll = true;
			this.VideoTab.BackColor = System.Drawing.SystemColors.Menu;
			this.VideoTab.Controls.Add(this.VideoParamsGroup);
			this.VideoTab.Controls.Add(this.VideoEffectsGroup);
			this.VideoTab.Controls.Add(this.flowLayoutPanel7);
			this.VideoTab.Location = new System.Drawing.Point(4, 29);
			this.VideoTab.Name = "VideoTab";
			this.VideoTab.Padding = new System.Windows.Forms.Padding(5);
			this.VideoTab.Size = new System.Drawing.Size(619, 597);
			this.VideoTab.TabIndex = 2;
			this.VideoTab.Text = "视频";
			// 
			// VideoParamsGroup
			// 
			this.VideoParamsGroup.AutoSize = true;
			this.VideoParamsGroup.Controls.Add(this.tableLayoutPanel9);
			this.VideoParamsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.VideoParamsGroup.Location = new System.Drawing.Point(5, 139);
			this.VideoParamsGroup.Name = "VideoParamsGroup";
			this.VideoParamsGroup.Padding = new System.Windows.Forms.Padding(5);
			this.VideoParamsGroup.Size = new System.Drawing.Size(588, 498);
			this.VideoParamsGroup.TabIndex = 3;
			this.VideoParamsGroup.TabStop = false;
			this.VideoParamsGroup.Text = "参数";
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.AutoSize = true;
			this.tableLayoutPanel9.ColumnCount = 3;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel9.Controls.Add(this.VideoFadeInLbl, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.VideoFadeInBox, 1, 0);
			this.tableLayoutPanel9.Controls.Add(this.VideoFadeInCurveCombo, 2, 0);
			this.tableLayoutPanel9.Controls.Add(this.VideoFadeOutLbl, 0, 1);
			this.tableLayoutPanel9.Controls.Add(this.VideoFadeOutBox, 1, 1);
			this.tableLayoutPanel9.Controls.Add(this.VideoFadeOutCurveCombo, 2, 1);
			this.tableLayoutPanel9.Controls.Add(this.VideoGlowLbl, 0, 2);
			this.tableLayoutPanel9.Controls.Add(this.VideoGlowBox, 1, 2);
			this.tableLayoutPanel9.Controls.Add(this.VideoGlowCurveCombo, 2, 2);
			this.tableLayoutPanel9.Controls.Add(this.VideoGlowBrightLbl, 0, 3);
			this.tableLayoutPanel9.Controls.Add(this.VideoGlowBrightBox, 1, 3);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartSizeLbl, 0, 4);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartSizeBox, 1, 4);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartSizeCurveCombo, 2, 4);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndSizeLbl, 0, 5);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndSizeBox, 1, 5);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartRotationLbl, 0, 6);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartRotationBox, 1, 6);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndRotationLbl, 0, 7);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndRotationBox, 1, 7);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartHorizontalTransLbl, 0, 8);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartHorizontalTransBox, 1, 8);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndHorizontalTransLbl, 0, 9);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndHorizontalTransBox, 1, 9);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartVerticalTransLbl, 0, 10);
			this.tableLayoutPanel9.Controls.Add(this.VideoStartVerticalTransBox, 1, 10);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndVerticalTransLbl, 0, 11);
			this.tableLayoutPanel9.Controls.Add(this.VideoEndVerticalTransBox, 1, 11);
			this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel9.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 12;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel9.Size = new System.Drawing.Size(578, 468);
			this.tableLayoutPanel9.TabIndex = 0;
			// 
			// VideoFadeInLbl
			// 
			this.VideoFadeInLbl.AutoSize = true;
			this.VideoFadeInLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoFadeInLbl.Location = new System.Drawing.Point(3, 0);
			this.VideoFadeInLbl.Name = "VideoFadeInLbl";
			this.VideoFadeInLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoFadeInLbl.TabIndex = 0;
			this.VideoFadeInLbl.Text = "渐入　　";
			this.VideoFadeInLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoFadeInBox
			// 
			this.VideoFadeInBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoFadeInBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoFadeInBox.Location = new System.Drawing.Point(79, 4);
			this.VideoFadeInBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoFadeInBox.Name = "VideoFadeInBox";
			this.VideoFadeInBox.NumericUpDownWidth = 65;
			this.VideoFadeInBox.Size = new System.Drawing.Size(424, 31);
			this.VideoFadeInBox.TabIndex = 2;
			// 
			// VideoFadeInCurveCombo
			// 
			this.VideoFadeInCurveCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoFadeInCurveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoFadeInCurveCombo.FormattingEnabled = true;
			this.VideoFadeInCurveCombo.Items.AddRange(new object[] {
            "线性",
            "快速",
            "慢速",
            "平滑",
            "急剧"});
			this.VideoFadeInCurveCombo.Location = new System.Drawing.Point(510, 4);
			this.VideoFadeInCurveCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.VideoFadeInCurveCombo.Name = "VideoFadeInCurveCombo";
			this.VideoFadeInCurveCombo.Size = new System.Drawing.Size(65, 28);
			this.VideoFadeInCurveCombo.TabIndex = 3;
			// 
			// VideoFadeOutLbl
			// 
			this.VideoFadeOutLbl.AutoSize = true;
			this.VideoFadeOutLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoFadeOutLbl.Location = new System.Drawing.Point(3, 39);
			this.VideoFadeOutLbl.Name = "VideoFadeOutLbl";
			this.VideoFadeOutLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoFadeOutLbl.TabIndex = 1;
			this.VideoFadeOutLbl.Text = "渐出　　";
			this.VideoFadeOutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoFadeOutBox
			// 
			this.VideoFadeOutBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoFadeOutBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoFadeOutBox.Location = new System.Drawing.Point(79, 43);
			this.VideoFadeOutBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoFadeOutBox.Name = "VideoFadeOutBox";
			this.VideoFadeOutBox.NumericUpDownWidth = 65;
			this.VideoFadeOutBox.Size = new System.Drawing.Size(424, 31);
			this.VideoFadeOutBox.TabIndex = 4;
			this.VideoFadeOutBox.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// VideoFadeOutCurveCombo
			// 
			this.VideoFadeOutCurveCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoFadeOutCurveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoFadeOutCurveCombo.FormattingEnabled = true;
			this.VideoFadeOutCurveCombo.Items.AddRange(new object[] {
            "线性",
            "快速",
            "慢速",
            "平滑",
            "急剧"});
			this.VideoFadeOutCurveCombo.Location = new System.Drawing.Point(510, 43);
			this.VideoFadeOutCurveCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.VideoFadeOutCurveCombo.Name = "VideoFadeOutCurveCombo";
			this.VideoFadeOutCurveCombo.Size = new System.Drawing.Size(65, 28);
			this.VideoFadeOutCurveCombo.TabIndex = 5;
			// 
			// VideoGlowLbl
			// 
			this.VideoGlowLbl.AutoSize = true;
			this.VideoGlowLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoGlowLbl.Location = new System.Drawing.Point(3, 78);
			this.VideoGlowLbl.Name = "VideoGlowLbl";
			this.VideoGlowLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoGlowLbl.TabIndex = 23;
			this.VideoGlowLbl.Text = "发光";
			this.VideoGlowLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoGlowBox
			// 
			this.VideoGlowBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoGlowBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoGlowBox.Location = new System.Drawing.Point(79, 82);
			this.VideoGlowBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoGlowBox.Minimum = -100;
			this.VideoGlowBox.Name = "VideoGlowBox";
			this.VideoGlowBox.NumericUpDownWidth = 65;
			this.VideoGlowBox.Size = new System.Drawing.Size(424, 31);
			this.VideoGlowBox.TabIndex = 10;
			// 
			// VideoGlowCurveCombo
			// 
			this.VideoGlowCurveCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoGlowCurveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoGlowCurveCombo.FormattingEnabled = true;
			this.VideoGlowCurveCombo.Items.AddRange(new object[] {
            "线性",
            "快速",
            "慢速",
            "平滑",
            "急剧"});
			this.VideoGlowCurveCombo.Location = new System.Drawing.Point(510, 82);
			this.VideoGlowCurveCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.VideoGlowCurveCombo.Name = "VideoGlowCurveCombo";
			this.VideoGlowCurveCombo.Size = new System.Drawing.Size(65, 28);
			this.VideoGlowCurveCombo.TabIndex = 11;
			// 
			// VideoGlowBrightLbl
			// 
			this.VideoGlowBrightLbl.AutoSize = true;
			this.VideoGlowBrightLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoGlowBrightLbl.Location = new System.Drawing.Point(3, 117);
			this.VideoGlowBrightLbl.Name = "VideoGlowBrightLbl";
			this.VideoGlowBrightLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoGlowBrightLbl.TabIndex = 24;
			this.VideoGlowBrightLbl.Text = "发光亮度";
			this.VideoGlowBrightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoGlowBrightBox
			// 
			this.VideoGlowBrightBox.DefaultValue = 100;
			this.VideoGlowBrightBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoGlowBrightBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoGlowBrightBox.Location = new System.Drawing.Point(79, 121);
			this.VideoGlowBrightBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoGlowBrightBox.Minimum = -100;
			this.VideoGlowBrightBox.Name = "VideoGlowBrightBox";
			this.VideoGlowBrightBox.NumericUpDownWidth = 65;
			this.VideoGlowBrightBox.Size = new System.Drawing.Size(424, 31);
			this.VideoGlowBrightBox.TabIndex = 12;
			this.VideoGlowBrightBox.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.VideoGlowBrightBox.Value = 100;
			// 
			// VideoStartSizeLbl
			// 
			this.VideoStartSizeLbl.AutoSize = true;
			this.VideoStartSizeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartSizeLbl.Location = new System.Drawing.Point(3, 156);
			this.VideoStartSizeLbl.Name = "VideoStartSizeLbl";
			this.VideoStartSizeLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoStartSizeLbl.TabIndex = 6;
			this.VideoStartSizeLbl.Text = "起始尺寸";
			this.VideoStartSizeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoStartSizeBox
			// 
			this.VideoStartSizeBox.DefaultValue = 90;
			this.VideoStartSizeBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartSizeBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoStartSizeBox.Location = new System.Drawing.Point(79, 160);
			this.VideoStartSizeBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoStartSizeBox.Maximum = 200;
			this.VideoStartSizeBox.Name = "VideoStartSizeBox";
			this.VideoStartSizeBox.NumericUpDownWidth = 65;
			this.VideoStartSizeBox.Size = new System.Drawing.Size(424, 31);
			this.VideoStartSizeBox.TabIndex = 14;
			this.VideoStartSizeBox.Value = 90;
			// 
			// VideoStartSizeCurveCombo
			// 
			this.VideoStartSizeCurveCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartSizeCurveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoStartSizeCurveCombo.FormattingEnabled = true;
			this.VideoStartSizeCurveCombo.Items.AddRange(new object[] {
            "线性",
            "快速",
            "慢速",
            "平滑",
            "急剧"});
			this.VideoStartSizeCurveCombo.Location = new System.Drawing.Point(510, 160);
			this.VideoStartSizeCurveCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.VideoStartSizeCurveCombo.Name = "VideoStartSizeCurveCombo";
			this.VideoStartSizeCurveCombo.Size = new System.Drawing.Size(65, 28);
			this.VideoStartSizeCurveCombo.TabIndex = 15;
			// 
			// VideoEndSizeLbl
			// 
			this.VideoEndSizeLbl.AutoSize = true;
			this.VideoEndSizeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndSizeLbl.Location = new System.Drawing.Point(3, 195);
			this.VideoEndSizeLbl.Name = "VideoEndSizeLbl";
			this.VideoEndSizeLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoEndSizeLbl.TabIndex = 7;
			this.VideoEndSizeLbl.Text = "终止尺寸";
			this.VideoEndSizeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoEndSizeBox
			// 
			this.VideoEndSizeBox.DefaultValue = 100;
			this.VideoEndSizeBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndSizeBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoEndSizeBox.Location = new System.Drawing.Point(79, 199);
			this.VideoEndSizeBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoEndSizeBox.Maximum = 200;
			this.VideoEndSizeBox.Name = "VideoEndSizeBox";
			this.VideoEndSizeBox.NumericUpDownWidth = 65;
			this.VideoEndSizeBox.Size = new System.Drawing.Size(424, 31);
			this.VideoEndSizeBox.TabIndex = 16;
			this.VideoEndSizeBox.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.VideoEndSizeBox.Value = 100;
			// 
			// VideoStartRotationLbl
			// 
			this.VideoStartRotationLbl.AutoSize = true;
			this.VideoStartRotationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartRotationLbl.Location = new System.Drawing.Point(3, 234);
			this.VideoStartRotationLbl.Name = "VideoStartRotationLbl";
			this.VideoStartRotationLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoStartRotationLbl.TabIndex = 8;
			this.VideoStartRotationLbl.Text = "起始旋转";
			this.VideoStartRotationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoStartRotationBox
			// 
			this.VideoStartRotationBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartRotationBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoStartRotationBox.Location = new System.Drawing.Point(79, 238);
			this.VideoStartRotationBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoStartRotationBox.Maximum = 360;
			this.VideoStartRotationBox.Minimum = -360;
			this.VideoStartRotationBox.Name = "VideoStartRotationBox";
			this.VideoStartRotationBox.NumericUpDownWidth = 65;
			this.VideoStartRotationBox.Size = new System.Drawing.Size(424, 31);
			this.VideoStartRotationBox.TabIndex = 17;
			// 
			// VideoEndRotationLbl
			// 
			this.VideoEndRotationLbl.AutoSize = true;
			this.VideoEndRotationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndRotationLbl.Location = new System.Drawing.Point(3, 273);
			this.VideoEndRotationLbl.Name = "VideoEndRotationLbl";
			this.VideoEndRotationLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoEndRotationLbl.TabIndex = 9;
			this.VideoEndRotationLbl.Text = "终止旋转";
			this.VideoEndRotationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoEndRotationBox
			// 
			this.VideoEndRotationBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndRotationBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoEndRotationBox.Location = new System.Drawing.Point(79, 277);
			this.VideoEndRotationBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoEndRotationBox.Maximum = 360;
			this.VideoEndRotationBox.Minimum = -360;
			this.VideoEndRotationBox.Name = "VideoEndRotationBox";
			this.VideoEndRotationBox.NumericUpDownWidth = 65;
			this.VideoEndRotationBox.Size = new System.Drawing.Size(424, 31);
			this.VideoEndRotationBox.TabIndex = 18;
			this.VideoEndRotationBox.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// VideoStartHorizontalTransLbl
			// 
			this.VideoStartHorizontalTransLbl.AutoSize = true;
			this.VideoStartHorizontalTransLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartHorizontalTransLbl.Location = new System.Drawing.Point(3, 312);
			this.VideoStartHorizontalTransLbl.Name = "VideoStartHorizontalTransLbl";
			this.VideoStartHorizontalTransLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoStartHorizontalTransLbl.TabIndex = 12;
			this.VideoStartHorizontalTransLbl.Text = "起始平移";
			this.VideoStartHorizontalTransLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoStartHorizontalTransBox
			// 
			this.VideoStartHorizontalTransBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartHorizontalTransBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoStartHorizontalTransBox.Location = new System.Drawing.Point(79, 316);
			this.VideoStartHorizontalTransBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoStartHorizontalTransBox.Minimum = -100;
			this.VideoStartHorizontalTransBox.Name = "VideoStartHorizontalTransBox";
			this.VideoStartHorizontalTransBox.NumericUpDownWidth = 65;
			this.VideoStartHorizontalTransBox.Size = new System.Drawing.Size(424, 31);
			this.VideoStartHorizontalTransBox.TabIndex = 19;
			// 
			// VideoEndHorizontalTransLbl
			// 
			this.VideoEndHorizontalTransLbl.AutoSize = true;
			this.VideoEndHorizontalTransLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndHorizontalTransLbl.Location = new System.Drawing.Point(3, 351);
			this.VideoEndHorizontalTransLbl.Name = "VideoEndHorizontalTransLbl";
			this.VideoEndHorizontalTransLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoEndHorizontalTransLbl.TabIndex = 10;
			this.VideoEndHorizontalTransLbl.Text = "终止平移";
			this.VideoEndHorizontalTransLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoEndHorizontalTransBox
			// 
			this.VideoEndHorizontalTransBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndHorizontalTransBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoEndHorizontalTransBox.Location = new System.Drawing.Point(79, 355);
			this.VideoEndHorizontalTransBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoEndHorizontalTransBox.Minimum = -100;
			this.VideoEndHorizontalTransBox.Name = "VideoEndHorizontalTransBox";
			this.VideoEndHorizontalTransBox.NumericUpDownWidth = 65;
			this.VideoEndHorizontalTransBox.Size = new System.Drawing.Size(424, 31);
			this.VideoEndHorizontalTransBox.TabIndex = 20;
			this.VideoEndHorizontalTransBox.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// VideoStartVerticalTransLbl
			// 
			this.VideoStartVerticalTransLbl.AutoSize = true;
			this.VideoStartVerticalTransLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartVerticalTransLbl.Location = new System.Drawing.Point(3, 390);
			this.VideoStartVerticalTransLbl.Name = "VideoStartVerticalTransLbl";
			this.VideoStartVerticalTransLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoStartVerticalTransLbl.TabIndex = 11;
			this.VideoStartVerticalTransLbl.Text = "起始直移";
			this.VideoStartVerticalTransLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoStartVerticalTransBox
			// 
			this.VideoStartVerticalTransBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoStartVerticalTransBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoStartVerticalTransBox.Location = new System.Drawing.Point(79, 394);
			this.VideoStartVerticalTransBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoStartVerticalTransBox.Minimum = -100;
			this.VideoStartVerticalTransBox.Name = "VideoStartVerticalTransBox";
			this.VideoStartVerticalTransBox.NumericUpDownWidth = 65;
			this.VideoStartVerticalTransBox.Size = new System.Drawing.Size(424, 31);
			this.VideoStartVerticalTransBox.TabIndex = 21;
			// 
			// VideoEndVerticalTransLbl
			// 
			this.VideoEndVerticalTransLbl.AutoSize = true;
			this.VideoEndVerticalTransLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndVerticalTransLbl.Location = new System.Drawing.Point(3, 429);
			this.VideoEndVerticalTransLbl.Name = "VideoEndVerticalTransLbl";
			this.VideoEndVerticalTransLbl.Size = new System.Drawing.Size(69, 39);
			this.VideoEndVerticalTransLbl.TabIndex = 13;
			this.VideoEndVerticalTransLbl.Text = "终止直移";
			this.VideoEndVerticalTransLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoEndVerticalTransBox
			// 
			this.VideoEndVerticalTransBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEndVerticalTransBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.VideoEndVerticalTransBox.Location = new System.Drawing.Point(79, 433);
			this.VideoEndVerticalTransBox.Margin = new System.Windows.Forms.Padding(4);
			this.VideoEndVerticalTransBox.Minimum = -100;
			this.VideoEndVerticalTransBox.Name = "VideoEndVerticalTransBox";
			this.VideoEndVerticalTransBox.NumericUpDownWidth = 65;
			this.VideoEndVerticalTransBox.Size = new System.Drawing.Size(424, 31);
			this.VideoEndVerticalTransBox.TabIndex = 22;
			this.VideoEndVerticalTransBox.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// VideoEffectsGroup
			// 
			this.VideoEffectsGroup.AutoSize = true;
			this.VideoEffectsGroup.Controls.Add(this.tableLayoutPanel8);
			this.VideoEffectsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.VideoEffectsGroup.Location = new System.Drawing.Point(5, 41);
			this.VideoEffectsGroup.Name = "VideoEffectsGroup";
			this.VideoEffectsGroup.Padding = new System.Windows.Forms.Padding(5);
			this.VideoEffectsGroup.Size = new System.Drawing.Size(588, 98);
			this.VideoEffectsGroup.TabIndex = 2;
			this.VideoEffectsGroup.TabStop = false;
			this.VideoEffectsGroup.Text = "效果";
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.AutoSize = true;
			this.tableLayoutPanel8.ColumnCount = 2;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Controls.Add(this.VideoEffectLbl, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.VideoEffectInitialValueLbl, 0, 1);
			this.tableLayoutPanel8.Controls.Add(this.VideoEffectCombo, 1, 0);
			this.tableLayoutPanel8.Controls.Add(this.VideoEffectInitialValueCombo, 1, 1);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(578, 68);
			this.tableLayoutPanel8.TabIndex = 1;
			// 
			// VideoEffectLbl
			// 
			this.VideoEffectLbl.AutoSize = true;
			this.VideoEffectLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEffectLbl.Location = new System.Drawing.Point(3, 0);
			this.VideoEffectLbl.Name = "VideoEffectLbl";
			this.VideoEffectLbl.Size = new System.Drawing.Size(69, 34);
			this.VideoEffectLbl.TabIndex = 0;
			this.VideoEffectLbl.Text = "视觉效果";
			this.VideoEffectLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoEffectInitialValueLbl
			// 
			this.VideoEffectInitialValueLbl.AutoSize = true;
			this.VideoEffectInitialValueLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideoEffectInitialValueLbl.Location = new System.Drawing.Point(3, 34);
			this.VideoEffectInitialValueLbl.Name = "VideoEffectInitialValueLbl";
			this.VideoEffectInitialValueLbl.Size = new System.Drawing.Size(69, 34);
			this.VideoEffectInitialValueLbl.TabIndex = 1;
			this.VideoEffectInitialValueLbl.Text = "初始值";
			this.VideoEffectInitialValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VideoEffectCombo
			// 
			this.VideoEffectCombo.Dock = System.Windows.Forms.DockStyle.Top;
			this.VideoEffectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoEffectCombo.FormattingEnabled = true;
			this.VideoEffectCombo.Items.AddRange(new object[] {
            "无效果",
            "水平翻转",
            "垂直翻转",
            "逆时针翻转",
            "顺时针翻转",
            "逆时针旋转",
            "顺时针旋转",
            "颠倒",
            "水平镜像",
            "垂直镜像",
            "逆时针镜像",
            "顺时针镜像",
            "颜色反转",
            "亮度反转",
            "色相反转",
            "3 步色差",
            "4 步色差",
            "5 步色差",
            "6 步色差",
            "7 步色差",
            "8 步色差",
            "彩灰",
            "乒乓效应",
            "爱的魔力转圈圈"});
			this.VideoEffectCombo.Location = new System.Drawing.Point(78, 3);
			this.VideoEffectCombo.Name = "VideoEffectCombo";
			this.VideoEffectCombo.Size = new System.Drawing.Size(497, 28);
			this.VideoEffectCombo.TabIndex = 2;
			this.VideoEffectCombo.SelectedIndexChanged += new System.EventHandler(this.VideoEffectCombo_SelectedIndexChanged);
			// 
			// VideoEffectInitialValueCombo
			// 
			this.VideoEffectInitialValueCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VideoEffectInitialValueCombo.FormattingEnabled = true;
			this.VideoEffectInitialValueCombo.Location = new System.Drawing.Point(78, 37);
			this.VideoEffectInitialValueCombo.Name = "VideoEffectInitialValueCombo";
			this.VideoEffectInitialValueCombo.Size = new System.Drawing.Size(90, 28);
			this.VideoEffectInitialValueCombo.TabIndex = 3;
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.AutoSize = true;
			this.flowLayoutPanel7.Controls.Add(this.VideoConfigCheck);
			this.flowLayoutPanel7.Controls.Add(this.VideoScratchCheck);
			this.flowLayoutPanel7.Controls.Add(this.VideoLoopCheck);
			this.flowLayoutPanel7.Controls.Add(this.VideoFreezeFirstFrameCheck);
			this.flowLayoutPanel7.Controls.Add(this.VideoFreezeLastFrameCheck);
			this.flowLayoutPanel7.Controls.Add(this.VideoLegatoCheck);
			this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel7.Location = new System.Drawing.Point(5, 5);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.flowLayoutPanel7.Size = new System.Drawing.Size(588, 36);
			this.flowLayoutPanel7.TabIndex = 1;
			// 
			// VideoConfigCheck
			// 
			this.VideoConfigCheck.AutoSize = true;
			this.VideoConfigCheck.Checked = true;
			this.VideoConfigCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.VideoConfigCheck.Location = new System.Drawing.Point(3, 6);
			this.VideoConfigCheck.Name = "VideoConfigCheck";
			this.VideoConfigCheck.Size = new System.Drawing.Size(91, 24);
			this.VideoConfigCheck.TabIndex = 0;
			this.VideoConfigCheck.Text = "生成视频";
			this.VideoConfigCheck.UseVisualStyleBackColor = true;
			// 
			// VideoScratchCheck
			// 
			this.VideoScratchCheck.AutoSize = true;
			this.VideoScratchCheck.Location = new System.Drawing.Point(100, 6);
			this.VideoScratchCheck.Name = "VideoScratchCheck";
			this.VideoScratchCheck.Size = new System.Drawing.Size(91, 24);
			this.VideoScratchCheck.TabIndex = 1;
			this.VideoScratchCheck.Text = "拉伸视频";
			this.VideoScratchCheck.UseVisualStyleBackColor = true;
			// 
			// VideoLoopCheck
			// 
			this.VideoLoopCheck.AutoSize = true;
			this.VideoLoopCheck.Checked = true;
			this.VideoLoopCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.VideoLoopCheck.Location = new System.Drawing.Point(197, 6);
			this.VideoLoopCheck.Name = "VideoLoopCheck";
			this.VideoLoopCheck.Size = new System.Drawing.Size(91, 24);
			this.VideoLoopCheck.TabIndex = 2;
			this.VideoLoopCheck.Text = "循环视频";
			this.VideoLoopCheck.UseVisualStyleBackColor = true;
			// 
			// VideoFreezeFirstFrameCheck
			// 
			this.VideoFreezeFirstFrameCheck.AutoSize = true;
			this.VideoFreezeFirstFrameCheck.Location = new System.Drawing.Point(294, 6);
			this.VideoFreezeFirstFrameCheck.Name = "VideoFreezeFirstFrameCheck";
			this.VideoFreezeFirstFrameCheck.Size = new System.Drawing.Size(91, 24);
			this.VideoFreezeFirstFrameCheck.TabIndex = 3;
			this.VideoFreezeFirstFrameCheck.Text = "定格首帧";
			this.VideoFreezeFirstFrameCheck.UseVisualStyleBackColor = true;
			// 
			// VideoFreezeLastFrameCheck
			// 
			this.VideoFreezeLastFrameCheck.AutoSize = true;
			this.VideoFreezeLastFrameCheck.Location = new System.Drawing.Point(391, 6);
			this.VideoFreezeLastFrameCheck.Name = "VideoFreezeLastFrameCheck";
			this.VideoFreezeLastFrameCheck.Size = new System.Drawing.Size(91, 24);
			this.VideoFreezeLastFrameCheck.TabIndex = 4;
			this.VideoFreezeLastFrameCheck.Text = "定格尾帧";
			this.VideoFreezeLastFrameCheck.UseVisualStyleBackColor = true;
			// 
			// VideoLegatoCheck
			// 
			this.VideoLegatoCheck.AutoSize = true;
			this.VideoLegatoCheck.Checked = true;
			this.VideoLegatoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.VideoLegatoCheck.Location = new System.Drawing.Point(488, 6);
			this.VideoLegatoCheck.Name = "VideoLegatoCheck";
			this.VideoLegatoCheck.Size = new System.Drawing.Size(91, 24);
			this.VideoLegatoCheck.TabIndex = 5;
			this.VideoLegatoCheck.Text = "填补间隙";
			this.VideoLegatoCheck.UseVisualStyleBackColor = true;
			// 
			// SheetTab
			// 
			this.SheetTab.AutoScroll = true;
			this.SheetTab.BackColor = System.Drawing.SystemColors.Menu;
			this.SheetTab.Controls.Add(this.StaffParamsGroup);
			this.SheetTab.Controls.Add(this.flowLayoutPanel8);
			this.SheetTab.Controls.Add(this.SheetConfigInfoLabel);
			this.SheetTab.Location = new System.Drawing.Point(4, 29);
			this.SheetTab.Name = "SheetTab";
			this.SheetTab.Padding = new System.Windows.Forms.Padding(5);
			this.SheetTab.Size = new System.Drawing.Size(619, 597);
			this.SheetTab.TabIndex = 3;
			this.SheetTab.Text = "五线谱";
			// 
			// StaffParamsGroup
			// 
			this.StaffParamsGroup.AutoSize = true;
			this.StaffParamsGroup.Controls.Add(this.tableLayoutPanel10);
			this.StaffParamsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.StaffParamsGroup.Location = new System.Drawing.Point(5, 91);
			this.StaffParamsGroup.Name = "StaffParamsGroup";
			this.StaffParamsGroup.Padding = new System.Windows.Forms.Padding(5);
			this.StaffParamsGroup.Size = new System.Drawing.Size(609, 162);
			this.StaffParamsGroup.TabIndex = 6;
			this.StaffParamsGroup.TabStop = false;
			this.StaffParamsGroup.Text = "参数";
			// 
			// tableLayoutPanel10
			// 
			this.tableLayoutPanel10.AutoSize = true;
			this.tableLayoutPanel10.ColumnCount = 4;
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel10.Controls.Add(this.StaffClefLbl, 0, 0);
			this.tableLayoutPanel10.Controls.Add(this.StaffClefCombo, 1, 0);
			this.tableLayoutPanel10.Controls.Add(this.StaffLineSpacingLbl, 2, 0);
			this.tableLayoutPanel10.Controls.Add(this.StaffLineSpacingBox, 3, 0);
			this.tableLayoutPanel10.Controls.Add(this.StaffSurfacePositionBox, 3, 1);
			this.tableLayoutPanel10.Controls.Add(this.StaffSurfaceWidthLbl, 0, 1);
			this.tableLayoutPanel10.Controls.Add(this.StaffSurfaceWidthBox, 1, 1);
			this.tableLayoutPanel10.Controls.Add(this.StaffSurfacePositionLbl, 2, 1);
			this.tableLayoutPanel10.Controls.Add(this.StaffLineThicknessLbl, 0, 2);
			this.tableLayoutPanel10.Controls.Add(this.StaffLineThicknessBox, 1, 2);
			this.tableLayoutPanel10.Controls.Add(this.StaffLineColorLbl, 2, 2);
			this.tableLayoutPanel10.Controls.Add(this.StaffLineColorBtn, 3, 2);
			this.tableLayoutPanel10.Controls.Add(this.StaffNotesShiftLbl, 0, 3);
			this.tableLayoutPanel10.Controls.Add(this.StaffNotesShiftBox, 1, 3);
			this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel10.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 4;
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel10.Size = new System.Drawing.Size(599, 132);
			this.tableLayoutPanel10.TabIndex = 0;
			// 
			// StaffClefLbl
			// 
			this.StaffClefLbl.AutoSize = true;
			this.StaffClefLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffClefLbl.Location = new System.Drawing.Point(3, 0);
			this.StaffClefLbl.Name = "StaffClefLbl";
			this.StaffClefLbl.Size = new System.Drawing.Size(69, 33);
			this.StaffClefLbl.TabIndex = 0;
			this.StaffClefLbl.Text = "谱号";
			this.StaffClefLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StaffClefCombo
			// 
			this.StaffClefCombo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffClefCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StaffClefCombo.Enabled = false;
			this.StaffClefCombo.FormattingEnabled = true;
			this.StaffClefCombo.Items.AddRange(new object[] {
            "高音",
            "低音"});
			this.StaffClefCombo.Location = new System.Drawing.Point(78, 3);
			this.StaffClefCombo.Name = "StaffClefCombo";
			this.StaffClefCombo.Size = new System.Drawing.Size(218, 28);
			this.StaffClefCombo.TabIndex = 6;
			// 
			// StaffLineSpacingLbl
			// 
			this.StaffLineSpacingLbl.AutoSize = true;
			this.StaffLineSpacingLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffLineSpacingLbl.Location = new System.Drawing.Point(302, 0);
			this.StaffLineSpacingLbl.Name = "StaffLineSpacingLbl";
			this.StaffLineSpacingLbl.Size = new System.Drawing.Size(69, 33);
			this.StaffLineSpacingLbl.TabIndex = 1;
			this.StaffLineSpacingLbl.Text = "谱线间距";
			this.StaffLineSpacingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StaffSurfaceWidthLbl
			// 
			this.StaffSurfaceWidthLbl.AutoSize = true;
			this.StaffSurfaceWidthLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffSurfaceWidthLbl.Location = new System.Drawing.Point(3, 33);
			this.StaffSurfaceWidthLbl.Name = "StaffSurfaceWidthLbl";
			this.StaffSurfaceWidthLbl.Size = new System.Drawing.Size(69, 33);
			this.StaffSurfaceWidthLbl.TabIndex = 5;
			this.StaffSurfaceWidthLbl.Text = "谱面宽度";
			this.StaffSurfaceWidthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StaffSurfacePositionLbl
			// 
			this.StaffSurfacePositionLbl.AutoSize = true;
			this.StaffSurfacePositionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffSurfacePositionLbl.Location = new System.Drawing.Point(302, 33);
			this.StaffSurfacePositionLbl.Name = "StaffSurfacePositionLbl";
			this.StaffSurfacePositionLbl.Size = new System.Drawing.Size(69, 33);
			this.StaffSurfacePositionLbl.TabIndex = 2;
			this.StaffSurfacePositionLbl.Text = "谱面位置";
			this.StaffSurfacePositionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StaffLineThicknessLbl
			// 
			this.StaffLineThicknessLbl.AutoSize = true;
			this.StaffLineThicknessLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffLineThicknessLbl.Location = new System.Drawing.Point(3, 66);
			this.StaffLineThicknessLbl.Name = "StaffLineThicknessLbl";
			this.StaffLineThicknessLbl.Size = new System.Drawing.Size(69, 33);
			this.StaffLineThicknessLbl.TabIndex = 4;
			this.StaffLineThicknessLbl.Text = "谱线粗细";
			this.StaffLineThicknessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StaffLineThicknessBox
			// 
			this.StaffLineThicknessBox.Constrain = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.StaffLineThicknessBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffLineThicknessBox.Enabled = false;
			this.StaffLineThicknessBox.EnableDecimalPlaces = true;
			this.StaffLineThicknessBox.Location = new System.Drawing.Point(78, 69);
			this.StaffLineThicknessBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.StaffLineThicknessBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.StaffLineThicknessBox.Name = "StaffLineThicknessBox";
			this.StaffLineThicknessBox.Size = new System.Drawing.Size(218, 27);
			this.StaffLineThicknessBox.TabIndex = 10;
			this.StaffLineThicknessBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// StaffLineColorLbl
			// 
			this.StaffLineColorLbl.AutoSize = true;
			this.StaffLineColorLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffLineColorLbl.Location = new System.Drawing.Point(302, 66);
			this.StaffLineColorLbl.Name = "StaffLineColorLbl";
			this.StaffLineColorLbl.Size = new System.Drawing.Size(69, 33);
			this.StaffLineColorLbl.TabIndex = 3;
			this.StaffLineColorLbl.Text = "谱线颜色";
			this.StaffLineColorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StaffLineColorBtn
			// 
			this.StaffLineColorBtn.BackColor = System.Drawing.Color.White;
			this.StaffLineColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffLineColorBtn.Enabled = false;
			this.StaffLineColorBtn.ForeColor = System.Drawing.Color.Black;
			this.StaffLineColorBtn.Location = new System.Drawing.Point(377, 69);
			this.StaffLineColorBtn.Name = "StaffLineColorBtn";
			this.StaffLineColorBtn.Size = new System.Drawing.Size(219, 27);
			this.StaffLineColorBtn.TabIndex = 11;
			this.StaffLineColorBtn.Text = "#FFFFFF";
			this.StaffLineColorBtn.UseVisualStyleBackColor = false;
			this.StaffLineColorBtn.Click += new System.EventHandler(this.StaffLineColorBtn_Click);
			// 
			// StaffNotesShiftLbl
			// 
			this.StaffNotesShiftLbl.AutoSize = true;
			this.StaffNotesShiftLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffNotesShiftLbl.Location = new System.Drawing.Point(3, 99);
			this.StaffNotesShiftLbl.Name = "StaffNotesShiftLbl";
			this.StaffNotesShiftLbl.Size = new System.Drawing.Size(69, 33);
			this.StaffNotesShiftLbl.TabIndex = 12;
			this.StaffNotesShiftLbl.Text = "音符偏移";
			this.StaffNotesShiftLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// StaffNotesShiftBox
			// 
			this.StaffNotesShiftBox.Constrain = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.StaffNotesShiftBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StaffNotesShiftBox.Enabled = false;
			this.StaffNotesShiftBox.EnableDecimalPlaces = true;
			this.StaffNotesShiftBox.Location = new System.Drawing.Point(78, 102);
			this.StaffNotesShiftBox.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.StaffNotesShiftBox.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
			this.StaffNotesShiftBox.Name = "StaffNotesShiftBox";
			this.StaffNotesShiftBox.Size = new System.Drawing.Size(218, 27);
			this.StaffNotesShiftBox.Suffix = "key";
			this.StaffNotesShiftBox.TabIndex = 13;
			// 
			// flowLayoutPanel8
			// 
			this.flowLayoutPanel8.AutoSize = true;
			this.flowLayoutPanel8.Controls.Add(this.StaffVisualizerConfigCheck);
			this.flowLayoutPanel8.Controls.Add(this.StaffGenerateCheck);
			this.flowLayoutPanel8.Controls.Add(this.StaffRelativeValueCheck);
			this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel8.Location = new System.Drawing.Point(5, 55);
			this.flowLayoutPanel8.Name = "flowLayoutPanel8";
			this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.flowLayoutPanel8.Size = new System.Drawing.Size(609, 36);
			this.flowLayoutPanel8.TabIndex = 5;
			// 
			// StaffVisualizerConfigCheck
			// 
			this.StaffVisualizerConfigCheck.AutoSize = true;
			this.StaffVisualizerConfigCheck.Location = new System.Drawing.Point(3, 6);
			this.StaffVisualizerConfigCheck.Name = "StaffVisualizerConfigCheck";
			this.StaffVisualizerConfigCheck.Size = new System.Drawing.Size(181, 24);
			this.StaffVisualizerConfigCheck.TabIndex = 4;
			this.StaffVisualizerConfigCheck.Text = "启用五线谱可视化效果";
			this.StaffVisualizerConfigCheck.UseVisualStyleBackColor = true;
			// 
			// StaffGenerateCheck
			// 
			this.StaffGenerateCheck.AutoSize = true;
			this.StaffGenerateCheck.Checked = true;
			this.StaffGenerateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.StaffGenerateCheck.Enabled = false;
			this.StaffGenerateCheck.Location = new System.Drawing.Point(190, 6);
			this.StaffGenerateCheck.Name = "StaffGenerateCheck";
			this.StaffGenerateCheck.Size = new System.Drawing.Size(106, 24);
			this.StaffGenerateCheck.TabIndex = 5;
			this.StaffGenerateCheck.Text = "生成五线谱";
			this.StaffGenerateCheck.UseVisualStyleBackColor = true;
			// 
			// SheetConfigInfoLabel
			// 
			this.SheetConfigInfoLabel.AutoSize = true;
			this.SheetConfigInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.SheetConfigInfoLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.SheetConfigInfoLabel.Location = new System.Drawing.Point(5, 5);
			this.SheetConfigInfoLabel.Name = "SheetConfigInfoLabel";
			this.SheetConfigInfoLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.SheetConfigInfoLabel.Size = new System.Drawing.Size(384, 50);
			this.SheetConfigInfoLabel.TabIndex = 4;
			this.SheetConfigInfoLabel.Text = "欲开启五线谱视觉效果，需要先开启“生成视频”选项。\r\n开启本功能会禁用视频视觉效果和视频拉伸选项。";
			this.SheetConfigInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// YtpTab
			// 
			this.YtpTab.AutoScroll = true;
			this.YtpTab.BackColor = System.Drawing.SystemColors.Menu;
			this.YtpTab.Controls.Add(this.YtpParamsGroup);
			this.YtpTab.Controls.Add(this.YtpEffectsGroup);
			this.YtpTab.Controls.Add(this.YtpSelectInfo);
			this.YtpTab.Controls.Add(this.YtpLbl);
			this.YtpTab.Location = new System.Drawing.Point(4, 29);
			this.YtpTab.Name = "YtpTab";
			this.YtpTab.Padding = new System.Windows.Forms.Padding(5);
			this.YtpTab.Size = new System.Drawing.Size(619, 597);
			this.YtpTab.TabIndex = 5;
			this.YtpTab.Text = "YTP";
			// 
			// YtpParamsGroup
			// 
			this.YtpParamsGroup.AutoSize = true;
			this.YtpParamsGroup.Controls.Add(this.tableLayoutPanel16);
			this.YtpParamsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.YtpParamsGroup.Location = new System.Drawing.Point(5, 222);
			this.YtpParamsGroup.Name = "YtpParamsGroup";
			this.YtpParamsGroup.Padding = new System.Windows.Forms.Padding(5);
			this.YtpParamsGroup.Size = new System.Drawing.Size(609, 96);
			this.YtpParamsGroup.TabIndex = 12;
			this.YtpParamsGroup.TabStop = false;
			this.YtpParamsGroup.Text = "参数";
			// 
			// tableLayoutPanel16
			// 
			this.tableLayoutPanel16.AutoSize = true;
			this.tableLayoutPanel16.ColumnCount = 4;
			this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel16.Controls.Add(this.YtpMinLenLbl, 0, 0);
			this.tableLayoutPanel16.Controls.Add(this.YtpClipsCountLbl, 0, 1);
			this.tableLayoutPanel16.Controls.Add(this.YtpClipsCountBox, 1, 1);
			this.tableLayoutPanel16.Controls.Add(this.YtpMinLenBox, 1, 0);
			this.tableLayoutPanel16.Controls.Add(this.YtpMaxLenLbl, 2, 0);
			this.tableLayoutPanel16.Controls.Add(this.YtpMaxLenBox, 3, 0);
			this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel16.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel16.Name = "tableLayoutPanel16";
			this.tableLayoutPanel16.RowCount = 2;
			this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel16.Size = new System.Drawing.Size(599, 66);
			this.tableLayoutPanel16.TabIndex = 0;
			// 
			// YtpMinLenLbl
			// 
			this.YtpMinLenLbl.AutoSize = true;
			this.YtpMinLenLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.YtpMinLenLbl.Location = new System.Drawing.Point(3, 0);
			this.YtpMinLenLbl.Name = "YtpMinLenLbl";
			this.YtpMinLenLbl.Size = new System.Drawing.Size(69, 33);
			this.YtpMinLenLbl.TabIndex = 5;
			this.YtpMinLenLbl.Text = "最小长度";
			this.YtpMinLenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// YtpClipsCountLbl
			// 
			this.YtpClipsCountLbl.AutoSize = true;
			this.YtpClipsCountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.YtpClipsCountLbl.Location = new System.Drawing.Point(3, 33);
			this.YtpClipsCountLbl.Name = "YtpClipsCountLbl";
			this.YtpClipsCountLbl.Size = new System.Drawing.Size(69, 33);
			this.YtpClipsCountLbl.TabIndex = 10;
			this.YtpClipsCountLbl.Text = "剪辑数目";
			this.YtpClipsCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// YtpClipsCountBox
			// 
			this.YtpClipsCountBox.Constrain = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.YtpClipsCountBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.YtpClipsCountBox.EnableDecimalPlaces = true;
			this.YtpClipsCountBox.Location = new System.Drawing.Point(78, 36);
			this.YtpClipsCountBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.YtpClipsCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.YtpClipsCountBox.Name = "YtpClipsCountBox";
			this.YtpClipsCountBox.Size = new System.Drawing.Size(218, 27);
			this.YtpClipsCountBox.TabIndex = 11;
			this.YtpClipsCountBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// YtpMaxLenLbl
			// 
			this.YtpMaxLenLbl.AutoSize = true;
			this.YtpMaxLenLbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.YtpMaxLenLbl.Location = new System.Drawing.Point(302, 0);
			this.YtpMaxLenLbl.Name = "YtpMaxLenLbl";
			this.YtpMaxLenLbl.Size = new System.Drawing.Size(69, 33);
			this.YtpMaxLenLbl.TabIndex = 2;
			this.YtpMaxLenLbl.Text = "最大长度";
			this.YtpMaxLenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// YtpEffectsGroup
			// 
			this.YtpEffectsGroup.AutoSize = true;
			this.YtpEffectsGroup.Controls.Add(this.YtpEnableAllEffectsCheck);
			this.YtpEffectsGroup.Controls.Add(this.YtpEffectsCheckList);
			this.YtpEffectsGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.YtpEffectsGroup.Location = new System.Drawing.Point(5, 81);
			this.YtpEffectsGroup.Name = "YtpEffectsGroup";
			this.YtpEffectsGroup.Padding = new System.Windows.Forms.Padding(9, 3, 6, 6);
			this.YtpEffectsGroup.Size = new System.Drawing.Size(609, 141);
			this.YtpEffectsGroup.TabIndex = 11;
			this.YtpEffectsGroup.TabStop = false;
			this.YtpEffectsGroup.Text = "效果";
			// 
			// YtpEnableAllEffectsCheck
			// 
			this.YtpEnableAllEffectsCheck.AutoSize = true;
			this.YtpEnableAllEffectsCheck.Checked = true;
			this.YtpEnableAllEffectsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.YtpEnableAllEffectsCheck.Dock = System.Windows.Forms.DockStyle.Top;
			this.YtpEnableAllEffectsCheck.Location = new System.Drawing.Point(9, 23);
			this.YtpEnableAllEffectsCheck.Name = "YtpEnableAllEffectsCheck";
			this.YtpEnableAllEffectsCheck.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.YtpEnableAllEffectsCheck.Size = new System.Drawing.Size(594, 24);
			this.YtpEnableAllEffectsCheck.TabIndex = 0;
			this.YtpEnableAllEffectsCheck.Text = "开启所有效果";
			this.YtpEnableAllEffectsCheck.CheckedChanged += new System.EventHandler(this.YtpEnableAllEffectsCheck_CheckedChanged);
			// 
			// YtpEffectsCheckList
			// 
			this.YtpEffectsCheckList.BackColor = System.Drawing.SystemColors.Menu;
			this.YtpEffectsCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.YtpEffectsCheckList.CheckOnClick = true;
			this.YtpEffectsCheckList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.YtpEffectsCheckList.FormattingEnabled = true;
			this.YtpEffectsCheckList.HorizontalScrollbar = true;
			this.YtpEffectsCheckList.Items.AddRange(new object[] {
            "合唱",
            "更改音调",
            "颤音（概率性附加波浪效果）",
            "倒放",
            "延迟",
            "更改速度",
            "更改色相",
            "旋转色相",
            "黑白",
            "反转颜色（概率性附加降调效果）",
            "高频重复",
            "随机调音（附加左右翻转效果）",
            "放大（附加增加音量）",
            "球面化",
            "镜像",
            "高对比（附加增加音量）",
            "过饱和（概率性附加升调效果）",
            "重说三（附加放大聚焦效果）"});
			this.YtpEffectsCheckList.Location = new System.Drawing.Point(9, 47);
			this.YtpEffectsCheckList.Name = "YtpEffectsCheckList";
			this.YtpEffectsCheckList.Size = new System.Drawing.Size(594, 88);
			this.YtpEffectsCheckList.TabIndex = 1;
			this.YtpEffectsCheckList.Click += new System.EventHandler(this.YtpEffectsCheckList_SelectedIndexChanged);
			this.YtpEffectsCheckList.SelectedIndexChanged += new System.EventHandler(this.YtpEffectsCheckList_SelectedIndexChanged);
			this.YtpEffectsCheckList.DoubleClick += new System.EventHandler(this.YtpEffectsCheckList_SelectedIndexChanged);
			// 
			// YtpSelectInfo
			// 
			this.YtpSelectInfo.AutoSize = true;
			this.YtpSelectInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.YtpSelectInfo.Location = new System.Drawing.Point(5, 53);
			this.YtpSelectInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.YtpSelectInfo.Name = "YtpSelectInfo";
			this.YtpSelectInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.YtpSelectInfo.Size = new System.Drawing.Size(160, 28);
			this.YtpSelectInfo.TabIndex = 13;
			this.YtpSelectInfo.Text = "已选中 0 项媒体素材。";
			this.YtpSelectInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// YtpLbl
			// 
			this.YtpLbl.AutoSize = true;
			this.YtpLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.YtpLbl.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.YtpLbl.Location = new System.Drawing.Point(5, 5);
			this.YtpLbl.Name = "YtpLbl";
			this.YtpLbl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
			this.YtpLbl.Size = new System.Drawing.Size(514, 48);
			this.YtpLbl.TabIndex = 10;
			this.YtpLbl.Text = "在当前选项卡下单击“完成”按钮，将会生成 YTP 而不是音 MAD / YTPMV。\r\n除“生成音频”“生成视频”外其它的参数设置并不会在 YTP 中使用。";
			// 
			// HelperTab
			// 
			this.HelperTab.AutoScroll = true;
			this.HelperTab.BackColor = System.Drawing.SystemColors.Menu;
			this.HelperTab.Controls.Add(this.tableLayoutPanel11);
			this.HelperTab.Controls.Add(this.tableLayoutPanel19);
			this.HelperTab.Location = new System.Drawing.Point(4, 29);
			this.HelperTab.Name = "HelperTab";
			this.HelperTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.HelperTab.Size = new System.Drawing.Size(619, 597);
			this.HelperTab.TabIndex = 4;
			this.HelperTab.Text = "工具";
			// 
			// tableLayoutPanel11
			// 
			this.tableLayoutPanel11.AutoSize = true;
			this.tableLayoutPanel11.ColumnCount = 1;
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel11.Controls.Add(this.QuickSelectIntervalBtn, 0, 1);
			this.tableLayoutPanel11.Controls.Add(this.ReplaceClipsBtn, 0, 2);
			this.tableLayoutPanel11.Controls.Add(this.ChangeTuneMethodBtn, 0, 3);
			this.tableLayoutPanel11.Controls.Add(this.AutoLayoutTracksGroup, 0, 4);
			this.tableLayoutPanel11.Controls.Add(this.CloseAfterOpenHelperCheck, 0, 0);
			this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 29);
			this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel11.Name = "tableLayoutPanel11";
			this.tableLayoutPanel11.RowCount = 5;
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel11.Size = new System.Drawing.Size(613, 452);
			this.tableLayoutPanel11.TabIndex = 8;
			// 
			// QuickSelectIntervalBtn
			// 
			this.QuickSelectIntervalBtn.CommandLink = true;
			this.QuickSelectIntervalBtn.CommandLinkNote = "本功能旨在辅助用户每隔一个或几个选中一个素材，然后可以执行“粘贴视频事件”等操作。\r\n已选中 0 个轨道剪辑。";
			this.QuickSelectIntervalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.QuickSelectIntervalBtn.Location = new System.Drawing.Point(3, 41);
			this.QuickSelectIntervalBtn.Name = "QuickSelectIntervalBtn";
			this.QuickSelectIntervalBtn.Size = new System.Drawing.Size(607, 84);
			this.QuickSelectIntervalBtn.TabIndex = 1;
			this.QuickSelectIntervalBtn.Text = "快速间隔选择";
			this.QuickSelectIntervalBtn.UseVisualStyleBackColor = true;
			this.QuickSelectIntervalBtn.Click += new System.EventHandler(this.ReadyToShowHelperDialog);
			// 
			// ReplaceClipsBtn
			// 
			this.ReplaceClipsBtn.CommandLink = true;
			this.ReplaceClipsBtn.CommandLinkNote = "将多个轨道剪辑替换为指定的新轨道剪辑。\r\n已选中 0 个轨道剪辑。";
			this.ReplaceClipsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ReplaceClipsBtn.Location = new System.Drawing.Point(3, 131);
			this.ReplaceClipsBtn.Name = "ReplaceClipsBtn";
			this.ReplaceClipsBtn.Size = new System.Drawing.Size(607, 84);
			this.ReplaceClipsBtn.TabIndex = 2;
			this.ReplaceClipsBtn.Text = "替换轨道素材";
			this.ReplaceClipsBtn.UseVisualStyleBackColor = true;
			this.ReplaceClipsBtn.Click += new System.EventHandler(this.ReadyToShowHelperDialog);
			// 
			// ChangeTuneMethodBtn
			// 
			this.ChangeTuneMethodBtn.CommandLink = true;
			this.ChangeTuneMethodBtn.CommandLinkNote = "将多个音频轨道剪辑统一更改为指定的调音算法。\r\n已选中 0 个音频轨道剪辑。";
			this.ChangeTuneMethodBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChangeTuneMethodBtn.Location = new System.Drawing.Point(3, 221);
			this.ChangeTuneMethodBtn.Name = "ChangeTuneMethodBtn";
			this.ChangeTuneMethodBtn.Size = new System.Drawing.Size(607, 84);
			this.ChangeTuneMethodBtn.TabIndex = 3;
			this.ChangeTuneMethodBtn.Text = "更改调音算法";
			this.ChangeTuneMethodBtn.UseVisualStyleBackColor = true;
			this.ChangeTuneMethodBtn.Click += new System.EventHandler(this.ReadyToShowHelperDialog);
			// 
			// AutoLayoutTracksGroup
			// 
			this.AutoLayoutTracksGroup.AutoSize = true;
			this.AutoLayoutTracksGroup.Controls.Add(this.tableLayoutPanel14);
			this.AutoLayoutTracksGroup.Dock = System.Windows.Forms.DockStyle.Top;
			this.AutoLayoutTracksGroup.Location = new System.Drawing.Point(3, 311);
			this.AutoLayoutTracksGroup.Name = "AutoLayoutTracksGroup";
			this.AutoLayoutTracksGroup.Padding = new System.Windows.Forms.Padding(5);
			this.AutoLayoutTracksGroup.Size = new System.Drawing.Size(607, 138);
			this.AutoLayoutTracksGroup.TabIndex = 6;
			this.AutoLayoutTracksGroup.TabStop = false;
			this.AutoLayoutTracksGroup.Text = "自动布局轨道";
			// 
			// tableLayoutPanel14
			// 
			this.tableLayoutPanel14.AutoSize = true;
			this.tableLayoutPanel14.ColumnCount = 1;
			this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel14.Controls.Add(this.AutoLayoutTracksLbl, 0, 0);
			this.tableLayoutPanel14.Controls.Add(this.AutoLayoutTracksSelectInfo, 0, 1);
			this.tableLayoutPanel14.Controls.Add(this.AutoLayoutTracksButtons, 0, 2);
			this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 0, 3);
			this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel14.Location = new System.Drawing.Point(5, 25);
			this.tableLayoutPanel14.Name = "tableLayoutPanel14";
			this.tableLayoutPanel14.RowCount = 4;
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel14.Size = new System.Drawing.Size(597, 108);
			this.tableLayoutPanel14.TabIndex = 2;
			// 
			// AutoLayoutTracksLbl
			// 
			this.AutoLayoutTracksLbl.AutoSize = true;
			this.AutoLayoutTracksLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.AutoLayoutTracksLbl.Location = new System.Drawing.Point(3, 0);
			this.AutoLayoutTracksLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.AutoLayoutTracksLbl.Name = "AutoLayoutTracksLbl";
			this.AutoLayoutTracksLbl.Size = new System.Drawing.Size(591, 20);
			this.AutoLayoutTracksLbl.TabIndex = 1;
			this.AutoLayoutTracksLbl.Text = "类 YTPMV 风格自动布局选中的轨道。";
			this.AutoLayoutTracksLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AutoLayoutTracksSelectInfo
			// 
			this.AutoLayoutTracksSelectInfo.AutoSize = true;
			this.tableLayoutPanel14.SetColumnSpan(this.AutoLayoutTracksSelectInfo, 2);
			this.AutoLayoutTracksSelectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AutoLayoutTracksSelectInfo.Location = new System.Drawing.Point(3, 23);
			this.AutoLayoutTracksSelectInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.AutoLayoutTracksSelectInfo.Name = "AutoLayoutTracksSelectInfo";
			this.AutoLayoutTracksSelectInfo.Size = new System.Drawing.Size(591, 20);
			this.AutoLayoutTracksSelectInfo.TabIndex = 7;
			this.AutoLayoutTracksSelectInfo.Text = "已选中 0 个视频轨道。";
			this.AutoLayoutTracksSelectInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// AutoLayoutTracksButtons
			// 
			this.AutoLayoutTracksButtons.AutoSize = true;
			this.AutoLayoutTracksButtons.ColumnCount = 4;
			this.AutoLayoutTracksButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.AutoLayoutTracksButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.AutoLayoutTracksButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.AutoLayoutTracksButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.AutoLayoutTracksButtons.Controls.Add(this.GradientTracksBtn, 0, 0);
			this.AutoLayoutTracksButtons.Controls.Add(this.AutoLayoutTracksBox3dBtn, 0, 0);
			this.AutoLayoutTracksButtons.Controls.Add(this.AutoLayoutTracksGridBtn, 0, 0);
			this.AutoLayoutTracksButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AutoLayoutTracksButtons.Location = new System.Drawing.Point(0, 46);
			this.AutoLayoutTracksButtons.Margin = new System.Windows.Forms.Padding(0);
			this.AutoLayoutTracksButtons.Name = "AutoLayoutTracksButtons";
			this.AutoLayoutTracksButtons.RowCount = 1;
			this.AutoLayoutTracksButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.AutoLayoutTracksButtons.Size = new System.Drawing.Size(597, 31);
			this.AutoLayoutTracksButtons.TabIndex = 8;
			// 
			// GradientTracksBtn
			// 
			this.GradientTracksBtn.AutoSize = true;
			this.GradientTracksBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.GradientTracksBtn.Location = new System.Drawing.Point(226, 3);
			this.GradientTracksBtn.MaximumSize = new System.Drawing.Size(0, 25);
			this.GradientTracksBtn.MinimumSize = new System.Drawing.Size(100, 0);
			this.GradientTracksBtn.Name = "GradientTracksBtn";
			this.GradientTracksBtn.Size = new System.Drawing.Size(100, 25);
			this.GradientTracksBtn.TabIndex = 5;
			this.GradientTracksBtn.Text = "渐变轨道...";
			this.GradientTracksBtn.UseVisualStyleBackColor = true;
			this.GradientTracksBtn.Click += new System.EventHandler(this.ReadyToShowHelperDialog);
			// 
			// AutoLayoutTracksBox3dBtn
			// 
			this.AutoLayoutTracksBox3dBtn.AutoSize = true;
			this.AutoLayoutTracksBox3dBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.AutoLayoutTracksBox3dBtn.Location = new System.Drawing.Point(109, 3);
			this.AutoLayoutTracksBox3dBtn.MaximumSize = new System.Drawing.Size(0, 25);
			this.AutoLayoutTracksBox3dBtn.MinimumSize = new System.Drawing.Size(100, 0);
			this.AutoLayoutTracksBox3dBtn.Name = "AutoLayoutTracksBox3dBtn";
			this.AutoLayoutTracksBox3dBtn.Size = new System.Drawing.Size(111, 25);
			this.AutoLayoutTracksBox3dBtn.TabIndex = 4;
			this.AutoLayoutTracksBox3dBtn.Text = "3D 方盒布局...";
			this.AutoLayoutTracksBox3dBtn.UseVisualStyleBackColor = true;
			this.AutoLayoutTracksBox3dBtn.Click += new System.EventHandler(this.ReadyToShowHelperDialog);
			// 
			// AutoLayoutTracksGridBtn
			// 
			this.AutoLayoutTracksGridBtn.AutoSize = true;
			this.AutoLayoutTracksGridBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.AutoLayoutTracksGridBtn.Location = new System.Drawing.Point(3, 3);
			this.AutoLayoutTracksGridBtn.MaximumSize = new System.Drawing.Size(0, 25);
			this.AutoLayoutTracksGridBtn.MinimumSize = new System.Drawing.Size(100, 0);
			this.AutoLayoutTracksGridBtn.Name = "AutoLayoutTracksGridBtn";
			this.AutoLayoutTracksGridBtn.Size = new System.Drawing.Size(100, 25);
			this.AutoLayoutTracksGridBtn.TabIndex = 3;
			this.AutoLayoutTracksGridBtn.Text = "网格布局...";
			this.AutoLayoutTracksGridBtn.UseVisualStyleBackColor = true;
			this.AutoLayoutTracksGridBtn.Click += new System.EventHandler(this.ReadyToShowHelperDialog);
			// 
			// tableLayoutPanel15
			// 
			this.tableLayoutPanel15.AutoSize = true;
			this.tableLayoutPanel15.ColumnCount = 4;
			this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel15.Controls.Add(this.TrackLegatoBtn, 2, 0);
			this.tableLayoutPanel15.Controls.Add(this.ClearTrackMotionBtn, 0, 0);
			this.tableLayoutPanel15.Controls.Add(this.ClearTrackEffectBtn, 1, 0);
			this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 77);
			this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel15.Name = "tableLayoutPanel15";
			this.tableLayoutPanel15.RowCount = 1;
			this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel15.Size = new System.Drawing.Size(597, 31);
			this.tableLayoutPanel15.TabIndex = 9;
			// 
			// TrackLegatoBtn
			// 
			this.TrackLegatoBtn.AutoSize = true;
			this.TrackLegatoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TrackLegatoBtn.ForeColor = System.Drawing.Color.Red;
			this.TrackLegatoBtn.Location = new System.Drawing.Point(233, 3);
			this.TrackLegatoBtn.MaximumSize = new System.Drawing.Size(0, 25);
			this.TrackLegatoBtn.MinimumSize = new System.Drawing.Size(100, 0);
			this.TrackLegatoBtn.Name = "TrackLegatoBtn";
			this.TrackLegatoBtn.Size = new System.Drawing.Size(122, 25);
			this.TrackLegatoBtn.TabIndex = 2;
			this.TrackLegatoBtn.Text = "填补轨道间隙▾";
			this.TrackLegatoBtn.UseVisualStyleBackColor = true;
			this.TrackLegatoBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackLegatoBtn_MouseDown);
			// 
			// ClearTrackMotionBtn
			// 
			this.ClearTrackMotionBtn.AutoSize = true;
			this.ClearTrackMotionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ClearTrackMotionBtn.ForeColor = System.Drawing.Color.Red;
			this.ClearTrackMotionBtn.Location = new System.Drawing.Point(3, 3);
			this.ClearTrackMotionBtn.MaximumSize = new System.Drawing.Size(0, 25);
			this.ClearTrackMotionBtn.MinimumSize = new System.Drawing.Size(100, 0);
			this.ClearTrackMotionBtn.Name = "ClearTrackMotionBtn";
			this.ClearTrackMotionBtn.Size = new System.Drawing.Size(109, 25);
			this.ClearTrackMotionBtn.TabIndex = 0;
			this.ClearTrackMotionBtn.Text = "清除轨道运动";
			this.ClearTrackMotionBtn.UseVisualStyleBackColor = true;
			this.ClearTrackMotionBtn.Click += new System.EventHandler(this.ClearTrackMotionBtn_Click);
			// 
			// ClearTrackEffectBtn
			// 
			this.ClearTrackEffectBtn.AutoSize = true;
			this.ClearTrackEffectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ClearTrackEffectBtn.ForeColor = System.Drawing.Color.Red;
			this.ClearTrackEffectBtn.Location = new System.Drawing.Point(118, 3);
			this.ClearTrackEffectBtn.MaximumSize = new System.Drawing.Size(0, 25);
			this.ClearTrackEffectBtn.MinimumSize = new System.Drawing.Size(100, 0);
			this.ClearTrackEffectBtn.Name = "ClearTrackEffectBtn";
			this.ClearTrackEffectBtn.Size = new System.Drawing.Size(109, 25);
			this.ClearTrackEffectBtn.TabIndex = 1;
			this.ClearTrackEffectBtn.Text = "清除轨道效果";
			this.ClearTrackEffectBtn.UseVisualStyleBackColor = true;
			this.ClearTrackEffectBtn.Click += new System.EventHandler(this.ClearTrackEffectBtn_Click);
			// 
			// CloseAfterOpenHelperCheck
			// 
			this.CloseAfterOpenHelperCheck.AutoSize = true;
			this.CloseAfterOpenHelperCheck.Checked = true;
			this.CloseAfterOpenHelperCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CloseAfterOpenHelperCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CloseAfterOpenHelperCheck.Location = new System.Drawing.Point(7, 7);
			this.CloseAfterOpenHelperCheck.Margin = new System.Windows.Forms.Padding(7);
			this.CloseAfterOpenHelperCheck.Name = "CloseAfterOpenHelperCheck";
			this.CloseAfterOpenHelperCheck.Size = new System.Drawing.Size(599, 24);
			this.CloseAfterOpenHelperCheck.TabIndex = 0;
			this.CloseAfterOpenHelperCheck.Text = "操作完成之后关闭本对话框";
			this.CloseAfterOpenHelperCheck.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel19
			// 
			this.tableLayoutPanel19.AutoSize = true;
			this.tableLayoutPanel19.ColumnCount = 1;
			this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel19.Controls.Add(this.HelperLbl, 0, 0);
			this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 4);
			this.tableLayoutPanel19.Name = "tableLayoutPanel19";
			this.tableLayoutPanel19.RowCount = 1;
			this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel19.Size = new System.Drawing.Size(613, 25);
			this.tableLayoutPanel19.TabIndex = 7;
			// 
			// HelperLbl
			// 
			this.HelperLbl.AutoSize = true;
			this.HelperLbl.Dock = System.Windows.Forms.DockStyle.Top;
			this.HelperLbl.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.HelperLbl.Location = new System.Drawing.Point(3, 0);
			this.HelperLbl.Name = "HelperLbl";
			this.HelperLbl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.HelperLbl.Size = new System.Drawing.Size(607, 25);
			this.HelperLbl.TabIndex = 2;
			this.HelperLbl.Text = "以下功能只是一些独立的辅助功能，与其它生成音视频的参数无关。";
			// 
			// TrackLegatoMenu
			// 
			this.TrackLegatoMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.TrackLegatoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stackingTracksToolStripMenuItem,
            this.limitStretchLegatoTracksToolStripMenuItem,
            this.stretchLegatoTracksToolStripMenuItem,
            this.lengthenLegatoToolStripMenuItem});
			this.TrackLegatoMenu.Name = "TrackLegatoMenu";
			this.TrackLegatoMenu.Size = new System.Drawing.Size(334, 100);
			// 
			// stackingTracksToolStripMenuItem
			// 
			this.stackingTracksToolStripMenuItem.Name = "stackingTracksToolStripMenuItem";
			this.stackingTracksToolStripMenuItem.Size = new System.Drawing.Size(333, 24);
			this.stackingTracksToolStripMenuItem.Text = "堆积素材";
			this.stackingTracksToolStripMenuItem.Click += new System.EventHandler(this.TrackLegatoMenuItems_Click);
			// 
			// limitStretchLegatoTracksToolStripMenuItem
			// 
			this.limitStretchLegatoTracksToolStripMenuItem.Name = "limitStretchLegatoTracksToolStripMenuItem";
			this.limitStretchLegatoTracksToolStripMenuItem.Size = new System.Drawing.Size(333, 24);
			this.limitStretchLegatoTracksToolStripMenuItem.Text = "拉伸素材（限制在拉伸极限范围之内）";
			this.limitStretchLegatoTracksToolStripMenuItem.Click += new System.EventHandler(this.TrackLegatoMenuItems_Click);
			// 
			// stretchLegatoTracksToolStripMenuItem
			// 
			this.stretchLegatoTracksToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
			this.stretchLegatoTracksToolStripMenuItem.Name = "stretchLegatoTracksToolStripMenuItem";
			this.stretchLegatoTracksToolStripMenuItem.Size = new System.Drawing.Size(333, 24);
			this.stretchLegatoTracksToolStripMenuItem.Text = "拉伸素材";
			this.stretchLegatoTracksToolStripMenuItem.Click += new System.EventHandler(this.TrackLegatoMenuItems_Click);
			// 
			// lengthenLegatoToolStripMenuItem
			// 
			this.lengthenLegatoToolStripMenuItem.Name = "lengthenLegatoToolStripMenuItem";
			this.lengthenLegatoToolStripMenuItem.Size = new System.Drawing.Size(333, 24);
			this.lengthenLegatoToolStripMenuItem.Text = "改变素材持续时间";
			this.lengthenLegatoToolStripMenuItem.Click += new System.EventHandler(this.TrackLegatoMenuItems_Click);
			// 
			// MidiCustomBpmCheck
			// 
			this.MidiCustomBpmCheck.AutoSize = true;
			this.MidiCustomBpmCheck.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MidiCustomBpmCheck.Enabled = false;
			this.MidiCustomBpmCheck.Location = new System.Drawing.Point(337, 3);
			this.MidiCustomBpmCheck.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.MidiCustomBpmCheck.Name = "MidiCustomBpmCheck";
			this.MidiCustomBpmCheck.Size = new System.Drawing.Size(75, 27);
			this.MidiCustomBpmCheck.TabIndex = 7;
			this.MidiCustomBpmCheck.Text = "自定义";
			this.MidiCustomBpmCheck.UseVisualStyleBackColor = true;
			// 
			// MidiCustomBpmBox
			// 
			this.MidiCustomBpmBox.Constrain = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.MidiCustomBpmBox.DecimalPlaces = 3;
			this.MidiCustomBpmBox.Enabled = false;
			this.MidiCustomBpmBox.Location = new System.Drawing.Point(412, 3);
			this.MidiCustomBpmBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.MidiCustomBpmBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.MidiCustomBpmBox.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.MidiCustomBpmBox.Name = "MidiCustomBpmBox";
			this.MidiCustomBpmBox.Size = new System.Drawing.Size(95, 27);
			this.MidiCustomBpmBox.Suffix = "BPM";
			this.MidiCustomBpmBox.TabIndex = 8;
			this.MidiCustomBpmBox.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			// 
			// ConfigForm
			// 
			this.AcceptButton = this.OkBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBtn;
			this.ClientSize = new System.Drawing.Size(643, 706);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menu);
			this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
			this.Location = new System.Drawing.Point(40, 40);
			this.MainMenuStrip = this.menu;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(580, 690);
			this.Name = "ConfigForm";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "音 MAD 助手 Vegas 版 - 配置";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
			this.Resize += new System.EventHandler(this.ConfigForm_Resize);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PreviewBeepDurationBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffLineSpacingBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffSurfacePositionBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffSurfaceWidthBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YtpMinLenBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.YtpMaxLenBox)).EndInit();
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.Tabs.ResumeLayout(false);
			this.SourceTab.ResumeLayout(false);
			this.SourceTab.PerformLayout();
			this.MidiConfigGroup.ResumeLayout(false);
			this.MidiConfigGroup.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.tableLayoutPanel12.ResumeLayout(false);
			this.tableLayoutPanel12.PerformLayout();
			this.SourceConfigGroup.ResumeLayout(false);
			this.SourceConfigGroup.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel9.ResumeLayout(false);
			this.flowLayoutPanel9.PerformLayout();
			this.AudioTab.ResumeLayout(false);
			this.AudioTab.PerformLayout();
			this.AudioParamsGroup.ResumeLayout(false);
			this.AudioParamsGroup.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.AudioTuneGroup.ResumeLayout(false);
			this.AudioTuneGroup.PerformLayout();
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.flowLayoutPanel10.ResumeLayout(false);
			this.flowLayoutPanel10.PerformLayout();
			this.flowLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel17.ResumeLayout(false);
			this.AudioPreviewAttrLayoutPanel.ResumeLayout(false);
			this.AudioPreviewAttrLayoutPanel.PerformLayout();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel5.PerformLayout();
			this.VideoTab.ResumeLayout(false);
			this.VideoTab.PerformLayout();
			this.VideoParamsGroup.ResumeLayout(false);
			this.VideoParamsGroup.PerformLayout();
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel9.PerformLayout();
			this.VideoEffectsGroup.ResumeLayout(false);
			this.VideoEffectsGroup.PerformLayout();
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.flowLayoutPanel7.ResumeLayout(false);
			this.flowLayoutPanel7.PerformLayout();
			this.SheetTab.ResumeLayout(false);
			this.SheetTab.PerformLayout();
			this.StaffParamsGroup.ResumeLayout(false);
			this.StaffParamsGroup.PerformLayout();
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.StaffLineThicknessBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StaffNotesShiftBox)).EndInit();
			this.flowLayoutPanel8.ResumeLayout(false);
			this.flowLayoutPanel8.PerformLayout();
			this.YtpTab.ResumeLayout(false);
			this.YtpTab.PerformLayout();
			this.YtpParamsGroup.ResumeLayout(false);
			this.YtpParamsGroup.PerformLayout();
			this.tableLayoutPanel16.ResumeLayout(false);
			this.tableLayoutPanel16.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.YtpClipsCountBox)).EndInit();
			this.YtpEffectsGroup.ResumeLayout(false);
			this.YtpEffectsGroup.PerformLayout();
			this.HelperTab.ResumeLayout(false);
			this.HelperTab.PerformLayout();
			this.tableLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel11.PerformLayout();
			this.AutoLayoutTracksGroup.ResumeLayout(false);
			this.AutoLayoutTracksGroup.PerformLayout();
			this.tableLayoutPanel14.ResumeLayout(false);
			this.tableLayoutPanel14.PerformLayout();
			this.AutoLayoutTracksButtons.ResumeLayout(false);
			this.AutoLayoutTracksButtons.PerformLayout();
			this.tableLayoutPanel15.ResumeLayout(false);
			this.tableLayoutPanel15.PerformLayout();
			this.tableLayoutPanel19.ResumeLayout(false);
			this.tableLayoutPanel19.PerformLayout();
			this.TrackLegatoMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.MidiCustomBpmBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.Button OkBtn;
		public System.Windows.Forms.Button CancelBtn;
		public System.Windows.Forms.Button AboutBtn;
		public System.Windows.Forms.LinkLabel UserHelpLink;
		public System.Windows.Forms.ColorDialog StaffLineColorDialog;
		public System.Windows.Forms.ToolTip Balloon;
		public System.Windows.Forms.MenuStrip menu;
		public System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		public System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem resetConfigToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		public System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		public System.Windows.Forms.ToolStripMenuItem userHelpToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem troubleShootingToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
		public System.Windows.Forms.TabControl Tabs;
		public System.Windows.Forms.TabPage SourceTab;
		public System.Windows.Forms.Label WarningInfoLabel;
		public System.Windows.Forms.GroupBox MidiConfigGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		public System.Windows.Forms.Label MidiStartSecondLbl;
		public TimecodeBox MidiStartSecondBox;
		public System.Windows.Forms.Label MidiEndSecondLbl;
		public TimecodeBox MidiEndSecondBox;
		public System.Windows.Forms.Label MidiBpmLbl;
		public System.Windows.Forms.Label MidiChannelLbl;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		public System.Windows.Forms.Button ChooseMidiBtn;
		public System.Windows.Forms.TextBox ChooseMidiText;
		public System.Windows.Forms.Label ChooseMidiLbl;
		public System.Windows.Forms.ComboBox MidiChannelCombo;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		public System.Windows.Forms.RadioButton MidiMidiBpmCheck;
		public System.Windows.Forms.RadioButton MidiProjectBpmCheck;
		public System.Windows.Forms.GroupBox SourceConfigGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
		public System.Windows.Forms.RadioButton GenerateAtBeginRadio;
		public System.Windows.Forms.RadioButton GenerateAtCursorRadio;
		public System.Windows.Forms.Label GenerateAtLbl;
		public System.Windows.Forms.Label ChooseSourceLbl;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		public System.Windows.Forms.ComboBox ChooseSourceCombo;
		public System.Windows.Forms.Button ChooseSourceBtn;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		public System.Windows.Forms.Label SourceStartTimeLbl;
		public TimecodeBox SourceStartTimeText;
		public System.Windows.Forms.Label SourceEndTimeLbl;
		public TimecodeBox SourceEndTimeText;
		public System.Windows.Forms.TabPage AudioTab;
		public System.Windows.Forms.GroupBox AudioParamsGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		public System.Windows.Forms.ComboBox AudioFadeOutCurveCombo;
		public System.Windows.Forms.Label AudioFadeInLbl;
		public System.Windows.Forms.Label AudioFadeOutLbl;
		public IntegerTrackWithBox AudioFadeInBox;
		public IntegerTrackWithBox AudioFadeOutBox;
		public System.Windows.Forms.ComboBox AudioFadeInCurveCombo;
		public System.Windows.Forms.GroupBox AudioTuneGroup;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		public System.Windows.Forms.CheckBox AudioConfigCheck;
		public System.Windows.Forms.CheckBox AudioScratchCheck;
		public System.Windows.Forms.CheckBox AudioLoopCheck;
		public System.Windows.Forms.CheckBox AudioNormalizeCheck;
		public System.Windows.Forms.TabPage VideoTab;
		public System.Windows.Forms.GroupBox VideoParamsGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		public IntegerTrackWithBox VideoEndVerticalTransBox;
		public IntegerTrackWithBox VideoStartVerticalTransBox;
		public IntegerTrackWithBox VideoEndHorizontalTransBox;
		public IntegerTrackWithBox VideoStartHorizontalTransBox;
		public IntegerTrackWithBox VideoEndRotationBox;
		public IntegerTrackWithBox VideoStartRotationBox;
		public IntegerTrackWithBox VideoEndSizeBox;
		public System.Windows.Forms.ComboBox VideoStartSizeCurveCombo;
		public IntegerTrackWithBox VideoStartSizeBox;
		public System.Windows.Forms.Label VideoEndVerticalTransLbl;
		public System.Windows.Forms.Label VideoStartHorizontalTransLbl;
		public System.Windows.Forms.Label VideoStartVerticalTransLbl;
		public System.Windows.Forms.Label VideoEndHorizontalTransLbl;
		public System.Windows.Forms.Label VideoEndRotationLbl;
		public System.Windows.Forms.Label VideoStartRotationLbl;
		public System.Windows.Forms.Label VideoEndSizeLbl;
		public System.Windows.Forms.Label VideoStartSizeLbl;
		public System.Windows.Forms.ComboBox VideoFadeOutCurveCombo;
		public System.Windows.Forms.Label VideoFadeInLbl;
		public System.Windows.Forms.Label VideoFadeOutLbl;
		public IntegerTrackWithBox VideoFadeInBox;
		public IntegerTrackWithBox VideoFadeOutBox;
		public System.Windows.Forms.ComboBox VideoFadeInCurveCombo;
		public System.Windows.Forms.GroupBox VideoEffectsGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		public System.Windows.Forms.ComboBox VideoEffectInitialValueCombo;
		public System.Windows.Forms.Label VideoEffectLbl;
		public System.Windows.Forms.Label VideoEffectInitialValueLbl;
		public System.Windows.Forms.ComboBox VideoEffectCombo;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
		public System.Windows.Forms.CheckBox VideoConfigCheck;
		public System.Windows.Forms.CheckBox VideoScratchCheck;
		public System.Windows.Forms.CheckBox VideoLoopCheck;
		public System.Windows.Forms.CheckBox VideoFreezeFirstFrameCheck;
		public System.Windows.Forms.CheckBox VideoFreezeLastFrameCheck;
		public System.Windows.Forms.CheckBox VideoLegatoCheck;
		public System.Windows.Forms.TabPage SheetTab;
		public System.Windows.Forms.TabPage HelperTab;
		public ToolStripRadioButtonMenuItem chineseToolStripMenuItem;
		public ToolStripRadioButtonMenuItem englishToolStripMenuItem;
		public ToolStripRadioButtonMenuItem japaneseToolStripMenuItem;
		public ToolStripRadioButtonMenuItem russianToolStripMenuItem;
		public System.Windows.Forms.Panel panel1;
		public ToolStripRadioButtonMenuItem tchineseToolStripMenuItem;
		public System.Windows.Forms.CheckBox AudioFreezeLastFrameCheck;
		public System.Windows.Forms.CheckBox AudioLegatoCheck;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		public System.Windows.Forms.Label AudioTuneMethodLbl;
		public System.Windows.Forms.Label AudioBasePitchLbl;
		public System.Windows.Forms.ComboBox AudioTuneMethodCombo;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		public System.Windows.Forms.ComboBox AudioMainKeyCombo;
		public System.Windows.Forms.ComboBox AudioMainOctaveCombo;
		public System.Windows.Forms.ComboBox VideoGlowCurveCombo;
		public IntegerTrackWithBox VideoGlowBox;
		public System.Windows.Forms.Label VideoGlowLbl;
		public IntegerTrackWithBox VideoGlowBrightBox;
		public System.Windows.Forms.Label VideoGlowBrightLbl;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
		public System.Windows.Forms.Button PreviewBasePitchBtn;
		public System.Windows.Forms.Button PreviewAudioBtn;
		public System.Windows.Forms.TabPage YtpTab;
		public System.Windows.Forms.ToolStripMenuItem exitDiscardingChangesToolStripMenuItem;
		public System.Windows.Forms.ComboBox AudioStretchAttrCombo;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
		public System.Windows.Forms.CheckBox AudioLockStretchPitchCheck;
		public System.Windows.Forms.CheckBox AudioReserveFormantCheck;
		public System.Windows.Forms.Label AudioStretchAttrLbl;
		public System.Windows.Forms.Label AudioPreviewLbl;
		public System.Windows.Forms.Label AudioLockAttrLbl;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
		public System.Windows.Forms.GroupBox AutoLayoutTracksGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
		public System.Windows.Forms.Label AutoLayoutTracksSelectInfo;
		public System.Windows.Forms.Label AutoLayoutTracksLbl;
		public System.Windows.Forms.TableLayoutPanel AutoLayoutTracksButtons;
		public System.Windows.Forms.Button GradientTracksBtn;
		public System.Windows.Forms.Button AutoLayoutTracksBox3dBtn;
		public System.Windows.Forms.Button AutoLayoutTracksGridBtn;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
		public System.Windows.Forms.Button ClearTrackMotionBtn;
		public System.Windows.Forms.Button ClearTrackEffectBtn;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
		public System.Windows.Forms.Label HelperLbl;
		public System.Windows.Forms.GroupBox YtpParamsGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
		public NumericUpDownWithUnit YtpClipsCountBox;
		public System.Windows.Forms.Label YtpClipsCountLbl;
		public NumericUpDownWithUnit YtpMaxLenBox;
		public NumericUpDownWithUnit YtpMinLenBox;
		public System.Windows.Forms.Label YtpMinLenLbl;
		public System.Windows.Forms.Label YtpMaxLenLbl;
		public System.Windows.Forms.GroupBox YtpEffectsGroup;
		public System.Windows.Forms.CheckBox YtpEnableAllEffectsCheck;
		public System.Windows.Forms.CheckedListBox YtpEffectsCheckList;
		public System.Windows.Forms.Label YtpLbl;
		public System.Windows.Forms.GroupBox StaffParamsGroup;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
		public NumericUpDownWithUnit StaffNotesShiftBox;
		public NumericUpDownWithUnit StaffLineThicknessBox;
		public NumericUpDownWithUnit StaffSurfacePositionBox;
		public NumericUpDownWithUnit StaffSurfaceWidthBox;
		public System.Windows.Forms.Label StaffSurfaceWidthLbl;
		public System.Windows.Forms.Label StaffLineThicknessLbl;
		public System.Windows.Forms.Label StaffLineColorLbl;
		public System.Windows.Forms.Label StaffSurfacePositionLbl;
		public System.Windows.Forms.Label StaffClefLbl;
		public System.Windows.Forms.Label StaffLineSpacingLbl;
		public System.Windows.Forms.ComboBox StaffClefCombo;
		public NumericUpDownWithUnit StaffLineSpacingBox;
		public System.Windows.Forms.Button StaffLineColorBtn;
		public System.Windows.Forms.Label StaffNotesShiftLbl;
		public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
		public System.Windows.Forms.CheckBox StaffVisualizerConfigCheck;
		public System.Windows.Forms.CheckBox StaffGenerateCheck;
		public System.Windows.Forms.CheckBox StaffRelativeValueCheck;
		public System.Windows.Forms.Label SheetConfigInfoLabel;
		public System.Windows.Forms.FlowLayoutPanel AudioPreviewAttrLayoutPanel;
		public System.Windows.Forms.ComboBox PreviewBeepWaveFormCombo;
		public NumericUpDownWithUnit PreviewBeepDurationBox;
		public System.Windows.Forms.CheckBox PreviewTuneAudioCheck;
		public System.Windows.Forms.Label AudioPreviewAttrLbl;
		public CommandLinkButton QuickSelectIntervalBtn;
		public CommandLinkButton ReplaceClipsBtn;
		public CommandLinkButton ChangeTuneMethodBtn;
		public System.Windows.Forms.ToolStripMenuItem whyOkBtnIsDisabledToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
		public System.Windows.Forms.Label YtpSelectInfo;
		public System.Windows.Forms.CheckBox CloseAfterOpenHelperCheck;
		public System.Windows.Forms.RadioButton GenerateAtCustomRadio;
		public System.Windows.Forms.TextBox GenerateAtCustomText;
		public System.Windows.Forms.Button TrackLegatoBtn;
		public System.Windows.Forms.ContextMenuStrip TrackLegatoMenu;
		public System.Windows.Forms.ToolStripMenuItem stackingTracksToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem limitStretchLegatoTracksToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem stretchLegatoTracksToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem lengthenLegatoToolStripMenuItem;
		public System.Windows.Forms.RadioButton MidiDynamicMidiBpmCheck;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
		public System.Windows.Forms.Label MidiBeatLbl;
		public System.Windows.Forms.Label MidiBeatTxt;
		public System.Windows.Forms.RadioButton MidiCustomBpmCheck;
		public NumericUpDownWithUnit MidiCustomBpmBox;
	}
}

