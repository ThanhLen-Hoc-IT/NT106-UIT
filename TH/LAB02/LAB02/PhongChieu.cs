using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{

    public class PhongChieu
    {
        public int idPhong { get; set; }
        public List<Ghe> DanhSachGhe { get; set; }

        public PhongChieu(int id, double giaVeChuan)
        {
            idPhong = id;
            DanhSachGhe = new List<Ghe>();

            // Khởi tạo 15 ghế mặc định A1–5, B1–5, C1–5
            string[] hang = { "A", "B", "C" };
            foreach (string h in hang)
            {
                for (int i = 1; i <= 5; i++)
                {
                    string ma = $"{h}{i}";
                    double heSo = 1;

                    if (ma == "A1" || ma == "A5" || ma == "C1" || ma == "C5")
                        heSo = 0.25; // vé vớt
                    else if (ma == "B2" || ma == "B3" || ma == "B4")
                        heSo = 2;    // VIP
                    else
                        heSo = 1;    // thường

                    DanhSachGhe.Add(new Ghe(id, ma, heSo, giaVeChuan));
                }
            }
        }

    }
}
