namespace AppDev_Finals
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.profilePanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // profilePanel
            // 
            this.profilePanel.BaseColor = System.Drawing.Color.White;
            this.profilePanel.Location = new System.Drawing.Point(802, 187);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Radius = 5;
            this.profilePanel.ShadowColor = System.Drawing.Color.Black;
            this.profilePanel.ShadowDepth = 90;
            this.profilePanel.ShadowShift = 15;
            this.profilePanel.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.profilePanel.Size = new System.Drawing.Size(753, 1068);
            this.profilePanel.TabIndex = 2;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(2467, 1480);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaShadowPanel profilePanel;
    }
}