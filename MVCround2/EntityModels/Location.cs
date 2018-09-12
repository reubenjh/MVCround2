using System.ComponentModel.DataAnnotations;

namespace MVCround2.EntityModels
{
    public class Location
    {
        public int Id { get; set; }

        [Display(Name="Location Name")]
        [Required, MaxLength(80)]
        public string Name { get; set; }

        public string Climate { get; set; }
        public string Terrain { get; set; }
        public Ratings Rating { get; set; }
    }
}
