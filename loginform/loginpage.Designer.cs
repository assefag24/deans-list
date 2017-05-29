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
            this.label1 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.deansPassword = new System.Windows.Forms.TextBox();
            this.deansUsername = new System.Windows.Forms.TextBox();
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
            this.editPanel = new System.Windows.Forms.Panel();
            this.psychBox = new System.Windows.Forms.TextBox();
            this.historyBox = new System.Windows.Forms.TextBox();
            this.foreignBox = new System.Windows.Forms.TextBox();
            this.englishBox = new System.Windows.Forms.TextBox();
            this.scienceBox = new System.Windows.Forms.TextBox();
            this.mathBox = new System.Windows.Forms.TextBox();
            this.psychLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.scienceLabel = new System.Windows.Forms.Label();
            this.mathLabel = new System.Windows.Forms.Label();
            this.selectedGpa = new System.Windows.Forms.Label();
            this.selectedName = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.students = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.loggedInPanel.SuspendLayout();
            this.calenderPanel.SuspendLayout();
            this.classesPanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.header.Controls.Add(this.logoutButton);
            this.header.Controls.Add(this.label1);
            this.header.Location = new System.Drawing.Point(1, -5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1814, 112);
            this.header.TabIndex = 0;
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
            this.loginPanel.Controls.Add(this.deansPassword);
            this.loginPanel.Controls.Add(this.deansUsername);
            this.loginPanel.Controls.Add(this.label7);
            this.loginPanel.Controls.Add(this.label6);
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Location = new System.Drawing.Point(743, 220);
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
            // deansPassword
            // 
            this.deansPassword.Location = new System.Drawing.Point(168, 163);
            this.deansPassword.Multiline = true;
            this.deansPassword.Name = "deansPassword";
            this.deansPassword.Size = new System.Drawing.Size(183, 22);
            this.deansPassword.TabIndex = 4;
            // 
            // deansUsername
            // 
            this.deansUsername.Location = new System.Drawing.Point(168, 101);
            this.deansUsername.Multiline = true;
            this.deansUsername.Name = "deansUsername";
            this.deansUsername.Size = new System.Drawing.Size(183, 22);
            this.deansUsername.TabIndex = 3;
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
            this.footer.Location = new System.Drawing.Point(1, 728);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1783, 114);
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
            this.button3.Size = new System.Drawing.Size(179, 19);
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
            this.loggedInPanel.Location = new System.Drawing.Point(99, 170);
            this.loggedInPanel.Name = "loggedInPanel";
            this.loggedInPanel.Size = new System.Drawing.Size(1497, 668);
            this.loggedInPanel.TabIndex = 4;
            this.loggedInPanel.Visible = false;
            // 
            // calenderPanel
            // 
            this.calenderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calenderPanel.Controls.Add(this.classesPanel);
            this.calenderPanel.Location = new System.Drawing.Point(182, 90);
            this.calenderPanel.Name = "calenderPanel";
            this.calenderPanel.Size = new System.Drawing.Size(1328, 722);
            this.calenderPanel.TabIndex = 8;
            // 
            // classesPanel
            // 
            this.classesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.classesPanel.Controls.Add(this.studentsPanel);
            this.classesPanel.Location = new System.Drawing.Point(3, 0);
            this.classesPanel.Name = "classesPanel";
            this.classesPanel.Size = new System.Drawing.Size(1305, 719);
            this.classesPanel.TabIndex = 0;
            this.classesPanel.Visible = false;
            // 
            // studentsPanel
            // 
            this.studentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentsPanel.Controls.Add(this.editPanel);
            this.studentsPanel.Controls.Add(this.editLabel);
            this.studentsPanel.Controls.Add(this.studentTable);
            this.studentsPanel.Location = new System.Drawing.Point(3, 3);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(1299, 782);
            this.studentsPanel.TabIndex = 9;
            this.studentsPanel.Visible = false;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.psychBox);
            this.editPanel.Controls.Add(this.historyBox);
            this.editPanel.Controls.Add(this.foreignBox);
            this.editPanel.Controls.Add(this.englishBox);
            this.editPanel.Controls.Add(this.scienceBox);
            this.editPanel.Controls.Add(this.mathBox);
            this.editPanel.Controls.Add(this.psychLabel);
            this.editPanel.Controls.Add(this.historyLabel);
            this.editPanel.Controls.Add(this.languageLabel);
            this.editPanel.Controls.Add(this.englishLabel);
            this.editPanel.Controls.Add(this.scienceLabel);
            this.editPanel.Controls.Add(this.mathLabel);
            this.editPanel.Controls.Add(this.selectedGpa);
            this.editPanel.Controls.Add(this.selectedName);
            this.editPanel.Controls.Add(this.saveButton);
            this.editPanel.Location = new System.Drawing.Point(3, 385);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(1247, 184);
            this.editPanel.TabIndex = 10;
            this.editPanel.Visible = false;
            // 
            // psychBox
            // 
            this.psychBox.Location = new System.Drawing.Point(810, 152);
            this.psychBox.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.psychBox.Name = "psychBox";
            this.psychBox.Size = new System.Drawing.Size(100, 22);
            this.psychBox.TabIndex = 23;
            this.psychBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // historyBox
            // 
            this.historyBox.Location = new System.Drawing.Point(667, 152);
            this.historyBox.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(100, 22);
            this.historyBox.TabIndex = 22;
            this.historyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // foreignBox
            // 
            this.foreignBox.Location = new System.Drawing.Point(524, 152);
            this.foreignBox.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.foreignBox.Name = "foreignBox";
            this.foreignBox.Size = new System.Drawing.Size(100, 22);
            this.foreignBox.TabIndex = 21;
            this.foreignBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // englishBox
            // 
            this.englishBox.Location = new System.Drawing.Point(381, 152);
            this.englishBox.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.englishBox.Name = "englishBox";
            this.englishBox.Size = new System.Drawing.Size(100, 22);
            this.englishBox.TabIndex = 20;
            this.englishBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scienceBox
            // 
            this.scienceBox.Location = new System.Drawing.Point(238, 152);
            this.scienceBox.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.scienceBox.Name = "scienceBox";
            this.scienceBox.Size = new System.Drawing.Size(100, 22);
            this.scienceBox.TabIndex = 19;
            this.scienceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mathBox
            // 
            this.mathBox.Location = new System.Drawing.Point(95, 152);
            this.mathBox.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.mathBox.Name = "mathBox";
            this.mathBox.Size = new System.Drawing.Size(100, 22);
            this.mathBox.TabIndex = 18;
            this.mathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // psychLabel
            // 
            this.psychLabel.AutoSize = true;
            this.psychLabel.Location = new System.Drawing.Point(819, 117);
            this.psychLabel.Name = "psychLabel";
            this.psychLabel.Size = new System.Drawing.Size(80, 17);
            this.psychLabel.TabIndex = 17;
            this.psychLabel.Text = "Psychology";
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(690, 117);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(52, 17);
            this.historyLabel.TabIndex = 16;
            this.historyLabel.Text = "History";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(515, 117);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(124, 17);
            this.languageLabel.TabIndex = 15;
            this.languageLabel.Text = "Foreign Language";
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Location = new System.Drawing.Point(405, 117);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(54, 17);
            this.englishLabel.TabIndex = 14;
            this.englishLabel.Text = "English";
            // 
            // scienceLabel
            // 
            this.scienceLabel.AutoSize = true;
            this.scienceLabel.Location = new System.Drawing.Point(259, 117);
            this.scienceLabel.Name = "scienceLabel";
            this.scienceLabel.Size = new System.Drawing.Size(58, 17);
            this.scienceLabel.TabIndex = 13;
            this.scienceLabel.Text = "Science";
            // 
            // mathLabel
            // 
            this.mathLabel.AutoSize = true;
            this.mathLabel.Location = new System.Drawing.Point(125, 117);
            this.mathLabel.Name = "mathLabel";
            this.mathLabel.Size = new System.Drawing.Size(39, 17);
            this.mathLabel.TabIndex = 12;
            this.mathLabel.Text = "Math";
            // 
            // selectedGpa
            // 
            this.selectedGpa.AutoSize = true;
            this.selectedGpa.Location = new System.Drawing.Point(93, 58);
            this.selectedGpa.Name = "selectedGpa";
            this.selectedGpa.Size = new System.Drawing.Size(0, 17);
            this.selectedGpa.TabIndex = 11;
            // 
            // selectedName
            // 
            this.selectedName.AutoSize = true;
            this.selectedName.Location = new System.Drawing.Point(93, 28);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(0, 17);
            this.selectedName.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveButton.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(953, 129);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.saveButton.Size = new System.Drawing.Size(89, 45);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.BackColor = System.Drawing.Color.White;
            this.editLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editLabel.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.ForeColor = System.Drawing.Color.Black;
            this.editLabel.Location = new System.Drawing.Point(3, 385);
            this.editLabel.Name = "editLabel";
            this.editLabel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.editLabel.Size = new System.Drawing.Size(83, 45);
            this.editLabel.TabIndex = 9;
            this.editLabel.Text = "Edit";
            this.editLabel.Click += new System.EventHandler(this.editLabel_Click);
            // 
            // studentTable
            // 
            this.studentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Location = new System.Drawing.Point(3, 3);
            this.studentTable.Name = "studentTable";
            this.studentTable.ReadOnly = true;
            this.studentTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.studentTable.RowTemplate.Height = 24;
            this.studentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentTable.Size = new System.Drawing.Size(1245, 379);
            this.studentTable.TabIndex = 0;
            this.studentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellContentClick);
            // 
            // students
            // 
            this.students.AutoSize = true;
            this.students.BackColor = System.Drawing.Color.White;
            this.students.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.students.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students.ForeColor = System.Drawing.Color.Black;
            this.students.Location = new System.Drawing.Point(469, 34);
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
            this.Classes.Location = new System.Drawing.Point(331, 34);
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
            this.calender.Location = new System.Drawing.Point(184, 34);
            this.calender.Name = "calender";
            this.calender.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.calender.Size = new System.Drawing.Size(120, 45);
            this.calender.TabIndex = 4;
            this.calender.Text = "Calender";
            this.calender.Click += new System.EventHandler(this.calender_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoutButton.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(1436, 49);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.logoutButton.Size = new System.Drawing.Size(107, 45);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "log out";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1783, 841);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.loggedInPanel);
            this.Controls.Add(this.loginPanel);
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
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox deansPassword;
        private System.Windows.Forms.TextBox deansUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.TextBox psychBox;
        private System.Windows.Forms.TextBox historyBox;
        private System.Windows.Forms.TextBox foreignBox;
        private System.Windows.Forms.TextBox englishBox;
        private System.Windows.Forms.TextBox scienceBox;
        private System.Windows.Forms.TextBox mathBox;
        private System.Windows.Forms.Label psychLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label scienceLabel;
        private System.Windows.Forms.Label mathLabel;
        private System.Windows.Forms.Label selectedGpa;
        private System.Windows.Forms.Label selectedName;
        private System.Windows.Forms.Label saveButton;
        private System.Windows.Forms.Label logoutButton;
    }
}