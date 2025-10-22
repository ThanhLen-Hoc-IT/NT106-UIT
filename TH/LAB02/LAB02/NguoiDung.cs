using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class NguoiDung
    {
        public int IDNCC { get; set; }
        public string HoVaTen { get; set; }
        public string QuyenHan { get; set; }

        public override string ToString()
        {
            return $"{IDNCC} - {HoVaTen}";
        }
    }
}
