namespace SocialMinerTestFormsApp
{
    partial class mainWindow
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
            this.outputStatic = new System.Windows.Forms.TextBox();
            this.getTranscriptButton = new System.Windows.Forms.Button();
            this.socialContactIdTextBox = new System.Windows.Forms.TextBox();
            this.agentNameTextBox = new System.Windows.Forms.TextBox();
            this.csqTextBox = new System.Windows.Forms.TextBox();
            this.guestEmailTextBox = new System.Windows.Forms.TextBox();
            this.guestNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chatStatusTextBox = new System.Windows.Forms.TextBox();
            this.chatDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transcriptOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalResultsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalQAAbleTextBox = new System.Windows.Forms.TextBox();
            this.agentSelectBox = new System.Windows.Forms.ComboBox();
            this.includeNonQAableChats = new System.Windows.Forms.CheckBox();
            this.includeQAedChats = new System.Windows.Forms.CheckBox();
            this.rawSearchQuery = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.Results = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qaAbleTextBox = new System.Windows.Forms.TextBox();
            this.prevResult = new System.Windows.Forms.Button();
            this.nextResult = new System.Windows.Forms.Button();
            this.generateWordCloudButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputStatic
            // 
            this.outputStatic.Location = new System.Drawing.Point(0, 0);
            this.outputStatic.Multiline = true;
            this.outputStatic.Name = "outputStatic";
            this.outputStatic.ReadOnly = true;
            this.outputStatic.Size = new System.Drawing.Size(580, 59);
            this.outputStatic.TabIndex = 0;
            this.outputStatic.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // getTranscriptButton
            // 
            this.getTranscriptButton.Location = new System.Drawing.Point(680, 494);
            this.getTranscriptButton.Name = "getTranscriptButton";
            this.getTranscriptButton.Size = new System.Drawing.Size(108, 23);
            this.getTranscriptButton.TabIndex = 1;
            this.getTranscriptButton.Text = "Get Transcript";
            this.getTranscriptButton.UseVisualStyleBackColor = true;
            this.getTranscriptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // socialContactIdTextBox
            // 
            this.socialContactIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.socialContactIdTextBox.Location = new System.Drawing.Point(0, 494);
            this.socialContactIdTextBox.Name = "socialContactIdTextBox";
            this.socialContactIdTextBox.Size = new System.Drawing.Size(662, 20);
            this.socialContactIdTextBox.TabIndex = 2;
            this.socialContactIdTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // agentNameTextBox
            // 
            this.agentNameTextBox.Location = new System.Drawing.Point(658, 333);
            this.agentNameTextBox.Name = "agentNameTextBox";
            this.agentNameTextBox.ReadOnly = true;
            this.agentNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.agentNameTextBox.TabIndex = 3;
            // 
            // csqTextBox
            // 
            this.csqTextBox.Location = new System.Drawing.Point(658, 411);
            this.csqTextBox.Name = "csqTextBox";
            this.csqTextBox.ReadOnly = true;
            this.csqTextBox.Size = new System.Drawing.Size(130, 20);
            this.csqTextBox.TabIndex = 4;
            // 
            // guestEmailTextBox
            // 
            this.guestEmailTextBox.Location = new System.Drawing.Point(658, 385);
            this.guestEmailTextBox.Name = "guestEmailTextBox";
            this.guestEmailTextBox.ReadOnly = true;
            this.guestEmailTextBox.Size = new System.Drawing.Size(130, 20);
            this.guestEmailTextBox.TabIndex = 5;
            // 
            // guestNameTextBox
            // 
            this.guestNameTextBox.Location = new System.Drawing.Point(658, 359);
            this.guestNameTextBox.Name = "guestNameTextBox";
            this.guestNameTextBox.ReadOnly = true;
            this.guestNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.guestNameTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agent Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Guest Name";
            // 
            // chatStatusTextBox
            // 
            this.chatStatusTextBox.Location = new System.Drawing.Point(658, 463);
            this.chatStatusTextBox.Name = "chatStatusTextBox";
            this.chatStatusTextBox.ReadOnly = true;
            this.chatStatusTextBox.Size = new System.Drawing.Size(130, 20);
            this.chatStatusTextBox.TabIndex = 11;
            // 
            // chatDateTextBox
            // 
            this.chatDateTextBox.Location = new System.Drawing.Point(658, 437);
            this.chatDateTextBox.Name = "chatDateTextBox";
            this.chatDateTextBox.ReadOnly = true;
            this.chatDateTextBox.Size = new System.Drawing.Size(130, 20);
            this.chatDateTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Guest Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CSQ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status";
            // 
            // transcriptOutput
            // 
            this.transcriptOutput.Location = new System.Drawing.Point(0, 193);
            this.transcriptOutput.Multiline = true;
            this.transcriptOutput.Name = "transcriptOutput";
            this.transcriptOutput.ReadOnly = true;
            this.transcriptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transcriptOutput.Size = new System.Drawing.Size(580, 264);
            this.transcriptOutput.TabIndex = 17;
            this.transcriptOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.transcriptOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Transcript";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.totalResultsTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.totalQAAbleTextBox);
            this.groupBox1.Controls.Add(this.agentSelectBox);
            this.groupBox1.Controls.Add(this.includeNonQAableChats);
            this.groupBox1.Controls.Add(this.includeQAedChats);
            this.groupBox1.Controls.Add(this.rawSearchQuery);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 96);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total Results:";
            // 
            // totalResultsTextBox
            // 
            this.totalResultsTextBox.Location = new System.Drawing.Point(370, 72);
            this.totalResultsTextBox.Name = "totalResultsTextBox";
            this.totalResultsTextBox.ReadOnly = true;
            this.totalResultsTextBox.Size = new System.Drawing.Size(42, 20);
            this.totalResultsTextBox.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total Results QAAble:\r\n";
            // 
            // totalQAAbleTextBox
            // 
            this.totalQAAbleTextBox.Location = new System.Drawing.Point(532, 72);
            this.totalQAAbleTextBox.Name = "totalQAAbleTextBox";
            this.totalQAAbleTextBox.ReadOnly = true;
            this.totalQAAbleTextBox.Size = new System.Drawing.Size(42, 20);
            this.totalQAAbleTextBox.TabIndex = 28;
            // 
            // agentSelectBox
            // 
            this.agentSelectBox.FormattingEnabled = true;
            this.agentSelectBox.Location = new System.Drawing.Point(418, 47);
            this.agentSelectBox.Name = "agentSelectBox";
            this.agentSelectBox.Size = new System.Drawing.Size(156, 21);
            this.agentSelectBox.TabIndex = 27;
            this.agentSelectBox.Text = "Agent";
            // 
            // includeNonQAableChats
            // 
            this.includeNonQAableChats.AutoSize = true;
            this.includeNonQAableChats.Location = new System.Drawing.Point(109, 75);
            this.includeNonQAableChats.Name = "includeNonQAableChats";
            this.includeNonQAableChats.Size = new System.Drawing.Size(128, 17);
            this.includeNonQAableChats.TabIndex = 26;
            this.includeNonQAableChats.Text = "Include Non-QAable?";
            this.includeNonQAableChats.UseVisualStyleBackColor = true;
            this.includeNonQAableChats.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // includeQAedChats
            // 
            this.includeQAedChats.AutoSize = true;
            this.includeQAedChats.Location = new System.Drawing.Point(6, 75);
            this.includeQAedChats.Name = "includeQAedChats";
            this.includeQAedChats.Size = new System.Drawing.Size(97, 17);
            this.includeQAedChats.TabIndex = 25;
            this.includeQAedChats.Text = "Include QAed?";
            this.includeQAedChats.UseVisualStyleBackColor = true;
            this.includeQAedChats.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rawSearchQuery
            // 
            this.rawSearchQuery.Location = new System.Drawing.Point(6, 48);
            this.rawSearchQuery.Name = "rawSearchQuery";
            this.rawSearchQuery.Size = new System.Drawing.Size(406, 20);
            this.rawSearchQuery.TabIndex = 23;
            this.rawSearchQuery.Text = "Raw Query";
            this.rawSearchQuery.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            this.rawSearchQuery.Enter += new System.EventHandler(this.rawSearchQuery_Enter);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(418, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(156, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(212, 19);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(6, 19);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 0;
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(586, 0);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(214, 290);
            this.Results.TabIndex = 20;
            this.Results.SelectedIndexChanged += new System.EventHandler(this.Results_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "QA-Able?";
            // 
            // qaAbleTextBox
            // 
            this.qaAbleTextBox.Location = new System.Drawing.Point(70, 467);
            this.qaAbleTextBox.Name = "qaAbleTextBox";
            this.qaAbleTextBox.ReadOnly = true;
            this.qaAbleTextBox.Size = new System.Drawing.Size(100, 20);
            this.qaAbleTextBox.TabIndex = 22;
            // 
            // prevResult
            // 
            this.prevResult.Location = new System.Drawing.Point(680, 296);
            this.prevResult.Name = "prevResult";
            this.prevResult.Size = new System.Drawing.Size(59, 23);
            this.prevResult.TabIndex = 23;
            this.prevResult.Text = "Previous";
            this.prevResult.UseVisualStyleBackColor = true;
            this.prevResult.Click += new System.EventHandler(this.prevResult_Click);
            // 
            // nextResult
            // 
            this.nextResult.Location = new System.Drawing.Point(745, 296);
            this.nextResult.Name = "nextResult";
            this.nextResult.Size = new System.Drawing.Size(55, 23);
            this.nextResult.TabIndex = 24;
            this.nextResult.Text = "Next";
            this.nextResult.UseVisualStyleBackColor = true;
            this.nextResult.Click += new System.EventHandler(this.nextResult_Click);
            // 
            // generateWordCloudButton
            // 
            this.generateWordCloudButton.Location = new System.Drawing.Point(586, 296);
            this.generateWordCloudButton.Name = "generateWordCloudButton";
            this.generateWordCloudButton.Size = new System.Drawing.Size(88, 23);
            this.generateWordCloudButton.TabIndex = 25;
            this.generateWordCloudButton.Text = "Word Cloud";
            this.generateWordCloudButton.UseVisualStyleBackColor = true;
            this.generateWordCloudButton.Click += new System.EventHandler(this.generateWordCloudButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.generateWordCloudButton);
            this.Controls.Add(this.nextResult);
            this.Controls.Add(this.prevResult);
            this.Controls.Add(this.qaAbleTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transcriptOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chatDateTextBox);
            this.Controls.Add(this.chatStatusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestNameTextBox);
            this.Controls.Add(this.guestEmailTextBox);
            this.Controls.Add(this.csqTextBox);
            this.Controls.Add(this.agentNameTextBox);
            this.Controls.Add(this.socialContactIdTextBox);
            this.Controls.Add(this.getTranscriptButton);
            this.Controls.Add(this.outputStatic);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputStatic;
        private System.Windows.Forms.Button getTranscriptButton;
        private System.Windows.Forms.TextBox socialContactIdTextBox;
        private System.Windows.Forms.TextBox agentNameTextBox;
        private System.Windows.Forms.TextBox csqTextBox;
        private System.Windows.Forms.TextBox guestEmailTextBox;
        private System.Windows.Forms.TextBox guestNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chatStatusTextBox;
        private System.Windows.Forms.TextBox chatDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox transcriptOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox qaAbleTextBox;
        private System.Windows.Forms.TextBox rawSearchQuery;
        private System.Windows.Forms.Button prevResult;
        private System.Windows.Forms.Button nextResult;
        private System.Windows.Forms.CheckBox includeQAedChats;
        private System.Windows.Forms.CheckBox includeNonQAableChats;
        private System.Windows.Forms.ComboBox agentSelectBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalQAAbleTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalResultsTextBox;
        private System.Windows.Forms.Button generateWordCloudButton;
    }
}