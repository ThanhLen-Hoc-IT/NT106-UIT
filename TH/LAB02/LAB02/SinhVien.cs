using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class SinhVien
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public float Course1 { get; set; }
        public float Course2 { get; set; }
        public float Course3 { get; set; }
        public float Average { get; set; }

        public SinhVien()
        {
            Name = "";
            ID = 0;
            Phone = "";
            Course1 = 0;
            Course2 = 0;
            Course3 = 0;
            Average = 0;
        }

        public SinhVien(string name, int id, string phone, float course1, float course2, float course3)
        {
            Name = name;
            ID = id;
            Phone = phone;
            Course1 = course1;
            Course2 = course2;
            Course3 = course3;
            Average =0;
        }

        public float TinhDiemTrungBinh()
        {
            Average = (Course1 + Course2 + Course3) / 3;
            return Average;
        }
    }
}
