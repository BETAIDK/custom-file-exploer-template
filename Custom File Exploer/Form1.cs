using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_File_Exploer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description="select your path " })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    WebBrowser.Url = new Uri(fbd.SelectedPath);
                }
                    
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoBack)
                WebBrowser.GoBack();
        }

        private void Froward_Click(object sender, EventArgs e)
        {
            if (WebBrowser.CanGoForward)
                WebBrowser.GoForward();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
