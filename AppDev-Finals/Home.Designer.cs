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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_sidebar = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lost2Found = new Guna.UI.WinForms.GunaButton();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lastname = new System.Windows.Forms.Label();
            this.profil = new System.Windows.Forms.Panel();
            this.profilepic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.firstname = new System.Windows.Forms.Label();
            this.btn_profile = new Guna.UI.WinForms.GunaButton();
            this.btn_dashboard = new Guna.UI.WinForms.GunaButton();
            this.btn_manage = new Guna.UI.WinForms.GunaButton();
            this.btn_addNewItem = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new Guna.UI.WinForms.GunaButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnl_header.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.profil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.White;
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.btn_sidebar);
            this.pnl_header.Controls.Add(this.flowLayoutPanel7);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(2560, 120);
            this.pnl_header.TabIndex = 5;
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
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btn_profile);
            this.sidebar.Controls.Add(this.btn_dashboard);
            this.sidebar.Controls.Add(this.btn_manage);
            this.sidebar.Controls.Add(this.btn_addNewItem);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btn_logout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 120);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(435, 1480);
            this.sidebar.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lastname);
            this.panel2.Controls.Add(this.profil);
            this.panel2.Controls.Add(this.firstname);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 480);
            this.panel2.TabIndex = 5;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.BackColor = System.Drawing.Color.Transparent;
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.White;
            this.lastname.Location = new System.Drawing.Point(108, 357);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(134, 37);
            this.lastname.TabIndex = 3;
            this.lastname.Text = "lastname";
            // 
            // profil
            // 
            this.profil.BackColor = System.Drawing.Color.Transparent;
            this.profil.Controls.Add(this.profilepic);
            this.profil.Location = new System.Drawing.Point(114, 100);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(200, 200);
            this.profil.TabIndex = 2;
            // 
            // profilepic
            // 
            this.profilepic.BaseColor = System.Drawing.Color.Gainsboro;
            this.profilepic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilepic.Image = ((System.Drawing.Image)(resources.GetObject("profilepic.Image")));
            this.profilepic.Location = new System.Drawing.Point(0, 0);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(200, 200);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 0;
            this.profilepic.TabStop = false;
            this.profilepic.UseTransfarantBackground = false;
            this.profilepic.Click += new System.EventHandler(this.profilepic_Click);
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.Color.Transparent;
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.White;
            this.firstname.Location = new System.Drawing.Point(108, 322);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(140, 37);
            this.firstname.TabIndex = 1;
            this.firstname.Text = "firstname";
            // 
            // btn_profile
            // 
            this.btn_profile.AnimationHoverSpeed = 0.07F;
            this.btn_profile.AnimationSpeed = 0.03F;
            this.btn_profile.BaseColor = System.Drawing.Color.Transparent;
            this.btn_profile.BorderColor = System.Drawing.Color.Black;
            this.btn_profile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_profile.Location = new System.Drawing.Point(3, 489);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_profile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_profile.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_profile.OnHoverImage = null;
            this.btn_profile.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_profile.Size = new System.Drawing.Size(450, 106);
            this.btn_profile.TabIndex = 1;
            this.btn_profile.Text = "Profile";
            this.btn_profile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.AnimationHoverSpeed = 0.07F;
            this.btn_dashboard.AnimationSpeed = 0.03F;
            this.btn_dashboard.BaseColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BorderColor = System.Drawing.Color.Black;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dashboard.Location = new System.Drawing.Point(3, 601);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_dashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dashboard.OnHoverImage = null;
            this.btn_dashboard.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_dashboard.Size = new System.Drawing.Size(450, 106);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            this.btn_dashboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_dashboard_MouseUp);
            // 
            // btn_manage
            // 
            this.btn_manage.AnimationHoverSpeed = 0.07F;
            this.btn_manage.AnimationSpeed = 0.03F;
            this.btn_manage.BaseColor = System.Drawing.Color.Transparent;
            this.btn_manage.BorderColor = System.Drawing.Color.Black;
            this.btn_manage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.ForeColor = System.Drawing.Color.White;
            this.btn_manage.Image = ((System.Drawing.Image)(resources.GetObject("btn_manage.Image")));
            this.btn_manage.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_manage.Location = new System.Drawing.Point(3, 713);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_manage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_manage.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_manage.OnHoverImage = null;
            this.btn_manage.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_manage.Size = new System.Drawing.Size(450, 106);
            this.btn_manage.TabIndex = 2;
            this.btn_manage.Text = "Manage Items";
            this.btn_manage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_addNewItem
            // 
            this.btn_addNewItem.AnimationHoverSpeed = 0.07F;
            this.btn_addNewItem.AnimationSpeed = 0.03F;
            this.btn_addNewItem.BaseColor = System.Drawing.Color.Transparent;
            this.btn_addNewItem.BorderColor = System.Drawing.Color.Black;
            this.btn_addNewItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewItem.ForeColor = System.Drawing.Color.White;
            this.btn_addNewItem.Image = ((System.Drawing.Image)(resources.GetObject("btn_addNewItem.Image")));
            this.btn_addNewItem.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_addNewItem.Location = new System.Drawing.Point(3, 825);
            this.btn_addNewItem.Name = "btn_addNewItem";
            this.btn_addNewItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_addNewItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_addNewItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_addNewItem.OnHoverImage = null;
            this.btn_addNewItem.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(196)))), ((int)(((byte)(122)))));
            this.btn_addNewItem.Size = new System.Drawing.Size(450, 106);
            this.btn_addNewItem.TabIndex = 6;
            this.btn_addNewItem.Text = "Add New Item";
            this.btn_addNewItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addNewItem.Click += new System.EventHandler(this.btn_addNewItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 937);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 355);
            this.panel1.TabIndex = 4;
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
            this.btn_logout.Location = new System.Drawing.Point(3, 1298);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btn_logout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_logout.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_logout.OnHoverImage = null;
            this.btn_logout.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_logout.Size = new System.Drawing.Size(450, 106);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.profil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
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
        private Guna.UI.WinForms.GunaButton btn_dashboard;
        private Guna.UI.WinForms.GunaButton btn_profile;
        private System.Windows.Forms.Button btn_exit;
        private Guna.UI.WinForms.GunaButton btn_manage;
        private Guna.UI.WinForms.GunaButton btn_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Panel profil;
        private Guna.UI.WinForms.GunaButton btn_addNewItem;
        private Guna.UI.WinForms.GunaCirclePictureBox profilepic;
        private System.Windows.Forms.Label lastname;
    }
}