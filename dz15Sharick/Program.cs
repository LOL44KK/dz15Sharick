namespace dz15Sharick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }

    public class Game
    {
        private delegate void Scene();
        
        private Scene scenes;

        public Game()
        {
            scenes += Exit;
            scenes += NewGame;
            scenes += LoadGame;
            scenes += Rules;
            scenes += Author;
        }

        public void Start()
        {
            Menu();
        }

        private void Menu()
        {
            while (true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Новая игра");
                Console.WriteLine("2. Загрузить игру");
                Console.WriteLine("3. Правила");
                Console.WriteLine("4. Об авторе");
                Console.WriteLine("0. Выход");

                Console.Write(">");
                string? fed = Console.ReadLine();
                Console.Clear();

                if (fed.All(char.IsDigit))
                {
                    scenes.GetInvocationList()[int.Parse(fed)].DynamicInvoke();
                }
            }
        }

        private void NewGame()
        {
            Console.WriteLine("New Game");
        }

        private void LoadGame()
        {
            Console.WriteLine("Load Game");
        }

        private void Rules()
        {
            Console.WriteLine("Rules");
        }

        private void Author()
        {
            Console.WriteLine("Author");
        }

        private void Exit()
        {
            Console.WriteLine("Poka");
            Environment.Exit(0);
        }
    }
}
