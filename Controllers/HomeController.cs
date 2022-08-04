using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestresponse)
        {
            if (ModelState.IsValid) {
                Repository.AddResponse(guestresponse);
                return View("Thanks", guestresponse);
            }
            else
            {
                return View();
            }
           
        }
        public IActionResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
      
}
