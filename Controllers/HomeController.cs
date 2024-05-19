using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;  // Certifique-se de incluir este using
using portfolioASP.NET.Models;
using System.Diagnostics;
using System.Collections.Generic;  // Certifique-se de incluir este using para List

namespace portfolioASP.NET.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            var greetingModel = new GreetingModel
            {
                GreetingMessage = GetGreetingMessage()
            };

            return View(greetingModel);
        }


#pragma warning disable CA1822
        private string GetGreetingMessage()
        {
            var hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                return "Good Morning";
            }
            else if (hour < 18)
            {
                return "Good Afternoon";
            }
            else
            {
                return "Good Evening";
            }
        }
#pragma warning restore CA1822


        public IActionResult AboutMe()
        {
            var certificates = new List<CertificateModel>();

            certificates.AddRange(new[]
            {
        new CertificateModel
        {
            Link = "https://www.shecodes.io/certificates/67bf8e29a72f0ed3fbbc8182892c91ba",
            ImageUrl = "https://s3.amazonaws.com/shecodesio-production/students/certificates/000/034/246/original/34246.png?1713536544",
            Title = "Alexandras Introduction to Coding certificate"
        },
        new CertificateModel
        {
            Link = "https://www.shecodes.io/certificates/f92923ede3cb550b423dbe1cac2f4f6d?_gl=1*xhv9d7*_gcl_au*MTc0OTQxOTk4NC4xNzA5NTYzMzQxLjEzMDAwNjkyNjEuMTcxMzk1ODM1MS4xNzEzOTU4MzUx",
            ImageUrl = "https://s3.amazonaws.com/shecodesio-production/students/certificates/000/035/608/original/35608.png?1713554952",
            Title = "Alexandras 'Web Development' certificate"
        },
        new CertificateModel
        {
            Link = "https://www.shecodes.io/certificates/bcfcc457518b7725d6541e00a418d712?_gl=1*1dcgwa6*_gcl_au*MTc0OTQxOTk4NC4xNzA5NTYzMzQxLjEzMDAwNjkyNjEuMTcxMzk1ODM1MS4xNzEzOTU4MzUx",
            ImageUrl = "https://s3.amazonaws.com/shecodesio-production/students/certificates/000/042/017/original/42017.png?1713537710",
            Title = "Alexandras 'Responsive Web Development' certificate"
        },
        new CertificateModel
        {
            Link = "",
            ImageUrl = "https://s3.amazonaws.com/shecodesio-production/students/certificates/000/049/007/original/49007.png?1713538731",
            Title = "Alexandras 'React' certificate"
        },
        new CertificateModel
        {
            Link = "https://www.freecodecamp.org/certification/AlexandraHockett/responsive-web-design",
            ImageUrl = "https://i.ibb.co/ckFSJ2N/Captura-de-ecr-2024-05-16-100856.png",
            Title = "Alexandras 'Responsive Web Design' certificate"
        }
    });

            return View(certificates);
        }

        public IActionResult Projects()
        {
            return View(); 
        }
            public IActionResult Contact()
        {
            return View();
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

