using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCround2.Data;
using MVCround2.EntityModels;

namespace MVCround2.Services
{
    public class SQLLocationData : ILocationData
    {
        private MVCround2DbContext _context;

        public SQLLocationData(MVCround2DbContext context)
        {
            _context = context;
        }

        public Location Add(Location newLocation)
        {
            _context.Locations.Add(newLocation);
            _context.SaveChanges();
            return newLocation;
        }

        public Location Get(int id)
        {
            return _context.Locations.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<Location> GetAll()
        {
            return _context.Locations;
        }

        public Location Update(Location newLocation)
        {
            _context.Attach(newLocation).State = 
                EntityState.Modified;
            _context.SaveChanges();
            return newLocation;
        }
    }
}
