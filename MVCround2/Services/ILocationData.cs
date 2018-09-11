using MVCround2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCround2.Services
{
    public interface ILocationData
    {
        IEnumerable<Location> GetAll();
    }
}
