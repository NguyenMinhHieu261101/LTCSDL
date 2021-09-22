using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1910125_NguyenMinhHieu_CTK43_Lab04
{
    public class Sinhvien
    {
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }
        public string Hinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public bool Phai { get; set; }
        public string Lop { get; set; }
        public string Sdt { get; set; }

        public Sinhvien()
        {
        }

        public Sinhvien(string ms, string ht, string em, string dc, string h, DateTime ns, bool p, string l, string sdt)
        {
            this.Maso = ms;
            this.Hoten = ht;
            this.Email = em;
            this.Diachi = dc;
            this.Hinh = h;
            this.Ngaysinh = ns;
            this.Phai = p;
            this.Lop = l;
            this.Sdt = sdt;
        }
    }
}
