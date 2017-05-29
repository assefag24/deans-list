namespace loginform
{
    partial class loginpage
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
            this.header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loggedInPanel = new System.Windows.Forms.Panel();
            this.calenderPanel = new System.Windows.Forms.Panel();
            this.classesPanel = new System.Windows.Forms.Panel();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scienceGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frenchGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psychGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.students = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.header.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.loggedInPanel.SuspendLayout();
            this.calenderPanel.SuspendLayout();
            this.classesPanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.header.Controls.Add(this.button1);
            this.header.Controls.Add(this.label1);
            this.header.Location = new System.Drawing.Point(1, -5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1814, 112);
            this.header.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1503, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breakout University";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.textBox2);
            this.loginPanel.Controls.Add(this.textBox1);
            this.loginPanel.Controls.Add(this.label7);
            this.loginPanel.Controls.Add(this.label6);
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Location = new System.Drawing.Point(1532, 312);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(382, 363);
            this.loginPanel.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(246, 231);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(105, 43);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 163);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 55);
            this.label7.TabIndex = 2;
            this.label7.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Name:";
            // 
            // footer
            // 
            this.footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.footer.Controls.Add(this.button7);
            this.footer.Controls.Add(this.button6);
            this.footer.Controls.Add(this.button9);
            this.footer.Controls.Add(this.button5);
            this.footer.Controls.Add(this.button8);
            this.footer.Controls.Add(this.button4);
            this.footer.Controls.Add(this.button3);
            this.footer.Controls.Add(this.label3);
            this.footer.Controls.Add(this.label2);
            this.footer.Location = new System.Drawing.Point(1, 805);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1783, 112);
            this.footer.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1024, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "Emergency Info";
            this.button7.UseCompatibleTextRendering = true;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(861, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Terms of Use";
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(635, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(220, 30);
            this.button9.TabIndex = 4;
            this.button9.Text = "Search Breakout";
            this.button9.UseCompatibleTextRendering = true;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(635, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Search Breakout";
            this.button5.UseCompatibleTextRendering = true;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(406, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(225, 30);
            this.button8.TabIndex = 3;
            this.button8.Text = "Maps &  Directions";
            this.button8.UseCompatibleTextRendering = true;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(406, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Maps &  Directions";
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(221, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 17);
            this.button3.TabIndex = 2;
            this.button3.Text = "BU Home";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "University";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Breakout";
            // 
            // loggedInPanel
            // 
            this.loggedInPanel.Controls.Add(this.calenderPanel);
            this.loggedInPanel.Controls.Add(this.students);
            this.loggedInPanel.Controls.Add(this.Classes);
            this.loggedInPanel.Controls.Add(this.calender);
            this.loggedInPanel.Location = new System.Drawing.Point(1, 105);
            this.loggedInPanel.Name = "loggedInPanel";
            this.loggedInPanel.Size = new System.Drawing.Size(1497, 696);
            this.loggedInPanel.TabIndex = 4;
            this.loggedInPanel.Visible = false;
            // 
            // calenderPanel
            // 
            this.calenderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calenderPanel.Controls.Add(this.classesPanel);
            this.calenderPanel.Location = new System.Drawing.Point(186, 185);
            this.calenderPanel.Name = "calenderPanel";
            this.calenderPanel.Size = new System.Drawing.Size(1328, 512);
            this.calenderPanel.TabIndex = 8;
            // 
            // classesPanel
            // 
            this.classesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.classesPanel.Controls.Add(this.studentsPanel);
            this.classesPanel.Location = new System.Drawing.Point(3, 0);
            this.classesPanel.Name = "classesPanel";
            this.classesPanel.Size = new System.Drawing.Size(1305, 509);
            this.classesPanel.TabIndex = 0;
            this.classesPanel.Visible = false;
            // 
            // studentsPanel
            // 
            this.studentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentsPanel.Controls.Add(this.btnsearch);
            this.studentsPanel.Controls.Add(this.txtsearch);
            this.studentsPanel.Controls.Add(this.studentTable);
            this.studentsPanel.Location = new System.Drawing.Point(0, 6);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(1299, 506);
            this.studentsPanel.TabIndex = 9;
            this.studentsPanel.Visible = false;
            // 
            // studentTable
            // 
            this.studentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastName,
            this.firstName,
            this.mathGrade,
            this.scienceGrade,
            this.englishGrade,
            this.frenchGrade,
            this.historyGrade,
            this.psychGrade,
            this.gpa});
            this.studentTable.Location = new System.Drawing.Point(3, 3);
            this.studentTable.Name = "studentTable";
            this.studentTable.ReadOnly = true;
            this.studentTable.RowTemplate.Height = 24;
            this.studentTable.Size = new System.Drawing.Size(1245, 379);
            this.studentTable.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // mathGrade
            // 
            this.mathGrade.HeaderText = "Math";
            this.mathGrade.Name = "mathGrade";
            this.mathGrade.ReadOnly = true;
            // 
            // scienceGrade
            // 
            this.scienceGrade.HeaderText = "Science";
            this.scienceGrade.Name = "scienceGrade";
            this.scienceGrade.ReadOnly = true;
            // 
            // englishGrade
            // 
            this.englishGrade.HeaderText = "English";
            this.englishGrade.Name = "englishGrade";
            this.englishGrade.ReadOnly = true;
            // 
            // frenchGrade
            // 
            this.frenchGrade.HeaderText = "Foreign Language";
            this.frenchGrade.Name = "frenchGrade";
            this.frenchGrade.ReadOnly = true;
            // 
            // historyGrade
            // 
            this.historyGrade.HeaderText = "History";
            this.historyGrade.Name = "historyGrade";
            this.historyGrade.ReadOnly = true;
            // 
            // psychGrade
            // 
            this.psychGrade.HeaderText = "Psychology";
            this.psychGrade.Name = "psychGrade";
            this.psychGrade.ReadOnly = true;
            // 
            // gpa
            // 
            this.gpa.HeaderText = "GPA";
            this.gpa.Name = "gpa";
            this.gpa.ReadOnly = true;
            // 
            // students
            // 
            this.students.AutoSize = true;
            this.students.BackColor = System.Drawing.Color.White;
            this.students.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.students.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students.ForeColor = System.Drawing.Color.Black;
            this.students.Location = new System.Drawing.Point(473, 129);
            this.students.Name = "students";
            this.students.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.students.Size = new System.Drawing.Size(123, 45);
            this.students.TabIndex = 6;
            this.students.Text = "Students";
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // Classes
            // 
            this.Classes.AutoSize = true;
            this.Classes.BackColor = System.Drawing.Color.White;
            this.Classes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Classes.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classes.ForeColor = System.Drawing.Color.Black;
            this.Classes.Location = new System.Drawing.Point(335, 129);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Classes.Size = new System.Drawing.Size(109, 45);
            this.Classes.TabIndex = 5;
            this.Classes.Text = "Classes";
            this.Classes.Click += new System.EventHandler(this.Classes_Click);
            // 
            // calender
            // 
            this.calender.AutoSize = true;
            this.calender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.calender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calender.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calender.ForeColor = System.Drawing.Color.White;
            this.calender.Location = new System.Drawing.Point(188, 129);
            this.calender.Name = "calender";
            this.calender.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.calender.Size = new System.Drawing.Size(120, 45);
            this.calender.TabIndex = 4;
            this.calender.Text = "Calender";
            this.calender.Click += new System.EventHandler(this.calender_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(1148, 394);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 33);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(880, 394);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(251, 28);
            this.txtsearch.TabIndex = 10;
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1783, 918);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.loggedInPanel);
            this.Name = "loginpage";
            this.Text = "loginpage";
            this.Load += new System.EventHandler(this.loginpage_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.loggedInPanel.ResumeLayout(false);
            this.loggedInPanel.PerformLayout();
            this.calenderPanel.ResumeLayout(false);
            this.classesPanel.ResumeLayout(false);
            this.studentsPanel.ResumeLayout(false);
            this.studentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel loggedInPanel;
        private System.Windows.Forms.Label calender;
        private System.Windows.Forms.Label students;
        private System.Windows.Forms.Label Classes;
        private System.Windows.Forms.Panel calenderPanel;
        private System.Windows.Forms.Panel classesPanel;
        private System.Windows.Forms.Panel studentsPanel;
        public System.Windows.Forms.DataGridView studentTable;
        public System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        public System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        public System.Windows.Forms.DataGridViewTextBoxColumn mathGrade;
        public System.Windows.Forms.DataGridViewTextBoxColumn scienceGrade;
        public System.Windows.Forms.DataGridViewTextBoxColumn englishGrade;
        public System.Windows.Forms.DataGridViewTextBoxColumn frenchGrade;
        public System.Windows.Forms.DataGridViewTextBoxColumn historyGrade;
        public System.Windows.Forms.DataGridViewTextBoxColumn psychGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpa;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}