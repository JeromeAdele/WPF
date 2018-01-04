using System.Windows;
using System.Windows.Controls;

namespace LivreMVP.ViewWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewMainPage
    {
        private AjoutLivreViewModel _model;
        public Presenter Presenter { get; private set; }

        public MainWindow()
        {
            Presenter = new Presenter(this);

            //initialisation du presenter -> attribution d'un ViewModel à la View
            Presenter.Initialize();

            Presenter.ChargementInitial();

            InitializeComponent();
        }

        public void AfficherDetail(IViewDetail viewDetail)
        {
            this.ContenControl.Content = viewDetail;
        }

        public AjoutLivreViewModel GetViewModel()
        {
            return _model;
        }

        public void SetViewModel(AjoutLivreViewModel value)
        {
            _model = value;
            this.DataContext = _model;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Presenter.AjouterLivre();
        }

        private void lbLivre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var source = sender as ListBox;

            var liv = source.SelectedItem as Livre;

            Presenter.SelectionChanged(liv);

        }
    }
}
