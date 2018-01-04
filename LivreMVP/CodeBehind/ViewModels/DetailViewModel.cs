using System.ComponentModel;

namespace LivreMVP
{
    public class DetailViewModel : INotifyPropertyChanged
    {
        private Livre _livre;
        public Livre Livre
        {
            get { return _livre; }
            set
            {
                _livre = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Livre"));
            }
        }
        public DetailViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
