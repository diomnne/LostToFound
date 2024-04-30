namespace AppDev_Finals
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.btn_editprofile = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastname = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_firstname = new Guna.UI.WinForms.GunaTextBox();
            this.profilepic = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_editPfp = new Guna.UI.WinForms.GunaCircleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editprofile
            // 
            this.btn_editprofile.AnimationHoverSpeed = 0.07F;
            this.btn_editprofile.AnimationSpeed = 0.03F;
            this.btn_editprofile.BackColor = System.Drawing.Color.White;
            this.btn_editprofile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_editprofile.BorderColor = System.Drawing.Color.Black;
            this.btn_editprofile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editprofile.ForeColor = System.Drawing.Color.White;
            this.btn_editprofile.Image = ((System.Drawing.Image)(resources.GetObject("btn_editprofile.Image")));
            this.btn_editprofile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_editprofile.ImageSize = new System.Drawing.Size(8, 8);
            this.btn_editprofile.Location = new System.Drawing.Point(3, 333);
            this.btn_editprofile.Name = "btn_editprofile";
            this.btn_editprofile.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_editprofile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_editprofile.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_editprofile.OnHoverImage = null;
            this.btn_editprofile.OnPressedColor = System.Drawing.Color.Black;
            this.btn_editprofile.Radius = 5;
            this.btn_editprofile.Size = new System.Drawing.Size(514, 55);
            this.btn_editprofile.TabIndex = 11;
            this.btn_editprofile.Text = "Save Changes";
            this.btn_editprofile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_editprofile, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(94, 449);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 553);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txt_lastname);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 104);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.BaseColor = System.Drawing.Color.White;
            this.txt_lastname.BorderColor = System.Drawing.Color.Silver;
            this.txt_lastname.BorderSize = 1;
            this.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lastname.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_lastname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_lastname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_lastname.Location = new System.Drawing.Point(3, 33);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PasswordChar = '\0';
            this.txt_lastname.Radius = 5;
            this.txt_lastname.Size = new System.Drawing.Size(514, 50);
            this.txt_lastname.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txt_email);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 223);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(528, 104);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.BaseColor = System.Drawing.Color.White;
            this.txt_email.BorderColor = System.Drawing.Color.Silver;
            this.txt_email.BorderSize = 1;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.Location = new System.Drawing.Point(3, 33);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.Radius = 5;
            this.txt_email.Size = new System.Drawing.Size(514, 50);
            this.txt_email.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.txt_firstname);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(528, 104);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name:";
            // 
            // txt_firstname
            // 
            this.txt_firstname.BaseColor = System.Drawing.Color.White;
            this.txt_firstname.BorderColor = System.Drawing.Color.Silver;
            this.txt_firstname.BorderSize = 1;
            this.txt_firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_firstname.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_firstname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_firstname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_firstname.Location = new System.Drawing.Point(3, 33);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.PasswordChar = '\0';
            this.txt_firstname.Radius = 5;
            this.txt_firstname.Size = new System.Drawing.Size(514, 50);
            this.txt_firstname.TabIndex = 9;
            // 
            // profilepic
            // 
            this.profilepic.BackColor = System.Drawing.Color.Transparent;
            this.profilepic.BaseColor = System.Drawing.Color.Gainsboro;
            this.profilepic.Location = new System.Drawing.Point(204, 96);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(300, 300);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 9;
            this.profilepic.TabStop = false;
            this.profilepic.UseTransfarantBackground = false;
            // 
            // btn_editPfp
            // 
            this.btn_editPfp.AnimationHoverSpeed = 0.07F;
            this.btn_editPfp.AnimationSpeed = 0.03F;
            this.btn_editPfp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_editPfp.BorderColor = System.Drawing.Color.White;
            this.btn_editPfp.BorderSize = 2;
            this.btn_editPfp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editPfp.ForeColor = System.Drawing.Color.White;
            this.btn_editPfp.Image = ((System.Drawing.Image)(resources.GetObject("btn_editPfp.Image")));
            this.btn_editPfp.ImageSize = new System.Drawing.Size(8, 8);
            this.btn_editPfp.Location = new System.Drawing.Point(424, 351);
            this.btn_editPfp.Name = "btn_editPfp";
            this.btn_editPfp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_editPfp.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_editPfp.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_editPfp.OnHoverImage = null;
            this.btn_editPfp.OnPressedColor = System.Drawing.Color.Black;
            this.btn_editPfp.Size = new System.Drawing.Size(45, 45);
            this.btn_editPfp.TabIndex = 12;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 924);
            this.Controls.Add(this.btn_editPfp);
            this.Controls.Add(this.profilepic);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Profile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_editprofile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI.WinForms.GunaCirclePictureBox profilepic;
        private Guna.UI.WinForms.GunaTextBox txt_firstname;
        private Guna.UI.WinForms.GunaTextBox txt_lastname;
        private Guna.UI.WinForms.GunaTextBox txt_email;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleButton btn_editPfp;
    }
}