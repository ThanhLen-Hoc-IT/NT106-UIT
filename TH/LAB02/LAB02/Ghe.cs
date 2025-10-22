using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    
    public class Ghe
    {
        public int MaPhong { get; set; }     // Ví dụ: 1, 2, ...
        public string MaGhe { get; set; }       // Ví dụ: A1, B2, ...
        public bool DaBan { get; set; }         // true nếu đã bán
        public double HeSoGia { get; set; }     // 0.25, 1, 2
            

        public Ghe(int maPhong, string maGhe, double heSo, double giaVeChuan)
        {
            MaPhong = maPhong;
            MaGhe = maGhe;
            HeSoGia = heSo;
           
            DaBan = false;
        }

        public double tinhGiaGhe(double heSo, Phim ph)
        {
            return heSo * ph.GiaVeChuan;
        }

       
    }
}

