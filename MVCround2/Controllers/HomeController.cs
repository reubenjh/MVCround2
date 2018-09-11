using Microsoft.AspNetCore.Mvc;
using MVCround2.EntityModels;
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
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LocationEditModel model)
        {
            if(ModelState.IsValid)
            {
                Location newLocation = new Location();
                newLocation.Name = model.Name;
                newLocation.Climate = model.Climate;
                newLocation.Terrain = model.Terrain;
                newLocation.Rating = model.Rating;

                newLocation =_locationData.Add(newLocation);

                return RedirectToAction(nameof(Details), new { id = newLocation.Id });
            }
            else
            {
                return View();
            }
        }

        private ILocationData _locationData;
        private IGreeter _greeter;
    }
}
