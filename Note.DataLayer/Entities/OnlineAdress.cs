using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.DataLayer.Abstract.Entities;

namespace Note.DataLayer.Entities
{
    public class OnlineAdress : IOnlineAdress
    {
        public int Id { get; set; }
        public string SkypeAddress { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public int NoteId { get; set; }

        public virtual Note Note { get; set; }
    }
}
