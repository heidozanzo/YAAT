using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityTracker
{
    public partial class Overlay : Form
    {
        public Form Parent_Form;
        public Overlay()
        {
            InitializeComponent();
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);

        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            Hide();
            Parent_Form.Show();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Normal)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            System.Environment.Exit(0);
        }
    }
}
