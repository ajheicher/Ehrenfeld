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
            this.SuspendLayout();
            // 
            // outputStatic
            // 
            this.outputStatic.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputStatic.Location = new System.Drawing.Point(0, 0);
            this.outputStatic.Multiline = true;
            this.outputStatic.Name = "outputStatic";
            this.outputStatic.ReadOnly = true;
            this.outputStatic.Size = new System.Drawing.Size(800, 59);
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
            this.transcriptOutput.Location = new System.Drawing.Point(0, 352);
            this.transcriptOutput.Multiline = true;
            this.transcriptOutput.Name = "transcriptOutput";
            this.transcriptOutput.ReadOnly = true;
            this.transcriptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transcriptOutput.Size = new System.Drawing.Size(580, 127);
            this.transcriptOutput.TabIndex = 17;
            this.transcriptOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Transcript";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
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
    }
}