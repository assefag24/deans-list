namespace CollegeWebsite
{
    partial class Website
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
            this.button1 = new System.Windows.Forms.Button();
            this.banner = new System.Windows.Forms.Panel();
            this.BreakoutTitle = new System.Windows.Forms.Label();
            this.navigation = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Label();
            this.Admission = new System.Windows.Forms.Label();
            this.Academics = new System.Windows.Forms.Label();
            this.Research = new System.Windows.Forms.Label();
            this.CampusLife = new System.Windows.Forms.Label();
            this.aboutPage = new System.Windows.Forms.Panel();
            this.admissionPage = new System.Windows.Forms.Panel();
            this.academicsPage = new System.Windows.Forms.Panel();
            this.researchPage = new System.Windows.Forms.Panel();
            this.campusPage = new System.Windows.Forms.Panel();
            this.banner.SuspendLayout();
            this.navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1357, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "close website";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.banner.Controls.Add(this.button1);
            this.banner.Controls.Add(this.BreakoutTitle);
            this.banner.Location = new System.Drawing.Point(-1, -2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(2165, 150);
            this.banner.TabIndex = 1;
            // 
            // BreakoutTitle
            // 
            this.BreakoutTitle.AutoSize = true;
            this.BreakoutTitle.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakoutTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BreakoutTitle.Location = new System.Drawing.Point(249, 19);
            this.BreakoutTitle.Name = "BreakoutTitle";
            this.BreakoutTitle.Size = new System.Drawing.Size(541, 70);
            this.BreakoutTitle.TabIndex = 0;
            this.BreakoutTitle.Text = "Breakout University";
            this.BreakoutTitle.Click += new System.EventHandler(this.BreakoutTitle_Click);
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.navigation.Controls.Add(this.CampusLife);
            this.navigation.Controls.Add(this.Research);
            this.navigation.Controls.Add(this.Academics);
            this.navigation.Controls.Add(this.Admission);
            this.navigation.Controls.Add(this.About);
            this.navigation.Location = new System.Drawing.Point(-4, 109);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(2168, 39);
            this.navigation.TabIndex = 1;
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(259, 2);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(195, 35);
            this.About.TabIndex = 2;
            this.About.Text = "About Stanford";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Admission
            // 
            this.Admission.AutoSize = true;
            this.Admission.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admission.Location = new System.Drawing.Point(510, 2);
            this.Admission.Name = "Admission";
            this.Admission.Size = new System.Drawing.Size(137, 35);
            this.Admission.TabIndex = 3;
            this.Admission.Text = "Admission";
            this.Admission.Click += new System.EventHandler(this.Admission_Click);
            // 
            // Academics
            // 
            this.Academics.AutoSize = true;
            this.Academics.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Academics.Location = new System.Drawing.Point(687, 1);
            this.Academics.Name = "Academics";
            this.Academics.Size = new System.Drawing.Size(141, 35);
            this.Academics.TabIndex = 4;
            this.Academics.Text = "Academics";
            this.Academics.Click += new System.EventHandler(this.Academics_Click);
            // 
            // Research
            // 
            this.Research.AutoSize = true;
            this.Research.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Research.Location = new System.Drawing.Point(877, 1);
            this.Research.Name = "Research";
            this.Research.Size = new System.Drawing.Size(120, 35);
            this.Research.TabIndex = 5;
            this.Research.Text = "Research";
            this.Research.Click += new System.EventHandler(this.Research_Click);
            // 
            // CampusLife
            // 
            this.CampusLife.AutoSize = true;
            this.CampusLife.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampusLife.Location = new System.Drawing.Point(1051, 2);
            this.CampusLife.Name = "CampusLife";
            this.CampusLife.Size = new System.Drawing.Size(161, 35);
            this.CampusLife.TabIndex = 6;
            this.CampusLife.Text = "Campus Life";
            this.CampusLife.Click += new System.EventHandler(this.CampusLife_Click);
            // 
            // aboutPage
            // 
            this.aboutPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.aboutPage.Location = new System.Drawing.Point(261, 148);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Size = new System.Drawing.Size(189, 3000);
            this.aboutPage.TabIndex = 3;
            this.aboutPage.Visible = false;
            // 
            // admissionPage
            // 
            this.admissionPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.admissionPage.Location = new System.Drawing.Point(879, 149);
            this.admissionPage.Name = "admissionPage";
            this.admissionPage.Size = new System.Drawing.Size(131, 538);
            this.admissionPage.TabIndex = 4;
            this.admissionPage.Visible = false;
            // 
            // academicsPage
            // 
            this.academicsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.academicsPage.Location = new System.Drawing.Point(689, 149);
            this.academicsPage.Name = "academicsPage";
            this.academicsPage.Size = new System.Drawing.Size(135, 733);
            this.academicsPage.TabIndex = 5;
            this.academicsPage.Visible = false;
            // 
            // researchPage
            // 
            this.researchPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.researchPage.Location = new System.Drawing.Point(512, 149);
            this.researchPage.Name = "researchPage";
            this.researchPage.Size = new System.Drawing.Size(114, 735);
            this.researchPage.TabIndex = 5;
            this.researchPage.Visible = false;
            // 
            // campusPage
            // 
            this.campusPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.campusPage.Location = new System.Drawing.Point(1053, 149);
            this.campusPage.Name = "campusPage";
            this.campusPage.Size = new System.Drawing.Size(155, 738);
            this.campusPage.TabIndex = 6;
            this.campusPage.Visible = false;
            // 
            // Website
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1914, 878);
            this.Controls.Add(this.academicsPage);
            this.Controls.Add(this.researchPage);
            this.Controls.Add(this.admissionPage);
            this.Controls.Add(this.campusPage);
            this.Controls.Add(this.aboutPage);
            this.Controls.Add(this.navigation);
            this.Controls.Add(this.banner);
            this.Name = "Website";
            this.Text = "Website";
            this.Load += new System.EventHandler(this.Website_Load);
            this.banner.ResumeLayout(false);
            this.banner.PerformLayout();
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel banner;
        private System.Windows.Forms.Panel navigation;
        private System.Windows.Forms.Label BreakoutTitle;
        private System.Windows.Forms.Label CampusLife;
        private System.Windows.Forms.Label Research;
        private System.Windows.Forms.Label Academics;
        private System.Windows.Forms.Label Admission;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.Panel aboutPage;
        private System.Windows.Forms.Panel academicsPage;
        private System.Windows.Forms.Panel admissionPage;
        private System.Windows.Forms.Panel researchPage;
        private System.Windows.Forms.Panel campusPage;
    }
}