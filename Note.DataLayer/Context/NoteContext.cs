using System.Data.Entity;
using Note.DataLayer.Entities;

namespace Note.DataLayer.Context
{
    public class NoteContext : DbContext
    {
        public NoteContext() : base("DbConnection")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Entities.Note> Notes { get; set; }

        public DbSet<Adress> Adresses { get; set; }

        public DbSet<OnlineAdress> OnlineAdresses { get; set; }
    }
}
