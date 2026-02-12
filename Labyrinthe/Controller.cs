namespace Labyrinthe
{
    internal class Controller
    {
        private Labyrinthe labyrinthe;
        private View view;

        public Controller(Labyrinthe labyrinthe, View view)
        {
            this.labyrinthe = labyrinthe;
            this.view = view;
        }
        public void Run()
        {
            view.AfficherEntete();
            view.AfficherLabyrinthe(labyrinthe);
            
        }
    }
}
