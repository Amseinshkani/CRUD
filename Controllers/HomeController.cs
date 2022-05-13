using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School.Models;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _Context;

        public HomeController(Context db)
        {
            _Context = db;
        }

        public IActionResult Index()
        {
            ViewBag.adstu = _Context.tblStudents.OrderByDescending(a => a.Id).ToList();
            ViewBag.adteach =_Context.tblTeachers.OrderByDescending(b => b.Id).ToList();
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }

        public IActionResult Teacher()
        {
            return View();
        }

        public IActionResult AddStudent(VMStudent MS)
        {
            TblStudent A = new TblStudent()
                {
                    Id = MS.Id,
                    FirstName = MS.FirstName,
                    LastName = MS.LastName,
                    score1 = MS.score1,
                    score2 = MS.score2,
                    score3 = MS.score3,
                    SumScore = MS.SumScore
                };
            _Context.tblStudents.Add (A);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddTeacher(VMTeacher MT)
        {
            TblTeacher B =new TblTeacher()
                {
                    Id = MT.Id,
                    FirstName = MT.FirstName,
                    LastName = MT.LastName,
                    Age = MT.Age,
                    RelatedEvidence = MT.RelatedEvidence,
                    Lesson = MT.Lesson
                };
            _Context.tblTeachers.Add (B);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateStudent(int Id)
        {
            var Select = _Context.tblStudents.Where(a => a.Id == Id).SingleOrDefault();

            VMStudent vM =new VMStudent()
                {
                    Id=Select.Id,
                    FirstName = Select.FirstName,
                    LastName = Select.LastName,
                    score1 = Select.score1,
                    score2 = Select.score2,
                    score3 = Select.score3,
                    SumScore = Select.SumScore
                };
            return View(vM);
        }

        public IActionResult EditStudent(VMStudent MVU)
        {
            var Select = _Context.tblStudents.Where(a => a.Id == MVU.Id).SingleOrDefault();

            Select.Id = MVU.Id;
            Select.FirstName = MVU.FirstName;
            Select.LastName = MVU.LastName;
            Select.score1 = MVU.score1;
            Select.score2 = MVU.score2;
            Select.score3 = MVU.score3;
            Select.SumScore = MVU.SumScore;

            _Context.tblStudents.Update (Select);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateTeacher(int Id)
        {
            var Select = _Context.tblTeachers.Where(a => a.Id == Id).SingleOrDefault();
            VMTeacher d = new VMTeacher()
                {
                    Id=Select.Id,
                    FirstName = Select.FirstName,
                    LastName = Select.LastName,
                    Age = Select.Age,
                    RelatedEvidence = Select.RelatedEvidence,
                    Lesson = Select.Lesson
                };
            return View(d);
        }

        public IActionResult EditTeacher(VMTeacher VMT)
        {
            TblTeacher TT=new TblTeacher()
            {
                Id=VMT.Id,
                FirstName=VMT.FirstName,
                LastName=VMT.LastName,
                Age=VMT.Age,
                RelatedEvidence=VMT.RelatedEvidence,
                Lesson=VMT.Lesson
            };
            _Context.tblTeachers.Update(TT);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSt(int Id)
        {
            var Select =_Context.tblStudents.Where(a => a.Id == Id).SingleOrDefault();
            _Context.tblStudents.Remove (Select);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTeacher(int Id)
        {
            var Select =
                _Context.tblTeachers.Where(a => a.Id == Id).SingleOrDefault();
            _Context.tblTeachers.Remove (Select);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
