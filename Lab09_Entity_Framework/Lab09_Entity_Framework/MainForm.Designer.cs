
namespace Lab09_Entity_Framework
{
    partial class MainForm
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
            this.btnReloadCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnReloadFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReloadCategory
            // 
            this.btnReloadCategory.BackColor = System.Drawing.Color.LightGray;
            this.btnReloadCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadCategory.Location = new System.Drawing.Point(200, 4);
            this.btnReloadCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadCategory.Name = "btnReloadCategory";
            this.btnReloadCategory.Size = new System.Drawing.Size(72, 46);
            this.btnReloadCategory.TabIndex = 0;
            this.btnReloadCategory.Text = "R";
            this.btnReloadCategory.UseVisualStyleBackColor = false;
            this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.LightGray;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(280, 4);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(72, 46);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục";
            // 
            // tvwCategory
            // 
            this.tvwCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tvwCategory.Location = new System.Drawing.Point(19, 58);
            this.tvwCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(368, 519);
            this.tvwCategory.TabIndex = 2;
            this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
            this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thực đơn";
            // 
            // lvwFood
            // 
            this.lvwFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lvwFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwFood.FullRowSelect = true;
            this.lvwFood.GridLines = true;
            this.lvwFood.HideSelection = false;
            this.lvwFood.Location = new System.Drawing.Point(395, 58);
            this.lvwFood.Margin = new System.Windows.Forms.Padding(4);
            this.lvwFood.MultiSelect = false;
            this.lvwFood.Name = "lvwFood";
            this.lvwFood.Size = new System.Drawing.Size(655, 519);
            this.lvwFood.TabIndex = 3;
            this.lvwFood.UseCompatibleStateImageBehavior = false;
            this.lvwFood.View = System.Windows.Forms.View.Details;
            this.lvwFood.SelectedIndexChanged += new System.EventHandler(this.lvwFood_SelectedIndexChanged);
            this.lvwFood.DoubleClick += new System.EventHandler(this.lvwFood_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đồ ăn thức uống";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐV Tính";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá bán";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nhóm mặt hàng";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi chú";
            this.columnHeader6.Width = 213;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.LightGray;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(977, 4);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(73, 46);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "+";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(885, 4);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(73, 46);
            this.btnDeleteFood.TabIndex = 4;
            this.btnDeleteFood.Text = "-";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.BackColor = System.Drawing.Color.LightGray;
            this.btnReloadFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadFood.Location = new System.Drawing.Point(787, 4);
            this.btnReloadFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(73, 46);
            this.btnReloadFood.TabIndex = 4;
            this.btnReloadFood.Text = "R";
            this.btnReloadFood.UseVisualStyleBackColor = false;
            this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1062, 590);
            this.Controls.Add(this.btnReloadFood);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lvwFood);
            this.Controls.Add(this.tvwCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnReloadCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReloadCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnReloadFood;
    }
}

