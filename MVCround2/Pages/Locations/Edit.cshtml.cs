using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVCround2.EntityModels;
using MVCround2.Services;

namespace MVCround2.Pages.Locations
{
    public class EditModel : PageModel
    {
        private ILocationData _locationData;

        [BindProperty]
        public Location Location { get; set; }

        public EditModel(ILocationData locationData)
        {
            _locationData = locationData;
        }

        public IActionResult OnGet(int id)
        {
            Location = _locationData.Get(id);
            if(Location == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _locationData.Update(Location);
                return RedirectToAction("Details", "Home", new { id = Location.Id });
            }
            return Page();
        }
    }
}