using MVCround2.EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCround2.ViewModels
{
    public class LocationEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public Ratings Rating { get; set; }
    }
}
