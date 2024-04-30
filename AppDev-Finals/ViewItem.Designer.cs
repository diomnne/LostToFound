namespace AppDev_Finals
{
    partial class ViewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewItem));
            this.choice_found = new Guna.UI.WinForms.GunaRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.choice_lost = new Guna.UI.WinForms.GunaRadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_itemname = new Guna.UI.WinForms.GunaTextBox();
            this.txt_timefound = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_placefound = new Guna.UI.WinForms.GunaTextBox();
            this.txt_datefound = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new Guna.UI.WinForms.GunaTextBox();
            this.txt_itemtype = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.image1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // choice_found
            // 
            this.choice_found.BaseColor = System.Drawing.SystemColors.Control;
            this.choice_found.CheckedOffColor = System.Drawing.Color.Gray;
            this.choice_found.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(39)))));
            this.choice_found.FillColor = System.Drawing.Color.White;
            this.choice_found.Location = new System.Drawing.Point(195, 43);
            this.choice_found.Name = "choice_found";
            this.choice_found.Size = new System.Drawing.Size(94, 28);
            this.choice_found.TabIndex = 17;
            this.choice_found.Text = "Found";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.choice_found);
            this.panel1.Controls.Add(this.choice_lost);
            this.panel1.Location = new System.Drawing.Point(72, 677);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 102);
            this.panel1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Category";
            // 
            // choice_lost
            // 
            this.choice_lost.BaseColor = System.Drawing.SystemColors.Control;
            this.choice_lost.CheckedOffColor = System.Drawing.Color.Gray;
            this.choice_lost.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(39)))));
            this.choice_lost.FillColor = System.Drawing.Color.White;
            this.choice_lost.Location = new System.Drawing.Point(0, 43);
            this.choice_lost.Name = "choice_lost";
            this.choice_lost.Size = new System.Drawing.Size(74, 28);
            this.choice_lost.TabIndex = 16;
            this.choice_lost.Text = "Lost";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txt_itemname);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(666, 89);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(638, 102);
            this.flowLayoutPanel2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item name";
            // 
            // txt_itemname
            // 
            this.txt_itemname.BaseColor = System.Drawing.Color.White;
            this.txt_itemname.BorderColor = System.Drawing.Color.Silver;
            this.txt_itemname.BorderSize = 1;
            this.txt_itemname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemname.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_itemname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_itemname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_itemname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_itemname.Location = new System.Drawing.Point(3, 33);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.PasswordChar = '\0';
            this.txt_itemname.Radius = 5;
            this.txt_itemname.Size = new System.Drawing.Size(550, 50);
            this.txt_itemname.TabIndex = 8;
            // 
            // txt_timefound
            // 
            this.txt_timefound.BaseColor = System.Drawing.Color.White;
            this.txt_timefound.BorderColor = System.Drawing.Color.Silver;
            this.txt_timefound.BorderSize = 1;
            this.txt_timefound.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timefound.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_timefound.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_timefound.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_timefound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_timefound.Location = new System.Drawing.Point(3, 33);
            this.txt_timefound.Name = "txt_timefound";
            this.txt_timefound.PasswordChar = '\0';
            this.txt_timefound.Radius = 5;
            this.txt_timefound.Size = new System.Drawing.Size(550, 50);
            this.txt_timefound.TabIndex = 11;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Controls.Add(this.txt_timefound);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(666, 483);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel6.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time Found";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Place Found";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.txt_placefound);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(666, 190);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(638, 102);
            this.flowLayoutPanel4.TabIndex = 37;
            // 
            // txt_placefound
            // 
            this.txt_placefound.BaseColor = System.Drawing.Color.White;
            this.txt_placefound.BorderColor = System.Drawing.Color.Silver;
            this.txt_placefound.BorderSize = 1;
            this.txt_placefound.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_placefound.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_placefound.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_placefound.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_placefound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_placefound.Location = new System.Drawing.Point(3, 33);
            this.txt_placefound.Name = "txt_placefound";
            this.txt_placefound.PasswordChar = '\0';
            this.txt_placefound.Radius = 5;
            this.txt_placefound.Size = new System.Drawing.Size(550, 50);
            this.txt_placefound.TabIndex = 8;
            // 
            // txt_datefound
            // 
            this.txt_datefound.BaseColor = System.Drawing.Color.White;
            this.txt_datefound.BorderColor = System.Drawing.Color.Silver;
            this.txt_datefound.BorderSize = 1;
            this.txt_datefound.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_datefound.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_datefound.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_datefound.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_datefound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_datefound.Location = new System.Drawing.Point(3, 33);
            this.txt_datefound.Name = "txt_datefound";
            this.txt_datefound.PasswordChar = '\0';
            this.txt_datefound.Radius = 5;
            this.txt_datefound.Size = new System.Drawing.Size(550, 50);
            this.txt_datefound.TabIndex = 10;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label3);
            this.flowLayoutPanel5.Controls.Add(this.txt_datefound);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(666, 387);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel5.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Found";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label5);
            this.flowLayoutPanel7.Controls.Add(this.txt_description);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(666, 583);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(638, 196);
            this.flowLayoutPanel7.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.BaseColor = System.Drawing.Color.White;
            this.txt_description.BorderColor = System.Drawing.Color.Silver;
            this.txt_description.BorderSize = 1;
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_description.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_description.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_description.Location = new System.Drawing.Point(3, 33);
            this.txt_description.MultiLine = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.Radius = 5;
            this.txt_description.Size = new System.Drawing.Size(550, 86);
            this.txt_description.TabIndex = 8;
            // 
            // txt_itemtype
            // 
            this.txt_itemtype.BaseColor = System.Drawing.Color.White;
            this.txt_itemtype.BorderColor = System.Drawing.Color.Silver;
            this.txt_itemtype.BorderSize = 1;
            this.txt_itemtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemtype.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_itemtype.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_itemtype.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_itemtype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_itemtype.Location = new System.Drawing.Point(3, 33);
            this.txt_itemtype.Name = "txt_itemtype";
            this.txt_itemtype.PasswordChar = '\0';
            this.txt_itemtype.Radius = 5;
            this.txt_itemtype.Size = new System.Drawing.Size(550, 50);
            this.txt_itemtype.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.txt_itemtype);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(666, 291);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Item Type";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(72, 810);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 134);
            this.panel2.TabIndex = 44;
            // 
            // image1
            // 
            this.image1.BaseColor = System.Drawing.Color.White;
            this.image1.Image = ((System.Drawing.Image)(resources.GetObject("image1.Image")));
            this.image1.Location = new System.Drawing.Point(67, 72);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(570, 570);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 45;
            this.image1.TabStop = false;
            // 
            // ViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 1039);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "ViewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaRadioButton choice_found;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaRadioButton choice_lost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_itemname;
        private Guna.UI.WinForms.GunaTextBox txt_timefound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI.WinForms.GunaTextBox txt_placefound;
        private Guna.UI.WinForms.GunaTextBox txt_datefound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_description;
        private Guna.UI.WinForms.GunaTextBox txt_itemtype;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox image1;
    }
}