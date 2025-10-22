using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class MonAn
    {
        public int IDMA { get; set; }
        public string TenMonAn { get; set; }
        public string HinhAnh { get; set; }
        public int IDNCC { get; set; }
        public string NguoiDongGop { get; set; }

        public override string ToString()
        {
            return $"{IDMA} - {TenMonAn}";
        }

    }
}
