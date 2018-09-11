using MVCround2.EntityModels;
using System.Collections.Generic;

namespace MVCround2.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Location> Locations { get; set; }
        public string CurrentMessage { get; set; }
    }
}
