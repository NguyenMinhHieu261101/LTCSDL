using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1910125_NguyenMinhHieu_CTK43_Lab04
{
    public partial class FormQLSV : Form
    {
        QuanLySinhVien qlsv;
      
        public FormQLSV()
        {
            InitializeComponent();
           
        }

        private Sinhvien GetSinhVien()
        {
            Sinhvien sv = new Sinhvien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.Maso = this.mtbMssv.Text;
            sv.Hoten = this.tbHovaten.Text;
            if (rbNu.Checked)
                gt = false;
            sv.Phai = gt;
            sv.Ngaysinh = this.dtpNgaysinh.Value;
            sv.Diachi = this.tbDiachi.Text;
            sv.Lop = this.cbLop.Text;
            sv.Hinh = this.tbHinh.Text;
            sv.Sdt = this.mtbSdt.Text;
            sv.Email = this.tbEmail.Text;
            return sv;
        }

        private Sinhvien GetSinhVienLV(ListViewItem lvitem)
        {
            Sinhvien sv = new Sinhvien();
            sv.Maso = lvitem.SubItems[0].Text;
            sv.Hoten = lvitem.SubItems[1].Text;
            sv.Phai = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.Phai = true;
            sv.Ngaysinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.Sdt = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.Diachi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;
            return sv;
        }

        private void ThietLapThongTin(Sinhvien sv)
        {
            this.mtbSdt.Text = sv.Maso;
            this.tbHovaten.Text = sv.Hoten;
            if (sv.Phai)
                this.rbNam.Checked = true;
            else
                this.rbNu.Checked = true;
            this.dtpNgaysinh.Value = sv.Ngaysinh;
            this.cbLop.Text = sv.Lop;
            this.mtbSdt.Text = sv.Sdt;
            this.tbEmail.Text = sv.Email;
            this.tbDiachi.Text = sv.Diachi;
            this.tbHinh.Text = sv.Hinh;
            this.frmPicture.ImageLocation = sv.Hinh;

        }

        private void ThemSV(Sinhvien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.Maso);
            lvitem.SubItems.Add(sv.Hoten);
            string gt = "Nữ";
            if (sv.Phai)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.Ngaysinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.Sdt);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.Diachi);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvDssv.Items.Add(lvitem);
        }

        private void LoadListView()
        {
            this.lvDssv.Items.Clear();
            foreach (Sinhvien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }

        private void btChonhinh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Hãy chọn file";
            dlg.Title = "Open file image";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var filename = dlg.FileName;
                tbHinh.Text = filename;
                frmPicture.Load(filename);
            }
        }
        private void btMacdinh_Click_1(object sender, EventArgs e)
        {
            this.mtbMssv.Text = "";
            this.tbHovaten.Text = "";
            this.tbEmail.Text = "";
            this.dtpNgaysinh.Value = DateTime.Now;
            this.tbDiachi.Text = "";
            this.cbLop.Text = this.cbLop.Items[0].ToString();
            this.tbHinh.Text = "";
            this.frmPicture.ImageLocation = "";
            this.rbNam.Checked = true;
            this.mtbSdt.Text = "";
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu danh sách không", "Lưu ý", MessageBoxButtons.YesNoCancel);
            if (dlr == DialogResult.Yes)
            {
                Sinhvien sv = GetSinhVien();
                Sinhvien kq = qlsv.Tim(sv.Maso, delegate (object obj1, object obj2)
                {
                    return (obj2 as Sinhvien).Maso.CompareTo(obj1.ToString());
                });
                this.qlsv.Them(sv);
                this.LoadListView();
                MessageBox.Show("Đã lưu");
            }
            else
            { Application.Exit(); }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Sinhvien sv = GetSinhVien();
            Sinhvien kq = qlsv.Tim(sv.Maso, delegate (object obj1, object obj2)
            {
                return (obj2 as Sinhvien).Maso.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            Sinhvien sv = obj2 as Sinhvien;
            return sv.Maso.CompareTo(obj1);

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvDssv.Items.Count - 1;

            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvDssv.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();

            this.btMacdinh.PerformClick();
        }

        private void tảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sinhvien sv = GetSinhVien();
            Sinhvien kq = qlsv.Tim(sv.Maso, delegate (object obj1, object obj2)
            {
                return (obj2 as Sinhvien).Maso.CompareTo(obj1.ToString());
            });
            LoadListView();


        }

        private void lvDssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDssv.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDssv.SelectedItems[0];
                Sinhvien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void gbTtsv_Enter(object sender, EventArgs e)
        {

        }

        private void FormQLSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void frmPicture_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}