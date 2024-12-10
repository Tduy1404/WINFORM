

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

using System.Linq.Expressions;


namespace vidu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }


        //Tai danh sach du lieu
        //private void LoadDataGridView()
        //{
        //    try
        //    {
        //        // Lấy dữ liệu từ BLL
        //        DataTable dt = NhanvienBL.GetInstance.GetDanhSachSanPham();
        //        if (dt == null || dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Không có dữ liệu để hiển thị.");
        //            return;
        //        }

        //        // Xóa dữ liệu cũ
        //        dgvSanPham.Rows.Clear();
        //        dgvSanPham.Columns.Clear();

        //        // Tạo các cột
        //        dgvSanPham.Columns.Add("ProductID", "Mã SP");
        //        dgvSanPham.Columns.Add("ProductName", "Tên SP");
        //        dgvSanPham.Columns.Add("Price", "Giá bán");
        //        dgvSanPham.Columns.Add("StockQuantity", "Số lượng");
        //        dgvSanPham.Columns.Add("CategoryID", "Mã loại SP");
        //        dgvSanPham.Columns.Add("SupplierID", "Mã NCC SP");
        //        dgvSanPham.Columns.Add("BrandID", "Mã nhãn hàng SP");
        //        dgvSanPham.Columns.Add("CreatedAt", "Ngày sản xuất");
         
        //        // Thêm dữ liệu vào DataGridView
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            int rowIndex = dgvSanPham.Rows.Add();
        //            dgvSanPham.Rows[rowIndex].Cells[0].Value = row["ProductID"];
        //            dgvSanPham.Rows[rowIndex].Cells[1].Value = row["ProductName"];
        //            dgvSanPham.Rows[rowIndex].Cells[2].Value = row["Price"];
        //            dgvSanPham.Rows[rowIndex].Cells[3].Value = row["StockQuantity"];
        //            dgvSanPham.Rows[rowIndex].Cells[4].Value = row["CategoryID"];
        //            dgvSanPham.Rows[rowIndex].Cells[5].Value = row["SupplierID"];
        //            dgvSanPham.Rows[rowIndex].Cells[6].Value = row["BrandID"];
        //            dgvSanPham.Rows[rowIndex].Cells[7].Value = row["CreatedAt"];
        //        }
        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        MessageBox.Show("Đối tượng null: " + ex.Message);
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        MessageBox.Show("Lỗi khi thao tác với DataGridView: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi không xác định: " + ex.Message);
        //    }
        //}



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
