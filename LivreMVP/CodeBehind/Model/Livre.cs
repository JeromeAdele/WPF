using System.ComponentModel;

namespace LivreMVP
{
    public class Livre: INotifyPropertyChanged
    {
        private string _titre;
        private bool? _isChecked;
        private string _genre;
        private string _auteur;

        public bool? IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsChecked"));
            }
        }
        public string Titre
        { 
            get { return _titre; }
            set
            {
                _titre = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Titre"));
            }
        }
        public string Genre
        {
            get { return _genre; }
            set
            {
                _genre = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Genre"));
            }

        }
        public string Auteur
        {
            get { return _auteur; }
            set
            {
                _auteur = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Auteur"));

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
