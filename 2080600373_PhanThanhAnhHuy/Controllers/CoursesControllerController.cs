using _2080600373_PhanThanhAnhHuy.Models;
using _2080600373_PhanThanhAnhHuy.ViewModels;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        public ActionResult Create()
        {
            var viewModels = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModels);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course()
            {
                LecturerId = User.Identity.GetUserId(),
                Datetime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place,
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}