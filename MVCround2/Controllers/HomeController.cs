using Microsoft.AspNetCore.Mvc;
using MVCround2.Models;
using MVCround2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCround2.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILocationData locationData)
        {
            _locationData = locationData;
        }

        public IActionResult Index()
        {
            var model = _locationData.GetAll();

            return View(model);
        }

        private ILocationData _locationData;
    }
}
