using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace CollegeWebsite
{
    public partial class Website : Form
    {
        int width;


        public Website()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) => { Website.VerticalScroll.Value = vScrollBar1.Value; };
            //Website.Controls.Add(vScrollBar1);

            banner.Left = 0;
            navigation.Left = 0;
            
            aboutPage.Left = 0;
            admissionPage.Left = 0;
            academicsPage.Left = 0;
            researchPage.Left = 0;
            campusPage.Left = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BreakoutTitle_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
            admissionPage.Visible = false;
            academicsPage.Visible = false;
            researchPage.Visible = false;
            campusPage.Visible = false;
        }

        private void About_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = true;
            admissionPage.Visible = false;
            academicsPage.Visible = false;
            researchPage.Visible = false;
            campusPage.Visible = false;
        }

        private void Academics_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
            admissionPage.Visible = false;
            academicsPage.Visible = true;
            researchPage.Visible = false;
            campusPage.Visible = false;
        }

        private void Research_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
            admissionPage.Visible = false;
            academicsPage.Visible = false;
            researchPage.Visible = true;
            campusPage.Visible = false;
        }

        private void CampusLife_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
            admissionPage.Visible = false;
            academicsPage.Visible = false;
            researchPage.Visible = false;
            campusPage.Visible = true;
        }

        private void Admission_Click(object sender, EventArgs e)
        {
            aboutPage.Visible = false;
            admissionPage.Visible = true;
            academicsPage.Visible = false;
            researchPage.Visible = false;
            campusPage.Visible = false;
        }

        private void Website_Load(object sender, EventArgs e)
        {
            width = this.Width;

            banner.Width = width;
            navigation.Width = width;

            aboutPage.Width = width;
            admissionPage.Width = width;
            academicsPage.Width = width;
            researchPage.Width = width;
            campusPage.Width = width;
        }
    }
}
