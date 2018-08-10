using System.Collections.Generic;
using Note.DataLayer.Abstract.Entities;

namespace Note.DataLayer.Entities
{
    public class OnlineAdress : IOnlineAdress
    {
        public int Id { get; set; }

        public string Adress { get; set; }

        public string AdressType { get; set; }

        public virtual ICollection<Note> Notes { get; set; }

    }
}
