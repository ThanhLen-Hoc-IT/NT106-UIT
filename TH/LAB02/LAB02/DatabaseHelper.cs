using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace LAB02
{
    internal class DatabaseHelper
    {
        private static string dbName = "HomNayAnGi.db";
        private static string connectionString = $"Data Source={dbName};Version=3;";

        public void CreateTables()
        {
            if (!File.Exists(dbName))
                SQLiteConnection.CreateFile(dbName);

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sqlNguoiDung = @"CREATE TABLE IF NOT EXISTS NguoiDung(
                                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                                        HoVaTen TEXT,
                                        QuyenHan TEXT
                                        )";

                string sqlMonAn = @"CREATE TABLE IF NOT EXISTS MonAn(
                                    IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                                    TenMonAn TEXT,
                                    HinhAnh TEXT,
                                    IDNCC INTEGER,
                                    FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC)
                                    )";

                using (var cmd = new SQLiteCommand(sqlNguoiDung, conn))
                    cmd.ExecuteNonQuery();
                using (var cmd = new SQLiteCommand(sqlMonAn, conn))
                    cmd.ExecuteNonQuery();
            }
        }

        public List<MonAn> GetAllMonAn()
        {
            List<MonAn> list = new List<MonAn>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen, m.IDNCC
                               FROM MonAn m
                               LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MonAn
                        {
                            IDMA = reader.GetInt32(0),
                            TenMonAn = reader.GetString(1),
                            HinhAnh = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            NguoiDongGop = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            IDNCC = reader.IsDBNull(4) ? 0 : reader.GetInt32(4)
                        });
                    }
                }
            }
            return list;
        }

        public List<NguoiDung> GetAllNguoiDung()
        {
            List<NguoiDung> list = new List<NguoiDung>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT IDNCC, HoVaTen, QuyenHan FROM NguoiDung";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NguoiDung nd = new NguoiDung
                        {
                            IDNCC = reader.GetInt32(0),
                            HoVaTen = reader.GetString(1),
                            QuyenHan = reader.GetString(2)
                        };
                        list.Add(nd);
                    }
                }
            }
            return list;
        }


        public void InsertNguoiDung(string hoTen, string quyenHan)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO NguoiDung(HoVaTen, QuyenHan) VALUES(@ten, @q)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", hoTen);
                    cmd.Parameters.AddWithValue("@q", quyenHan);
                    cmd.ExecuteNonQuery();
                    
                }
            }
        }

        public string GetQuyen(int idNCC)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT QuyenHan FROM NguoiDung WHERE IDNCC = @id";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idNCC);
                    object result = cmd.ExecuteScalar(); // lấy giá trị duy nhất

                    if (result != null)
                        return result.ToString();
                    else
                        return null; // hoặc "Không có quyền" nếu muốn
                }
            }
        }

        public void InsertMonAn(string tenMA, string hinh, int idNCC)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                // Kiểm tra idNCC có tồn tại
                string check = "SELECT COUNT(*) FROM NguoiDung WHERE IDNCC = @id";
                using (var cmdCheck = new SQLiteCommand(check, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@id", idNCC);
                    long count = (long)cmdCheck.ExecuteScalar();
                    if (count == 0)
                        throw new Exception("Người dùng không tồn tại!");
                }

                string sql = "INSERT INTO MonAn(TenMonAn, HinhAnh, IDNCC) VALUES(@ten, @hinh, @id)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", tenMA);
                    cmd.Parameters.AddWithValue("@hinh", hinh);
                    cmd.Parameters.AddWithValue("@id", idNCC);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMonAn(int idMA, string tenMA, string hinh, int idNCC)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE MonAn SET TenMonAn=@ten, HinhAnh=@hinh, IDNCC=@id WHERE IDMA=@idMA";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", tenMA);
                    cmd.Parameters.AddWithValue("@hinh", hinh);
                    cmd.Parameters.AddWithValue("@id", idNCC);
                    cmd.Parameters.AddWithValue("@idMA", idMA);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMonAn(int idMA)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM MonAn WHERE IDMA=@id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idMA);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteNguoiDung(int idNCC)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM NguoiDung WHERE IDNCC = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idNCC);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
