using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Julio_C_301016383.Models;

namespace Julio_C_301016383.Controllers
{
    public class TicketController : Controller
    {
        private IMatchRepository repo;

        public TicketController(IMatchRepository repository)
        {
            repo = repository;
        }

        public IActionResult Index()
        {
            ViewBag.fromTicekt = "fromTicket";
            return View("Index", repo.GetListOfMatches() );
        }
    }
}