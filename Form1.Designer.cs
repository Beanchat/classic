
namespace apiClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainRefreshBtn = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.msgSendBtn = new System.Windows.Forms.Button();
            this.msgDisplayLabel = new System.Windows.Forms.Label();
            this.mainHeader = new System.Windows.Forms.PictureBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.mainGroup = new System.Windows.Forms.GroupBox();
            this.usernameGroup = new System.Windows.Forms.GroupBox();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consoleSendBtn = new System.Windows.Forms.Button();
            this.consoleBox2 = new System.Windows.Forms.TextBox();
            this.consoleDisplayLabel = new System.Windows.Forms.Label();
            this.lastMsgBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainHeader)).BeginInit();
            this.mainGroup.SuspendLayout();
            this.usernameGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRefreshBtn
            // 
            this.mainRefreshBtn.Location = new System.Drawing.Point(304, 359);
            this.mainRefreshBtn.Name = "mainRefreshBtn";
            this.mainRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.mainRefreshBtn.TabIndex = 0;
            this.mainRefreshBtn.Text = "Refresh";
            this.mainRefreshBtn.UseVisualStyleBackColor = true;
            this.mainRefreshBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(17, 359);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(279, 23);
            this.msgBox.TabIndex = 2;
            // 
            // msgSendBtn
            // 
            this.msgSendBtn.Location = new System.Drawing.Point(304, 330);
            this.msgSendBtn.Name = "msgSendBtn";
            this.msgSendBtn.Size = new System.Drawing.Size(75, 23);
            this.msgSendBtn.TabIndex = 3;
            this.msgSendBtn.Text = "Send";
            this.msgSendBtn.UseVisualStyleBackColor = true;
            this.msgSendBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // msgDisplayLabel
            // 
            this.msgDisplayLabel.AutoSize = true;
            this.msgDisplayLabel.Location = new System.Drawing.Point(6, 97);
            this.msgDisplayLabel.Name = "msgDisplayLabel";
            this.msgDisplayLabel.Size = new System.Drawing.Size(142, 15);
            this.msgDisplayLabel.TabIndex = 4;
            this.msgDisplayLabel.Text = "Making first connection...";
            // 
            // mainHeader
            // 
            this.mainHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainHeader.Image = global::apiClient.Properties.Resources.header;
            this.mainHeader.Location = new System.Drawing.Point(0, 19);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(200, 75);
            this.mainHeader.TabIndex = 5;
            this.mainHeader.TabStop = false;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 6000;
            this.refreshTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainGroup
            // 
            this.mainGroup.Controls.Add(this.mainHeader);
            this.mainGroup.Controls.Add(this.mainRefreshBtn);
            this.mainGroup.Controls.Add(this.msgSendBtn);
            this.mainGroup.Controls.Add(this.msgDisplayLabel);
            this.mainGroup.Controls.Add(this.msgBox);
            this.mainGroup.Location = new System.Drawing.Point(12, 12);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(400, 400);
            this.mainGroup.TabIndex = 6;
            this.mainGroup.TabStop = false;
            this.mainGroup.Text = "Main";
            this.mainGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // usernameGroup
            // 
            this.usernameGroup.Controls.Add(this.tokenBox);
            this.usernameGroup.Controls.Add(this.label2);
            this.usernameGroup.Controls.Add(this.usernameBox);
            this.usernameGroup.Controls.Add(this.label1);
            this.usernameGroup.Location = new System.Drawing.Point(824, 12);
            this.usernameGroup.Name = "usernameGroup";
            this.usernameGroup.Size = new System.Drawing.Size(400, 162);
            this.usernameGroup.TabIndex = 7;
            this.usernameGroup.TabStop = false;
            this.usernameGroup.Text = "Settings";
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(7, 116);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.PasswordChar = '*';
            this.tokenBox.Size = new System.Drawing.Size(155, 23);
            this.tokenBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funny admin token:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(6, 52);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(156, 23);
            this.usernameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.consoleSendBtn);
            this.groupBox1.Controls.Add(this.consoleBox2);
            this.groupBox1.Controls.Add(this.consoleDisplayLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(418, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 400);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funny Admin Panel";
            // 
            // consoleSendBtn
            // 
            this.consoleSendBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.consoleSendBtn.Location = new System.Drawing.Point(304, 360);
            this.consoleSendBtn.Name = "consoleSendBtn";
            this.consoleSendBtn.Size = new System.Drawing.Size(75, 23);
            this.consoleSendBtn.TabIndex = 6;
            this.consoleSendBtn.Text = "Send";
            this.consoleSendBtn.UseVisualStyleBackColor = true;
            this.consoleSendBtn.Click += new System.EventHandler(this.consoleSendBtn_Click);
            // 
            // consoleBox2
            // 
            this.consoleBox2.Location = new System.Drawing.Point(19, 360);
            this.consoleBox2.Name = "consoleBox2";
            this.consoleBox2.Size = new System.Drawing.Size(279, 23);
            this.consoleBox2.TabIndex = 6;
            // 
            // consoleDisplayLabel
            // 
            this.consoleDisplayLabel.AutoSize = true;
            this.consoleDisplayLabel.Location = new System.Drawing.Point(6, 34);
            this.consoleDisplayLabel.Name = "consoleDisplayLabel";
            this.consoleDisplayLabel.Size = new System.Drawing.Size(142, 15);
            this.consoleDisplayLabel.TabIndex = 4;
            this.consoleDisplayLabel.Text = "Making first connection...";
            // 
            // lastMsgBox
            // 
            this.lastMsgBox.Location = new System.Drawing.Point(831, 203);
            this.lastMsgBox.Name = "lastMsgBox";
            this.lastMsgBox.Size = new System.Drawing.Size(393, 23);
            this.lastMsgBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last message:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastMsgBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usernameGroup);
            this.Controls.Add(this.mainGroup);
            this.Name = "Form1";
            this.Text = "Beanchat but cooler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainHeader)).EndInit();
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            this.usernameGroup.ResumeLayout(false);
            this.usernameGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainRefreshBtn;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Button msgSendBtn;
        private System.Windows.Forms.Label msgDisplayLabel;
        private System.Windows.Forms.PictureBox mainHeader;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.GroupBox mainGroup;
        private System.Windows.Forms.GroupBox usernameGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label consoleDisplayLabel;
        private System.Windows.Forms.TextBox consoleBox2;
        private System.Windows.Forms.Button consoleSendBtn;
        private System.Windows.Forms.TextBox lastMsgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

