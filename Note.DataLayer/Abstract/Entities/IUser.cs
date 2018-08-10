namespace Note.DataLayer.Abstract.Entities
{
    public interface IUser
    {
        string Name { get; set; }

        string Surname { get; set; }

        int AdressId { get; set; }
    }
}
