using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SL
{
   
    public partial class Form1 : Form
    {
        string[] files;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            files = Directory.GetFiles(Application.StartupPath + @"\AnhSlide");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
                btnS.Text = "Stop";
            }
            else
            {
                timer.Stop();
                btnS.Text = "Start";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (i == files.Length)
            {
                timer.Stop();
                i = 0;
                btnS.Text = "Start";
            }
            else
            {
                FileInfo file = new FileInfo(files[i]);

                var anhDaiDien = Image.FromFile(Application.StartupPath + @"\AnhSlide\" + file.Name);
                pictureBox.Image = anhDaiDien;

                i++;
            }
        }
    }
}
