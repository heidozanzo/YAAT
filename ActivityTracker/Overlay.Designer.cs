namespace ActivityTracker
{
    partial class Overlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.lbl_Actual_Project = new System.Windows.Forms.Label();
            this.lbl_Actual_Project_Value = new System.Windows.Forms.Label();
            this.lbl_Actual_Time_Value = new System.Windows.Forms.Label();
            this.lbl_Hours_Text = new System.Windows.Forms.Label();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Actual_Project
            // 
            this.lbl_Actual_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Actual_Project.AutoSize = true;
            this.lbl_Actual_Project.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actual_Project.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Actual_Project.Location = new System.Drawing.Point(14, 49);
            this.lbl_Actual_Project.Name = "lbl_Actual_Project";
            this.lbl_Actual_Project.Size = new System.Drawing.Size(132, 25);
            this.lbl_Actual_Project.TabIndex = 6;
            this.lbl_Actual_Project.Text = "En el proyecto";
            this.lbl_Actual_Project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Actual_Project_Value
            // 
            this.lbl_Actual_Project_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Actual_Project_Value.AutoSize = true;
            this.lbl_Actual_Project_Value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actual_Project_Value.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Actual_Project_Value.Location = new System.Drawing.Point(152, 49);
            this.lbl_Actual_Project_Value.Name = "lbl_Actual_Project_Value";
            this.lbl_Actual_Project_Value.Size = new System.Drawing.Size(0, 25);
            this.lbl_Actual_Project_Value.TabIndex = 7;
            this.lbl_Actual_Project_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Actual_Time_Value
            // 
            this.lbl_Actual_Time_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Actual_Time_Value.AutoSize = true;
            this.lbl_Actual_Time_Value.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actual_Time_Value.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Actual_Time_Value.Location = new System.Drawing.Point(152, 9);
            this.lbl_Actual_Time_Value.Name = "lbl_Actual_Time_Value";
            this.lbl_Actual_Time_Value.Size = new System.Drawing.Size(0, 40);
            this.lbl_Actual_Time_Value.TabIndex = 8;
            this.lbl_Actual_Time_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Hours_Text
            // 
            this.lbl_Hours_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Hours_Text.AutoSize = true;
            this.lbl_Hours_Text.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hours_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Hours_Text.Location = new System.Drawing.Point(12, 9);
            this.lbl_Hours_Text.Name = "lbl_Hours_Text";
            this.lbl_Hours_Text.Size = new System.Drawing.Size(119, 40);
            this.lbl_Hours_Text.TabIndex = 4;
            this.lbl_Hours_Text.Text = "Tiempo:";
            this.lbl_Hours_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Maximize.BackgroundImage")));
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Location = new System.Drawing.Point(2, 1);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(19, 18);
            this.btn_Maximize.TabIndex = 9;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.BackgroundImage")));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(268, 1);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(19, 18);
            this.btn_Minimize.TabIndex = 10;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Haz click para maximizarme!";
            this.notifyIcon.BalloonTipTitle = "Activity Tracker";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Activity Tracker";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(293, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(19, 18);
            this.btn_close.TabIndex = 11;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(315, 77);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Maximize);
            this.Controls.Add(this.lbl_Actual_Time_Value);
            this.Controls.Add(this.lbl_Actual_Project_Value);
            this.Controls.Add(this.lbl_Actual_Project);
            this.Controls.Add(this.lbl_Hours_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Overlay";
            this.Text = "s";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Actual_Project;
        public System.Windows.Forms.Label lbl_Actual_Project_Value;
        public System.Windows.Forms.Label lbl_Actual_Time_Value;
        private System.Windows.Forms.Label lbl_Hours_Text;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Minimize;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btn_close;
    }
}