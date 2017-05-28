using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class loginpage : Form
    {
        int width;

        public loginpage()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            header.Left = 0;
            footer.Left = 0;
            loggedInPanel.Left = 0;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            width = this.Width;

            header.Width = width;
            footer.Width = width;
            loggedInPanel.Width = width;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            loggedInPanel.Visible = true;
        }

        private void calender_Click(object sender, EventArgs e)
        {
            calender.BackColor = Color.FromArgb(140, 21, 21);
            calender.ForeColor = System.Drawing.Color.White;

            Classes.BackColor = System.Drawing.Color.White;
            Classes.ForeColor = System.Drawing.Color.Black;

            students.BackColor = System.Drawing.Color.White;
            students.ForeColor = System.Drawing.Color.Black;

            studentsPanel.Visible = false;
            classesPanel.Visible = false;
        }

        private void Classes_Click(object sender, EventArgs e)
        {
            calender.BackColor = System.Drawing.Color.White;
            calender.ForeColor = System.Drawing.Color.Black;

            Classes.BackColor = Color.FromArgb(140, 21, 21);
            Classes.ForeColor = System.Drawing.Color.White;

            students.BackColor = System.Drawing.Color.White;
            students.ForeColor = System.Drawing.Color.Black;

            classesPanel.Visible = true;
            studentsPanel.Visible = false;
        }

        private void students_Click(object sender, EventArgs e)
        {
            calender.BackColor = System.Drawing.Color.White;
            calender.ForeColor = System.Drawing.Color.Black;

            Classes.BackColor = System.Drawing.Color.White;
            Classes.ForeColor = System.Drawing.Color.Black;

            students.BackColor = Color.FromArgb(140, 21, 21);
            students.ForeColor = System.Drawing.Color.White;

            classesPanel.Visible = true;
            studentsPanel.Visible = true;
        }
    }
}
