﻿using CSHTML09._07._23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using CSHTML09._07._23.Data;
using CSHTML09._07._23.Models.SchoolViewModels;
using Microsoft.Extensions.Logging;

namespace CSHTML09._07._23.Controllers
{
    public class HomeController : Controller
    {
        public readonly ILogger<HomeController> _logger;
        public readonly SchoolContext _context;

        public HomeController(ILogger<HomeController> logger, SchoolContext context)
        {
            _logger = logger;
            _context = context;
        }
       


        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> About()
        {
            IQueryable<EnrollmentDateGroup> data =
                from student in _context.Students
                group student by student.EnrollmentDate into dateGroup
                select new EnrollmentDateGroup()
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}