namespace LivreMVP.ViewWPF
{
    public class Presenter
    {
        public Livre SelectItem { get; private set; }
        public IViewDetail ViewDetail { get; private set; }

        public IViewMainPage ViewMain { get; private set; }

        public Presenter(IViewMainPage view)
        {
            this.ViewMain = view;
        }

        public void AjouterLivre()
        {
            var vm = ViewMain.GetViewModel();
            var bouquin = new Livre()
            {
                Titre = vm.ItemString,
                Auteur = vm.ItemString,
                Genre = vm.ItemString,
                IsChecked = false
            };
            vm.listeLivre.Add(bouquin);
        }

        public void ChargementInitial()
        {
            var vm = ViewMain.GetViewModel();

            var listLivre = vm.listeLivre;

            listLivre.Add(new Livre()
            {
                Titre = "La Quatorzième Colonie",
                Auteur = "Steve Berry",
                Genre = "Thriller",
                IsChecked = true
            });
            listLivre.Add(new Livre()
            {
                Titre = "The Patriot Threat",
                Auteur = "Steve Berry",
                Genre = "Thriller",
                IsChecked = true
            });
            listLivre.Add(new Livre()
            {
                Titre = "Le Dernier Templier",
                Auteur = "Raymond Khoury",
                Genre = "Thriller",
                IsChecked = true
            });
        }

        public void Initialize()
        {
            var vm = new AjoutLivreViewModel();
            //assignation du viewModel
            ViewMain.SetViewModel(vm);
        }
        public void SelectionChanged(Livre livre)
        {
            this.SelectItem = livre;
            var vm = new DetailViewModel()
            {
                Livre = SelectItem
            };

            ViewDetail = new UCDetail(this);
            ViewDetail.SetViewModel(vm);

            ViewMain.AfficherDetail(ViewDetail);
        }
    }
}
