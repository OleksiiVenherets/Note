﻿using System.Collections.Generic;
using Note.DataLayer.Abstract.Entities;

namespace Note.DataLayer.Entities
{
    public class Adress : IAdress
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
