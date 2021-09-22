using System;
using System.Collections.Generic;
using System.IO;

using System.Text;

namespace _1910125_NguyenMinhHieu_CTK43_Lab04
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        
        public List<Sinhvien> DanhSach;
        

        public QuanLySinhVien()
        {
            DanhSach = new List<Sinhvien>();
        }
        public void Them(Sinhvien sv)
        {
            this.DanhSach.Add(sv);
        }

        public Sinhvien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        public Sinhvien Tim(object obj, SoSanh ss)
        {
            Sinhvien svresult = null;
            foreach (Sinhvien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;

        }


        public bool Sua(Sinhvien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }
        public void DocTuFile()
        {
            string filename = "DanhSachSV.txt", t;
            string[] s;
            Sinhvien sv;
            StreamReader sr = new StreamReader(
                new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new Sinhvien();
                sv.Maso = s[0];
                sv.Hoten = s[1];
                sv.Phai = false;
                if (s[2] == "1")
                    sv.Phai = true;
                sv.Ngaysinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.Sdt = s[5];
                sv.Email = s[6];
                sv.Diachi = s[7];
                sv.Hinh = s[8];

                this.Them(sv);
            }
        }
    }

}
