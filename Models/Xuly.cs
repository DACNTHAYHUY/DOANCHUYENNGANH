using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATN.Models
{
    class Xuly
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter da;
        private String lenh = "Data Source=DATHANHLAP-PC;Initial Catalog=QLCuaHangMyPham;Integrated Security=True";
        //hàm dùng để kết nối cơ sở dữ liệu,nếu có lỗi xảy ra sẽ thông báo.
        public Xuly()
        {
            con = new SqlConnection(lenh);
        }
        public void KetNoi()
        {
            try
            {
                if ((con.State == ConnectionState.Closed))
                con.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }           
        }
        //hàm dùng để ngắt kết nối cơ sở dữ liệu,nếu có lỗi xảy ra sẽ thông báo.
        public void NgatKetNoi()
        {
            try
            {
                if ((con.State == ConnectionState.Open))
                con.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }           
        }
        //hàm lấy dữ liệu từ một bảng bất kỳ.
        public DataTable GetData(String sql)
        {
            KetNoi();
            dt = new DataTable();
            try
            {
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception)
            {
                dt = null;
            }
            NgatKetNoi();
            return dt;
        }
        //hàm thực thi lệnh thêm sửa xóa ở một bảng bất kỳ.
        public bool Thucthi(String sql)
        {
            KetNoi();
            bool check = false;
            try
            {
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch(Exception)
            {
                check = false;
            }
            NgatKetNoi();
            return check;
        }
    }
}
