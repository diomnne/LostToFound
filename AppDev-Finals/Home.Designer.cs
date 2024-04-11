namespace AppDev_Finals
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_sidebar = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lost2Found = new Guna.UI.WinForms.GunaButton();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.btn_logout = new Guna.UI.WinForms.GunaButton();
            this.btn_notif = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.White;
            this.pnl_header.Controls.Add(this.btn_notif);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.btn_sidebar);
            this.pnl_header.Controls.Add(this.flowLayoutPanel7);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(2560, 120);
            this.pnl_header.TabIndex = 5;
            // 
            // btn_sidebar
            // 
            this.btn_sidebar.BackColor = System.Drawing.Color.Transparent;
            this.btn_sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sidebar.BackgroundImage")));
            this.btn_sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sidebar.FlatAppearance.BorderSize = 0;
            this.btn_sidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sidebar.Location = new System.Drawing.Point(28, 38);
            this.btn_sidebar.Name = "btn_sidebar";
            this.btn_sidebar.Size = new System.Drawing.Size(45, 45);
            this.btn_sidebar.TabIndex = 0;
            this.btn_sidebar.UseVisualStyleBackColor = false;
            this.btn_sidebar.Click += new System.EventHandler(this.btn_sidebar_Click);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel7.Controls.Add(this.Lost2Found);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(1134, 7);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(354, 107);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // Lost2Found
            // 
            this.Lost2Found.AnimationHoverSpeed = 0.07F;
            this.Lost2Found.AnimationSpeed = 0.03F;
            this.Lost2Found.BaseColor = System.Drawing.Color.Transparent;
            this.Lost2Found.BorderColor = System.Drawing.Color.Transparent;
            this.Lost2Found.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lost2Found.Font = new System.Drawing.Font("Impact", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lost2Found.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.Lost2Found.Image = ((System.Drawing.Image)(resources.GetObject("Lost2Found.Image")));
            this.Lost2Found.ImageSize = new System.Drawing.Size(30, 30);
            this.Lost2Found.Location = new System.Drawing.Point(3, 3);
            this.Lost2Found.Name = "Lost2Found";
            this.Lost2Found.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Lost2Found.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Lost2Found.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.Lost2Found.OnHoverImage = null;
            this.Lost2Found.OnPressedColor = System.Drawing.Color.Transparent;
            this.Lost2Found.Size = new System.Drawing.Size(390, 107);
            this.Lost2Found.TabIndex = 0;
            this.Lost2Found.Text = "Lost2Found";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.sidebar.Controls.Add(this.gunaButton2);
            this.sidebar.Controls.Add(this.gunaButton1);
            this.sidebar.Controls.Add(this.gunaButton3);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btn_logout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 120);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(435, 1480);
            this.sidebar.TabIndex = 6;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(435, 120);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(2125, 1480);
            this.mainpanel.TabIndex = 7;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(3, 115);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(450, 106);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Dashboard";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(3, 3);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(450, 106);
            this.gunaButton2.TabIndex = 1;
            this.gunaButton2.Text = "Profile";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(2487, 38);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 45);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(3, 227);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(450, 106);
            this.gunaButton3.TabIndex = 2;
            this.gunaButton3.Text = "Manage Items";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_logout
            // 
            this.btn_logout.AnimationHoverSpeed = 0.07F;
            this.btn_logout.AnimationSpeed = 0.03F;
            this.btn_logout.BaseColor = System.Drawing.Color.Transparent;
            this.btn_logout.BorderColor = System.Drawing.Color.Black;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_logout.Location = new System.Drawing.Point(3, 1301);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_logout.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_logout.OnHoverImage = null;
            this.btn_logout.OnPressedColor = System.Drawing.Color.Black;
            this.btn_logout.Size = new System.Drawing.Size(450, 106);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_notif
            // 
            this.btn_notif.BackColor = System.Drawing.Color.Transparent;
            this.btn_notif.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_notif.BackgroundImage")));
            this.btn_notif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_notif.FlatAppearance.BorderSize = 0;
            this.btn_notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notif.Location = new System.Drawing.Point(2406, 38);
            this.btn_notif.Name = "btn_notif";
            this.btn_notif.Size = new System.Drawing.Size(45, 45);
            this.btn_notif.TabIndex = 7;
            this.btn_notif.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 956);
            this.panel1.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(2560, 1600);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnl_header.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private Guna.UI.WinForms.GunaButton Lost2Found;
        private System.Windows.Forms.Button btn_sidebar;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer sidebarTransition;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Button btn_exit;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton btn_logout;
        private System.Windows.Forms.Button btn_notif;
        private System.Windows.Forms.Panel panel1;
    }
}