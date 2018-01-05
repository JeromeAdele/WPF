using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFmvvm.ViewModel;

namespace WPFmvvm.UserControls
{
    /// <summary>
    /// Logique d'interaction pour PersonneUserControl.xaml
    /// </summary>
    public partial class PersonneUserControl : UserControl
    {
        private readonly PersonneUserControlViewModel _personneUserControlViewModel;
        public PersonneUserControl()
        {
            InitializeComponent();
            _personneUserControlViewModel = new PersonneUserControlViewModel();
            DataContext = _personneUserControlViewModel;
        }
    }
}
