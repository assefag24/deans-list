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
        public loginpage()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            header.Left = 0;
            footer.Left = 0;

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
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
