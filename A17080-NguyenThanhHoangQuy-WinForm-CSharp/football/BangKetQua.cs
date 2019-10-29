using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace football
{
    public partial class BangKetQua : Form
    {
        string connectionString = football.Properties.Settings.Default.footballsrcConnectionString;
        public BangKetQua()
        {
            InitializeComponent();
        }

        private void BangKetQua_Load(object sender, EventArgs e)
        {

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"select [TenDoi], sum([SoTranDaThiDau]) as SoTranDaDau, sum(HieuSo) as HieuSo, sum([Diem]) as TongDiem from BangDiemThiDau group by [TenDoi] order by sum([Diem]) desc, sum(HieuSo) desc";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        footballsrcDataSet.BangKetQua.Clear();
                        adapter.Fill(footballsrcDataSet.BangKetQua);
                        int i = 1;
                        foreach (DataRow row in footballsrcDataSet.BangKetQua.Rows)
                        {
                            row["Stt"] = i;
                            i++;
                        }

                        // Hiển thị dữ liệu
                        bangKetQuaBindingSource.DataSource = footballsrcDataSet.BangKetQua;
                        bangKetQuaDataGridView.DataSource = bangKetQuaBindingSource;

                        bangKetQuaDataGridView.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
