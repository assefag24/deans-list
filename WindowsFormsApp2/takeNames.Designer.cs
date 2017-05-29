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
            this.label1 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.TextBox();
            this.nameError = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.saveUser = new System.Windows.Forms.Button();
            this.passwordInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newName
            // 
            this.newName.AutoSize = true;
            this.newName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newName.Location = new System.Drawing.Point(27, 142);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(109, 25);
            this.newName.TabIndex = 0;
            this.newName.Text = "First name:";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(140, 146);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(265, 22);
            this.first.TabIndex = 1;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(424, 158);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(209, 39);
            this.addName.TabIndex = 3;
            this.addName.Text = "add name";
            this.addName.UseVisualStyleBackColor = true;
            this.addName.Click += new System.EventHandler(this.addName_Click);
            // 
            // addedNames
            // 
            this.addedNames.FormattingEnabled = true;
            this.addedNames.ItemHeight = 16;
            this.addedNames.Location = new System.Drawing.Point(15, 264);
            this.addedNames.Name = "addedNames";
            this.addedNames.Size = new System.Drawing.Size(618, 148);
            this.addedNames.TabIndex = 4;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(195, 440);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(256, 39);
            this.start.TabIndex = 5;
            this.start.Text = "Start New Game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last name:";
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(140, 184);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(265, 22);
            this.last.TabIndex = 2;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.Location = new System.Drawing.Point(146, 221);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 25);
            this.nameError.TabIndex = 9;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(140, 66);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(265, 22);
            this.password.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(27, 63);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(140, 28);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(265, 22);
            this.username.TabIndex = 12;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(27, 24);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 25);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username";
            // 
            // saveUser
            // 
            this.saveUser.Location = new System.Drawing.Point(424, 39);
            this.saveUser.Name = "saveUser";
            this.saveUser.Size = new System.Drawing.Size(209, 39);
            this.saveUser.TabIndex = 15;
            this.saveUser.Text = "Save Username/Password";
            this.saveUser.UseVisualStyleBackColor = true;
            this.saveUser.Click += new System.EventHandler(this.saveUser_Click);
            // 
            // passwordInfo
            // 
            this.passwordInfo.AutoSize = true;
            this.passwordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInfo.Location = new System.Drawing.Point(146, 102);
            this.passwordInfo.Name = "passwordInfo";
            this.passwordInfo.Size = new System.Drawing.Size(0, 25);
            this.passwordInfo.TabIndex = 16;
            // 
            // takeNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 511);
            this.Controls.Add(this.passwordInfo);
            this.Controls.Add(this.saveUser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.last);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.addedNames);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.first);
            this.Controls.Add(this.newName);
            this.Name = "takeNames";
            this.Text = "takeNames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newName;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Button addName;
        private System.Windows.Forms.ListBox addedNames;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button saveUser;
        private System.Windows.Forms.Label passwordInfo;
    }
}