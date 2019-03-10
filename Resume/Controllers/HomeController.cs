using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Data;
using Resume.Models;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Resume.Controllers
{
    public class HomeController : Controller

    {
        private readonly ResumeContext _context;

        public HomeController(ResumeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        

            {
                var applicant = await _context.Applicant
                       .Include(i => i.Educations)
                       .Include(i => i.Skills)
                       .Include(i => i.Job)
                       .ThenInclude(i => i.Workexperiences)

                .FirstOrDefaultAsync(m => m.FirstName == "Rishita");



            
            return View(applicant);
        }


        //.Include(i => i.References)
        //         .Include(i => i.Skills)
        //       .Include(i => i.Job)






        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }
    }
}

 