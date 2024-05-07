namespace AppDev_Finals
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label6 = new System.Windows.Forms.Label();
            this.btn_upload = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_itemname = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_placefound = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_reportedBy = new Guna.UI.WinForms.GunaTextBox();
            this.btn_addItem = new Guna.UI.WinForms.GunaButton();
            this.choice_lost = new Guna.UI.WinForms.GunaRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.choice_found = new Guna.UI.WinForms.GunaRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.image1 = new Guna.UI.WinForms.GunaPictureBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(62, 662);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(503, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Upload an image (Acceptable File types: jpg, png)";
            // 
            // btn_upload
            // 
            this.btn_upload.AnimationHoverSpeed = 0.07F;
            this.btn_upload.AnimationSpeed = 0.03F;
            this.btn_upload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_upload.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_upload.BorderSize = 1;
            this.btn_upload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_upload.ForeColor = System.Drawing.Color.Black;
            this.btn_upload.Image = null;
            this.btn_upload.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_upload.Location = new System.Drawing.Point(67, 703);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.btn_upload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_upload.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_upload.OnHoverImage = null;
            this.btn_upload.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_upload.Radius = 5;
            this.btn_upload.Size = new System.Drawing.Size(570, 48);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Choose File";
            this.btn_upload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txt_itemname);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(661, 72);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(638, 102);
            this.flowLayoutPanel2.TabIndex = 0;
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
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.txt_placefound);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(661, 173);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(638, 102);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location";
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
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label3);
            this.flowLayoutPanel5.Controls.Add(this.datePicker);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(661, 370);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
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
            this.datePicker.TabIndex = 7;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Controls.Add(this.timePicker);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(661, 466);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel6.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time";
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
            this.timePicker.TabIndex = 7;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label5);
            this.flowLayoutPanel7.Controls.Add(this.txt_description);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(661, 566);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(638, 196);
            this.flowLayoutPanel7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description (Optional)";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.txt_reportedBy);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(661, 274);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(638, 90);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reported by (User email)";
            // 
            // txt_reportedBy
            // 
            this.txt_reportedBy.BaseColor = System.Drawing.Color.White;
            this.txt_reportedBy.BorderColor = System.Drawing.Color.Silver;
            this.txt_reportedBy.BorderSize = 1;
            this.txt_reportedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reportedBy.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_reportedBy.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.txt_reportedBy.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_reportedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_reportedBy.Location = new System.Drawing.Point(3, 33);
            this.txt_reportedBy.Name = "txt_reportedBy";
            this.txt_reportedBy.PasswordChar = '\0';
            this.txt_reportedBy.Radius = 5;
            this.txt_reportedBy.Size = new System.Drawing.Size(550, 50);
            this.txt_reportedBy.TabIndex = 9;
            // 
            // btn_addItem
            // 
            this.btn_addItem.AnimationHoverSpeed = 0.07F;
            this.btn_addItem.AnimationSpeed = 0.03F;
            this.btn_addItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_addItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_addItem.BorderSize = 1;
            this.btn_addItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.Image = null;
            this.btn_addItem.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_addItem.Location = new System.Drawing.Point(664, 780);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_addItem.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_addItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_addItem.OnHoverImage = null;
            this.btn_addItem.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btn_addItem.Radius = 5;
            this.btn_addItem.Size = new System.Drawing.Size(553, 60);
            this.btn_addItem.TabIndex = 15;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
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
            this.panel1.Location = new System.Drawing.Point(67, 769);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 102);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(67, 877);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 72);
            this.panel2.TabIndex = 19;
            // 
            // image1
            // 
            this.image1.BaseColor = System.Drawing.Color.White;
            this.image1.Image = ((System.Drawing.Image)(resources.GetObject("image1.Image")));
            this.image1.Location = new System.Drawing.Point(67, 72);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(570, 570);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 20;
            this.image1.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 1038);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Lost Items";
            this.Load += new System.EventHandler(this.Report_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton btn_upload;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaTextBox txt_itemname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_placefound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txt_description;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton btn_addItem;
        private Guna.UI.WinForms.GunaRadioButton choice_lost;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaRadioButton choice_found;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox image1;
        private Guna.UI.WinForms.GunaTextBox txt_reportedBy;
    }
}