using RecurringIntegrationsScheduler.Properties;

namespace RecurringIntegrationsScheduler.Forms
{
    partial class UploadJobV3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadJobV3));
            this.jobIdentificationGroupBox = new System.Windows.Forms.GroupBox();
            this.jobNameLabel = new System.Windows.Forms.Label();
            this.jobName = new System.Windows.Forms.TextBox();
            this.jobGroupLabel = new System.Windows.Forms.Label();
            this.jobGroupComboBox = new System.Windows.Forms.ComboBox();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.jobDescription = new System.Windows.Forms.TextBox();
            this.processingErrorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.processingErrorsFolderTextBox = new System.Windows.Forms.TextBox();
            this.processingErrorsFolderLabel = new System.Windows.Forms.Label();
            this.inputFolderBrowserButton = new System.Windows.Forms.Button();
            this.inputFolderTextBox = new System.Windows.Forms.TextBox();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.processingSuccessFolderBrowserButton = new System.Windows.Forms.Button();
            this.processingSuccessFolderTextBox = new System.Windows.Forms.TextBox();
            this.processingSuccessFolderLabel = new System.Windows.Forms.Label();
            this.uploadSuccessFolderBrowserButton = new System.Windows.Forms.Button();
            this.uploadSuccessFolderTextBox = new System.Windows.Forms.TextBox();
            this.uploadSuccessFolderLabel = new System.Windows.Forms.Label();
            this.useStandardSubfolder = new System.Windows.Forms.CheckBox();
            this.uploadErrorsFolderBrowserButton = new System.Windows.Forms.Button();
            this.uploadErrorsFolderTextBox = new System.Windows.Forms.TextBox();
            this.uploadErrorsFolderLabel = new System.Windows.Forms.Label();
            this.topUploadFolderBrowserButton = new System.Windows.Forms.Button();
            this.topUploadFolderTextBox = new System.Windows.Forms.TextBox();
            this.topUploadFolderLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.downloadFolderLabel = new System.Windows.Forms.Label();
            this.jobTabControl = new System.Windows.Forms.TabControl();
            this.jobOverviewTabPage = new System.Windows.Forms.TabPage();
            this.jobControlGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.verboseLoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.retryPolicyGroupBox = new System.Windows.Forms.GroupBox();
            this.retriesLabel = new System.Windows.Forms.Label();
            this.retriesCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.retriesDelayLabel = new System.Windows.Forms.Label();
            this.retriesDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBoxExceptions = new System.Windows.Forms.GroupBox();
            this.pauseOnExceptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.pauseIndefinitelyCheckBox = new System.Windows.Forms.CheckBox();
            this.foldersGroupBox = new System.Windows.Forms.GroupBox();
            this.jobDetailsTabPage = new System.Windows.Forms.TabPage();
            this.uploadDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.getLegalEntityFromFilenameTextBox = new System.Windows.Forms.TextBox();
            this.getLegalEntityFromFilenameDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.filenameSeparatorLabel = new System.Windows.Forms.Label();
            this.filenameSeparatorTextBox = new System.Windows.Forms.TextBox();
            this.legalEntityTokenPositionLabel = new System.Windows.Forms.Label();
            this.legalEntityTokenPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.separatorExmpleLabel = new System.Windows.Forms.Label();
            this.separatorExampleTextBox = new System.Windows.Forms.TextBox();
            this.separatorExampleLegalEntityTextBox = new System.Windows.Forms.TextBox();
            this.separatorExampleButton = new System.Windows.Forms.Button();
            this.dataJobLabel = new System.Windows.Forms.Label();
            this.dataJobComboBox = new System.Windows.Forms.ComboBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericUpDownIntervalUploads = new System.Windows.Forms.NumericUpDown();
            this.LegalEntityLabel = new System.Windows.Forms.Label();
            this.legalEntityTextBox = new System.Windows.Forms.TextBox();
            this.fileSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.isDataPackageCheckBox = new System.Windows.Forms.CheckBox();
            this.searchPatternLabel = new System.Windows.Forms.Label();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.orderByLabel = new System.Windows.Forms.Label();
            this.orderByComboBox = new System.Windows.Forms.ComboBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.orderByPanel = new System.Windows.Forms.Panel();
            this.orderAscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.orderDescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.uploadRecurrenceTabPage = new System.Windows.Forms.TabPage();
            this.upJobTriggerTypePanel = new System.Windows.Forms.Panel();
            this.upJobSimpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.upJobCronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.simpleTriggerUploadJobGroupBox = new System.Windows.Forms.GroupBox();
            this.runEveryUploadJobLabel = new System.Windows.Forms.Label();
            this.upJobHoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.upJobHoursLabel = new System.Windows.Forms.Label();
            this.importJobAndOrLabel = new System.Windows.Forms.Label();
            this.upJobMinutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.upJobMinutesLabel = new System.Windows.Forms.Label();
            this.upJobStartAtLabel = new System.Windows.Forms.Label();
            this.upJobStartAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cronTriggerUploadJobGroupBox = new System.Windows.Forms.GroupBox();
            this.upJobCronExpressionLabel = new System.Windows.Forms.Label();
            this.upJobCronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.cronTriggerInfoTextBox = new System.Windows.Forms.TextBox();
            this.buildCronLabel = new System.Windows.Forms.Label();
            this.cronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.getCronScheduleForUploadButton = new System.Windows.Forms.Button();
            this.calculatedRunsTextBox = new System.Windows.Forms.TextBox();
            this.moreExamplesButton = new System.Windows.Forms.Button();
            this.monitoringJobTabPage = new System.Windows.Forms.TabPage();
            this.useMonitoringJobCheckBox = new System.Windows.Forms.CheckBox();
            this.processingJobGroupBox = new System.Windows.Forms.GroupBox();
            this.getExecutionErrorsCheckBox = new System.Windows.Forms.CheckBox();
            this.delayBetweenStatusCheckLabel = new System.Windows.Forms.Label();
            this.delayBetweenStatusCheckNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusFileExtensionLabel = new System.Windows.Forms.Label();
            this.statusFileExtensionTextBox = new System.Windows.Forms.TextBox();
            this.procJobTriggerTypePanel = new System.Windows.Forms.Panel();
            this.procJobSimpleTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.procJobCronTriggerRadioButton = new System.Windows.Forms.RadioButton();
            this.simpleTriggerMonitoringJobGroupBox = new System.Windows.Forms.GroupBox();
            this.runEveryMonitoringJobLabel = new System.Windows.Forms.Label();
            this.procJobHoursDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.procJobHoursLabel = new System.Windows.Forms.Label();
            this.andOrMonitoringJobLabel = new System.Windows.Forms.Label();
            this.procJobMinutesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.procJobMinutesLabel = new System.Windows.Forms.Label();
            this.procJobStartAtLabel = new System.Windows.Forms.Label();
            this.procJobStartAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cronTriggerMonitoringJobGroupBox = new System.Windows.Forms.GroupBox();
            this.procJobCronExpressionLabel = new System.Windows.Forms.Label();
            this.procJobCronExpressionTextBox = new System.Windows.Forms.TextBox();
            this.monitoringCronTextBox = new System.Windows.Forms.TextBox();
            this.monitoringJobBuildCronLabel = new System.Windows.Forms.Label();
            this.monitoringJobCronmakerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.monitoringJobCronDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.getCronScheduleForMonitoringButton = new System.Windows.Forms.Button();
            this.calculatedRunsMonitoringTextBox = new System.Windows.Forms.TextBox();
            this.moreExamplesMonitoringButton = new System.Windows.Forms.Button();
            this.connectionTabPage = new System.Windows.Forms.TabPage();
            this.axDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.instanceLabel = new System.Windows.Forms.Label();
            this.instanceComboBox = new System.Windows.Forms.ComboBox();
            this.authMethodPanel = new System.Windows.Forms.Panel();
            this.serviceAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.userAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.aadApplicationLabel = new System.Windows.Forms.Label();
            this.appRegistrationComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getLegalEntityFromFilenameCheckbox = new System.Windows.Forms.CheckBox();
            this.jobIdentificationGroupBox.SuspendLayout();
            this.jobTabControl.SuspendLayout();
            this.jobOverviewTabPage.SuspendLayout();
            this.jobControlGroupBox.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.retryPolicyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).BeginInit();
            this.groupBoxExceptions.SuspendLayout();
            this.foldersGroupBox.SuspendLayout();
            this.jobDetailsTabPage.SuspendLayout();
            this.uploadDetailsGroupBox.SuspendLayout();
            this.getLegalEntityFromFilenameDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legalEntityTokenPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalUploads)).BeginInit();
            this.fileSelectionGroupBox.SuspendLayout();
            this.orderByPanel.SuspendLayout();
            this.uploadRecurrenceTabPage.SuspendLayout();
            this.upJobTriggerTypePanel.SuspendLayout();
            this.simpleTriggerUploadJobGroupBox.SuspendLayout();
            this.cronTriggerUploadJobGroupBox.SuspendLayout();
            this.monitoringJobTabPage.SuspendLayout();
            this.processingJobGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenStatusCheckNumericUpDown)).BeginInit();
            this.procJobTriggerTypePanel.SuspendLayout();
            this.simpleTriggerMonitoringJobGroupBox.SuspendLayout();
            this.cronTriggerMonitoringJobGroupBox.SuspendLayout();
            this.connectionTabPage.SuspendLayout();
            this.axDetailsGroupBox.SuspendLayout();
            this.authMethodPanel.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobIdentificationGroupBox
            // 
            this.jobIdentificationGroupBox.Controls.Add(this.jobNameLabel);
            this.jobIdentificationGroupBox.Controls.Add(this.jobName);
            this.jobIdentificationGroupBox.Controls.Add(this.jobGroupLabel);
            this.jobIdentificationGroupBox.Controls.Add(this.jobGroupComboBox);
            this.jobIdentificationGroupBox.Controls.Add(this.jobDescriptionLabel);
            this.jobIdentificationGroupBox.Controls.Add(this.jobDescription);
            this.jobIdentificationGroupBox.Location = new System.Drawing.Point(11, 9);
            this.jobIdentificationGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobIdentificationGroupBox.Name = "jobIdentificationGroupBox";
            this.jobIdentificationGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobIdentificationGroupBox.Size = new System.Drawing.Size(571, 485);
            this.jobIdentificationGroupBox.TabIndex = 0;
            this.jobIdentificationGroupBox.TabStop = false;
            this.jobIdentificationGroupBox.Text = "Job identification";
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Location = new System.Drawing.Point(11, 82);
            this.jobNameLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(184, 32);
            this.jobNameLabel.TabIndex = 0;
            this.jobNameLabel.Text = "RIS job name";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(217, 73);
            this.jobName.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(340, 38);
            this.jobName.TabIndex = 1;
            // 
            // jobGroupLabel
            // 
            this.jobGroupLabel.AutoSize = true;
            this.jobGroupLabel.Location = new System.Drawing.Point(11, 144);
            this.jobGroupLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.jobGroupLabel.Name = "jobGroupLabel";
            this.jobGroupLabel.Size = new System.Drawing.Size(186, 32);
            this.jobGroupLabel.TabIndex = 2;
            this.jobGroupLabel.Text = "RIS job group";
            // 
            // jobGroupComboBox
            // 
            this.jobGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobGroupComboBox.FormattingEnabled = true;
            this.jobGroupComboBox.Location = new System.Drawing.Point(217, 135);
            this.jobGroupComboBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobGroupComboBox.Name = "jobGroupComboBox";
            this.jobGroupComboBox.Size = new System.Drawing.Size(340, 39);
            this.jobGroupComboBox.Sorted = true;
            this.jobGroupComboBox.TabIndex = 2;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(11, 215);
            this.jobDescriptionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(333, 32);
            this.jobDescriptionLabel.TabIndex = 4;
            this.jobDescriptionLabel.Text = "Job description (optional)";
            // 
            // jobDescription
            // 
            this.jobDescription.Location = new System.Drawing.Point(19, 255);
            this.jobDescription.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobDescription.Multiline = true;
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.Size = new System.Drawing.Size(537, 207);
            this.jobDescription.TabIndex = 3;
            // 
            // processingErrorsFolderBrowserButton
            // 
            this.processingErrorsFolderBrowserButton.Enabled = false;
            this.processingErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingErrorsFolderBrowserButton.Location = new System.Drawing.Point(521, 640);
            this.processingErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingErrorsFolderBrowserButton.Name = "processingErrorsFolderBrowserButton";
            this.processingErrorsFolderBrowserButton.Size = new System.Drawing.Size(64, 62);
            this.processingErrorsFolderBrowserButton.TabIndex = 27;
            this.processingErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingErrorsFolderBrowserButton.Click += new System.EventHandler(this.ProcessingErrorsFolderBrowserButton_Click);
            // 
            // processingErrorsFolderTextBox
            // 
            this.processingErrorsFolderTextBox.Enabled = false;
            this.processingErrorsFolderTextBox.Location = new System.Drawing.Point(13, 646);
            this.processingErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.processingErrorsFolderTextBox.Name = "processingErrorsFolderTextBox";
            this.processingErrorsFolderTextBox.Size = new System.Drawing.Size(493, 38);
            this.processingErrorsFolderTextBox.TabIndex = 26;
            // 
            // processingErrorsFolderLabel
            // 
            this.processingErrorsFolderLabel.AutoSize = true;
            this.processingErrorsFolderLabel.Location = new System.Drawing.Point(9, 606);
            this.processingErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.processingErrorsFolderLabel.Name = "processingErrorsFolderLabel";
            this.processingErrorsFolderLabel.Size = new System.Drawing.Size(314, 32);
            this.processingErrorsFolderLabel.TabIndex = 28;
            this.processingErrorsFolderLabel.Text = "Processing errors folder";
            // 
            // inputFolderBrowserButton
            // 
            this.inputFolderBrowserButton.Enabled = false;
            this.inputFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.inputFolderBrowserButton.Location = new System.Drawing.Point(521, 259);
            this.inputFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.inputFolderBrowserButton.Name = "inputFolderBrowserButton";
            this.inputFolderBrowserButton.Size = new System.Drawing.Size(64, 62);
            this.inputFolderBrowserButton.TabIndex = 19;
            this.inputFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.inputFolderBrowserButton.UseVisualStyleBackColor = true;
            this.inputFolderBrowserButton.Click += new System.EventHandler(this.InputFolderButton_Click);
            // 
            // inputFolderTextBox
            // 
            this.inputFolderTextBox.Enabled = false;
            this.inputFolderTextBox.Location = new System.Drawing.Point(13, 270);
            this.inputFolderTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.inputFolderTextBox.Name = "inputFolderTextBox";
            this.inputFolderTextBox.Size = new System.Drawing.Size(493, 38);
            this.inputFolderTextBox.TabIndex = 18;
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(9, 226);
            this.inputFolderLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(202, 32);
            this.inputFolderLabel.TabIndex = 20;
            this.inputFolderLabel.Text = "Input subfolder";
            // 
            // processingSuccessFolderBrowserButton
            // 
            this.processingSuccessFolderBrowserButton.Enabled = false;
            this.processingSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.processingSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.processingSuccessFolderBrowserButton.Location = new System.Drawing.Point(521, 547);
            this.processingSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.processingSuccessFolderBrowserButton.Name = "processingSuccessFolderBrowserButton";
            this.processingSuccessFolderBrowserButton.Size = new System.Drawing.Size(64, 62);
            this.processingSuccessFolderBrowserButton.TabIndex = 16;
            this.processingSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.processingSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.processingSuccessFolderBrowserButton.Click += new System.EventHandler(this.ProcessingSuccessFolderButton_Click);
            // 
            // processingSuccessFolderTextBox
            // 
            this.processingSuccessFolderTextBox.Enabled = false;
            this.processingSuccessFolderTextBox.Location = new System.Drawing.Point(13, 553);
            this.processingSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.processingSuccessFolderTextBox.Name = "processingSuccessFolderTextBox";
            this.processingSuccessFolderTextBox.Size = new System.Drawing.Size(493, 38);
            this.processingSuccessFolderTextBox.TabIndex = 15;
            // 
            // processingSuccessFolderLabel
            // 
            this.processingSuccessFolderLabel.AutoSize = true;
            this.processingSuccessFolderLabel.Location = new System.Drawing.Point(9, 513);
            this.processingSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.processingSuccessFolderLabel.Name = "processingSuccessFolderLabel";
            this.processingSuccessFolderLabel.Size = new System.Drawing.Size(343, 32);
            this.processingSuccessFolderLabel.TabIndex = 17;
            this.processingSuccessFolderLabel.Text = "Processing success folder";
            // 
            // uploadSuccessFolderBrowserButton
            // 
            this.uploadSuccessFolderBrowserButton.Enabled = false;
            this.uploadSuccessFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadSuccessFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadSuccessFolderBrowserButton.Location = new System.Drawing.Point(521, 358);
            this.uploadSuccessFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadSuccessFolderBrowserButton.Name = "uploadSuccessFolderBrowserButton";
            this.uploadSuccessFolderBrowserButton.Size = new System.Drawing.Size(64, 62);
            this.uploadSuccessFolderBrowserButton.TabIndex = 13;
            this.uploadSuccessFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadSuccessFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadSuccessFolderBrowserButton.Click += new System.EventHandler(this.UploadSuccessFolderButton_Click);
            // 
            // uploadSuccessFolderTextBox
            // 
            this.uploadSuccessFolderTextBox.Enabled = false;
            this.uploadSuccessFolderTextBox.Location = new System.Drawing.Point(13, 365);
            this.uploadSuccessFolderTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.uploadSuccessFolderTextBox.Name = "uploadSuccessFolderTextBox";
            this.uploadSuccessFolderTextBox.Size = new System.Drawing.Size(493, 38);
            this.uploadSuccessFolderTextBox.TabIndex = 12;
            // 
            // uploadSuccessFolderLabel
            // 
            this.uploadSuccessFolderLabel.AutoSize = true;
            this.uploadSuccessFolderLabel.Location = new System.Drawing.Point(9, 321);
            this.uploadSuccessFolderLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.uploadSuccessFolderLabel.Name = "uploadSuccessFolderLabel";
            this.uploadSuccessFolderLabel.Size = new System.Drawing.Size(293, 32);
            this.uploadSuccessFolderLabel.TabIndex = 14;
            this.uploadSuccessFolderLabel.Text = "Upload success folder";
            // 
            // useStandardSubfolder
            // 
            this.useStandardSubfolder.AutoSize = true;
            this.useStandardSubfolder.Checked = true;
            this.useStandardSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useStandardSubfolder.Location = new System.Drawing.Point(13, 177);
            this.useStandardSubfolder.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.useStandardSubfolder.Name = "useStandardSubfolder";
            this.useStandardSubfolder.Size = new System.Drawing.Size(411, 36);
            this.useStandardSubfolder.TabIndex = 8;
            this.useStandardSubfolder.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Use_default_subfolders_names;
            this.useStandardSubfolder.UseVisualStyleBackColor = true;
            this.useStandardSubfolder.CheckedChanged += new System.EventHandler(this.UseStandardSubfolder_CheckedChanged);
            // 
            // uploadErrorsFolderBrowserButton
            // 
            this.uploadErrorsFolderBrowserButton.Enabled = false;
            this.uploadErrorsFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadErrorsFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.uploadErrorsFolderBrowserButton.Location = new System.Drawing.Point(521, 451);
            this.uploadErrorsFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.uploadErrorsFolderBrowserButton.Name = "uploadErrorsFolderBrowserButton";
            this.uploadErrorsFolderBrowserButton.Size = new System.Drawing.Size(64, 62);
            this.uploadErrorsFolderBrowserButton.TabIndex = 7;
            this.uploadErrorsFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uploadErrorsFolderBrowserButton.UseVisualStyleBackColor = true;
            this.uploadErrorsFolderBrowserButton.Click += new System.EventHandler(this.UploadErrorsFolderBrowserButton_Click);
            // 
            // uploadErrorsFolderTextBox
            // 
            this.uploadErrorsFolderTextBox.Enabled = false;
            this.uploadErrorsFolderTextBox.Location = new System.Drawing.Point(13, 458);
            this.uploadErrorsFolderTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.uploadErrorsFolderTextBox.Name = "uploadErrorsFolderTextBox";
            this.uploadErrorsFolderTextBox.Size = new System.Drawing.Size(493, 38);
            this.uploadErrorsFolderTextBox.TabIndex = 6;
            // 
            // uploadErrorsFolderLabel
            // 
            this.uploadErrorsFolderLabel.AutoSize = true;
            this.uploadErrorsFolderLabel.Location = new System.Drawing.Point(9, 414);
            this.uploadErrorsFolderLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.uploadErrorsFolderLabel.Name = "uploadErrorsFolderLabel";
            this.uploadErrorsFolderLabel.Size = new System.Drawing.Size(264, 32);
            this.uploadErrorsFolderLabel.TabIndex = 11;
            this.uploadErrorsFolderLabel.Text = "Upload errors folder";
            // 
            // topUploadFolderBrowserButton
            // 
            this.topUploadFolderBrowserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topUploadFolderBrowserButton.Image = global::RecurringIntegrationsScheduler.Properties.Resources.Folder_open_32xMD_exp;
            this.topUploadFolderBrowserButton.Location = new System.Drawing.Point(521, 117);
            this.topUploadFolderBrowserButton.Margin = new System.Windows.Forms.Padding(0);
            this.topUploadFolderBrowserButton.Name = "topUploadFolderBrowserButton";
            this.topUploadFolderBrowserButton.Size = new System.Drawing.Size(64, 62);
            this.topUploadFolderBrowserButton.TabIndex = 5;
            this.topUploadFolderBrowserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.topUploadFolderBrowserButton.UseVisualStyleBackColor = true;
            this.topUploadFolderBrowserButton.Click += new System.EventHandler(this.TopUploadFolderBrowserButton_Click);
            // 
            // topUploadFolderTextBox
            // 
            this.topUploadFolderTextBox.Location = new System.Drawing.Point(13, 124);
            this.topUploadFolderTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.topUploadFolderTextBox.Name = "topUploadFolderTextBox";
            this.topUploadFolderTextBox.Size = new System.Drawing.Size(493, 38);
            this.topUploadFolderTextBox.TabIndex = 4;
            this.topUploadFolderTextBox.TextChanged += new System.EventHandler(this.TopUploadFolder_TextChanged);
            // 
            // topUploadFolderLabel
            // 
            this.topUploadFolderLabel.AutoSize = true;
            this.topUploadFolderLabel.Location = new System.Drawing.Point(9, 82);
            this.topUploadFolderLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.topUploadFolderLabel.Name = "topUploadFolderLabel";
            this.topUploadFolderLabel.Size = new System.Drawing.Size(236, 32);
            this.topUploadFolderLabel.TabIndex = 8;
            this.topUploadFolderLabel.Text = "Top upload folder";
            // 
            // downloadFolderLabel
            // 
            this.downloadFolderLabel.AutoSize = true;
            this.downloadFolderLabel.Location = new System.Drawing.Point(9, 157);
            this.downloadFolderLabel.Name = "downloadFolderLabel";
            this.downloadFolderLabel.Size = new System.Drawing.Size(90, 13);
            this.downloadFolderLabel.TabIndex = 8;
            this.downloadFolderLabel.Text = "Top upload folder";
            // 
            // jobTabControl
            // 
            this.jobTabControl.Controls.Add(this.jobOverviewTabPage);
            this.jobTabControl.Controls.Add(this.jobDetailsTabPage);
            this.jobTabControl.Controls.Add(this.uploadRecurrenceTabPage);
            this.jobTabControl.Controls.Add(this.monitoringJobTabPage);
            this.jobTabControl.Controls.Add(this.connectionTabPage);
            this.jobTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobTabControl.Location = new System.Drawing.Point(0, 0);
            this.jobTabControl.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobTabControl.Name = "jobTabControl";
            this.jobTabControl.SelectedIndex = 0;
            this.jobTabControl.Size = new System.Drawing.Size(1904, 1286);
            this.jobTabControl.TabIndex = 13;
            // 
            // jobOverviewTabPage
            // 
            this.jobOverviewTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.jobOverviewTabPage.Controls.Add(this.jobIdentificationGroupBox);
            this.jobOverviewTabPage.Controls.Add(this.jobControlGroupBox);
            this.jobOverviewTabPage.Controls.Add(this.foldersGroupBox);
            this.jobOverviewTabPage.Location = new System.Drawing.Point(4, 40);
            this.jobOverviewTabPage.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobOverviewTabPage.Name = "jobOverviewTabPage";
            this.jobOverviewTabPage.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobOverviewTabPage.Size = new System.Drawing.Size(1896, 1242);
            this.jobOverviewTabPage.TabIndex = 0;
            this.jobOverviewTabPage.Text = "Upload job overview";
            // 
            // jobControlGroupBox
            // 
            this.jobControlGroupBox.Controls.Add(this.groupBoxLogging);
            this.jobControlGroupBox.Controls.Add(this.retryPolicyGroupBox);
            this.jobControlGroupBox.Controls.Add(this.groupBoxExceptions);
            this.jobControlGroupBox.Controls.Add(this.pauseIndefinitelyCheckBox);
            this.jobControlGroupBox.Location = new System.Drawing.Point(11, 503);
            this.jobControlGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobControlGroupBox.Name = "jobControlGroupBox";
            this.jobControlGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobControlGroupBox.Size = new System.Drawing.Size(571, 494);
            this.jobControlGroupBox.TabIndex = 15;
            this.jobControlGroupBox.TabStop = false;
            this.jobControlGroupBox.Text = "Job control";
            // 
            // groupBoxLogging
            // 
            this.groupBoxLogging.Controls.Add(this.verboseLoggingCheckBox);
            this.groupBoxLogging.Location = new System.Drawing.Point(20, 332);
            this.groupBoxLogging.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxLogging.Name = "groupBoxLogging";
            this.groupBoxLogging.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxLogging.Size = new System.Drawing.Size(539, 95);
            this.groupBoxLogging.TabIndex = 16;
            this.groupBoxLogging.TabStop = false;
            this.groupBoxLogging.Text = "Verbose logging";
            // 
            // verboseLoggingCheckBox
            // 
            this.verboseLoggingCheckBox.AutoSize = true;
            this.verboseLoggingCheckBox.Location = new System.Drawing.Point(25, 40);
            this.verboseLoggingCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.verboseLoggingCheckBox.Name = "verboseLoggingCheckBox";
            this.verboseLoggingCheckBox.Size = new System.Drawing.Size(295, 36);
            this.verboseLoggingCheckBox.TabIndex = 0;
            this.verboseLoggingCheckBox.Text = "Use verbose logging";
            this.verboseLoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // retryPolicyGroupBox
            // 
            this.retryPolicyGroupBox.Controls.Add(this.retriesLabel);
            this.retryPolicyGroupBox.Controls.Add(this.retriesCountUpDown);
            this.retryPolicyGroupBox.Controls.Add(this.retriesDelayLabel);
            this.retryPolicyGroupBox.Controls.Add(this.retriesDelayUpDown);
            this.retryPolicyGroupBox.Location = new System.Drawing.Point(19, 53);
            this.retryPolicyGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.retryPolicyGroupBox.Name = "retryPolicyGroupBox";
            this.retryPolicyGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.retryPolicyGroupBox.Size = new System.Drawing.Size(539, 160);
            this.retryPolicyGroupBox.TabIndex = 11;
            this.retryPolicyGroupBox.TabStop = false;
            this.retryPolicyGroupBox.Text = "Retry policy";
            // 
            // retriesLabel
            // 
            this.retriesLabel.AutoSize = true;
            this.retriesLabel.Location = new System.Drawing.Point(19, 48);
            this.retriesLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.retriesLabel.Name = "retriesLabel";
            this.retriesLabel.Size = new System.Drawing.Size(231, 32);
            this.retriesLabel.TabIndex = 0;
            this.retriesLabel.Text = "Number of retries";
            // 
            // retriesCountUpDown
            // 
            this.retriesCountUpDown.Location = new System.Drawing.Point(265, 42);
            this.retriesCountUpDown.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.retriesCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.retriesCountUpDown.Name = "retriesCountUpDown";
            this.retriesCountUpDown.Size = new System.Drawing.Size(128, 38);
            this.retriesCountUpDown.TabIndex = 4;
            this.retriesCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // retriesDelayLabel
            // 
            this.retriesDelayLabel.AutoSize = true;
            this.retriesDelayLabel.Location = new System.Drawing.Point(19, 104);
            this.retriesDelayLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.retriesDelayLabel.Name = "retriesDelayLabel";
            this.retriesDelayLabel.Size = new System.Drawing.Size(218, 32);
            this.retriesDelayLabel.TabIndex = 2;
            this.retriesDelayLabel.Text = "Delay (seconds)";
            // 
            // retriesDelayUpDown
            // 
            this.retriesDelayUpDown.Location = new System.Drawing.Point(265, 100);
            this.retriesDelayUpDown.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.retriesDelayUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.retriesDelayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.retriesDelayUpDown.Name = "retriesDelayUpDown";
            this.retriesDelayUpDown.Size = new System.Drawing.Size(128, 38);
            this.retriesDelayUpDown.TabIndex = 5;
            this.retriesDelayUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBoxExceptions
            // 
            this.groupBoxExceptions.Controls.Add(this.pauseOnExceptionsCheckBox);
            this.groupBoxExceptions.Location = new System.Drawing.Point(19, 226);
            this.groupBoxExceptions.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxExceptions.Name = "groupBoxExceptions";
            this.groupBoxExceptions.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxExceptions.Size = new System.Drawing.Size(539, 95);
            this.groupBoxExceptions.TabIndex = 12;
            this.groupBoxExceptions.TabStop = false;
            this.groupBoxExceptions.Text = "Exceptions";
            // 
            // pauseOnExceptionsCheckBox
            // 
            this.pauseOnExceptionsCheckBox.AutoSize = true;
            this.pauseOnExceptionsCheckBox.Checked = true;
            this.pauseOnExceptionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pauseOnExceptionsCheckBox.Location = new System.Drawing.Point(25, 40);
            this.pauseOnExceptionsCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.pauseOnExceptionsCheckBox.Name = "pauseOnExceptionsCheckBox";
            this.pauseOnExceptionsCheckBox.Size = new System.Drawing.Size(458, 36);
            this.pauseOnExceptionsCheckBox.TabIndex = 0;
            this.pauseOnExceptionsCheckBox.Text = "Pause job when exception occurs";
            this.pauseOnExceptionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pauseIndefinitelyCheckBox
            // 
            this.pauseIndefinitelyCheckBox.AutoSize = true;
            this.pauseIndefinitelyCheckBox.Location = new System.Drawing.Point(19, 445);
            this.pauseIndefinitelyCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.pauseIndefinitelyCheckBox.Name = "pauseIndefinitelyCheckBox";
            this.pauseIndefinitelyCheckBox.Size = new System.Drawing.Size(499, 36);
            this.pauseIndefinitelyCheckBox.TabIndex = 13;
            this.pauseIndefinitelyCheckBox.Text = "Don\'t execute the job. Always pause.";
            this.pauseIndefinitelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // foldersGroupBox
            // 
            this.foldersGroupBox.Controls.Add(this.topUploadFolderLabel);
            this.foldersGroupBox.Controls.Add(this.topUploadFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.topUploadFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.useStandardSubfolder);
            this.foldersGroupBox.Controls.Add(this.inputFolderLabel);
            this.foldersGroupBox.Controls.Add(this.inputFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.inputFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.uploadSuccessFolderLabel);
            this.foldersGroupBox.Controls.Add(this.uploadSuccessFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.uploadSuccessFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.uploadErrorsFolderLabel);
            this.foldersGroupBox.Controls.Add(this.uploadErrorsFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.uploadErrorsFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.processingSuccessFolderLabel);
            this.foldersGroupBox.Controls.Add(this.processingSuccessFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.processingSuccessFolderBrowserButton);
            this.foldersGroupBox.Controls.Add(this.processingErrorsFolderLabel);
            this.foldersGroupBox.Controls.Add(this.processingErrorsFolderTextBox);
            this.foldersGroupBox.Controls.Add(this.processingErrorsFolderBrowserButton);
            this.foldersGroupBox.Location = new System.Drawing.Point(595, 9);
            this.foldersGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.foldersGroupBox.Name = "foldersGroupBox";
            this.foldersGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.foldersGroupBox.Size = new System.Drawing.Size(595, 724);
            this.foldersGroupBox.TabIndex = 14;
            this.foldersGroupBox.TabStop = false;
            this.foldersGroupBox.Text = "Folders";
            // 
            // jobDetailsTabPage
            // 
            this.jobDetailsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.jobDetailsTabPage.Controls.Add(this.uploadDetailsGroupBox);
            this.jobDetailsTabPage.Controls.Add(this.fileSelectionGroupBox);
            this.jobDetailsTabPage.Location = new System.Drawing.Point(4, 40);
            this.jobDetailsTabPage.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobDetailsTabPage.Name = "jobDetailsTabPage";
            this.jobDetailsTabPage.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.jobDetailsTabPage.Size = new System.Drawing.Size(1896, 1242);
            this.jobDetailsTabPage.TabIndex = 1;
            this.jobDetailsTabPage.Text = "Upload job details";
            // 
            // uploadDetailsGroupBox
            // 
            this.uploadDetailsGroupBox.Controls.Add(this.getLegalEntityFromFilenameCheckbox);
            this.uploadDetailsGroupBox.Controls.Add(this.getLegalEntityFromFilenameTextBox);
            this.uploadDetailsGroupBox.Controls.Add(this.getLegalEntityFromFilenameDetailsGroupBox);
            this.uploadDetailsGroupBox.Controls.Add(this.dataJobLabel);
            this.uploadDetailsGroupBox.Controls.Add(this.dataJobComboBox);
            this.uploadDetailsGroupBox.Controls.Add(this.labelInterval);
            this.uploadDetailsGroupBox.Controls.Add(this.numericUpDownIntervalUploads);
            this.uploadDetailsGroupBox.Controls.Add(this.LegalEntityLabel);
            this.uploadDetailsGroupBox.Controls.Add(this.legalEntityTextBox);
            this.uploadDetailsGroupBox.Location = new System.Drawing.Point(11, 9);
            this.uploadDetailsGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.uploadDetailsGroupBox.Name = "uploadDetailsGroupBox";
            this.uploadDetailsGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.uploadDetailsGroupBox.Size = new System.Drawing.Size(605, 786);
            this.uploadDetailsGroupBox.TabIndex = 38;
            this.uploadDetailsGroupBox.TabStop = false;
            this.uploadDetailsGroupBox.Text = "Upload details";
            this.uploadDetailsGroupBox.Enter += new System.EventHandler(this.uploadDetailsGroupBox_Enter);
            // 
            // getLegalEntityFromFilenameTextBox
            // 
            this.getLegalEntityFromFilenameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.getLegalEntityFromFilenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getLegalEntityFromFilenameTextBox.Location = new System.Drawing.Point(29, 348);
            this.getLegalEntityFromFilenameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.getLegalEntityFromFilenameTextBox.Multiline = true;
            this.getLegalEntityFromFilenameTextBox.Name = "getLegalEntityFromFilenameTextBox";
            this.getLegalEntityFromFilenameTextBox.Size = new System.Drawing.Size(505, 100);
            this.getLegalEntityFromFilenameTextBox.TabIndex = 38;
            this.getLegalEntityFromFilenameTextBox.Text = "Legal entity is part of input file name. It is necessary to specify separator and" +
    " position of LE token in the file name.";
            // 
            // getLegalEntityFromFilenameDetailsGroupBox
            // 
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.filenameSeparatorLabel);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.filenameSeparatorTextBox);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.legalEntityTokenPositionLabel);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.legalEntityTokenPositionNumericUpDown);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExmpleLabel);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExampleTextBox);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExampleLegalEntityTextBox);
            this.getLegalEntityFromFilenameDetailsGroupBox.Controls.Add(this.separatorExampleButton);
            this.getLegalEntityFromFilenameDetailsGroupBox.Location = new System.Drawing.Point(25, 454);
            this.getLegalEntityFromFilenameDetailsGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.getLegalEntityFromFilenameDetailsGroupBox.Name = "getLegalEntityFromFilenameDetailsGroupBox";
            this.getLegalEntityFromFilenameDetailsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.getLegalEntityFromFilenameDetailsGroupBox.Size = new System.Drawing.Size(509, 288);
            this.getLegalEntityFromFilenameDetailsGroupBox.TabIndex = 39;
            this.getLegalEntityFromFilenameDetailsGroupBox.TabStop = false;
            // 
            // filenameSeparatorLabel
            // 
            this.filenameSeparatorLabel.AutoSize = true;
            this.filenameSeparatorLabel.Location = new System.Drawing.Point(9, 33);
            this.filenameSeparatorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.filenameSeparatorLabel.Name = "filenameSeparatorLabel";
            this.filenameSeparatorLabel.Size = new System.Drawing.Size(264, 32);
            this.filenameSeparatorLabel.TabIndex = 3;
            this.filenameSeparatorLabel.Text = "Separator character";
            // 
            // filenameSeparatorTextBox
            // 
            this.filenameSeparatorTextBox.Location = new System.Drawing.Point(285, 26);
            this.filenameSeparatorTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.filenameSeparatorTextBox.MaxLength = 1;
            this.filenameSeparatorTextBox.Name = "filenameSeparatorTextBox";
            this.filenameSeparatorTextBox.Size = new System.Drawing.Size(47, 38);
            this.filenameSeparatorTextBox.TabIndex = 0;
            this.filenameSeparatorTextBox.Text = "_";
            // 
            // legalEntityTokenPositionLabel
            // 
            this.legalEntityTokenPositionLabel.AutoSize = true;
            this.legalEntityTokenPositionLabel.Location = new System.Drawing.Point(9, 84);
            this.legalEntityTokenPositionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.legalEntityTokenPositionLabel.Name = "legalEntityTokenPositionLabel";
            this.legalEntityTokenPositionLabel.Size = new System.Drawing.Size(345, 32);
            this.legalEntityTokenPositionLabel.TabIndex = 2;
            this.legalEntityTokenPositionLabel.Text = "Legal entity token position";
            // 
            // legalEntityTokenPositionNumericUpDown
            // 
            this.legalEntityTokenPositionNumericUpDown.Location = new System.Drawing.Point(365, 79);
            this.legalEntityTokenPositionNumericUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.legalEntityTokenPositionNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.legalEntityTokenPositionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.legalEntityTokenPositionNumericUpDown.Name = "legalEntityTokenPositionNumericUpDown";
            this.legalEntityTokenPositionNumericUpDown.Size = new System.Drawing.Size(91, 38);
            this.legalEntityTokenPositionNumericUpDown.TabIndex = 1;
            this.legalEntityTokenPositionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // separatorExmpleLabel
            // 
            this.separatorExmpleLabel.AutoSize = true;
            this.separatorExmpleLabel.Location = new System.Drawing.Point(13, 135);
            this.separatorExmpleLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.separatorExmpleLabel.Name = "separatorExmpleLabel";
            this.separatorExmpleLabel.Size = new System.Drawing.Size(125, 32);
            this.separatorExmpleLabel.TabIndex = 4;
            this.separatorExmpleLabel.Text = "Example";
            // 
            // separatorExampleTextBox
            // 
            this.separatorExampleTextBox.Location = new System.Drawing.Point(16, 175);
            this.separatorExampleTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.separatorExampleTextBox.Name = "separatorExampleTextBox";
            this.separatorExampleTextBox.Size = new System.Drawing.Size(487, 38);
            this.separatorExampleTextBox.TabIndex = 5;
            this.separatorExampleTextBox.Text = "d04_test.zip";
            // 
            // separatorExampleLegalEntityTextBox
            // 
            this.separatorExampleLegalEntityTextBox.Location = new System.Drawing.Point(16, 237);
            this.separatorExampleLegalEntityTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.separatorExampleLegalEntityTextBox.Name = "separatorExampleLegalEntityTextBox";
            this.separatorExampleLegalEntityTextBox.Size = new System.Drawing.Size(231, 38);
            this.separatorExampleLegalEntityTextBox.TabIndex = 6;
            this.separatorExampleLegalEntityTextBox.Text = "d04";
            // 
            // separatorExampleButton
            // 
            this.separatorExampleButton.Location = new System.Drawing.Point(267, 231);
            this.separatorExampleButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.separatorExampleButton.Name = "separatorExampleButton";
            this.separatorExampleButton.Size = new System.Drawing.Size(243, 55);
            this.separatorExampleButton.TabIndex = 7;
            this.separatorExampleButton.Text = "Get legal entity";
            this.separatorExampleButton.UseVisualStyleBackColor = true;
            this.separatorExampleButton.Click += new System.EventHandler(this.separatorExampleButton_Click);
            // 
            // dataJobLabel
            // 
            this.dataJobLabel.AutoSize = true;
            this.dataJobLabel.Location = new System.Drawing.Point(11, 48);
            this.dataJobLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.dataJobLabel.Name = "dataJobLabel";
            this.dataJobLabel.Size = new System.Drawing.Size(281, 32);
            this.dataJobLabel.TabIndex = 37;
            this.dataJobLabel.Text = "Data job in Dynamics";
            // 
            // dataJobComboBox
            // 
            this.dataJobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataJobComboBox.FormattingEnabled = true;
            this.dataJobComboBox.Location = new System.Drawing.Point(19, 93);
            this.dataJobComboBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.dataJobComboBox.Name = "dataJobComboBox";
            this.dataJobComboBox.Size = new System.Drawing.Size(564, 39);
            this.dataJobComboBox.TabIndex = 36;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(13, 172);
            this.labelInterval.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(446, 32);
            this.labelInterval.TabIndex = 34;
            this.labelInterval.Text = "Delay between files uploads (sec.)";
            // 
            // numericUpDownIntervalUploads
            // 
            this.numericUpDownIntervalUploads.Location = new System.Drawing.Point(475, 166);
            this.numericUpDownIntervalUploads.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.numericUpDownIntervalUploads.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownIntervalUploads.Name = "numericUpDownIntervalUploads";
            this.numericUpDownIntervalUploads.Size = new System.Drawing.Size(117, 38);
            this.numericUpDownIntervalUploads.TabIndex = 35;
            this.numericUpDownIntervalUploads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LegalEntityLabel
            // 
            this.LegalEntityLabel.AutoSize = true;
            this.LegalEntityLabel.Location = new System.Drawing.Point(19, 255);
            this.LegalEntityLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.LegalEntityLabel.Name = "LegalEntityLabel";
            this.LegalEntityLabel.Size = new System.Drawing.Size(368, 32);
            this.LegalEntityLabel.TabIndex = 31;
            this.LegalEntityLabel.Text = "Target legal entity (optional)";
            // 
            // legalEntityTextBox
            // 
            this.legalEntityTextBox.Location = new System.Drawing.Point(400, 248);
            this.legalEntityTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.legalEntityTextBox.Name = "legalEntityTextBox";
            this.legalEntityTextBox.Size = new System.Drawing.Size(185, 38);
            this.legalEntityTextBox.TabIndex = 32;
            // 
            // fileSelectionGroupBox
            // 
            this.fileSelectionGroupBox.Controls.Add(this.isDataPackageCheckBox);
            this.fileSelectionGroupBox.Controls.Add(this.searchPatternLabel);
            this.fileSelectionGroupBox.Controls.Add(this.searchPatternTextBox);
            this.fileSelectionGroupBox.Controls.Add(this.orderByLabel);
            this.fileSelectionGroupBox.Controls.Add(this.orderByComboBox);
            this.fileSelectionGroupBox.Controls.Add(this.orderLabel);
            this.fileSelectionGroupBox.Controls.Add(this.orderByPanel);
            this.fileSelectionGroupBox.Location = new System.Drawing.Point(627, 9);
            this.fileSelectionGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.fileSelectionGroupBox.Name = "fileSelectionGroupBox";
            this.fileSelectionGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.fileSelectionGroupBox.Size = new System.Drawing.Size(659, 308);
            this.fileSelectionGroupBox.TabIndex = 39;
            this.fileSelectionGroupBox.TabStop = false;
            this.fileSelectionGroupBox.Text = "Files filter and order";
            // 
            // isDataPackageCheckBox
            // 
            this.isDataPackageCheckBox.AutoSize = true;
            this.isDataPackageCheckBox.Location = new System.Drawing.Point(13, 45);
            this.isDataPackageCheckBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.isDataPackageCheckBox.Name = "isDataPackageCheckBox";
            this.isDataPackageCheckBox.Size = new System.Drawing.Size(335, 36);
            this.isDataPackageCheckBox.TabIndex = 6;
            this.isDataPackageCheckBox.Text = "Input files are packages";
            this.isDataPackageCheckBox.UseVisualStyleBackColor = true;
            this.isDataPackageCheckBox.CheckedChanged += new System.EventHandler(this.IsDataPackageCheckBox_CheckedChanged);
            // 
            // searchPatternLabel
            // 
            this.searchPatternLabel.AutoSize = true;
            this.searchPatternLabel.Location = new System.Drawing.Point(19, 119);
            this.searchPatternLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchPatternLabel.Name = "searchPatternLabel";
            this.searchPatternLabel.Size = new System.Drawing.Size(369, 32);
            this.searchPatternLabel.TabIndex = 0;
            this.searchPatternLabel.Text = "Search pattern for input files";
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.Location = new System.Drawing.Point(389, 113);
            this.searchPatternTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(247, 38);
            this.searchPatternTextBox.TabIndex = 3;
            this.searchPatternTextBox.Text = "*.*";
            // 
            // orderByLabel
            // 
            this.orderByLabel.AutoSize = true;
            this.orderByLabel.Location = new System.Drawing.Point(19, 172);
            this.orderByLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.orderByLabel.Name = "orderByLabel";
            this.orderByLabel.Size = new System.Drawing.Size(123, 32);
            this.orderByLabel.TabIndex = 1;
            this.orderByLabel.Text = "Order by";
            // 
            // orderByComboBox
            // 
            this.orderByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByComboBox.FormattingEnabled = true;
            this.orderByComboBox.Location = new System.Drawing.Point(160, 166);
            this.orderByComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.orderByComboBox.Name = "orderByComboBox";
            this.orderByComboBox.Size = new System.Drawing.Size(477, 39);
            this.orderByComboBox.TabIndex = 5;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(19, 241);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(127, 32);
            this.orderLabel.TabIndex = 2;
            this.orderLabel.Text = "Direction";
            // 
            // orderByPanel
            // 
            this.orderByPanel.Controls.Add(this.orderAscendingRadioButton);
            this.orderByPanel.Controls.Add(this.orderDescendingRadioButton);
            this.orderByPanel.Location = new System.Drawing.Point(160, 228);
            this.orderByPanel.Margin = new System.Windows.Forms.Padding(0);
            this.orderByPanel.Name = "orderByPanel";
            this.orderByPanel.Size = new System.Drawing.Size(485, 57);
            this.orderByPanel.TabIndex = 4;
            // 
            // orderAscendingRadioButton
            // 
            this.orderAscendingRadioButton.AutoSize = true;
            this.orderAscendingRadioButton.Checked = true;
            this.orderAscendingRadioButton.Location = new System.Drawing.Point(19, 7);
            this.orderAscendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderAscendingRadioButton.Name = "orderAscendingRadioButton";
            this.orderAscendingRadioButton.Size = new System.Drawing.Size(169, 36);
            this.orderAscendingRadioButton.TabIndex = 0;
            this.orderAscendingRadioButton.TabStop = true;
            this.orderAscendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Ascending;
            this.orderAscendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderDescendingRadioButton
            // 
            this.orderDescendingRadioButton.AutoSize = true;
            this.orderDescendingRadioButton.Location = new System.Drawing.Point(229, 7);
            this.orderDescendingRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderDescendingRadioButton.Name = "orderDescendingRadioButton";
            this.orderDescendingRadioButton.Size = new System.Drawing.Size(186, 36);
            this.orderDescendingRadioButton.TabIndex = 1;
            this.orderDescendingRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Descending;
            this.orderDescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // uploadRecurrenceTabPage
            // 
            this.uploadRecurrenceTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.uploadRecurrenceTabPage.Controls.Add(this.upJobTriggerTypePanel);
            this.uploadRecurrenceTabPage.Controls.Add(this.simpleTriggerUploadJobGroupBox);
            this.uploadRecurrenceTabPage.Controls.Add(this.cronTriggerUploadJobGroupBox);
            this.uploadRecurrenceTabPage.Location = new System.Drawing.Point(4, 40);
            this.uploadRecurrenceTabPage.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.uploadRecurrenceTabPage.Name = "uploadRecurrenceTabPage";
            this.uploadRecurrenceTabPage.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.uploadRecurrenceTabPage.Size = new System.Drawing.Size(1896, 1238);
            this.uploadRecurrenceTabPage.TabIndex = 2;
            this.uploadRecurrenceTabPage.Text = "Upload job recurrence";
            // 
            // upJobTriggerTypePanel
            // 
            this.upJobTriggerTypePanel.Controls.Add(this.upJobSimpleTriggerRadioButton);
            this.upJobTriggerTypePanel.Controls.Add(this.upJobCronTriggerRadioButton);
            this.upJobTriggerTypePanel.Location = new System.Drawing.Point(13, 11);
            this.upJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.upJobTriggerTypePanel.Name = "upJobTriggerTypePanel";
            this.upJobTriggerTypePanel.Size = new System.Drawing.Size(1219, 60);
            this.upJobTriggerTypePanel.TabIndex = 29;
            // 
            // upJobSimpleTriggerRadioButton
            // 
            this.upJobSimpleTriggerRadioButton.AutoSize = true;
            this.upJobSimpleTriggerRadioButton.Checked = true;
            this.upJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(16, 7);
            this.upJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.upJobSimpleTriggerRadioButton.Name = "upJobSimpleTriggerRadioButton";
            this.upJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(211, 36);
            this.upJobSimpleTriggerRadioButton.TabIndex = 15;
            this.upJobSimpleTriggerRadioButton.TabStop = true;
            this.upJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.upJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // upJobCronTriggerRadioButton
            // 
            this.upJobCronTriggerRadioButton.AutoSize = true;
            this.upJobCronTriggerRadioButton.Location = new System.Drawing.Point(619, 7);
            this.upJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.upJobCronTriggerRadioButton.Name = "upJobCronTriggerRadioButton";
            this.upJobCronTriggerRadioButton.Size = new System.Drawing.Size(184, 36);
            this.upJobCronTriggerRadioButton.TabIndex = 16;
            this.upJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.upJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.upJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.UpJobCronTriggerRadioButton_CheckedChanged);
            // 
            // simpleTriggerUploadJobGroupBox
            // 
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.runEveryUploadJobLabel);
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.upJobHoursDateTimePicker);
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.upJobHoursLabel);
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.importJobAndOrLabel);
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.upJobMinutesDateTimePicker);
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.upJobMinutesLabel);
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.upJobStartAtLabel);
            this.simpleTriggerUploadJobGroupBox.Controls.Add(this.upJobStartAtDateTimePicker);
            this.simpleTriggerUploadJobGroupBox.Location = new System.Drawing.Point(13, 84);
            this.simpleTriggerUploadJobGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.simpleTriggerUploadJobGroupBox.Name = "simpleTriggerUploadJobGroupBox";
            this.simpleTriggerUploadJobGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.simpleTriggerUploadJobGroupBox.Size = new System.Drawing.Size(587, 200);
            this.simpleTriggerUploadJobGroupBox.TabIndex = 30;
            this.simpleTriggerUploadJobGroupBox.TabStop = false;
            // 
            // runEveryUploadJobLabel
            // 
            this.runEveryUploadJobLabel.AutoSize = true;
            this.runEveryUploadJobLabel.Location = new System.Drawing.Point(9, 33);
            this.runEveryUploadJobLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.runEveryUploadJobLabel.Name = "runEveryUploadJobLabel";
            this.runEveryUploadJobLabel.Size = new System.Drawing.Size(212, 32);
            this.runEveryUploadJobLabel.TabIndex = 15;
            this.runEveryUploadJobLabel.Text = "Run job every...";
            // 
            // upJobHoursDateTimePicker
            // 
            this.upJobHoursDateTimePicker.CustomFormat = "HH";
            this.upJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobHoursDateTimePicker.Location = new System.Drawing.Point(233, 24);
            this.upJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.upJobHoursDateTimePicker.Name = "upJobHoursDateTimePicker";
            this.upJobHoursDateTimePicker.ShowUpDown = true;
            this.upJobHoursDateTimePicker.Size = new System.Drawing.Size(109, 38);
            this.upJobHoursDateTimePicker.TabIndex = 12;
            this.upJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // upJobHoursLabel
            // 
            this.upJobHoursLabel.AutoSize = true;
            this.upJobHoursLabel.Location = new System.Drawing.Point(349, 33);
            this.upJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.upJobHoursLabel.Name = "upJobHoursLabel";
            this.upJobHoursLabel.Size = new System.Drawing.Size(103, 32);
            this.upJobHoursLabel.TabIndex = 4;
            this.upJobHoursLabel.Text = "hour(s)";
            this.upJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // importJobAndOrLabel
            // 
            this.importJobAndOrLabel.AutoSize = true;
            this.importJobAndOrLabel.Location = new System.Drawing.Point(123, 86);
            this.importJobAndOrLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.importJobAndOrLabel.Name = "importJobAndOrLabel";
            this.importJobAndOrLabel.Size = new System.Drawing.Size(95, 32);
            this.importJobAndOrLabel.TabIndex = 16;
            this.importJobAndOrLabel.Text = "and/or";
            // 
            // upJobMinutesDateTimePicker
            // 
            this.upJobMinutesDateTimePicker.CustomFormat = "mm";
            this.upJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobMinutesDateTimePicker.Location = new System.Drawing.Point(233, 76);
            this.upJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.upJobMinutesDateTimePicker.Name = "upJobMinutesDateTimePicker";
            this.upJobMinutesDateTimePicker.ShowUpDown = true;
            this.upJobMinutesDateTimePicker.Size = new System.Drawing.Size(109, 38);
            this.upJobMinutesDateTimePicker.TabIndex = 13;
            this.upJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 1, 0, 0);
            // 
            // upJobMinutesLabel
            // 
            this.upJobMinutesLabel.AutoSize = true;
            this.upJobMinutesLabel.Location = new System.Drawing.Point(349, 86);
            this.upJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.upJobMinutesLabel.Name = "upJobMinutesLabel";
            this.upJobMinutesLabel.Size = new System.Drawing.Size(132, 32);
            this.upJobMinutesLabel.TabIndex = 5;
            this.upJobMinutesLabel.Text = "minute(s)";
            this.upJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobStartAtLabel
            // 
            this.upJobStartAtLabel.AutoSize = true;
            this.upJobStartAtLabel.Location = new System.Drawing.Point(75, 135);
            this.upJobStartAtLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.upJobStartAtLabel.Name = "upJobStartAtLabel";
            this.upJobStartAtLabel.Size = new System.Drawing.Size(139, 32);
            this.upJobStartAtLabel.TabIndex = 3;
            this.upJobStartAtLabel.Text = "starting at";
            this.upJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upJobStartAtDateTimePicker
            // 
            this.upJobStartAtDateTimePicker.CustomFormat = "HH:mm:ss";
            this.upJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.upJobStartAtDateTimePicker.Location = new System.Drawing.Point(233, 129);
            this.upJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.upJobStartAtDateTimePicker.Name = "upJobStartAtDateTimePicker";
            this.upJobStartAtDateTimePicker.ShowUpDown = true;
            this.upJobStartAtDateTimePicker.Size = new System.Drawing.Size(187, 38);
            this.upJobStartAtDateTimePicker.TabIndex = 14;
            this.upJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // cronTriggerUploadJobGroupBox
            // 
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.upJobCronExpressionLabel);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.upJobCronExpressionTextBox);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.cronTriggerInfoTextBox);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.buildCronLabel);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.cronmakerLinkLabel);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.cronDocsLinkLabel);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.getCronScheduleForUploadButton);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.calculatedRunsTextBox);
            this.cronTriggerUploadJobGroupBox.Controls.Add(this.moreExamplesButton);
            this.cronTriggerUploadJobGroupBox.Enabled = false;
            this.cronTriggerUploadJobGroupBox.Location = new System.Drawing.Point(611, 84);
            this.cronTriggerUploadJobGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cronTriggerUploadJobGroupBox.Name = "cronTriggerUploadJobGroupBox";
            this.cronTriggerUploadJobGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cronTriggerUploadJobGroupBox.Size = new System.Drawing.Size(624, 817);
            this.cronTriggerUploadJobGroupBox.TabIndex = 3;
            this.cronTriggerUploadJobGroupBox.TabStop = false;
            // 
            // upJobCronExpressionLabel
            // 
            this.upJobCronExpressionLabel.AutoSize = true;
            this.upJobCronExpressionLabel.Location = new System.Drawing.Point(16, 33);
            this.upJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.upJobCronExpressionLabel.Name = "upJobCronExpressionLabel";
            this.upJobCronExpressionLabel.Size = new System.Drawing.Size(220, 32);
            this.upJobCronExpressionLabel.TabIndex = 23;
            this.upJobCronExpressionLabel.Text = "Cron expression";
            // 
            // upJobCronExpressionTextBox
            // 
            this.upJobCronExpressionTextBox.Location = new System.Drawing.Point(25, 69);
            this.upJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.upJobCronExpressionTextBox.Name = "upJobCronExpressionTextBox";
            this.upJobCronExpressionTextBox.Size = new System.Drawing.Size(567, 38);
            this.upJobCronExpressionTextBox.TabIndex = 17;
            this.upJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // cronTriggerInfoTextBox
            // 
            this.cronTriggerInfoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cronTriggerInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cronTriggerInfoTextBox.Location = new System.Drawing.Point(25, 122);
            this.cronTriggerInfoTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cronTriggerInfoTextBox.Multiline = true;
            this.cronTriggerInfoTextBox.Name = "cronTriggerInfoTextBox";
            this.cronTriggerInfoTextBox.Size = new System.Drawing.Size(573, 350);
            this.cronTriggerInfoTextBox.TabIndex = 25;
            this.cronTriggerInfoTextBox.TabStop = false;
            this.cronTriggerInfoTextBox.Text = resources.GetString("cronTriggerInfoTextBox.Text");
            // 
            // buildCronLabel
            // 
            this.buildCronLabel.AutoSize = true;
            this.buildCronLabel.Location = new System.Drawing.Point(16, 479);
            this.buildCronLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.buildCronLabel.Name = "buildCronLabel";
            this.buildCronLabel.Size = new System.Drawing.Size(317, 32);
            this.buildCronLabel.TabIndex = 26;
            this.buildCronLabel.Text = "Build cron expression at";
            // 
            // cronmakerLinkLabel
            // 
            this.cronmakerLinkLabel.AutoSize = true;
            this.cronmakerLinkLabel.Location = new System.Drawing.Point(336, 479);
            this.cronmakerLinkLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.cronmakerLinkLabel.Name = "cronmakerLinkLabel";
            this.cronmakerLinkLabel.Size = new System.Drawing.Size(208, 32);
            this.cronmakerLinkLabel.TabIndex = 24;
            this.cronmakerLinkLabel.TabStop = true;
            this.cronmakerLinkLabel.Text = "cronmaker.com";
            this.cronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // cronDocsLinkLabel
            // 
            this.cronDocsLinkLabel.AutoSize = true;
            this.cronDocsLinkLabel.Location = new System.Drawing.Point(16, 525);
            this.cronDocsLinkLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.cronDocsLinkLabel.Name = "cronDocsLinkLabel";
            this.cronDocsLinkLabel.Size = new System.Drawing.Size(458, 32);
            this.cronDocsLinkLabel.TabIndex = 30;
            this.cronDocsLinkLabel.TabStop = true;
            this.cronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.cronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // getCronScheduleForUploadButton
            // 
            this.getCronScheduleForUploadButton.Location = new System.Drawing.Point(25, 572);
            this.getCronScheduleForUploadButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.getCronScheduleForUploadButton.Name = "getCronScheduleForUploadButton";
            this.getCronScheduleForUploadButton.Size = new System.Drawing.Size(281, 86);
            this.getCronScheduleForUploadButton.TabIndex = 18;
            this.getCronScheduleForUploadButton.Text = "Calculate next 100 runs of cron trigger";
            this.getCronScheduleForUploadButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForUploadButton.Click += new System.EventHandler(this.GetCronScheduleForUploadButton_Click);
            // 
            // calculatedRunsTextBox
            // 
            this.calculatedRunsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsTextBox.Location = new System.Drawing.Point(25, 668);
            this.calculatedRunsTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.calculatedRunsTextBox.Multiline = true;
            this.calculatedRunsTextBox.Name = "calculatedRunsTextBox";
            this.calculatedRunsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsTextBox.Size = new System.Drawing.Size(381, 126);
            this.calculatedRunsTextBox.TabIndex = 32;
            this.calculatedRunsTextBox.TabStop = false;
            // 
            // moreExamplesButton
            // 
            this.moreExamplesButton.Location = new System.Drawing.Point(421, 668);
            this.moreExamplesButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.moreExamplesButton.Name = "moreExamplesButton";
            this.moreExamplesButton.Size = new System.Drawing.Size(176, 131);
            this.moreExamplesButton.TabIndex = 19;
            this.moreExamplesButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesButton.UseVisualStyleBackColor = true;
            this.moreExamplesButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
            // 
            // monitoringJobTabPage
            // 
            this.monitoringJobTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.monitoringJobTabPage.Controls.Add(this.useMonitoringJobCheckBox);
            this.monitoringJobTabPage.Controls.Add(this.processingJobGroupBox);
            this.monitoringJobTabPage.Location = new System.Drawing.Point(4, 40);
            this.monitoringJobTabPage.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.monitoringJobTabPage.Name = "monitoringJobTabPage";
            this.monitoringJobTabPage.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.monitoringJobTabPage.Size = new System.Drawing.Size(1896, 1238);
            this.monitoringJobTabPage.TabIndex = 3;
            this.monitoringJobTabPage.Text = "Processing monitoring job";
            // 
            // useMonitoringJobCheckBox
            // 
            this.useMonitoringJobCheckBox.AutoSize = true;
            this.useMonitoringJobCheckBox.Location = new System.Drawing.Point(13, 11);
            this.useMonitoringJobCheckBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.useMonitoringJobCheckBox.Name = "useMonitoringJobCheckBox";
            this.useMonitoringJobCheckBox.Size = new System.Drawing.Size(419, 36);
            this.useMonitoringJobCheckBox.TabIndex = 28;
            this.useMonitoringJobCheckBox.Text = "Add processing monitoring job";
            this.useMonitoringJobCheckBox.UseVisualStyleBackColor = true;
            this.useMonitoringJobCheckBox.CheckedChanged += new System.EventHandler(this.UseMonitoringJobCheckBox_CheckedChanged);
            // 
            // processingJobGroupBox
            // 
            this.processingJobGroupBox.Controls.Add(this.getExecutionErrorsCheckBox);
            this.processingJobGroupBox.Controls.Add(this.delayBetweenStatusCheckLabel);
            this.processingJobGroupBox.Controls.Add(this.delayBetweenStatusCheckNumericUpDown);
            this.processingJobGroupBox.Controls.Add(this.statusFileExtensionLabel);
            this.processingJobGroupBox.Controls.Add(this.statusFileExtensionTextBox);
            this.processingJobGroupBox.Controls.Add(this.procJobTriggerTypePanel);
            this.processingJobGroupBox.Controls.Add(this.simpleTriggerMonitoringJobGroupBox);
            this.processingJobGroupBox.Controls.Add(this.cronTriggerMonitoringJobGroupBox);
            this.processingJobGroupBox.Enabled = false;
            this.processingJobGroupBox.Location = new System.Drawing.Point(13, 67);
            this.processingJobGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.processingJobGroupBox.Name = "processingJobGroupBox";
            this.processingJobGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.processingJobGroupBox.Size = new System.Drawing.Size(1251, 1102);
            this.processingJobGroupBox.TabIndex = 29;
            this.processingJobGroupBox.TabStop = false;
            // 
            // getExecutionErrorsCheckBox
            // 
            this.getExecutionErrorsCheckBox.AutoSize = true;
            this.getExecutionErrorsCheckBox.Location = new System.Drawing.Point(635, 42);
            this.getExecutionErrorsCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.getExecutionErrorsCheckBox.Name = "getExecutionErrorsCheckBox";
            this.getExecutionErrorsCheckBox.Size = new System.Drawing.Size(529, 36);
            this.getExecutionErrorsCheckBox.TabIndex = 43;
            this.getExecutionErrorsCheckBox.Text = "Retrieve execution errors in json format";
            this.getExecutionErrorsCheckBox.UseVisualStyleBackColor = true;
            this.getExecutionErrorsCheckBox.Visible = false;
            // 
            // delayBetweenStatusCheckLabel
            // 
            this.delayBetweenStatusCheckLabel.AutoSize = true;
            this.delayBetweenStatusCheckLabel.Location = new System.Drawing.Point(16, 42);
            this.delayBetweenStatusCheckLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.delayBetweenStatusCheckLabel.Name = "delayBetweenStatusCheckLabel";
            this.delayBetweenStatusCheckLabel.Size = new System.Drawing.Size(435, 32);
            this.delayBetweenStatusCheckLabel.TabIndex = 39;
            this.delayBetweenStatusCheckLabel.Text = "Delay between status check (sec)";
            // 
            // delayBetweenStatusCheckNumericUpDown
            // 
            this.delayBetweenStatusCheckNumericUpDown.Location = new System.Drawing.Point(473, 40);
            this.delayBetweenStatusCheckNumericUpDown.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.delayBetweenStatusCheckNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.delayBetweenStatusCheckNumericUpDown.Name = "delayBetweenStatusCheckNumericUpDown";
            this.delayBetweenStatusCheckNumericUpDown.Size = new System.Drawing.Size(123, 38);
            this.delayBetweenStatusCheckNumericUpDown.TabIndex = 40;
            this.delayBetweenStatusCheckNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // statusFileExtensionLabel
            // 
            this.statusFileExtensionLabel.AutoSize = true;
            this.statusFileExtensionLabel.Location = new System.Drawing.Point(19, 110);
            this.statusFileExtensionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.statusFileExtensionLabel.Name = "statusFileExtensionLabel";
            this.statusFileExtensionLabel.Size = new System.Drawing.Size(270, 32);
            this.statusFileExtensionLabel.TabIndex = 26;
            this.statusFileExtensionLabel.Text = "Status file extension";
            // 
            // statusFileExtensionTextBox
            // 
            this.statusFileExtensionTextBox.Location = new System.Drawing.Point(304, 102);
            this.statusFileExtensionTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.statusFileExtensionTextBox.Name = "statusFileExtensionTextBox";
            this.statusFileExtensionTextBox.Size = new System.Drawing.Size(145, 38);
            this.statusFileExtensionTextBox.TabIndex = 27;
            this.statusFileExtensionTextBox.Text = ".Status";
            this.statusFileExtensionTextBox.Leave += new System.EventHandler(this.StatusFileExtensionTextBox_Leave);
            // 
            // procJobTriggerTypePanel
            // 
            this.procJobTriggerTypePanel.Controls.Add(this.procJobSimpleTriggerRadioButton);
            this.procJobTriggerTypePanel.Controls.Add(this.procJobCronTriggerRadioButton);
            this.procJobTriggerTypePanel.Location = new System.Drawing.Point(16, 191);
            this.procJobTriggerTypePanel.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.procJobTriggerTypePanel.Name = "procJobTriggerTypePanel";
            this.procJobTriggerTypePanel.Size = new System.Drawing.Size(1219, 60);
            this.procJobTriggerTypePanel.TabIndex = 38;
            // 
            // procJobSimpleTriggerRadioButton
            // 
            this.procJobSimpleTriggerRadioButton.AutoSize = true;
            this.procJobSimpleTriggerRadioButton.Checked = true;
            this.procJobSimpleTriggerRadioButton.Location = new System.Drawing.Point(11, 7);
            this.procJobSimpleTriggerRadioButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.procJobSimpleTriggerRadioButton.Name = "procJobSimpleTriggerRadioButton";
            this.procJobSimpleTriggerRadioButton.Size = new System.Drawing.Size(211, 36);
            this.procJobSimpleTriggerRadioButton.TabIndex = 15;
            this.procJobSimpleTriggerRadioButton.TabStop = true;
            this.procJobSimpleTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Simple_trigger;
            this.procJobSimpleTriggerRadioButton.UseVisualStyleBackColor = true;
            // 
            // procJobCronTriggerRadioButton
            // 
            this.procJobCronTriggerRadioButton.AutoSize = true;
            this.procJobCronTriggerRadioButton.Location = new System.Drawing.Point(619, 7);
            this.procJobCronTriggerRadioButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.procJobCronTriggerRadioButton.Name = "procJobCronTriggerRadioButton";
            this.procJobCronTriggerRadioButton.Size = new System.Drawing.Size(184, 36);
            this.procJobCronTriggerRadioButton.TabIndex = 16;
            this.procJobCronTriggerRadioButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.Cron_trigger;
            this.procJobCronTriggerRadioButton.UseVisualStyleBackColor = true;
            this.procJobCronTriggerRadioButton.CheckedChanged += new System.EventHandler(this.ProcJobCronTriggerRadioButton_CheckedChanged);
            // 
            // simpleTriggerMonitoringJobGroupBox
            // 
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.runEveryMonitoringJobLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.procJobHoursDateTimePicker);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.procJobHoursLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.andOrMonitoringJobLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.procJobMinutesDateTimePicker);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.procJobMinutesLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.procJobStartAtLabel);
            this.simpleTriggerMonitoringJobGroupBox.Controls.Add(this.procJobStartAtDateTimePicker);
            this.simpleTriggerMonitoringJobGroupBox.Location = new System.Drawing.Point(16, 259);
            this.simpleTriggerMonitoringJobGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.simpleTriggerMonitoringJobGroupBox.Name = "simpleTriggerMonitoringJobGroupBox";
            this.simpleTriggerMonitoringJobGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.simpleTriggerMonitoringJobGroupBox.Size = new System.Drawing.Size(587, 200);
            this.simpleTriggerMonitoringJobGroupBox.TabIndex = 41;
            this.simpleTriggerMonitoringJobGroupBox.TabStop = false;
            // 
            // runEveryMonitoringJobLabel
            // 
            this.runEveryMonitoringJobLabel.AutoSize = true;
            this.runEveryMonitoringJobLabel.Location = new System.Drawing.Point(27, 33);
            this.runEveryMonitoringJobLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.runEveryMonitoringJobLabel.Name = "runEveryMonitoringJobLabel";
            this.runEveryMonitoringJobLabel.Size = new System.Drawing.Size(212, 32);
            this.runEveryMonitoringJobLabel.TabIndex = 0;
            this.runEveryMonitoringJobLabel.Text = "Run job every...";
            // 
            // procJobHoursDateTimePicker
            // 
            this.procJobHoursDateTimePicker.CustomFormat = "HH";
            this.procJobHoursDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobHoursDateTimePicker.Location = new System.Drawing.Point(245, 26);
            this.procJobHoursDateTimePicker.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.procJobHoursDateTimePicker.Name = "procJobHoursDateTimePicker";
            this.procJobHoursDateTimePicker.ShowUpDown = true;
            this.procJobHoursDateTimePicker.Size = new System.Drawing.Size(109, 38);
            this.procJobHoursDateTimePicker.TabIndex = 33;
            this.procJobHoursDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // procJobHoursLabel
            // 
            this.procJobHoursLabel.AutoSize = true;
            this.procJobHoursLabel.Location = new System.Drawing.Point(363, 33);
            this.procJobHoursLabel.Margin = new System.Windows.Forms.Padding(0);
            this.procJobHoursLabel.Name = "procJobHoursLabel";
            this.procJobHoursLabel.Size = new System.Drawing.Size(103, 32);
            this.procJobHoursLabel.TabIndex = 31;
            this.procJobHoursLabel.Text = "hour(s)";
            this.procJobHoursLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // andOrMonitoringJobLabel
            // 
            this.andOrMonitoringJobLabel.AutoSize = true;
            this.andOrMonitoringJobLabel.Location = new System.Drawing.Point(139, 82);
            this.andOrMonitoringJobLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.andOrMonitoringJobLabel.Name = "andOrMonitoringJobLabel";
            this.andOrMonitoringJobLabel.Size = new System.Drawing.Size(95, 32);
            this.andOrMonitoringJobLabel.TabIndex = 34;
            this.andOrMonitoringJobLabel.Text = "and/or";
            // 
            // procJobMinutesDateTimePicker
            // 
            this.procJobMinutesDateTimePicker.CustomFormat = "mm";
            this.procJobMinutesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobMinutesDateTimePicker.Location = new System.Drawing.Point(245, 82);
            this.procJobMinutesDateTimePicker.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.procJobMinutesDateTimePicker.Name = "procJobMinutesDateTimePicker";
            this.procJobMinutesDateTimePicker.ShowUpDown = true;
            this.procJobMinutesDateTimePicker.Size = new System.Drawing.Size(109, 38);
            this.procJobMinutesDateTimePicker.TabIndex = 34;
            this.procJobMinutesDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 30, 0, 0);
            // 
            // procJobMinutesLabel
            // 
            this.procJobMinutesLabel.AutoSize = true;
            this.procJobMinutesLabel.Location = new System.Drawing.Point(363, 86);
            this.procJobMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.procJobMinutesLabel.Name = "procJobMinutesLabel";
            this.procJobMinutesLabel.Size = new System.Drawing.Size(132, 32);
            this.procJobMinutesLabel.TabIndex = 32;
            this.procJobMinutesLabel.Text = "minute(s)";
            this.procJobMinutesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobStartAtLabel
            // 
            this.procJobStartAtLabel.AutoSize = true;
            this.procJobStartAtLabel.Location = new System.Drawing.Point(99, 133);
            this.procJobStartAtLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.procJobStartAtLabel.Name = "procJobStartAtLabel";
            this.procJobStartAtLabel.Size = new System.Drawing.Size(139, 32);
            this.procJobStartAtLabel.TabIndex = 30;
            this.procJobStartAtLabel.Text = "starting at";
            this.procJobStartAtLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // procJobStartAtDateTimePicker
            // 
            this.procJobStartAtDateTimePicker.CustomFormat = "HH:mm:ss";
            this.procJobStartAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.procJobStartAtDateTimePicker.Location = new System.Drawing.Point(245, 133);
            this.procJobStartAtDateTimePicker.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.procJobStartAtDateTimePicker.Name = "procJobStartAtDateTimePicker";
            this.procJobStartAtDateTimePicker.ShowUpDown = true;
            this.procJobStartAtDateTimePicker.Size = new System.Drawing.Size(187, 38);
            this.procJobStartAtDateTimePicker.TabIndex = 35;
            this.procJobStartAtDateTimePicker.Value = new System.DateTime(2016, 6, 26, 0, 0, 0, 0);
            // 
            // cronTriggerMonitoringJobGroupBox
            // 
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.procJobCronExpressionLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.procJobCronExpressionTextBox);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringCronTextBox);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobBuildCronLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobCronmakerLinkLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.monitoringJobCronDocsLinkLabel);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.getCronScheduleForMonitoringButton);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.calculatedRunsMonitoringTextBox);
            this.cronTriggerMonitoringJobGroupBox.Controls.Add(this.moreExamplesMonitoringButton);
            this.cronTriggerMonitoringJobGroupBox.Enabled = false;
            this.cronTriggerMonitoringJobGroupBox.Location = new System.Drawing.Point(611, 259);
            this.cronTriggerMonitoringJobGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cronTriggerMonitoringJobGroupBox.Name = "cronTriggerMonitoringJobGroupBox";
            this.cronTriggerMonitoringJobGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.cronTriggerMonitoringJobGroupBox.Size = new System.Drawing.Size(624, 826);
            this.cronTriggerMonitoringJobGroupBox.TabIndex = 42;
            this.cronTriggerMonitoringJobGroupBox.TabStop = false;
            // 
            // procJobCronExpressionLabel
            // 
            this.procJobCronExpressionLabel.AutoSize = true;
            this.procJobCronExpressionLabel.Location = new System.Drawing.Point(16, 33);
            this.procJobCronExpressionLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.procJobCronExpressionLabel.Name = "procJobCronExpressionLabel";
            this.procJobCronExpressionLabel.Size = new System.Drawing.Size(220, 32);
            this.procJobCronExpressionLabel.TabIndex = 37;
            this.procJobCronExpressionLabel.Text = "Cron expression";
            // 
            // procJobCronExpressionTextBox
            // 
            this.procJobCronExpressionTextBox.Location = new System.Drawing.Point(25, 76);
            this.procJobCronExpressionTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.procJobCronExpressionTextBox.Name = "procJobCronExpressionTextBox";
            this.procJobCronExpressionTextBox.Size = new System.Drawing.Size(567, 38);
            this.procJobCronExpressionTextBox.TabIndex = 36;
            this.procJobCronExpressionTextBox.Text = "0 0/15 8-18 ? * MON-FRI *";
            // 
            // monitoringCronTextBox
            // 
            this.monitoringCronTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.monitoringCronTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monitoringCronTextBox.Location = new System.Drawing.Point(25, 133);
            this.monitoringCronTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.monitoringCronTextBox.Multiline = true;
            this.monitoringCronTextBox.Name = "monitoringCronTextBox";
            this.monitoringCronTextBox.Size = new System.Drawing.Size(573, 350);
            this.monitoringCronTextBox.TabIndex = 38;
            this.monitoringCronTextBox.TabStop = false;
            this.monitoringCronTextBox.Text = resources.GetString("monitoringCronTextBox.Text");
            // 
            // monitoringJobBuildCronLabel
            // 
            this.monitoringJobBuildCronLabel.AutoSize = true;
            this.monitoringJobBuildCronLabel.Location = new System.Drawing.Point(16, 491);
            this.monitoringJobBuildCronLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.monitoringJobBuildCronLabel.Name = "monitoringJobBuildCronLabel";
            this.monitoringJobBuildCronLabel.Size = new System.Drawing.Size(317, 32);
            this.monitoringJobBuildCronLabel.TabIndex = 39;
            this.monitoringJobBuildCronLabel.Text = "Build cron expression at";
            // 
            // monitoringJobCronmakerLinkLabel
            // 
            this.monitoringJobCronmakerLinkLabel.AutoSize = true;
            this.monitoringJobCronmakerLinkLabel.Location = new System.Drawing.Point(349, 491);
            this.monitoringJobCronmakerLinkLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.monitoringJobCronmakerLinkLabel.Name = "monitoringJobCronmakerLinkLabel";
            this.monitoringJobCronmakerLinkLabel.Size = new System.Drawing.Size(208, 32);
            this.monitoringJobCronmakerLinkLabel.TabIndex = 40;
            this.monitoringJobCronmakerLinkLabel.TabStop = true;
            this.monitoringJobCronmakerLinkLabel.Text = "cronmaker.com";
            this.monitoringJobCronmakerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronmakerLinkLabel_LinkClicked);
            // 
            // monitoringJobCronDocsLinkLabel
            // 
            this.monitoringJobCronDocsLinkLabel.AutoSize = true;
            this.monitoringJobCronDocsLinkLabel.Location = new System.Drawing.Point(16, 534);
            this.monitoringJobCronDocsLinkLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.monitoringJobCronDocsLinkLabel.Name = "monitoringJobCronDocsLinkLabel";
            this.monitoringJobCronDocsLinkLabel.Size = new System.Drawing.Size(458, 32);
            this.monitoringJobCronDocsLinkLabel.TabIndex = 41;
            this.monitoringJobCronDocsLinkLabel.TabStop = true;
            this.monitoringJobCronDocsLinkLabel.Text = "Quartz cron triggers documentation";
            this.monitoringJobCronDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CronDocsLinkLabel_LinkClicked);
            // 
            // getCronScheduleForMonitoringButton
            // 
            this.getCronScheduleForMonitoringButton.Location = new System.Drawing.Point(25, 584);
            this.getCronScheduleForMonitoringButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.getCronScheduleForMonitoringButton.Name = "getCronScheduleForMonitoringButton";
            this.getCronScheduleForMonitoringButton.Size = new System.Drawing.Size(281, 86);
            this.getCronScheduleForMonitoringButton.TabIndex = 43;
            this.getCronScheduleForMonitoringButton.Text = "Get cron schedule for monitoring job ";
            this.getCronScheduleForMonitoringButton.UseVisualStyleBackColor = true;
            this.getCronScheduleForMonitoringButton.Click += new System.EventHandler(this.GetCronScheduleForProcButton_Click);
            // 
            // calculatedRunsMonitoringTextBox
            // 
            this.calculatedRunsMonitoringTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculatedRunsMonitoringTextBox.Location = new System.Drawing.Point(25, 680);
            this.calculatedRunsMonitoringTextBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.calculatedRunsMonitoringTextBox.Multiline = true;
            this.calculatedRunsMonitoringTextBox.Name = "calculatedRunsMonitoringTextBox";
            this.calculatedRunsMonitoringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.calculatedRunsMonitoringTextBox.Size = new System.Drawing.Size(381, 126);
            this.calculatedRunsMonitoringTextBox.TabIndex = 42;
            this.calculatedRunsMonitoringTextBox.TabStop = false;
            // 
            // moreExamplesMonitoringButton
            // 
            this.moreExamplesMonitoringButton.Location = new System.Drawing.Point(421, 680);
            this.moreExamplesMonitoringButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.moreExamplesMonitoringButton.Name = "moreExamplesMonitoringButton";
            this.moreExamplesMonitoringButton.Size = new System.Drawing.Size(176, 131);
            this.moreExamplesMonitoringButton.TabIndex = 44;
            this.moreExamplesMonitoringButton.Text = global::RecurringIntegrationsScheduler.Properties.Resources.More_examples;
            this.moreExamplesMonitoringButton.UseVisualStyleBackColor = true;
            this.moreExamplesMonitoringButton.Click += new System.EventHandler(this.MoreExamplesButton_Click);
            // 
            // connectionTabPage
            // 
            this.connectionTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.connectionTabPage.Controls.Add(this.axDetailsGroupBox);
            this.connectionTabPage.Location = new System.Drawing.Point(4, 40);
            this.connectionTabPage.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.connectionTabPage.Name = "connectionTabPage";
            this.connectionTabPage.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.connectionTabPage.Size = new System.Drawing.Size(1896, 1238);
            this.connectionTabPage.TabIndex = 4;
            this.connectionTabPage.Text = "Connection";
            // 
            // axDetailsGroupBox
            // 
            this.axDetailsGroupBox.Controls.Add(this.instanceLabel);
            this.axDetailsGroupBox.Controls.Add(this.instanceComboBox);
            this.axDetailsGroupBox.Controls.Add(this.authMethodPanel);
            this.axDetailsGroupBox.Controls.Add(this.aadApplicationLabel);
            this.axDetailsGroupBox.Controls.Add(this.appRegistrationComboBox);
            this.axDetailsGroupBox.Controls.Add(this.userLabel);
            this.axDetailsGroupBox.Controls.Add(this.userComboBox);
            this.axDetailsGroupBox.Location = new System.Drawing.Point(11, 9);
            this.axDetailsGroupBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.axDetailsGroupBox.Name = "axDetailsGroupBox";
            this.axDetailsGroupBox.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.axDetailsGroupBox.Size = new System.Drawing.Size(704, 312);
            this.axDetailsGroupBox.TabIndex = 2;
            this.axDetailsGroupBox.TabStop = false;
            this.axDetailsGroupBox.Text = "Dynamics connection details";
            // 
            // instanceLabel
            // 
            this.instanceLabel.AutoSize = true;
            this.instanceLabel.Location = new System.Drawing.Point(19, 51);
            this.instanceLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.instanceLabel.Name = "instanceLabel";
            this.instanceLabel.Size = new System.Drawing.Size(121, 32);
            this.instanceLabel.TabIndex = 16;
            this.instanceLabel.Text = "Instance";
            // 
            // instanceComboBox
            // 
            this.instanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instanceComboBox.FormattingEnabled = true;
            this.instanceComboBox.Location = new System.Drawing.Point(157, 45);
            this.instanceComboBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.instanceComboBox.Name = "instanceComboBox";
            this.instanceComboBox.Size = new System.Drawing.Size(529, 39);
            this.instanceComboBox.TabIndex = 9;
            // 
            // authMethodPanel
            // 
            this.authMethodPanel.Controls.Add(this.serviceAuthRadioButton);
            this.authMethodPanel.Controls.Add(this.userAuthRadioButton);
            this.authMethodPanel.Location = new System.Drawing.Point(19, 107);
            this.authMethodPanel.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.authMethodPanel.Name = "authMethodPanel";
            this.authMethodPanel.Size = new System.Drawing.Size(675, 60);
            this.authMethodPanel.TabIndex = 30;
            // 
            // serviceAuthRadioButton
            // 
            this.serviceAuthRadioButton.AutoSize = true;
            this.serviceAuthRadioButton.Location = new System.Drawing.Point(320, 7);
            this.serviceAuthRadioButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.serviceAuthRadioButton.Name = "serviceAuthRadioButton";
            this.serviceAuthRadioButton.Size = new System.Drawing.Size(317, 36);
            this.serviceAuthRadioButton.TabIndex = 16;
            this.serviceAuthRadioButton.Text = "Service authentication";
            this.serviceAuthRadioButton.UseVisualStyleBackColor = true;
            this.serviceAuthRadioButton.CheckedChanged += new System.EventHandler(this.ServiceAuthRadioButton_CheckedChanged);
            // 
            // userAuthRadioButton
            // 
            this.userAuthRadioButton.AutoSize = true;
            this.userAuthRadioButton.Checked = true;
            this.userAuthRadioButton.Location = new System.Drawing.Point(9, 7);
            this.userAuthRadioButton.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.userAuthRadioButton.Name = "userAuthRadioButton";
            this.userAuthRadioButton.Size = new System.Drawing.Size(281, 36);
            this.userAuthRadioButton.TabIndex = 15;
            this.userAuthRadioButton.TabStop = true;
            this.userAuthRadioButton.Text = "User authentication";
            this.userAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // aadApplicationLabel
            // 
            this.aadApplicationLabel.AutoSize = true;
            this.aadApplicationLabel.Location = new System.Drawing.Point(25, 188);
            this.aadApplicationLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.aadApplicationLabel.Name = "aadApplicationLabel";
            this.aadApplicationLabel.Size = new System.Drawing.Size(292, 32);
            this.aadApplicationLabel.TabIndex = 32;
            this.aadApplicationLabel.Text = "Azure app registration";
            // 
            // appRegistrationComboBox
            // 
            this.appRegistrationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appRegistrationComboBox.FormattingEnabled = true;
            this.appRegistrationComboBox.Location = new System.Drawing.Point(329, 181);
            this.appRegistrationComboBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.appRegistrationComboBox.Name = "appRegistrationComboBox";
            this.appRegistrationComboBox.Size = new System.Drawing.Size(359, 39);
            this.appRegistrationComboBox.TabIndex = 31;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(240, 246);
            this.userLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(73, 32);
            this.userLabel.TabIndex = 19;
            this.userLabel.Text = "User";
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(329, 241);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(359, 39);
            this.userComboBox.TabIndex = 10;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripButton,
            this.addToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 1286);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1904, 27);
            this.mainToolStrip.TabIndex = 6;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelToolStripButton.Image")));
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(57, 24);
            this.cancelToolStripButton.Text = "Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.CancelToolStripButton_Click);
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(67, 24);
            this.addToolStripButton.Text = "Add job";
            this.addToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // getLegalEntityFromFilenameCheckbox
            // 
            this.getLegalEntityFromFilenameCheckbox.AutoSize = true;
            this.getLegalEntityFromFilenameCheckbox.Location = new System.Drawing.Point(29, 304);
            this.getLegalEntityFromFilenameCheckbox.Name = "getLegalEntityFromFilenameCheckbox";
            this.getLegalEntityFromFilenameCheckbox.Size = new System.Drawing.Size(483, 36);
            this.getLegalEntityFromFilenameCheckbox.TabIndex = 40;
            this.getLegalEntityFromFilenameCheckbox.Text = "Get legal entity from input file name";
            this.getLegalEntityFromFilenameCheckbox.UseVisualStyleBackColor = true;
            this.getLegalEntityFromFilenameCheckbox.CheckedChanged += new System.EventHandler(this.getLegalEntityFromFilenameCheckbox_CheckedChanged);
            // 
            // UploadJobV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1313);
            this.Controls.Add(this.jobTabControl);
            this.Controls.Add(this.mainToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1907, 1322);
            this.Name = "UploadJobV3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UploadJobForm_Load);
            this.jobIdentificationGroupBox.ResumeLayout(false);
            this.jobIdentificationGroupBox.PerformLayout();
            this.jobTabControl.ResumeLayout(false);
            this.jobOverviewTabPage.ResumeLayout(false);
            this.jobControlGroupBox.ResumeLayout(false);
            this.jobControlGroupBox.PerformLayout();
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.retryPolicyGroupBox.ResumeLayout(false);
            this.retryPolicyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retriesDelayUpDown)).EndInit();
            this.groupBoxExceptions.ResumeLayout(false);
            this.groupBoxExceptions.PerformLayout();
            this.foldersGroupBox.ResumeLayout(false);
            this.foldersGroupBox.PerformLayout();
            this.jobDetailsTabPage.ResumeLayout(false);
            this.uploadDetailsGroupBox.ResumeLayout(false);
            this.uploadDetailsGroupBox.PerformLayout();
            this.getLegalEntityFromFilenameDetailsGroupBox.ResumeLayout(false);
            this.getLegalEntityFromFilenameDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.legalEntityTokenPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalUploads)).EndInit();
            this.fileSelectionGroupBox.ResumeLayout(false);
            this.fileSelectionGroupBox.PerformLayout();
            this.orderByPanel.ResumeLayout(false);
            this.orderByPanel.PerformLayout();
            this.uploadRecurrenceTabPage.ResumeLayout(false);
            this.upJobTriggerTypePanel.ResumeLayout(false);
            this.upJobTriggerTypePanel.PerformLayout();
            this.simpleTriggerUploadJobGroupBox.ResumeLayout(false);
            this.simpleTriggerUploadJobGroupBox.PerformLayout();
            this.cronTriggerUploadJobGroupBox.ResumeLayout(false);
            this.cronTriggerUploadJobGroupBox.PerformLayout();
            this.monitoringJobTabPage.ResumeLayout(false);
            this.monitoringJobTabPage.PerformLayout();
            this.processingJobGroupBox.ResumeLayout(false);
            this.processingJobGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayBetweenStatusCheckNumericUpDown)).EndInit();
            this.procJobTriggerTypePanel.ResumeLayout(false);
            this.procJobTriggerTypePanel.PerformLayout();
            this.simpleTriggerMonitoringJobGroupBox.ResumeLayout(false);
            this.simpleTriggerMonitoringJobGroupBox.PerformLayout();
            this.cronTriggerMonitoringJobGroupBox.ResumeLayout(false);
            this.cronTriggerMonitoringJobGroupBox.PerformLayout();
            this.connectionTabPage.ResumeLayout(false);
            this.axDetailsGroupBox.ResumeLayout(false);
            this.axDetailsGroupBox.PerformLayout();
            this.authMethodPanel.ResumeLayout(false);
            this.authMethodPanel.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox jobIdentificationGroupBox;
        private System.Windows.Forms.Button topUploadFolderBrowserButton;
        private System.Windows.Forms.TextBox topUploadFolderTextBox;
        private System.Windows.Forms.Label topUploadFolderLabel;
        private System.Windows.Forms.TextBox jobDescription;
        private System.Windows.Forms.Label jobDescriptionLabel;
        private System.Windows.Forms.ComboBox jobGroupComboBox;
        private System.Windows.Forms.Label jobGroupLabel;
        private System.Windows.Forms.TextBox jobName;
        private System.Windows.Forms.Label jobNameLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button uploadErrorsFolderBrowserButton;
        private System.Windows.Forms.TextBox uploadErrorsFolderTextBox;
        private System.Windows.Forms.Label uploadErrorsFolderLabel;
        private System.Windows.Forms.CheckBox useStandardSubfolder;
        private System.Windows.Forms.Label downloadFolderLabel;
        private System.Windows.Forms.Button inputFolderBrowserButton;
        private System.Windows.Forms.TextBox inputFolderTextBox;
        private System.Windows.Forms.Label inputFolderLabel;
        private System.Windows.Forms.Button processingSuccessFolderBrowserButton;
        private System.Windows.Forms.TextBox processingSuccessFolderTextBox;
        private System.Windows.Forms.Label processingSuccessFolderLabel;
        private System.Windows.Forms.Button uploadSuccessFolderBrowserButton;
        private System.Windows.Forms.TextBox uploadSuccessFolderTextBox;
        private System.Windows.Forms.Label uploadSuccessFolderLabel;
        private System.Windows.Forms.Button processingErrorsFolderBrowserButton;
        private System.Windows.Forms.TextBox processingErrorsFolderTextBox;
        private System.Windows.Forms.Label processingErrorsFolderLabel;
        private System.Windows.Forms.TabControl jobTabControl;
        private System.Windows.Forms.TabPage jobOverviewTabPage;
        private System.Windows.Forms.TabPage jobDetailsTabPage;
        private System.Windows.Forms.TabPage uploadRecurrenceTabPage;
        private System.Windows.Forms.TabPage monitoringJobTabPage;
        private System.Windows.Forms.TabPage connectionTabPage;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.GroupBox groupBoxExceptions;
        private System.Windows.Forms.CheckBox pauseOnExceptionsCheckBox;
        private System.Windows.Forms.GroupBox retryPolicyGroupBox;
        private System.Windows.Forms.NumericUpDown retriesDelayUpDown;
        private System.Windows.Forms.NumericUpDown retriesCountUpDown;
        private System.Windows.Forms.Label retriesDelayLabel;
        private System.Windows.Forms.Label retriesLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalUploads;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.TextBox legalEntityTextBox;
        private System.Windows.Forms.Label LegalEntityLabel;
        private System.Windows.Forms.GroupBox cronTriggerUploadJobGroupBox;
        private System.Windows.Forms.Button moreExamplesButton;
        private System.Windows.Forms.TextBox calculatedRunsTextBox;
        private System.Windows.Forms.Button getCronScheduleForUploadButton;
        private System.Windows.Forms.LinkLabel cronDocsLinkLabel;
        private System.Windows.Forms.Panel upJobTriggerTypePanel;
        private System.Windows.Forms.RadioButton upJobCronTriggerRadioButton;
        private System.Windows.Forms.RadioButton upJobSimpleTriggerRadioButton;
        private System.Windows.Forms.Label buildCronLabel;
        private System.Windows.Forms.TextBox cronTriggerInfoTextBox;
        private System.Windows.Forms.LinkLabel cronmakerLinkLabel;
        private System.Windows.Forms.Label upJobCronExpressionLabel;
        private System.Windows.Forms.TextBox upJobCronExpressionTextBox;
        private System.Windows.Forms.Label upJobMinutesLabel;
        private System.Windows.Forms.Label upJobHoursLabel;
        private System.Windows.Forms.Label upJobStartAtLabel;
        private System.Windows.Forms.DateTimePicker upJobStartAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker upJobMinutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker upJobHoursDateTimePicker;
        private System.Windows.Forms.GroupBox processingJobGroupBox;
        private System.Windows.Forms.NumericUpDown delayBetweenStatusCheckNumericUpDown;
        private System.Windows.Forms.Label delayBetweenStatusCheckLabel;
        private System.Windows.Forms.Panel procJobTriggerTypePanel;
        private System.Windows.Forms.RadioButton procJobCronTriggerRadioButton;
        private System.Windows.Forms.RadioButton procJobSimpleTriggerRadioButton;
        private System.Windows.Forms.Label procJobCronExpressionLabel;
        private System.Windows.Forms.TextBox procJobCronExpressionTextBox;
        private System.Windows.Forms.Label procJobMinutesLabel;
        private System.Windows.Forms.Label procJobHoursLabel;
        private System.Windows.Forms.Label procJobStartAtLabel;
        private System.Windows.Forms.DateTimePicker procJobStartAtDateTimePicker;
        private System.Windows.Forms.DateTimePicker procJobMinutesDateTimePicker;
        private System.Windows.Forms.DateTimePicker procJobHoursDateTimePicker;
        private System.Windows.Forms.CheckBox useMonitoringJobCheckBox;
        private System.Windows.Forms.TextBox statusFileExtensionTextBox;
        private System.Windows.Forms.Label statusFileExtensionLabel;
        private System.Windows.Forms.GroupBox axDetailsGroupBox;
        private System.Windows.Forms.Label aadApplicationLabel;
        private System.Windows.Forms.ComboBox appRegistrationComboBox;
        private System.Windows.Forms.Panel authMethodPanel;
        private System.Windows.Forms.RadioButton serviceAuthRadioButton;
        private System.Windows.Forms.RadioButton userAuthRadioButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label instanceLabel;
        private System.Windows.Forms.ComboBox instanceComboBox;
        private System.Windows.Forms.Label dataJobLabel;
        private System.Windows.Forms.ComboBox dataJobComboBox;
        private System.Windows.Forms.GroupBox simpleTriggerMonitoringJobGroupBox;
        private System.Windows.Forms.Label runEveryMonitoringJobLabel;
        private System.Windows.Forms.Label andOrMonitoringJobLabel;
        private System.Windows.Forms.GroupBox cronTriggerMonitoringJobGroupBox;
        private System.Windows.Forms.TextBox monitoringCronTextBox;
        private System.Windows.Forms.Label monitoringJobBuildCronLabel;
        private System.Windows.Forms.LinkLabel monitoringJobCronmakerLinkLabel;
        private System.Windows.Forms.LinkLabel monitoringJobCronDocsLinkLabel;
        private System.Windows.Forms.Button getCronScheduleForMonitoringButton;
        private System.Windows.Forms.TextBox calculatedRunsMonitoringTextBox;
        private System.Windows.Forms.Button moreExamplesMonitoringButton;
        private System.Windows.Forms.CheckBox pauseIndefinitelyCheckBox;
        private System.Windows.Forms.GroupBox uploadDetailsGroupBox;
        private System.Windows.Forms.GroupBox fileSelectionGroupBox;
        private System.Windows.Forms.ComboBox orderByComboBox;
        private System.Windows.Forms.Panel orderByPanel;
        private System.Windows.Forms.RadioButton orderDescendingRadioButton;
        private System.Windows.Forms.RadioButton orderAscendingRadioButton;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label orderByLabel;
        private System.Windows.Forms.Label searchPatternLabel;
        private System.Windows.Forms.GroupBox simpleTriggerUploadJobGroupBox;
        private System.Windows.Forms.Label runEveryUploadJobLabel;
        private System.Windows.Forms.Label importJobAndOrLabel;
        private System.Windows.Forms.GroupBox foldersGroupBox;
        private System.Windows.Forms.GroupBox jobControlGroupBox;
        private System.Windows.Forms.CheckBox getExecutionErrorsCheckBox;
        private System.Windows.Forms.CheckBox isDataPackageCheckBox;
        private System.Windows.Forms.GroupBox groupBoxLogging;
        private System.Windows.Forms.CheckBox verboseLoggingCheckBox;
        private System.Windows.Forms.TextBox getLegalEntityFromFilenameTextBox;
        private System.Windows.Forms.GroupBox getLegalEntityFromFilenameDetailsGroupBox;
        private System.Windows.Forms.Label filenameSeparatorLabel;
        private System.Windows.Forms.TextBox filenameSeparatorTextBox;
        private System.Windows.Forms.Label legalEntityTokenPositionLabel;
        private System.Windows.Forms.NumericUpDown legalEntityTokenPositionNumericUpDown;
        private System.Windows.Forms.Label separatorExmpleLabel;
        private System.Windows.Forms.TextBox separatorExampleTextBox;
        private System.Windows.Forms.TextBox separatorExampleLegalEntityTextBox;
        private System.Windows.Forms.Button separatorExampleButton;
        private System.Windows.Forms.CheckBox getLegalEntityFromFilenameCheckbox;
    }
}