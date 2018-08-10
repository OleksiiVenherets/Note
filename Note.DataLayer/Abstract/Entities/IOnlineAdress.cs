namespace Note.DataLayer.Abstract.Entities
{
    public interface IOnlineAdress
    {
        int Id { get; set; }

        string Adress { get; set; }

        string AdressType { get; set; }
    }

}