
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
            this.settingsBtn = new System.Windows.Forms.Button();
            this.usernameGroup = new System.Windows.Forms.GroupBox();
            this.changeLog = new System.Windows.Forms.Label();
            this.adminModeBox = new System.Windows.Forms.CheckBox();
            this.settingsExitBtn = new System.Windows.Forms.Button();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consoleGroup = new System.Windows.Forms.GroupBox();
            this.consoleSendBtn = new System.Windows.Forms.Button();
            this.consoleBox2 = new System.Windows.Forms.TextBox();
            this.consoleDisplayLabel = new System.Windows.Forms.Label();
            this.lastMsgBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adminGroup = new System.Windows.Forms.GroupBox();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.requestsChecker = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainHeader)).BeginInit();
            this.mainGroup.SuspendLayout();
            this.usernameGroup.SuspendLayout();
            this.consoleGroup.SuspendLayout();
            this.adminGroup.SuspendLayout();
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
            this.mainGroup.Controls.Add(this.settingsBtn);
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
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(205, 20);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(75, 23);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // usernameGroup
            // 
            this.usernameGroup.Controls.Add(this.changeLog);
            this.usernameGroup.Controls.Add(this.adminModeBox);
            this.usernameGroup.Controls.Add(this.settingsExitBtn);
            this.usernameGroup.Controls.Add(this.tokenBox);
            this.usernameGroup.Controls.Add(this.label2);
            this.usernameGroup.Controls.Add(this.usernameBox);
            this.usernameGroup.Controls.Add(this.label1);
            this.usernameGroup.Location = new System.Drawing.Point(824, 12);
            this.usernameGroup.Name = "usernameGroup";
            this.usernameGroup.Size = new System.Drawing.Size(400, 192);
            this.usernameGroup.TabIndex = 7;
            this.usernameGroup.TabStop = false;
            this.usernameGroup.Text = "Settings";
            // 
            // changeLog
            // 
            this.changeLog.AutoSize = true;
            this.changeLog.Location = new System.Drawing.Point(181, 52);
            this.changeLog.Name = "changeLog";
            this.changeLog.Size = new System.Drawing.Size(187, 105);
            this.changeLog.TabIndex = 6;
            this.changeLog.Text = "Beanchat v1.2 Changes:\r\n-Added settings button\r\n-Added \"admin mode\" option\r\n\r\nTo-" +
    "do list:\r\n-Make usernames persistent\r\n-Enable address aliases for admins";
            // 
            // adminModeBox
            // 
            this.adminModeBox.AutoSize = true;
            this.adminModeBox.Location = new System.Drawing.Point(7, 162);
            this.adminModeBox.Name = "adminModeBox";
            this.adminModeBox.Size = new System.Drawing.Size(96, 19);
            this.adminModeBox.TabIndex = 5;
            this.adminModeBox.Text = "Admin mode";
            this.adminModeBox.UseVisualStyleBackColor = true;
            this.adminModeBox.CheckedChanged += new System.EventHandler(this.adminModeBox_CheckedChanged);
            // 
            // settingsExitBtn
            // 
            this.settingsExitBtn.Location = new System.Drawing.Point(181, 20);
            this.settingsExitBtn.Name = "settingsExitBtn";
            this.settingsExitBtn.Size = new System.Drawing.Size(75, 23);
            this.settingsExitBtn.TabIndex = 4;
            this.settingsExitBtn.Text = "Back";
            this.settingsExitBtn.UseVisualStyleBackColor = true;
            this.settingsExitBtn.Click += new System.EventHandler(this.settingsExitBtn_Click);
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
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin token:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
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
            // consoleGroup
            // 
            this.consoleGroup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consoleGroup.Controls.Add(this.consoleSendBtn);
            this.consoleGroup.Controls.Add(this.consoleBox2);
            this.consoleGroup.Controls.Add(this.consoleDisplayLabel);
            this.consoleGroup.ForeColor = System.Drawing.Color.Lime;
            this.consoleGroup.Location = new System.Drawing.Point(418, 12);
            this.consoleGroup.Name = "consoleGroup";
            this.consoleGroup.Size = new System.Drawing.Size(400, 400);
            this.consoleGroup.TabIndex = 7;
            this.consoleGroup.TabStop = false;
            this.consoleGroup.Text = "Funny Admin Panel";
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
            this.lastMsgBox.Location = new System.Drawing.Point(6, 54);
            this.lastMsgBox.Name = "lastMsgBox";
            this.lastMsgBox.Size = new System.Drawing.Size(387, 23);
            this.lastMsgBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last message:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // adminGroup
            // 
            this.adminGroup.Controls.Add(this.clientsLabel);
            this.adminGroup.Controls.Add(this.label3);
            this.adminGroup.Controls.Add(this.button1);
            this.adminGroup.Controls.Add(this.lastMsgBox);
            this.adminGroup.Location = new System.Drawing.Point(824, 210);
            this.adminGroup.Name = "adminGroup";
            this.adminGroup.Size = new System.Drawing.Size(400, 202);
            this.adminGroup.TabIndex = 11;
            this.adminGroup.TabStop = false;
            this.adminGroup.Text = "Admin stuff";
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(6, 132);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(51, 15);
            this.clientsLabel.TabIndex = 11;
            this.clientsLabel.Text = "requests";
            // 
            // requestsChecker
            // 
            this.requestsChecker.Interval = 12000;
            this.requestsChecker.Tick += new System.EventHandler(this.requestsChecker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 424);
            this.Controls.Add(this.adminGroup);
            this.Controls.Add(this.consoleGroup);
            this.Controls.Add(this.usernameGroup);
            this.Controls.Add(this.mainGroup);
            this.Name = "Form1";
            this.Text = "Beanchat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainHeader)).EndInit();
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            this.usernameGroup.ResumeLayout(false);
            this.usernameGroup.PerformLayout();
            this.consoleGroup.ResumeLayout(false);
            this.consoleGroup.PerformLayout();
            this.adminGroup.ResumeLayout(false);
            this.adminGroup.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox consoleGroup;
        private System.Windows.Forms.Label consoleDisplayLabel;
        private System.Windows.Forms.TextBox consoleBox2;
        private System.Windows.Forms.Button consoleSendBtn;
        private System.Windows.Forms.TextBox lastMsgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button settingsExitBtn;
        private System.Windows.Forms.GroupBox adminGroup;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.CheckBox adminModeBox;
        private System.Windows.Forms.Label changeLog;
        private System.Windows.Forms.Timer requestsChecker;
        private System.Windows.Forms.Label clientsLabel;
    }
}

