using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.DataLayer.Abstract.Entities
{
    public interface IUser
    {
        string Name { get; set; }

        string Surname { get; set; }

        int AdressId { get; set; }
    }
}
