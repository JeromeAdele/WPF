using ManagerContact.ViewModel.Interface;

namespace ManagerContact.ViewModel.Design
{
    public class DesignContactViewModel : IContactViewModel
    {
        public int? ID
        {
            get { return 1; }
            set { }
        }

        public string Prenom
        {
            get { return "Gilles"; }
            set { }
        }

        public string Nom
        {
            get { return "Giblov"; }
            set { }
        }

        public int? Age
        {
            get { return 27; }
            set { }
        }

        public bool? Genre
        {
            get { return true; }
            set { }
        }
    }
}