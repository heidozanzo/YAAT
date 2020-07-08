namespace ActivityTracker
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_Hours_Text = new System.Windows.Forms.Label();
            this.lbl_Hours_Value = new System.Windows.Forms.Label();
            this.lbl_Actual_Proyect_text = new System.Windows.Forms.Label();
            this.hour_timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_proyects = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_retract = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Add_New_Project = new System.Windows.Forms.Button();
            this.txt_New_Project = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(161)))), ((int)(((byte)(4)))));
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_start.Location = new System.Drawing.Point(5, 144);
            this.btn_start.Margin = new System.Windows.Forms.Padding(5);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(116, 22);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Comenzar";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(161)))), ((int)(((byte)(4)))));
            this.btn_stop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_stop.Location = new System.Drawing.Point(131, 144);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(5, 5, 7, 5);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(177, 22);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Detener";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // lbl_Hours_Text
            // 
            this.lbl_Hours_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hours_Text.AutoSize = true;
            this.lbl_Hours_Text.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hours_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Hours_Text.Location = new System.Drawing.Point(3, 68);
            this.lbl_Hours_Text.Name = "lbl_Hours_Text";
            this.lbl_Hours_Text.Size = new System.Drawing.Size(120, 71);
            this.lbl_Hours_Text.TabIndex = 2;
            this.lbl_Hours_Text.Text = "Tiempo:";
            this.lbl_Hours_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Hours_Value
            // 
            this.lbl_Hours_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hours_Value.AutoSize = true;
            this.lbl_Hours_Value.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hours_Value.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Hours_Value.Location = new System.Drawing.Point(129, 68);
            this.lbl_Hours_Value.Name = "lbl_Hours_Value";
            this.lbl_Hours_Value.Size = new System.Drawing.Size(183, 71);
            this.lbl_Hours_Value.TabIndex = 3;
            this.lbl_Hours_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Actual_Proyect_text
            // 
            this.lbl_Actual_Proyect_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Actual_Proyect_text.AutoSize = true;
            this.lbl_Actual_Proyect_text.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_Actual_Proyect_text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Actual_Proyect_text.Location = new System.Drawing.Point(8, 35);
            this.lbl_Actual_Proyect_text.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.lbl_Actual_Proyect_text.Name = "lbl_Actual_Proyect_text";
            this.lbl_Actual_Proyect_text.Size = new System.Drawing.Size(115, 33);
            this.lbl_Actual_Proyect_text.TabIndex = 4;
            this.lbl_Actual_Proyect_text.Text = "Proyecto Actual:";
            this.lbl_Actual_Proyect_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hour_timer
            // 
            this.hour_timer.Tick += new System.EventHandler(this.Hour_timer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.06515F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.93485F));
            this.tableLayoutPanel1.Controls.Add(this.btn_start, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_stop, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Hours_Text, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Hours_Value, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Actual_Proyect_text, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_proyects, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 171);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // cb_proyects
            // 
            this.cb_proyects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_proyects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_proyects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_proyects.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_proyects.FormattingEnabled = true;
            this.cb_proyects.Location = new System.Drawing.Point(129, 38);
            this.cb_proyects.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.cb_proyects.Name = "cb_proyects";
            this.cb_proyects.Size = new System.Drawing.Size(179, 25);
            this.cb_proyects.TabIndex = 5;
            this.cb_proyects.SelectedIndexChanged += new System.EventHandler(this.Cb_proyects_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(126, 32);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Backup);
            this.panel1.Controls.Add(this.btn_retract);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 26);
            this.panel1.TabIndex = 8;
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Backup.BackgroundImage")));
            this.btn_Backup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Backup.FlatAppearance.BorderSize = 0;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.Location = new System.Drawing.Point(88, 4);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(19, 19);
            this.btn_Backup.TabIndex = 11;
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.Btn_Backup_Click);
            // 
            // btn_retract
            // 
            this.btn_retract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.btn_retract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_retract.BackgroundImage")));
            this.btn_retract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_retract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_retract.FlatAppearance.BorderSize = 0;
            this.btn_retract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_retract.Location = new System.Drawing.Point(8, 4);
            this.btn_retract.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btn_retract.MaximumSize = new System.Drawing.Size(30, 30);
            this.btn_retract.Name = "btn_retract";
            this.btn_retract.Size = new System.Drawing.Size(19, 19);
            this.btn_retract.TabIndex = 6;
            this.btn_retract.UseVisualStyleBackColor = false;
            this.btn_retract.Click += new System.EventHandler(this.Btn_retract_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_minimize.Location = new System.Drawing.Point(48, 4);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.btn_minimize.MaximumSize = new System.Drawing.Size(30, 30);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(19, 19);
            this.btn_minimize.TabIndex = 7;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.26966F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.73034F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Add_New_Project, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_New_Project, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(126, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(189, 32);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // btn_Add_New_Project
            // 
            this.btn_Add_New_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(101)))), ((int)(((byte)(166)))));
            this.btn_Add_New_Project.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add_New_Project.BackgroundImage")));
            this.btn_Add_New_Project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add_New_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add_New_Project.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Add_New_Project.FlatAppearance.BorderSize = 0;
            this.btn_Add_New_Project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_New_Project.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add_New_Project.Location = new System.Drawing.Point(162, 3);
            this.btn_Add_New_Project.Name = "btn_Add_New_Project";
            this.btn_Add_New_Project.Size = new System.Drawing.Size(24, 26);
            this.btn_Add_New_Project.TabIndex = 0;
            this.btn_Add_New_Project.UseVisualStyleBackColor = false;
            this.btn_Add_New_Project.Click += new System.EventHandler(this.Btn_Add_New_Project_Click);
            // 
            // txt_New_Project
            // 
            this.txt_New_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_New_Project.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_New_Project.Location = new System.Drawing.Point(3, 3);
            this.txt_New_Project.Name = "txt_New_Project";
            this.txt_New_Project.Size = new System.Drawing.Size(153, 25);
            this.txt_New_Project.TabIndex = 1;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Haz click para maximizarme!";
            this.notifyIcon.BalloonTipTitle = "Activity Tracker";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Activity Tracker";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(315, 171);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Activity Tracker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_Hours_Text;
        private System.Windows.Forms.Label lbl_Hours_Value;
        private System.Windows.Forms.Label lbl_Actual_Proyect_text;
        private System.Windows.Forms.Timer hour_timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_proyects;
        private System.Windows.Forms.Button btn_retract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Add_New_Project;
        private System.Windows.Forms.TextBox txt_New_Project;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Backup;
    }
}

