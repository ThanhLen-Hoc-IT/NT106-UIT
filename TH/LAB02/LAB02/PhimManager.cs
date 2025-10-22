using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace LAB02
{
   
    public class PhimManager
    {
        public List<Phim> DanhSachPhim { get; private set; }

        public PhimManager()
        {
            DanhSachPhim = new List<Phim>();
        }

        public bool ThemPhim(Phim phim)
        {
            if (DanhSachPhim.Any(p => p.TenPhim.Equals(phim.TenPhim, StringComparison.OrdinalIgnoreCase)))
                return false;

            DanhSachPhim.Add(phim);
            return true;
        }

        public PhimManager DocFile(StreamReader sr)
        {
            DanhSachPhim.Clear();

            int idPhim = 0;
            while (!sr.EndOfStream)
            {
                //Đọc 3 dòng
                string tenPhim = sr.ReadLine();
                if (string.IsNullOrWhiteSpace(tenPhim))
                    continue;

                string giaStr = sr.ReadLine();
                string phongStr = sr.ReadLine();

                if (giaStr == null || phongStr == null)
                    break;

                if (!double.TryParse(giaStr, out double giaVe))
                    giaVe = 0;



                string[] phongList = phongStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                List<int> phongChieuList = new List<int>();

                foreach (string idPhong in phongList)
                {
                    if (int.TryParse(idPhong, out int id))
                        phongChieuList.Add(id);
                }

                Phim phim = new Phim (idPhim.ToString(),tenPhim, giaVe, phongChieuList); 
                DanhSachPhim.Add(phim);
                idPhim++;

                sr.ReadLine(); // bỏ dòng trống giữa 2 phim
            }
            return this;
        }

      

        /// <summary>
        /// Ghi thống kê ra file output5.txt
        /// </summary>
        public void GhiFileThongKe(string filePath, System.Windows.Forms.ProgressBar progressBar = null)
        {
            if (DanhSachPhim.Count == 0)
                throw new Exception("Không có phim để thống kê!");

            // Tính doanh thu, số vé bán, tỉ lệ bán
            var thongKe = DanhSachPhim
                .Select(p => new
                {
                    TenPhim = p.TenPhim,
                    SoVeBan = p.SoVeBanRa,
                    TongVe = p.TongSoVe,
                    DoanhThu = p.DoanhThu,
                    TiLeBan = p.TongSoVe == 0 ? 0 : (double)p.SoVeBanRa / p.TongSoVe * 100
                })
                .OrderByDescending(p => p.DoanhThu) // Xếp hạng doanh thu
                .ToList();

            var sb = new StringBuilder();
            sb.AppendLine("=== THỐNG KÊ PHÒNG VÉ ===\n");

            int rank = 1;
            int count = thongKe.Count;
            int step = count > 0 ? 100 / count : 100;

            foreach (var p in thongKe)
            {
                sb.AppendLine($"{rank}. Tên phim: {p.TenPhim}");
                sb.AppendLine($"   Số vé bán ra: {p.SoVeBan}");
                sb.AppendLine($"   Số vé tồn: {p.TongVe - p.SoVeBan}");
                sb.AppendLine($"   Tỉ lệ bán: {p.TiLeBan:F2}%");
                sb.AppendLine($"   Doanh thu: {p.DoanhThu:N0} đ");
                sb.AppendLine($"   Xếp hạng: {rank}");
                sb.AppendLine();

                progressBar?.PerformStep();
                rank++;
            }

            // Ghi ra file
            File.WriteAllText(filePath, sb.ToString());
        }

    }
}


