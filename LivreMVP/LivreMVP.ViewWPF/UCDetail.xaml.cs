using System.Windows.Controls;

namespace LivreMVP.ViewWPF
{
    /// <summary>
    /// Logique d'interaction pour UCDetail.xaml
    /// </summary>
    public partial class UCDetail : UserControl, IViewDetail
    {
        private Presenter _presenter;
        private DetailViewModel _vm;
        public UCDetail(Presenter p)
        {
            _presenter = p;
            InitializeComponent();
        }

        public DetailViewModel GetViewModel()
        {
            return _vm;
        }

        public void SetViewModel(DetailViewModel value)
        {
            _vm = value;
            this.DataContext = _vm;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
