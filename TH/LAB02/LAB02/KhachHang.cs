using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{

    public class KhachHang
    {
        public string HoTen { get; set; }
        public List<Ghe> DanhSachGhe { get; set; } = new List<Ghe>();

        // Kiểm tra xem khách có thể mua thêm ghế ở phòng mới không
        public bool CoTheMuaThem(Dictionary<int, List<Ghe>> gheMoiTheoPhong)
        {
            // Số phòng đã mua trước đó
            var phongDaMua = DanhSachGhe.Select(g => g.MaPhong).Distinct().ToList();

            // Số phòng trong lần mua mới
            var phongMoi = gheMoiTheoPhong.Keys.Distinct().ToList();

            // Nếu chỉ chọn 1 phòng mới → luôn OK
            if (phongMoi.Count <= 1)
                return true;

            // Nếu nhiều phòng → kiểm tra tổng số ghế không vượt quá 2
            int tongGheDaMua = DanhSachGhe.Count;
            int tongGheMoi = gheMoiTheoPhong.Values.Sum(list => list.Count);
            int tongGhe = tongGheDaMua + tongGheMoi;

            return tongGhe <= 2; 
        }

    }



}

