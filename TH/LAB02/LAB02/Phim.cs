using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{

    public class Phim
    {
        public string idPhim { get; set; }
        public string TenPhim { get; set; }
        public double GiaVeChuan { get; set; }
        public List<PhongChieu> PhongChieuList { get; set; }

        public Phim()  
        {
            PhongChieuList = new List<PhongChieu>();
        }

        public Phim(string id, string ten, double gia, List<int> dsPhong)
        {
            idPhim = id;
            TenPhim = ten;
            GiaVeChuan = gia;
            PhongChieuList = new List<PhongChieu>();
            foreach (int idPhong in dsPhong)
                PhongChieuList.Add(new PhongChieu(idPhong,GiaVeChuan));
        }
        

        // Tính doanh thu, vé bán, v.v.
        public int TongSoVe => PhongChieuList.Sum(p => p.DanhSachGhe.Count);
        public int SoVeBanRa => PhongChieuList.Sum(p => p.DanhSachGhe.Count(g => g.DaBan));
        public double DoanhThu => PhongChieuList.Sum(p => p.DanhSachGhe.Where(g => g.DaBan).Sum(g => g.HeSoGia * GiaVeChuan));
    }

}




