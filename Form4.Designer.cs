
namespace AhyokoPBLReTech
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnReport = new AhyokoPBLReTech.Custom_Buttons.RoundButton();
            this.BtnArticle = new AhyokoPBLReTech.Custom_Buttons.RoundButton();
            this.BtnMap = new AhyokoPBLReTech.Custom_Buttons.RoundButton();
            this.logOutBtn = new AhyokoPBLReTech.Custom_Buttons.RoundButton();
            this.BtnAlarm2 = new AhyokoPBLReTech.Custom_Buttons.RoundButton();
            this.BtnAlarm = new AhyokoPBLReTech.Custom_Buttons.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 161);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(203, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Safe Haven";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AhyokoPBLReTech.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(-12, -38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAlarm2);
            this.panel2.Controls.Add(this.BtnAlarm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 921);
            this.panel2.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::AhyokoPBLReTech.Properties.Resources.Blue_Square_Button;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(119)))), ((int)(((byte)(109)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(377, 798);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 73);
            this.button5.TabIndex = 5;
            this.button5.Text = "About Us";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.BtnReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.BtnReport.BackgroundImage = global::AhyokoPBLReTech.Properties.Resources.Report1;
            this.BtnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnReport.BorderRadius = 40;
            this.BtnReport.BorderSize = 0;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F);
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(325, 428);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(235, 175);
            this.BtnReport.TabIndex = 12;
            this.BtnReport.Text = "Report";
            this.BtnReport.TextColor = System.Drawing.Color.White;
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnArticle
            // 
            this.BtnArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(191)))));
            this.BtnArticle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(191)))));
            this.BtnArticle.BackgroundImage = global::AhyokoPBLReTech.Properties.Resources.Flag1;
            this.BtnArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnArticle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnArticle.BorderRadius = 40;
            this.BtnArticle.BorderSize = 0;
            this.BtnArticle.FlatAppearance.BorderSize = 0;
            this.BtnArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArticle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F);
            this.BtnArticle.ForeColor = System.Drawing.Color.White;
            this.BtnArticle.Location = new System.Drawing.Point(65, 428);
            this.BtnArticle.Name = "BtnArticle";
            this.BtnArticle.Size = new System.Drawing.Size(235, 175);
            this.BtnArticle.TabIndex = 11;
            this.BtnArticle.Text = "Red Flags";
            this.BtnArticle.TextColor = System.Drawing.Color.White;
            this.BtnArticle.UseVisualStyleBackColor = false;
            this.BtnArticle.Click += new System.EventHandler(this.BtnArticle_Click);
            // 
            // BtnMap
            // 
            this.BtnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(191)))));
            this.BtnMap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(191)))));
            this.BtnMap.BackgroundImage = global::AhyokoPBLReTech.Properties.Resources.Maps;
            this.BtnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMap.BorderRadius = 40;
            this.BtnMap.BorderSize = 0;
            this.BtnMap.FlatAppearance.BorderSize = 0;
            this.BtnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMap.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F);
            this.BtnMap.ForeColor = System.Drawing.Color.White;
            this.BtnMap.Location = new System.Drawing.Point(325, 236);
            this.BtnMap.Name = "BtnMap";
            this.BtnMap.Size = new System.Drawing.Size(235, 175);
            this.BtnMap.TabIndex = 10;
            this.BtnMap.Text = "Maps";
            this.BtnMap.TextColor = System.Drawing.Color.White;
            this.BtnMap.UseVisualStyleBackColor = false;
            this.BtnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.logOutBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(191)))));
            this.logOutBtn.BorderRadius = 20;
            this.logOutBtn.BorderSize = 4;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F);
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(47, 798);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(168, 73);
            this.logOutBtn.TabIndex = 8;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.TextColor = System.Drawing.Color.White;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // BtnAlarm2
            // 
            this.BtnAlarm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.BtnAlarm2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.BtnAlarm2.BackgroundImage = global::AhyokoPBLReTech.Properties.Resources.Alarm_Off;
            this.BtnAlarm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlarm2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAlarm2.BorderRadius = 40;
            this.BtnAlarm2.BorderSize = 0;
            this.BtnAlarm2.FlatAppearance.BorderSize = 0;
            this.BtnAlarm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlarm2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F);
            this.BtnAlarm2.ForeColor = System.Drawing.Color.White;
            this.BtnAlarm2.Location = new System.Drawing.Point(65, 236);
            this.BtnAlarm2.Name = "BtnAlarm2";
            this.BtnAlarm2.Size = new System.Drawing.Size(235, 175);
            this.BtnAlarm2.TabIndex = 15;
            this.BtnAlarm2.Text = "Alarm";
            this.BtnAlarm2.TextColor = System.Drawing.Color.White;
            this.BtnAlarm2.UseVisualStyleBackColor = false;
            this.BtnAlarm2.Click += new System.EventHandler(this.BtnAlarm2_Click);
            // 
            // BtnAlarm
            // 
            this.BtnAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAlarm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnAlarm.BackgroundImage = global::AhyokoPBLReTech.Properties.Resources.Alarm_On;
            this.BtnAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlarm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAlarm.BorderRadius = 40;
            this.BtnAlarm.BorderSize = 0;
            this.BtnAlarm.FlatAppearance.BorderSize = 0;
            this.BtnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlarm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F);
            this.BtnAlarm.ForeColor = System.Drawing.Color.White;
            this.BtnAlarm.Location = new System.Drawing.Point(65, 236);
            this.BtnAlarm.Name = "BtnAlarm";
            this.BtnAlarm.Size = new System.Drawing.Size(235, 175);
            this.BtnAlarm.TabIndex = 14;
            this.BtnAlarm.Text = "Alarm";
            this.BtnAlarm.TextColor = System.Drawing.Color.White;
            this.BtnAlarm.UseVisualStyleBackColor = false;
            this.BtnAlarm.Click += new System.EventHandler(this.BtnAlarm_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(119)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(624, 921);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnArticle);
            this.Controls.Add(this.BtnMap);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Custom_Buttons.RoundButton logOutBtn;
        private Custom_Buttons.RoundButton BtnMap;
        private Custom_Buttons.RoundButton BtnArticle;
        private Custom_Buttons.RoundButton BtnReport;
        private System.Windows.Forms.Panel panel2;
        private Custom_Buttons.RoundButton BtnAlarm;
        private Custom_Buttons.RoundButton BtnAlarm2;
    }
}