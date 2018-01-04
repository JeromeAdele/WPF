using System.Collections.ObjectModel;

namespace LivreMVP
{
    public class AjoutLivreViewModel
    {
        public ObservableCollection<Livre> listeLivre { get; private set; }
        public string ItemString { get; set; }
        public AjoutLivreViewModel()
        {
            listeLivre = new ObservableCollection<Livre>();
            ItemString = "";
        }
    }
}
