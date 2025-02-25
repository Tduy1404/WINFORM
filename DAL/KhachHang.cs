﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHang
    {
        private static KhachHang Instance;

        public static KhachHang GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new KhachHang();
                }
                return Instance;
            }
        }

        #region Lấy Danh Sách Khách Hàng
        public DataTable GetDanhSachKhachHang()
        {
            try
            {
                string sql = @"
SELECT TOP (1000) [CustomerID]
      ,[FullName]
      ,[ImgCustomer]
      ,[Email]
      ,[CreatedAt]
      ,[Password]
      ,[Phone]
      ,[Gender]
      ,[Address]
  FROM [WatchStore].[dbo].[Customer]";

              

                DataTable dt = DATA.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product list: " + ex.Message);
            }
        }
        #endregion
        #region Tìm Kiếm Khách Hàng
        public DataTable SearchCustomer(string searchText)
        {
            try
            {
                string sql = "SELECT * FROM Customer WHERE FullName LIKE @SearchText ";
                SqlParameter searchParam = new SqlParameter("@SearchText", SqlDbType.NVarChar)
                {
                    Value = "%" + searchText + "%"
                };

                // Sử dụng phương thức GetTable từ lớp DATA để lấy kết quả
                DataTable dt = DATA.GetTableWithParameters(sql, searchParam);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching customer: " + ex.Message);
            }
        }
        #endregion
        #region Thêm nhân viên
        public int InsertCustomer(string customerName, string customerEmail, string customerPhone,
                             string customerPassword, string customerAddress,
                             string customerGender, string imageFileName)
        {
            string query = "INSERT INTO Customer (FullName, Email, Phone, Password, Address, Gender, ImgCustomer) " +
                          "VALUES (@FullName, @Email, @Phone, @Password, @Address, @Gender, @ImgCustomer)";
            SqlParameter[] parameters =
            {

            new SqlParameter("@FullName", customerName),
            new SqlParameter("@Email", customerEmail),
            new SqlParameter("@Phone", customerPhone),
            new SqlParameter("@Password", customerPassword),
            new SqlParameter("@Address", customerAddress),
            new SqlParameter("@Gender", customerGender),
            new SqlParameter("@ImgCustomer", imageFileName),
        };
            return DATA.ExecuteCommand(query, parameters);
        }
        #endregion
        #region Xóa khách hàng
        public int DeleteCustomer(int CustomerID)
        {
            try
            {
                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@CustomerID", CustomerID),
                };

                return DATA.ExecuteCommand(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }
        #endregion
        #region update nhân viên
        public int UpdateCustomer(int customerid, string customerName, string customerEmail, string customerPhone,
                             string customerPassword, string customerAddress,
                             string customerGender, string imageFileName)
        {

            string query = "UPDATE Customer SET FullName = @FullName, Email=@Email, Phone=@Phone, Password=@Password, Address=@Address, Gender=@Gender, ImgCustomer=@ImgCustomer WHERE CustomerID = @CustomerID ";


       
            SqlParameter[] parameters =
                            {
             new SqlParameter("@FullName", customerName),
            new SqlParameter("@Email", customerEmail),
            new SqlParameter("@Phone", customerPhone),
            new SqlParameter("@Password", customerPassword),
            new SqlParameter("@Address", customerAddress),
            new SqlParameter("@Gender", customerGender),
            new SqlParameter("@ImgCustomer", imageFileName),
             new SqlParameter("@CustomerID",customerid ),

            };
            return DATA.ExecuteCommand(query, parameters);
        }
        #endregion
    }
}
