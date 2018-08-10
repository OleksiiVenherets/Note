using System;

namespace Note.DataLayer.Abstract.Entities
{
    public interface INote
    {
        int Id { get; set; }
        string Name { get; set; }

        string Description { get; set; }

        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }

        bool IsOffline { get; set; }

        bool IsOnline { get; set; }

        int? AdressId { get; set; }

        int? OnlineAdressId { get; set; }

    }
}
