
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
            this.button2 = new System.Windows.Forms.Button();
            this.usernameSubmitBtn = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainHeader)).BeginInit();
            this.mainGroup.SuspendLayout();
            this.usernameGroup.SuspendLayout();
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
            this.mainHeader.Location = new System.Drawing.Point(0, 10);
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
            this.usernameGroup.Controls.Add(this.button2);
            this.usernameGroup.Controls.Add(this.usernameSubmitBtn);
            this.usernameGroup.Controls.Add(this.usernameBox);
            this.usernameGroup.Controls.Add(this.label1);
            this.usernameGroup.Location = new System.Drawing.Point(418, 22);
            this.usernameGroup.Name = "usernameGroup";
            this.usernameGroup.Size = new System.Drawing.Size(400, 400);
            this.usernameGroup.TabIndex = 7;
            this.usernameGroup.TabStop = false;
            this.usernameGroup.Text = "Username";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // usernameSubmitBtn
            // 
            this.usernameSubmitBtn.Location = new System.Drawing.Point(6, 66);
            this.usernameSubmitBtn.Name = "usernameSubmitBtn";
            this.usernameSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.usernameSubmitBtn.TabIndex = 2;
            this.usernameSubmitBtn.Text = "Submit";
            this.usernameSubmitBtn.UseVisualStyleBackColor = true;
            this.usernameSubmitBtn.Click += new System.EventHandler(this.usernameSubmitBtn_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(6, 37);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(156, 23);
            this.usernameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 642);
            this.Controls.Add(this.usernameGroup);
            this.Controls.Add(this.mainGroup);
            this.Name = "Form1";
            this.Text = "Beanchat but newer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainHeader)).EndInit();
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            this.usernameGroup.ResumeLayout(false);
            this.usernameGroup.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button usernameSubmitBtn;
        private System.Windows.Forms.TextBox usernameBox;
    }
}

