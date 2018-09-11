using MVCround2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCround2.Services
{
    public class InMemoryLocationData : ILocationData
    {
        public InMemoryLocationData()
        {
            _locations = new List<Location>
            {
                new Location {
                    Id = 1,
                    Name = "Irontown",
                    Climate = "Continental",
                    Terrain = "Mountain"
                },
                new Location {
                    Id = 12,
                    Name = "Gutiokipanja",
                    Climate = "Continental",
                    Terrain = "Hill"
                },
                new Location {
                    Id = 3,
                    Name = "The Cat Kingdom",
                    Climate = "Continental",
                    Terrain = "Plain"
                },
                new Location {
                    Id = 4,
                    Name = "The Marsh House",
                    Climate = "Mild",
                    Terrain = "Marsh"
                }
            };

        }

        public IEnumerable<Location> GetAll()
        {
            return _locations.OrderBy(l => l.Name);
        }

        List<Location> _locations;
    }
}
