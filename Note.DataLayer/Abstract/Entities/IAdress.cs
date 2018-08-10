namespace Note.DataLayer.Abstract.Entities
{
    public interface IAdress
    {
        int Id { get; set; }

        string Country { get; set; }

        string City { get; set; }

        string Address { get; set; }

        decimal Longitude { get; set; }
        
        decimal Latitude { get; set; }
    }
}
