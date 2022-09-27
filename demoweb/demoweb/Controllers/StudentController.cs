using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoweb.Models;

//khi user yeeu cau den controller
//controller lay data tu model (model da lay dc du lieu va xu ly cac yeu cau tu controller)
//controller tra data ve cho view
//view hien thi len _layout (_layout.cshtml lay code tu view de dan vao RenderBody)

namespace demoweb.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult DanhsachSV()//Tra ve danh sach cho view 
        {
            StudentList stuList = new StudentList();//khoi tao
            List<Student> obj = stuList.getStudent(string.Empty).OrderBy(x => x.MaSV).ToList(); //sd de sap xep
            //gan list student lay dc o model vao list obj vi lay het nen MaSV truyen vao la Empty

            return View(obj);
        }



        public IActionResult InsertStudent()
        {
            return View();
        }
        [HttpPost]//don su kien gui len server
        public IActionResult InsertStudent(Student stu)
        {
            if (ModelState.IsValid)//kiem tra xem cac truong da day du chua
            {
                StudentList stuList = new StudentList();//khoi tao
                stuList.AddStudent(stu);//goi ham add da viet trong Student/StudentList
                return RedirectToAction("DanhsachSV");//hien thi lai danh sach

            }
            return View();
        }


        public IActionResult Edit(string MaSV = "")
        {
            StudentList stuList = new StudentList();//khoi tao
            List<Student> obj = stuList.getStudent(MaSV);
            return View(obj.FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Edit(Student std)
        {
            StudentList stuList = new StudentList();//khoi tao
            stuList.UpdateStudent(std);//goi ham update da viet trong Student/StudentList
            return RedirectToAction("DanhsachSV");//hien thi lai danh sach
        }


        public IActionResult Details(string MaSV = "")
        {
            StudentList stuList = new StudentList();//khoi tao
            List<Student> obj = stuList.getStudent(MaSV);
            return View(obj.FirstOrDefault());
        }



        public IActionResult Delete(string MaSV = "")
        {
            StudentList stuList = new StudentList();//khoi tao
            List<Student> obj = stuList.getStudent(MaSV);
            return View(obj.FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Delete(Student std)
        {
            StudentList stuList = new StudentList();//khoi tao
            stuList.DeleteStudent(std);//goi ham update da viet trong Student/StudentList
            return RedirectToAction("DanhsachSV");//hien thi lai danh sach
        }

    }
}

