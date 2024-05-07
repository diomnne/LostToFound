namespace AppDev_Finals
{
    partial class ItemRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.category = new Guna.UI.WinForms.GunaLabel();
            this.itemName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.status = new Guna.UI.WinForms.GunaLabel();
            this.timefound = new Guna.UI.WinForms.GunaLabel();
            this.datefound = new Guna.UI.WinForms.GunaLabel();
            this.location = new Guna.UI.WinForms.GunaLabel();
            this.email = new Guna.UI.WinForms.GunaLabel();
            this.itemID = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(411, 32);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(106, 32);
            this.category.TabIndex = 0;
            this.category.Text = "category";
            this.category.Click += new System.EventHandler(this.status_Click);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(103, 32);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(129, 32);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "item name";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.status);
            this.gunaLinePanel1.Controls.Add(this.timefound);
            this.gunaLinePanel1.Controls.Add(this.datefound);
            this.gunaLinePanel1.Controls.Add(this.location);
            this.gunaLinePanel1.Controls.Add(this.email);
            this.gunaLinePanel1.Controls.Add(this.itemID);
            this.gunaLinePanel1.Controls.Add(this.category);
            this.gunaLinePanel1.Controls.Add(this.itemName);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1930, 95);
            this.gunaLinePanel1.TabIndex = 3;
            this.gunaLinePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaLinePanel1_Paint);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(1682, 32);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 32);
            this.status.TabIndex = 7;
            this.status.Text = "status";
            // 
            // timefound
            // 
            this.timefound.AutoSize = true;
            this.timefound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timefound.Location = new System.Drawing.Point(1116, 32);
            this.timefound.Name = "timefound";
            this.timefound.Size = new System.Drawing.Size(133, 32);
            this.timefound.TabIndex = 6;
            this.timefound.Text = "time found";
            // 
            // datefound
            // 
            this.datefound.AutoSize = true;
            this.datefound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefound.Location = new System.Drawing.Point(978, 32);
            this.datefound.Name = "datefound";
            this.datefound.Size = new System.Drawing.Size(132, 32);
            this.datefound.TabIndex = 5;
            this.datefound.Text = "date found";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(601, 32);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(99, 32);
            this.location.TabIndex = 4;
            this.location.Text = "location";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(1283, 32);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(72, 32);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            // 
            // itemID
            // 
            this.itemID.AutoSize = true;
            this.itemID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemID.Location = new System.Drawing.Point(23, 32);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(40, 32);
            this.itemID.TabIndex = 2;
            this.itemID.Text = "ID";
            // 
            // ItemRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(227)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ItemRow";
            this.Size = new System.Drawing.Size(1930, 97);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel category;
        private Guna.UI.WinForms.GunaLabel itemName;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel itemID;
        private Guna.UI.WinForms.GunaLabel email;
        private Guna.UI.WinForms.GunaLabel datefound;
        private Guna.UI.WinForms.GunaLabel location;
        private Guna.UI.WinForms.GunaLabel timefound;
        private Guna.UI.WinForms.GunaLabel status;
    }
}
