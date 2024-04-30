namespace AppDev_Finals
{
    partial class ManageRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRow));
            this.timefound = new Guna.UI.WinForms.GunaLabel();
            this.datefound = new Guna.UI.WinForms.GunaLabel();
            this.placefound = new Guna.UI.WinForms.GunaLabel();
            this.itemID = new Guna.UI.WinForms.GunaLabel();
            this.category = new Guna.UI.WinForms.GunaLabel();
            this.itemName = new Guna.UI.WinForms.GunaLabel();
            this.btn_show = new Guna.UI.WinForms.GunaButton();
            this.btn_edit = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.btn_claimed = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timefound
            // 
            this.timefound.AutoSize = true;
            this.timefound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timefound.Location = new System.Drawing.Point(1035, 32);
            this.timefound.Name = "timefound";
            this.timefound.Size = new System.Drawing.Size(133, 32);
            this.timefound.TabIndex = 13;
            this.timefound.Text = "time found";
            // 
            // datefound
            // 
            this.datefound.AutoSize = true;
            this.datefound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefound.Location = new System.Drawing.Point(883, 32);
            this.datefound.Name = "datefound";
            this.datefound.Size = new System.Drawing.Size(132, 32);
            this.datefound.TabIndex = 12;
            this.datefound.Text = "date found";
            // 
            // placefound
            // 
            this.placefound.AutoSize = true;
            this.placefound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placefound.Location = new System.Drawing.Point(579, 32);
            this.placefound.Name = "placefound";
            this.placefound.Size = new System.Drawing.Size(141, 32);
            this.placefound.TabIndex = 11;
            this.placefound.Text = "place found";
            // 
            // itemID
            // 
            this.itemID.AutoSize = true;
            this.itemID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemID.Location = new System.Drawing.Point(23, 30);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(40, 32);
            this.itemID.TabIndex = 9;
            this.itemID.Text = "ID";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(387, 30);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(106, 32);
            this.category.TabIndex = 7;
            this.category.Text = "category";
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(103, 30);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(129, 32);
            this.itemName.TabIndex = 8;
            this.itemName.Text = "item name";
            // 
            // btn_show
            // 
            this.btn_show.AnimationHoverSpeed = 0.07F;
            this.btn_show.AnimationSpeed = 0.03F;
            this.btn_show.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_show.BorderColor = System.Drawing.Color.Black;
            this.btn_show.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_show.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.Image")));
            this.btn_show.ImageSize = new System.Drawing.Size(8, 8);
            this.btn_show.Location = new System.Drawing.Point(1291, 32);
            this.btn_show.Name = "btn_show";
            this.btn_show.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_show.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_show.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_show.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_show.OnHoverImage")));
            this.btn_show.OnPressedColor = System.Drawing.Color.Black;
            this.btn_show.Radius = 3;
            this.btn_show.Size = new System.Drawing.Size(193, 42);
            this.btn_show.TabIndex = 14;
            this.btn_show.Text = "Show more";
            this.btn_show.Click += new System.EventHandler(this.show_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AnimationHoverSpeed = 0.07F;
            this.btn_edit.AnimationSpeed = 0.03F;
            this.btn_edit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_edit.BorderColor = System.Drawing.Color.Black;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(69)))), ((int)(((byte)(78)))));
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageSize = new System.Drawing.Size(8, 8);
            this.btn_edit.Location = new System.Drawing.Point(1502, 32);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_edit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_edit.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.OnHoverImage")));
            this.btn_edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_edit.Radius = 3;
            this.btn_edit.Size = new System.Drawing.Size(109, 42);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.btn_claimed);
            this.gunaLinePanel1.Controls.Add(this.itemName);
            this.gunaLinePanel1.Controls.Add(this.btn_edit);
            this.gunaLinePanel1.Controls.Add(this.category);
            this.gunaLinePanel1.Controls.Add(this.btn_show);
            this.gunaLinePanel1.Controls.Add(this.itemID);
            this.gunaLinePanel1.Controls.Add(this.timefound);
            this.gunaLinePanel1.Controls.Add(this.datefound);
            this.gunaLinePanel1.Controls.Add(this.placefound);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1930, 95);
            this.gunaLinePanel1.TabIndex = 16;
            // 
            // btn_claimed
            // 
            this.btn_claimed.AnimationHoverSpeed = 0.07F;
            this.btn_claimed.AnimationSpeed = 0.03F;
            this.btn_claimed.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(143)))), ((int)(((byte)(120)))));
            this.btn_claimed.BorderColor = System.Drawing.Color.Black;
            this.btn_claimed.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_claimed.ForeColor = System.Drawing.Color.White;
            this.btn_claimed.Image = ((System.Drawing.Image)(resources.GetObject("btn_claimed.Image")));
            this.btn_claimed.ImageSize = new System.Drawing.Size(8, 8);
            this.btn_claimed.Location = new System.Drawing.Point(1627, 32);
            this.btn_claimed.Name = "btn_claimed";
            this.btn_claimed.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(176)))), ((int)(((byte)(152)))));
            this.btn_claimed.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_claimed.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_claimed.OnHoverImage = null;
            this.btn_claimed.OnPressedColor = System.Drawing.Color.Black;
            this.btn_claimed.Radius = 3;
            this.btn_claimed.Size = new System.Drawing.Size(159, 42);
            this.btn_claimed.TabIndex = 16;
            this.btn_claimed.Text = "Claimed";
            this.btn_claimed.Click += new System.EventHandler(this.btn_claimed_Click);
            // 
            // ManageRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(227)))), ((int)(((byte)(225)))));
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "ManageRow";
            this.Size = new System.Drawing.Size(1930, 97);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel timefound;
        private Guna.UI.WinForms.GunaLabel datefound;
        private Guna.UI.WinForms.GunaLabel placefound;
        private Guna.UI.WinForms.GunaLabel itemID;
        private Guna.UI.WinForms.GunaLabel category;
        private Guna.UI.WinForms.GunaLabel itemName;
        private Guna.UI.WinForms.GunaButton btn_show;
        private Guna.UI.WinForms.GunaButton btn_edit;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaButton btn_claimed;
    }
}
