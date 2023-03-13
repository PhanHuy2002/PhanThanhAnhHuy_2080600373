using _2080600373_PhanThanhAnhHuy.Models;
using _2080600373_PhanThanhAnhHuy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2080600373_PhanThanhAnhHuy.Controllers
{
    public class CoursesControllerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesControllerController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: CoursesController
        public ActionResult Create()
        {
            var viewModels = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModels);
        }
    }
}