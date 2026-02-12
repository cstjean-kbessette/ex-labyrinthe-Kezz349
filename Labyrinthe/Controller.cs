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
            bool exit = false;
            while (!exit)
            {
                view.AfficherEntete();
                view.AfficherLabyrinthe(labyrinthe);

                ConsoleKeyInfo input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.W:
                        labyrinthe.MoveUp();
                        break;
                    case ConsoleKey.S:
                        labyrinthe.MoveDown();
                        break;
                    case ConsoleKey.A:
                        labyrinthe.MoveLeft();
                        break;
                    case ConsoleKey.D:
                        labyrinthe.MoveRight();
                        break;
                    default:
                        break;
                }

                if (labyrinthe.isExit())
                {
                    view.AfficherVictoire();
                    exit = true;
                }
            }
        }
    }
}
