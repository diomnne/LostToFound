namespace AppDev_Finals
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_editInfo = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_placefound = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_itemname = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.choice_found = new Guna.UI.WinForms.GunaRadioButton();
            this.choice_lost = new Guna.UI.WinForms.GunaRadioButton();
            this.btn_cancel = new Guna.UI.WinForms.GunaButton();
            this.image1 = new Guna.UI.WinForms.GunaPictureBox();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(72, 886);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 55);
            this.panel2.TabIndex = 31;
            // 
            // btn_editInfo
            // 
            this.btn_editInfo.AnimationHoverSpeed = 0.07F;
            this.btn_editInfo.AnimationSpeed = 0.03F;
            this.btn_editInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_editInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_editInfo.BorderSize = 1;
            this.btn_editInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editInfo.ForeColor = System.Drawing.Color.White;
            this.btn_editInfo.Image = null;
            this.btn_editInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_editInfo.Location = new System.Drawing.Point(960, 710);
            this.btn_editInfo.Name = "btn_editInfo";
            this.btn_editInfo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_editInfo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_editInfo.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_editInfo.OnHoverImage = null;
            this.btn_editInfo.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_editInfo.Radius = 5;
            this.btn_editInfo.Size = new System.Drawing.Size(271, 60);
            this.btn_editInfo.TabIndex = 29;
            this.btn_editInfo.Text = "Save";
            this.btn_editInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_editInfo.Click += new System.EventHandler(this.btn_editInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
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
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label5);
            this.flowLayoutPanel7.Controls.Add(this.txt_description);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(666, 479);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(638, 196);
            this.flowLayoutPanel7.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date:";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label3);
            this.flowLayoutPanel5.Controls.Add(this.datePicker);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(666, 283);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel5.TabIndex = 25;
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(3, 33);
            this.datePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2023, 8, 16, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(446, 39);
            this.datePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location:";
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
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.txt_placefound);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(666, 182);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(638, 102);
            this.flowLayoutPanel4.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item name:";
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
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Controls.Add(this.timePicker);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(666, 379);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel6.TabIndex = 26;
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(3, 33);
            this.timePicker.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2023, 8, 16, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(446, 39);
            this.timePicker.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txt_itemname);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(666, 81);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(638, 102);
            this.flowLayoutPanel2.TabIndex = 20;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.choice_found);
            this.panel1.Controls.Add(this.choice_lost);
            this.panel1.Location = new System.Drawing.Point(72, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 102);
            this.panel1.TabIndex = 30;
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
            // btn_cancel
            // 
            this.btn_cancel.AnimationHoverSpeed = 0.07F;
            this.btn_cancel.AnimationSpeed = 0.03F;
            this.btn_cancel.BaseColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_cancel.BorderSize = 1;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_cancel.Image = null;
            this.btn_cancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cancel.Location = new System.Drawing.Point(666, 710);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_cancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_cancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cancel.OnHoverImage = null;
            this.btn_cancel.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_cancel.Radius = 5;
            this.btn_cancel.Size = new System.Drawing.Size(271, 60);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // image1
            // 
            this.image1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image1.BackgroundImage")));
            this.image1.BaseColor = System.Drawing.Color.White;
            this.image1.Location = new System.Drawing.Point(67, 72);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(570, 570);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 33;
            this.image1.TabStop = false;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 1038);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_editInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Information";
            this.Load += new System.EventHandler(this.ItemInfo_Load);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btn_editInfo;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_description;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_placefound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_itemname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaRadioButton choice_found;
        private Guna.UI.WinForms.GunaRadioButton choice_lost;
        private Guna.UI.WinForms.GunaButton btn_cancel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private Guna.UI.WinForms.GunaPictureBox image1;
    }
}