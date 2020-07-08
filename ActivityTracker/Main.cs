using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityTracker
{
    public partial class Main : Form
    {
        Stopwatch StopWatch = new Stopwatch();
        List<Project> list_projects = new List<Project>();
        readonly string initial_path = "activity.json";
        Project actual_project = new Project();
        Overlay timeOverlay = new Overlay();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);

            if (!File.Exists(initial_path))
            {
                Project proj = new Project
                {
                    name = "Seleccione.."
                };
                list_projects.Add(proj);
                Write_New_Project(null);
            }
            else
            {

                using (StreamReader sr = File.OpenText(initial_path))
                {
                    list_projects = JsonConvert.DeserializeObject<List<Project>>(sr.ReadToEnd());

                    Update_Combo_Box();
                }
            }
        }

        private void Hour_timer_Tick(object sender, EventArgs e)
        {
            lbl_Hours_Value.Text = Format_Elapsed(StopWatch.Elapsed);
            timeOverlay.lbl_Actual_Time_Value.Text = lbl_Hours_Value.Text;
            timeOverlay.lbl_Actual_Project_Value.Text = actual_project.name;
            actual_project.elapsed = StopWatch.Elapsed;
            Update_Activity_File();

        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            if(cb_proyects.SelectedIndex != 0)
            {
                Start_time();
            }
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            Stop_time();
        }


        private void Stop_time()
        {
            hour_timer.Stop();
            StopWatch.Stop();
        }

        private void Start_time()
        {
            hour_timer.Start();
            StopWatch.Start();
        }

        private void Btn_Add_New_Project_Click(object sender, EventArgs e)
        {
            if (txt_New_Project.Text.Length != 0)
            {
                Project proj = new Project();
                proj.name = txt_New_Project.Text;
                Write_New_Project(proj);
            }
        }

        private void Write_New_Project(Project proj)
        {
            if (proj != null)
            {
                proj.id = list_projects.Count;
                list_projects.Add(proj);
            }
            Update_Activity_File();

            Update_Combo_Box();

        }

        private void Update_Combo_Box()
        {
            cb_proyects.Items.Clear();
            foreach (Project p in list_projects)
            {
                cb_proyects.Items.Add(p.name);
            }
            cb_proyects.SelectedIndex = 0;

        }

        private void Cb_proyects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_proyects.SelectedIndex != 0)
            {
                var obj = list_projects.FirstOrDefault(x => x.id == actual_project.id);
                if (obj != null) obj.elapsed = actual_project.elapsed;
                Project proj = list_projects[cb_proyects.SelectedIndex];
                Update_Time_Counter(proj.elapsed);
                actual_project = proj;
            }
        }

        private string Format_Elapsed(TimeSpan ts)
        {
            return String.Format("{0:00}:{1:00}:{2:00}",
                                ts.Hours, ts.Minutes, ts.Seconds,
                                ts.Milliseconds / 10);
        }

        private void Update_Time_Counter(TimeSpan actual_counter)
        {
            lbl_Hours_Value.Text = Format_Elapsed(actual_counter);
            StopWatch.Reset();
            StopWatch.SetOffset(actual_counter);
            Stop_time();
        }

        private void Update_Activity_File()
        {
            string JSONresult = JsonConvert.SerializeObject(list_projects);

            if (JSONresult != null)
            {
                using (var tw = new StreamWriter(initial_path, false))
                {
                    tw.Write(JSONresult.ToString());
                    tw.Close();
                }
            }
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Btn_retract_Click(object sender, EventArgs e)
        {
            Hide();
            timeOverlay.Parent_Form = this;
            timeOverlay.Show();
        }

        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            string backup_path = "Backups";
            string file_backup_path = backup_path + "\\" + DateTime.Now.ToString("MMddyyyymmss") + "_" + initial_path;
            if (!Directory.Exists(backup_path))
            {
                Directory.CreateDirectory(backup_path);

            }
            else
            {
                if (!File.Exists(file_backup_path))
                {
                    File.Copy(initial_path, file_backup_path);
                }
            }
        }

        private void ManageFormClosing(Object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
