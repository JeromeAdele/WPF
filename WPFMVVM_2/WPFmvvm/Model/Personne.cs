using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFmvvm.Model
{
    public class Personne : INotifyPropertyChanged
    {
        private string _nom;
        private string _prenom;
        private string _pseudo;

        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                OnPropertyChanged("Nom");

            }
        }

        public string Prenom
        {
            get { return _prenom; }
            set
            {
                _prenom = value;
                OnPropertyChanged("Prenom");
            }
        }

        public string Pseudo
        {
            get { return _pseudo; }
            set
            {
                _pseudo = value;
                OnPropertyChanged("Pseudo");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler eventHandler = PropertyChanged;

            if (eventHandler != null)

            {

                eventHandler(this, new PropertyChangedEventArgs(propertyName));

            }
        }
    }
}
