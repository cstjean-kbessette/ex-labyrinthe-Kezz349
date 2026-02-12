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
                    case ConsoleKey.UpArrow:
                        labyrinthe.MoveUp();
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        labyrinthe.MoveDown();
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        labyrinthe.MoveLeft();
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
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
