namespace WindowsFormsApp2
{
    partial class takeNames
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
            this.newName = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.Button();
            this.addedNames = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.displayListOfNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.change = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpaDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentLast = new System.Windows.Forms.Label();
            this.scienceGrade = new System.Windows.Forms.TextBox();
            this.englishGrade = new System.Windows.Forms.TextBox();
            this.frenchGrade = new System.Windows.Forms.TextBox();
            this.historyGrade = new System.Windows.Forms.TextBox();
            this.psychologyGrade = new System.Windows.Forms.TextBox();
            this.mathGrade = new System.Windows.Forms.TextBox();
            this.nameError = new System.Windows.Forms.Label();
            this.startWebsite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newName
            // 
            this.newName.AutoSize = true;
            this.newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newName.Location = new System.Drawing.Point(27, 9);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(102, 25);
            this.newName.TabIndex = 0;
            this.newName.Text = "first name:";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(140, 13);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(265, 22);
            this.first.TabIndex = 1;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(476, 24);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(110, 39);
            this.addName.TabIndex = 3;
            this.addName.Text = "add name";
            this.addName.UseVisualStyleBackColor = true;
            this.addName.Click += new System.EventHandler(this.addName_Click);
            // 
            // addedNames
            // 
            this.addedNames.FormattingEnabled = true;
            this.addedNames.ItemHeight = 16;
            this.addedNames.Location = new System.Drawing.Point(32, 100);
            this.addedNames.Name = "addedNames";
            this.addedNames.Size = new System.Drawing.Size(764, 148);
            this.addedNames.TabIndex = 4;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(32, 266);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(110, 39);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // displayListOfNames
            // 
            this.displayListOfNames.FormattingEnabled = true;
            this.displayListOfNames.ItemHeight = 16;
            this.displayListOfNames.Location = new System.Drawing.Point(20, 101);
            this.displayListOfNames.Name = "displayListOfNames";
            this.displayListOfNames.Size = new System.Drawing.Size(764, 148);
            this.displayListOfNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "last name:";
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(140, 51);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(265, 22);
            this.last.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.change);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.displayListOfNames);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 305);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(20, 255);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(110, 34);
            this.change.TabIndex = 2;
            this.change.Text = "change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Students:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gpaDisplay);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.studentLast);
            this.panel2.Controls.Add(this.scienceGrade);
            this.panel2.Controls.Add(this.englishGrade);
            this.panel2.Controls.Add(this.frenchGrade);
            this.panel2.Controls.Add(this.historyGrade);
            this.panel2.Controls.Add(this.psychologyGrade);
            this.panel2.Controls.Add(this.mathGrade);
            this.panel2.Location = new System.Drawing.Point(14, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 312);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // gpaDisplay
            // 
            this.gpaDisplay.AutoSize = true;
            this.gpaDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaDisplay.Location = new System.Drawing.Point(393, 95);
            this.gpaDisplay.Name = "gpaDisplay";
            this.gpaDisplay.Size = new System.Drawing.Size(64, 25);
            this.gpaDisplay.TabIndex = 15;
            this.gpaDisplay.Text = "label9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Psychology";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "HIstory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "French";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "English";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Science";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Math";
            // 
            // studentLast
            // 
            this.studentLast.AutoSize = true;
            this.studentLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLast.Location = new System.Drawing.Point(48, 82);
            this.studentLast.Name = "studentLast";
            this.studentLast.Size = new System.Drawing.Size(93, 32);
            this.studentLast.TabIndex = 6;
            this.studentLast.Text = "label3";
            // 
            // scienceGrade
            // 
            this.scienceGrade.Location = new System.Drawing.Point(151, 213);
            this.scienceGrade.Name = "scienceGrade";
            this.scienceGrade.Size = new System.Drawing.Size(100, 22);
            this.scienceGrade.TabIndex = 5;
            this.scienceGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // englishGrade
            // 
            this.englishGrade.Location = new System.Drawing.Point(271, 213);
            this.englishGrade.Name = "englishGrade";
            this.englishGrade.Size = new System.Drawing.Size(100, 22);
            this.englishGrade.TabIndex = 4;
            this.englishGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frenchGrade
            // 
            this.frenchGrade.Location = new System.Drawing.Point(396, 213);
            this.frenchGrade.Name = "frenchGrade";
            this.frenchGrade.Size = new System.Drawing.Size(100, 22);
            this.frenchGrade.TabIndex = 3;
            this.frenchGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // historyGrade
            // 
            this.historyGrade.Location = new System.Drawing.Point(520, 213);
            this.historyGrade.Name = "historyGrade";
            this.historyGrade.Size = new System.Drawing.Size(100, 22);
            this.historyGrade.TabIndex = 2;
            this.historyGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // psychologyGrade
            // 
            this.psychologyGrade.Location = new System.Drawing.Point(654, 213);
            this.psychologyGrade.Name = "psychologyGrade";
            this.psychologyGrade.Size = new System.Drawing.Size(100, 22);
            this.psychologyGrade.TabIndex = 1;
            this.psychologyGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mathGrade
            // 
            this.mathGrade.Location = new System.Drawing.Point(30, 213);
            this.mathGrade.Name = "mathGrade";
            this.mathGrade.Size = new System.Drawing.Size(100, 22);
            this.mathGrade.TabIndex = 0;
            this.mathGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.Location = new System.Drawing.Point(602, 24);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 25);
            this.nameError.TabIndex = 9;
            // 
            // startWebsite
            // 
            this.startWebsite.Location = new System.Drawing.Point(44, 357);
            this.startWebsite.Name = "startWebsite";
            this.startWebsite.Size = new System.Drawing.Size(249, 43);
            this.startWebsite.TabIndex = 10;
            this.startWebsite.Text = "open website";
            this.startWebsite.UseVisualStyleBackColor = true;
            this.startWebsite.Click += new System.EventHandler(this.startWebsite_Click);
            // 
            // takeNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 471);
            this.Controls.Add(this.startWebsite);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.last);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.addedNames);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.first);
            this.Controls.Add(this.newName);
            this.Name = "takeNames";
            this.Text = "takeNames";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newName;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Button addName;
        private System.Windows.Forms.ListBox addedNames;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListBox displayListOfNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label studentLast;
        private System.Windows.Forms.TextBox scienceGrade;
        private System.Windows.Forms.TextBox englishGrade;
        private System.Windows.Forms.TextBox frenchGrade;
        private System.Windows.Forms.TextBox historyGrade;
        private System.Windows.Forms.TextBox psychologyGrade;
        private System.Windows.Forms.TextBox mathGrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label gpaDisplay;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Button startWebsite;
    }
}