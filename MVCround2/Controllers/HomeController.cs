using Microsoft.AspNetCore.Mvc;
using MVCround2.Services;
using MVCround2.ViewModels;

namespace MVCround2.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILocationData locationData,
                                IGreeter greeter)
        {
            _locationData = locationData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Locations = _locationData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _locationData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        private ILocationData _locationData;
        private IGreeter _greeter;
    }
}
