using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgentProfile.Models;

namespace AgentProfile.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["FullName"] = "Melissa Crosby";
            ViewData["Summary_First_Part"] = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes.I strive to exceed expectations and never forget that I am always accountable to my clients.";
            ViewData["Summary_Second_Part"] = "My objective is to establish relationships for life, not just for the current transaction. I enjoy assisting home buyers and sellers to get moved to a better place, one that is exciting.";
            ViewData["Brokerage"] = "Berkshire Hathaway HomeServices Elite Real Estate";
            ViewData["Specialties"] = "Property Management, Buyer’s Agent, Listing Agent…";
            ViewData["License_Number"] = "#5452129";

            ViewData["reviewed_by_1"] = "russroberts";
            ViewData["reviewed_date_1"] = "09/24/2017";
            ViewData["reviewed_address_1"] = "Bought a home in 2017 in El Cajon, CA";
            ViewData["reviewed_text_1"] = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes.I strive to exceed expectations and never forget that I am always accountable to my clients.";

            ViewData["reviewed_by_2"] = "russroberts";
            ViewData["reviewed_date_2"] = "09/24/2017";
            ViewData["reviewed_address_2"] = "Bought a home in 2017 in El Cajon, CA";
            ViewData["reviewed_text_2"] = "Most important to me was communication and Mark saw that every question or concern of ours we met with full and complete information. In most cases, Mark delivered information to us before we even had to ask. I look forward to working with Mark in the future because I know that I can trust him to";

            return View();
        }

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
