using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDM_Crack_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        string fms = $"   --- Internet Download Manager (IDM) ---\n" +
                      $"- IDM Status: {{0}}\n" +
                      $"- Version: {{1}}\n" +
                      $"- Activation Status: {{2}}" ;

        void LoadIDMStatus()
        {
            richTextBox1.Text = string.Format(fms,
                Process_IDM.CheckInstalledIDM() ? "Installed" : "Not Installed!", 
                Process_IDM.CheckInstalledIDM() ? Process_IDM.GetVersionIDM() : "N/A", 
                act, 
                "N/A" 
            );
        }


        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
            cButton1.Location = new Point(this.Width - 34, 2);
            cButton2.Location = new Point(this.Width - cButton1.Width - 34, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PB_Icon.Image = Icon.ToBitmap();
            LB_Form_Text.Text = Text;
            LoadIDMStatus();
        }

        string act = Process_IDM.GetActivationStatus();

    
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.DodgerBlue), 1), 0, 0, this.Width - 1, this.Height - 1);
            base.OnPaint(e);
        }

        private void cButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void cButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Close();
            }
        }

        private void cButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Style = ProgressBarStyle.Marquee;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Process_IDM.DeleteRegistryIDMKey();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            act = Process_IDM.GetActivationStatus();
            LoadIDMStatus();
            MessageBox.Show("Process completed!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cButton4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                backgroundWorker2.RunWorkerAsync();
                progressBar1.Style = ProgressBarStyle.Marquee;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Process_IDM.CrackIDM();
            act = "Activating...";
            LoadIDMStatus();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            act = Process_IDM.GetActivationStatus();
            LoadIDMStatus();
            MessageBox.Show("Process completed!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
