using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace demoweb.Models
{
    public class Student
    {
        [Required(ErrorMessage = "moi nhap du")]//khi loi
        [Display(Name = "Ma sinh vien:")]//tranh hien thi ten MaSV goc

        public string MaSV { get; set; }

        [Required(ErrorMessage = "moi nhap du")]//khi loi
        [Display(Name = "Ten sinh vien:")]//tranh hien thi ten MaSV goc
        public string name { get; set; }

        [Required(ErrorMessage = "moi nhap du")]//khi loi
        [Display(Name = "Gioi tinh sinh vien:")]//tranh hien thi ten MaSV goc
        public string sex { get; set; }

        [Required(ErrorMessage = "moi nhap du")]//khi loi
        [Display(Name = " Ngay sinh sinh vien:")]//tranh hien thi ten MaSV goc
        public string brith { get; set; }

        [Required(ErrorMessage = "moi nhap du")]//khi loi
        [Display(Name = "Dia chi sinh vien:")]//tranh hien thi ten MaSV goc
        public string Addrest { get; set; }

        [Required(ErrorMessage = "moi nhap du")]//khi loi
        [Display(Name = "Lop sinh vien:")] //tranh hien thi ten MaSV goc
        public string lop { get; set; }
        

    }
    class StudentList
    {
        DBConnection db;
        public StudentList()
        {
            db = new DBConnection();//ham tao cua class DBConnection
        }
        public List<Student> getStudent(string MaSV)
        {
            string sql;
            if (string.IsNullOrEmpty(MaSV))
            {
                sql = "SELECT * FROM Sinhvien";
            }
            else
            {
                sql = "SELECT * FROM Sinhvien WHERE MaSV = "+MaSV;
            }
            List<Student> stdList = new List<Student>();//list sv se tra ve
            DataTable dataTable = new DataTable();//khoi tao datatable
            SqlConnection con = db.getConnection();//khoi tao ket noi
            
            SqlDataAdapter da = new SqlDataAdapter(sql, con);//truyen cau lenh sql va chuoi ket noi vao
            con.Open();//mo ket noi
            da.Fill(dataTable);//do toan bo du lieu lay ve vao datatable
            da.Dispose();
            con.Close();//dong ket noi

            Student tmpStd;//gan du lieu vao list
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                tmpStd = new Student();
                tmpStd.MaSV = dataTable.Rows[i]["MaSV"].ToString();
                tmpStd.name = dataTable.Rows[i]["TenSV"].ToString();
                tmpStd.sex = dataTable.Rows[i]["gioitinh"].ToString();
                tmpStd.brith = dataTable.Rows[i]["Ngaysinh"].ToString();
                tmpStd.Addrest = dataTable.Rows[i]["Que"].ToString();
                tmpStd.lop = dataTable.Rows[i]["Lop"].ToString();
                stdList.Add(tmpStd);
            }
            return stdList;
        }
        public void AddStudent(Student stu)
        {
            string sql = "INSERT INTO Sinhvien VALUES ('" + stu.MaSV + "',N'" + stu.name + "', N'" + stu.sex + "','" + stu.brith + "',N'" + stu.Addrest + "','" + stu.lop + "')";
            SqlConnection con = db.getConnection();//khoi tao ket noi
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void UpdateStudent(Student stu)
        {
            string sql = "UPDATE Sinhvien SET TenSV = N'" + stu.name + "', gioitinh = '" + stu.sex + "', Ngaysinh = '" + stu.brith + "' ,Que =N'" + stu.Addrest + "' ,Lop='" + stu.lop + "' WHERE MaSV = '"+stu.MaSV+"'";
            SqlConnection con = db.getConnection();//khoi tao ket noi
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }



        public void DeleteStudent(Student stu)
        {
            string sql = "DELETE Sinhvien WHERE MaSV = '" + stu.MaSV+"'";
            SqlConnection con = db.getConnection();//khoi tao ket noi
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

    }
}

