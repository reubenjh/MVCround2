using MVCround2.EntityModels;
using System.Collections.Generic;

namespace MVCround2.Services
{
    public interface ILocationData
    {
        IEnumerable<Location> GetAll();
        Location Get(int id);
        Location Add(Location newLocation);
        Location Update(Location newLocation);
    }
}
