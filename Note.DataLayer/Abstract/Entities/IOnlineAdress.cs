namespace Note.DataLayer.Abstract.Entities
{
    public interface IOnlineAdress
    {
        int Id { get; set; }

        string SkypeAddress { get; set; }

        string Telephone { get; set; }

        string Email { get;  set; }
    }
}