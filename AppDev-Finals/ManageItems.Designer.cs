namespace AppDev_Finals
{
    partial class ManageItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageItems));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addItem = new Guna.UI.WinForms.GunaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemsTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Management";
            // 
            // btn_addItem
            // 
            this.btn_addItem.AnimationHoverSpeed = 0.07F;
            this.btn_addItem.AnimationSpeed = 0.03F;
            this.btn_addItem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.btn_addItem.BorderColor = System.Drawing.Color.Black;
            this.btn_addItem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.Image = ((System.Drawing.Image)(resources.GetObject("btn_addItem.Image")));
            this.btn_addItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addItem.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_addItem.Location = new System.Drawing.Point(75, 1247);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.btn_addItem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_addItem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_addItem.OnHoverImage = null;
            this.btn_addItem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_addItem.Radius = 5;
            this.btn_addItem.Size = new System.Drawing.Size(290, 81);
            this.btn_addItem.TabIndex = 3;
            this.btn_addItem.Text = "Add New Item";
            this.btn_addItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(143)))), ((int)(((byte)(140)))));
            this.panel3.Location = new System.Drawing.Point(75, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1980, 100);
            this.panel3.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1286, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 37);
            this.label14.TabIndex = 6;
            this.label14.Text = "Actions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(949, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 37);
            this.label13.TabIndex = 5;
            this.label13.Text = "Date and Time";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(579, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(177, 37);
            this.label.TabIndex = 4;
            this.label.Text = "Reported by";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 37);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(386, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(103, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item Name";
            // 
            // itemsTable
            // 
            this.itemsTable.AutoScroll = true;
            this.itemsTable.BackColor = System.Drawing.Color.White;
            this.itemsTable.Location = new System.Drawing.Point(75, 247);
            this.itemsTable.Name = "itemsTable";
            this.itemsTable.Size = new System.Drawing.Size(1980, 959);
            this.itemsTable.TabIndex = 6;
            // 
            // ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(2467, 1480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.itemsTable);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageItems";
            this.Text = "ManageItems";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btn_addItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel itemsTable;
    }
}