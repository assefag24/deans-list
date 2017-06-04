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
        public string university;
        public loginpage()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            header.Left = 0;
            footer.Left = 0;
            loggedInPanel.Left = 0;
            
            
            this.ActiveControl = deansUsername;
            deansUsername.Focus();

            loginPanel.Location = new Point(
                 this.ClientSize.Width / 2 - loginPanel.Size.Width / 2,
                 this.ClientSize.Height / 2 - loginPanel.Size.Height / 2);
            loginPanel.Anchor = AnchorStyles.None;

        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            width = this.Width;

            header.Width = width;
            footer.Width = width;
            loggedInPanel.Width = width;

            deansPassword.PasswordChar = '*';
            universityName.Text = university;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (deansUsername.Text == "gamemaster" && deansPassword.Text == "endcurrentgame")
            {
                this.Close();
            }
            else if (deansUsername.Text == username && deansPassword.Text == password)
            {
                deansPassword.Clear();
                deansUsername.Clear();

                loginPanel.Visible = false;
                loggedInPanel.Visible = true;
                logoutButton.Visible = true;
            }
            else{
                deansPassword.Clear();
                deansUsername.Clear();
                incorrectUser.Text = "Username/Password is incorrent";
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
            searchBtn.Visible = false;
            searchText.Visible = false;
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
            searchBtn.Visible = false;
            searchText.Visible = false;
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
            searchBtn.Visible = true;
            searchText.Visible = true;
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

        private void studentTable_CellClick(object sender, DataGridViewCellEventArgs e)
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
            selectedGpa.Text = "GPA: " + gpa;
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
            logoutButton.Visible = false;
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string value = searchText.Text.ToLower();
            int valueL = value.Length;
            value = value.First().ToString().ToUpper() + String.Join("", value.Skip(1));

            foreach (DataGridViewRow row in studentTable.Rows)
            {
                string last = row.Cells[0].Value.ToString();
                string first = row.Cells[1].Value.ToString();
                if (last.StartsWith(value) || first.StartsWith(value) || first + " " + last == value || last + " " + first == value)
                {
                    studentTable.ClearSelection();
                    studentTable.CurrentCell = row.Cells[0];
                    break;
                }
            }
            
        }

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void deansPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
