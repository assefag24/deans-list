using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace loginform
{
    public partial class loginpage : Form
    {
        int width;
        public string username;
        public string password;

        public loginpage()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            header.Left = 0;
            footer.Left = 0;
            loggedInPanel.Left = 0;
            
            
        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            width = this.Width;

            header.Width = width;
            footer.Width = width;
            loggedInPanel.Width = width;

            deansPassword.PasswordChar = '*';

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (deansUsername.Text == username && deansPassword.Text == password)
            {
                loginPanel.Visible = false;
                loggedInPanel.Visible = true;
            }
            if (deansUsername.Text == "gamemaster" && deansPassword.Text == "endcurrentgame")
            {
                this.Close();                
            }
            
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

        private void editLabel_Click(object sender, EventArgs e)
        {          
            editPanel.Visible = true;
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            editPanel.Visible = false;
            string m = mathBox.Text;
            string s = scienceBox.Text;
            string en = englishBox.Text;
            string f = foreignBox.Text;
            string h = historyBox.Text;
            string p = psychBox.Text;
            
            studentTable.CurrentRow.Cells[2].Value = m;
            studentTable.CurrentRow.Cells[3].Value = s;
            studentTable.CurrentRow.Cells[4].Value = en;
            studentTable.CurrentRow.Cells[5].Value = f;
            studentTable.CurrentRow.Cells[6].Value = h;
            studentTable.CurrentRow.Cells[7].Value = p;
            studentTable.CurrentRow.Cells[8].Value = calcGpa(m, s, en, f, h, p);


        }

        private void studentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string first = studentTable.CurrentRow.Cells[1].Value.ToString();
            string last = studentTable.CurrentRow.Cells[0].Value.ToString();
            string m = studentTable.CurrentRow.Cells[2].Value.ToString();
            string s = studentTable.CurrentRow.Cells[3].Value.ToString();
            string en = studentTable.CurrentRow.Cells[4].Value.ToString();
            string f = studentTable.CurrentRow.Cells[5].Value.ToString();
            string h = studentTable.CurrentRow.Cells[6].Value.ToString();
            string p = studentTable.CurrentRow.Cells[7].Value.ToString();
            string gpa = studentTable.CurrentRow.Cells[8].Value.ToString();
            selectedName.Text = last + ", " + first;
            selectedGpa.Text = "GPA: "+gpa;
            mathBox.Text = m;
            scienceBox.Text = s;
            englishBox.Text = en;
            foreignBox.Text = f;
            historyBox.Text = h;
            psychBox.Text = p;
        }

        public decimal calcGpa(string m, string s, string e, string f, string h, string p)
        {
            decimal mN = gradeReturn(m);
            decimal sN = gradeReturn(s);
            decimal eN = gradeReturn(e);
            decimal fN = gradeReturn(f);
            decimal hN = gradeReturn(h);
            decimal pN = gradeReturn(p);

            decimal gpa = mN + sN + eN + fN + hN + pN;
            gpa = gpa / 6;
            gpa = Math.Round(gpa, 1);

            return gpa;
        }

        public decimal gradeReturn(string x)
        {
            if (x == "F")
            {
                return .0M;
            }
            else if (x == "D")
            {
                return 1.0M;
            }
            else if (x == "C")
            {
                return 2.33M;
            }
            else if (x == "B")
            {
                return 3.33M;
            }
            else if (x == "A")
            {
                return 4.0M;
            }
            else
            {
                return 0.0M;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loggedInPanel.Visible = false;
            loginPanel.Visible = true;
            this.Close();
        }
    }
}
