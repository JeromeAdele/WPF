using ManagerContact.Helpers;
using ManagerContact.Model.Classe;
using ManagerContact.Model.Service;
using ManagerContact.ViewModel.Interface;
using System.Windows.Input;

namespace ManagerContact.ViewModel
{
    public class ContactViewModel : ObservableObject, IContactViewModel
    {
        #region ViewModel

        private int? _ID = null;

        public int? ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
                OnPropertyChanged("ID");
            }
        }

        private string _prenom = null;

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            set
            {
                _prenom = value;
                OnPropertyChanged("Prenom");
            }
        }

        private string _nom = null;

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
                OnPropertyChanged("Nom");
            }
        }

        private int? _age = null;

        public int? Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        private bool? _genre = null;

        public bool? Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
                OnPropertyChanged("Genre");
            }
        }

        #endregion ViewModel

        /// <summary>
        /// Définition de la commande permettant de charger le contact
        /// </summary>
        public ICommand ChargerContactCommand { get; private set; }

        #region Constructor

        /// <summary>
        /// // association de  ChargerContactCommand à la méthode CContact
        /// </summary>
        public ContactViewModel()
        {
            ChargerContactCommand = new RelayCommand(CContact);
        }

        #endregion Constructor

        #region Methode de chargement de contact

        private void CContact()
        {
            ServiceContact serv = new ServiceContact();
            Contact contact = serv.FakeList();

            if (contact != null)
            {
                this.ID = contact.ID;
                this.Nom = contact.Nom;
                this.Prenom = contact.Prenom;
                this.Age = contact.Age;
                this.Genre = contact.Genre;
            }
        }

        #endregion Methode de chargement de contact
    }
}