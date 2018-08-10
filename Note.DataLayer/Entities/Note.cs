using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.DataLayer.Abstract.Entities;

namespace Note.DataLayer.Entities
{
    public class Note : INote
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsOffline { get; set; }

        public bool IsOnline { get; set; }

        public string UserId { get; set; }

        public int? AdressId { get; set; }

        public int? OnlineAdressId { get; set; }

        public virtual User User { get; set; }

        public virtual Adress Adress { get; set; }

    }
}
