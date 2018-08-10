using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Note.DataLayer.Abstract.Entities;

namespace Note.DataLayer.Entities
{
    public class User : IdentityUser, IUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int AdressId { get; set; }

        public virtual Adress Address { get; set; }

        public virtual ICollection<Note> Notes { get; set; }

    }
}
