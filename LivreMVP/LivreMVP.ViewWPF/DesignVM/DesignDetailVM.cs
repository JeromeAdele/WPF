namespace LivreMVP
{
    public class DesignDetailVM
    {
        public Livre Bouquin { get; set; }

        public DesignDetailVM()
        {
            Bouquin = new Livre()
            {
                Titre = "design",
                Auteur = "Geronimo",
                Genre = "fiction",
                IsChecked = true

            };
        }
    }
}
