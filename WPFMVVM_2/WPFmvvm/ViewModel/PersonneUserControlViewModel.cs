using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFmvvm.Helpers;
using WPFmvvm.Model;

namespace WPFmvvm.ViewModel
{
    public class PersonneUserControlViewModel : ViewModelBase
    {
        public ICommand AddNewPersonneCommand { get; set; }
        public ObservableCollection<Personne> PersonneList { get; set; }

        private string nom;
        private string prenom;
        private string pseudo;

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                OnPropertyChanged("Nom");
            }
        }
        public string Prenom
        {
            get { return prenom; }
            set
            {
                prenom = value;
                OnPropertyChanged("Prenom");
            }
        }

        public string Pseudo
        {
            get { return pseudo; }
            set
            {
                pseudo = value;
                OnPropertyChanged("Pseudo");
            }
        }
        private void BindCommand()
        {
            try
            {
                AddNewPersonneCommand = new RelayCommand(AddNewPersonne);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddNewPersonne(object parameter)
        {
            try
            {
                PersonneList.Add(new Personne()
                {
                   Nom = Nom,
                   Prenom= Prenom,
                   Pseudo = Pseudo

                });
                Nom = "";
                Prenom = "";
                Pseudo = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
        public PersonneUserControlViewModel()
        {
            BindCommand();
            PersonneList = new ObservableCollection<Personne>
            {
                new Personne()
                {
                    Nom= "Pierrot",
                    Prenom= "Le Foux",
                    Pseudo = "Tragicomix"
                    
                }
            };
        }
    }
}
