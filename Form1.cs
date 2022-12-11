using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace VividITAdminTool
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

    

        private void MainApp_Load(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipText = "Welcome to Vivid IT Admin Tool for Enterprise!!";
            notifyIcon.BalloonTipTitle = "Welcome Message";
            notifyIcon.ShowBalloonTip(1000);

        }

        private void MainApp_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        // Reset Windows Update button link here... 
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        // Reset Network button link here...

        }

        private void button3_Click(object sender, EventArgs e)
        {

        // Runs gpupdate /f command button link here...

        }

        private void button4_Click(object sender, EventArgs e)
        {

        // Runs one drive registry fix button link here...

        }

        private void button5_Click(object sender, EventArgs e)
        {

        // Reset WMI button link here...

        }

        private void button6_Click(object sender, EventArgs e)
        {

        // Runs SCCM Repair script button link here...

        }

        private void button7_Click(object sender, EventArgs e)
        {

        // Launches Windows Quick Assist button link here...

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
            Environment.Exit(0);
        }
    }
}