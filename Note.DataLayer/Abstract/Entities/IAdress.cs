using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.DataLayer.Abstract.Entities
{
    public interface IAdress
    {
        int Id { get; set; }

        string Country { get; set; }

        string City { get; set; }

        string Address { get; set; }

        Decimal Longitude { get; set; }
        
        Decimal Latitude { get; set; }
    }
}
