using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // when data is posted to /student/Register
        // this action will execute
        [HttpPost]
        public IActionResult Register(IFormCollection data)
        {
            // Validate input (lot of work!)
            // Server-side and client-side

            Student stu = new Student()
            {
                FullName = data["full-name"],
                ProgramOfChoice = data["program"],
                DateOfBirth = Convert.ToDateTime(data["dob"]),
                homeAddress = data["address"]
            };
            return View();
        }

        [HttpGet]
        public IActionResult RegisterMB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterMB(Student s)
        {
            return View();
        }
    }
}