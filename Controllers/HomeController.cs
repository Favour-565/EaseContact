using Microsoft.AspNetCore.Mvc;
using SQ20.Net_Wee7_8_Task.Models;
using System.Diagnostics;
using SQ20.Net_Wee7_8_Task.Data;
using SQ20.Net_Wee7_8_Task.ViewModel;

namespace SQ20.Net_Wee7_8_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var edu = _context.Educations.ToList();
            var port = _context.Portfolios.ToList();
            var serv = _context.Services.ToList();
            var exp = _context.Experiences.ToList();
            var con  = _context.Contacts.ToList();
            var skil = _context.Skills.ToList();
            var soc = _context.Socials.ToList();

            var myModel = new DashBoardViewModel
            {
                Educations = edu,
                Portfolios = port,
                Services = serv,
                Experiences = exp,
                Skills = skil,
                Socials = soc,
                Contacts = con
                



            };

            return View(myModel);
            /*return RedirectToAction("Index", "NewHome");*/
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Services()
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
