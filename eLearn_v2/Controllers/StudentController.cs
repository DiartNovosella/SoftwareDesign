using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace eLearn_v1.Controllers
{
    public class StudentController : Controller
    {
        public static List<Course> _enrolledCoruses = new List<Course>();
        private ApplicationDbContext dbContext;
        public StudentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await dbContext.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        public IActionResult Enrollment(int id)
        {

            var course = dbContext.Courses.FirstOrDefault((m => m.Id == id));

            if (!CheckExists(id))
            {
                _enrolledCoruses.Add(course);
            }


            return View(_enrolledCoruses);
        }


        private bool CheckExists(int id)
        {
            return _enrolledCoruses.Any(e => e.Id == id);
        }
    }
}