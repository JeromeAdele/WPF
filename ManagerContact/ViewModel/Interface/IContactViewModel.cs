namespace ManagerContact.ViewModel.Interface
{
    public interface IContactViewModel
    {
        int? ID { get; set; }

        string Prenom { get; set; }

        string Nom { get; set; }

        int? Age { get; set; }

        bool? Genre { get; set; }
    }
}