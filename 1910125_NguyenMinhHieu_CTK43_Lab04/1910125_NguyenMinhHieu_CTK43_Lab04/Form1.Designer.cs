
namespace _1910125_NguyenMinhHieu_CTK43_Lab04
{
    partial class FormQLSV
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
            this.frmPicture = new System.Windows.Forms.PictureBox();
            this.gbTtsv = new System.Windows.Forms.GroupBox();
            this.mtbSdt = new System.Windows.Forms.MaskedTextBox();
            this.mtbMssv = new System.Windows.Forms.MaskedTextBox();
            this.btChonhinh = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbHinh = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbHovaten = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btMacdinh = new System.Windows.Forms.Button();
            this.lbPhai = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbHovaten = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.lbHinh = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbDssv = new System.Windows.Forms.GroupBox();
            this.lvDssv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.frmPicture)).BeginInit();
            this.gbTtsv.SuspendLayout();
            this.gbDssv.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmPicture
            // 
            this.frmPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frmPicture.Location = new System.Drawing.Point(24, 24);
            this.frmPicture.Name = "frmPicture";
            this.frmPicture.Size = new System.Drawing.Size(293, 361);
            this.frmPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frmPicture.TabIndex = 0;
            this.frmPicture.TabStop = false;
            this.frmPicture.Click += new System.EventHandler(this.frmPicture_Click);
            // 
            // gbTtsv
            // 
            this.gbTtsv.Controls.Add(this.mtbSdt);
            this.gbTtsv.Controls.Add(this.mtbMssv);
            this.gbTtsv.Controls.Add(this.btChonhinh);
            this.gbTtsv.Controls.Add(this.cbLop);
            this.gbTtsv.Controls.Add(this.rbNu);
            this.gbTtsv.Controls.Add(this.rbNam);
            this.gbTtsv.Controls.Add(this.dtpNgaysinh);
            this.gbTtsv.Controls.Add(this.tbHinh);
            this.gbTtsv.Controls.Add(this.tbDiachi);
            this.gbTtsv.Controls.Add(this.tbEmail);
            this.gbTtsv.Controls.Add(this.tbHovaten);
            this.gbTtsv.Controls.Add(this.btThoat);
            this.gbTtsv.Controls.Add(this.btLuu);
            this.gbTtsv.Controls.Add(this.btMacdinh);
            this.gbTtsv.Controls.Add(this.lbPhai);
            this.gbTtsv.Controls.Add(this.lbSdt);
            this.gbTtsv.Controls.Add(this.lbLop);
            this.gbTtsv.Controls.Add(this.lbHovaten);
            this.gbTtsv.Controls.Add(this.lbEmail);
            this.gbTtsv.Controls.Add(this.lbDiachi);
            this.gbTtsv.Controls.Add(this.lbHinh);
            this.gbTtsv.Controls.Add(this.lbNgaysinh);
            this.gbTtsv.Controls.Add(this.lbName);
            this.gbTtsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTtsv.Location = new System.Drawing.Point(342, 24);
            this.gbTtsv.Name = "gbTtsv";
            this.gbTtsv.Size = new System.Drawing.Size(717, 361);
            this.gbTtsv.TabIndex = 1;
            this.gbTtsv.TabStop = false;
            this.gbTtsv.Text = "Thông tin sinh viên";
            this.gbTtsv.Enter += new System.EventHandler(this.gbTtsv_Enter);
            // 
            // mtbSdt
            // 
            this.mtbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSdt.Location = new System.Drawing.Point(459, 189);
            this.mtbSdt.Mask = "0000.000.000";
            this.mtbSdt.Name = "mtbSdt";
            this.mtbSdt.Size = new System.Drawing.Size(240, 28);
            this.mtbSdt.TabIndex = 8;
            // 
            // mtbMssv
            // 
            this.mtbMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbMssv.Location = new System.Drawing.Point(108, 44);
            this.mtbMssv.Mask = "0000000";
            this.mtbMssv.Name = "mtbMssv";
            this.mtbMssv.Size = new System.Drawing.Size(240, 28);
            this.mtbMssv.TabIndex = 0;
            // 
            // btChonhinh
            // 
            this.btChonhinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChonhinh.Location = new System.Drawing.Point(588, 232);
            this.btChonhinh.Name = "btChonhinh";
            this.btChonhinh.Size = new System.Drawing.Size(102, 40);
            this.btChonhinh.TabIndex = 9;
            this.btChonhinh.Text = "Chọn hình";
            this.btChonhinh.UseVisualStyleBackColor = true;
            this.btChonhinh.Click += new System.EventHandler(this.btChonhinh_Click_1);
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK40",
            "CTK45"});
            this.cbLop.Location = new System.Drawing.Point(459, 136);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(240, 28);
            this.cbLop.TabIndex = 7;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(585, 86);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(51, 24);
            this.rbNu.TabIndex = 6;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(474, 86);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(65, 24);
            this.rbNam.TabIndex = 5;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(459, 44);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(240, 27);
            this.dtpNgaysinh.TabIndex = 4;
            this.dtpNgaysinh.ValueChanged += new System.EventHandler(this.dtpNgaysinh_ValueChanged);
            // 
            // tbHinh
            // 
            this.tbHinh.Location = new System.Drawing.Point(108, 245);
            this.tbHinh.Name = "tbHinh";
            this.tbHinh.ReadOnly = true;
            this.tbHinh.Size = new System.Drawing.Size(456, 27);
            this.tbHinh.TabIndex = 17;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(108, 192);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(240, 27);
            this.tbDiachi.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(108, 137);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(240, 27);
            this.tbEmail.TabIndex = 2;
            // 
            // tbHovaten
            // 
            this.tbHovaten.Location = new System.Drawing.Point(108, 86);
            this.tbHovaten.Name = "tbHovaten";
            this.tbHovaten.Size = new System.Drawing.Size(240, 27);
            this.tbHovaten.TabIndex = 1;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(585, 297);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(105, 40);
            this.btThoat.TabIndex = 12;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(434, 297);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(105, 40);
            this.btLuu.TabIndex = 11;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btMacdinh
            // 
            this.btMacdinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMacdinh.Location = new System.Drawing.Point(286, 297);
            this.btMacdinh.Name = "btMacdinh";
            this.btMacdinh.Size = new System.Drawing.Size(102, 40);
            this.btMacdinh.TabIndex = 10;
            this.btMacdinh.Text = "Mặc định";
            this.btMacdinh.UseVisualStyleBackColor = true;
            this.btMacdinh.Click += new System.EventHandler(this.btMacdinh_Click_1);
            // 
            // lbPhai
            // 
            this.lbPhai.AutoSize = true;
            this.lbPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhai.Location = new System.Drawing.Point(354, 88);
            this.lbPhai.Name = "lbPhai";
            this.lbPhai.Size = new System.Drawing.Size(51, 25);
            this.lbPhai.TabIndex = 0;
            this.lbPhai.Text = "Phái";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(354, 192);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(53, 25);
            this.lbSdt.TabIndex = 0;
            this.lbSdt.Text = "SĐT";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(354, 139);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(45, 25);
            this.lbLop.TabIndex = 0;
            this.lbLop.Text = "Lớp";
            // 
            // lbHovaten
            // 
            this.lbHovaten.AutoSize = true;
            this.lbHovaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHovaten.Location = new System.Drawing.Point(6, 88);
            this.lbHovaten.Name = "lbHovaten";
            this.lbHovaten.Size = new System.Drawing.Size(95, 25);
            this.lbHovaten.TabIndex = 0;
            this.lbHovaten.Text = "Họ và tên";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 139);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 25);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiachi.Location = new System.Drawing.Point(6, 192);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(71, 25);
            this.lbDiachi.TabIndex = 0;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // lbHinh
            // 
            this.lbHinh.AutoSize = true;
            this.lbHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinh.Location = new System.Drawing.Point(6, 247);
            this.lbHinh.Name = "lbHinh";
            this.lbHinh.Size = new System.Drawing.Size(52, 25);
            this.lbHinh.TabIndex = 0;
            this.lbHinh.Text = "Hình";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaysinh.Location = new System.Drawing.Point(354, 46);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(99, 25);
            this.lbNgaysinh.TabIndex = 0;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 46);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "MSSV";
            // 
            // gbDssv
            // 
            this.gbDssv.Controls.Add(this.lvDssv);
            this.gbDssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDssv.Location = new System.Drawing.Point(24, 401);
            this.gbDssv.Name = "gbDssv";
            this.gbDssv.Size = new System.Drawing.Size(1035, 298);
            this.gbDssv.TabIndex = 0;
            this.gbDssv.TabStop = false;
            this.gbDssv.Text = "Danh sách sinh viên";
            // 
            // lvDssv
            // 
            this.lvDssv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvDssv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDssv.GridLines = true;
            this.lvDssv.HideSelection = false;
            this.lvDssv.Location = new System.Drawing.Point(3, 23);
            this.lvDssv.Name = "lvDssv";
            this.lvDssv.Size = new System.Drawing.Size(1029, 272);
            this.lvDssv.TabIndex = 0;
            this.lvDssv.UseCompatibleStateImageBehavior = false;
            this.lvDssv.View = System.Windows.Forms.View.Details;
            this.lvDssv.SelectedIndexChanged += new System.EventHandler(this.lvDssv_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 171;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa chỉ";
            this.columnHeader8.Width = 182;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hình";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "File GIF|*.Gif|File JPEG|*.Jpg";
            // 
            // FormQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 722);
            this.Controls.Add(this.gbDssv);
            this.Controls.Add(this.gbTtsv);
            this.Controls.Add(this.frmPicture);
            this.Name = "FormQLSV";
            this.Text = "Quan ly thong tin sinh vien khoa CNTT";
            this.Load += new System.EventHandler(this.FormQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmPicture)).EndInit();
            this.gbTtsv.ResumeLayout(false);
            this.gbTtsv.PerformLayout();
            this.gbDssv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox frmPicture;
        private System.Windows.Forms.GroupBox gbTtsv;
        private System.Windows.Forms.MaskedTextBox mtbSdt;
        private System.Windows.Forms.MaskedTextBox mtbMssv;
        private System.Windows.Forms.Button btChonhinh;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox tbHinh;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbHovaten;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btMacdinh;
        private System.Windows.Forms.Label lbPhai;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbHovaten;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.Label lbHinh;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbDssv;
        private System.Windows.Forms.ListView lvDssv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

