namespace LivreMVP
{
    public interface IViewMainPage
    {
        void AfficherDetail(IViewDetail viewDetail);

        AjoutLivreViewModel GetViewModel();

        void SetViewModel(AjoutLivreViewModel value);
    }
}
