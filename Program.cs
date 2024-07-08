using System.Text.Json; 

namespace Assignment_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var character = new Character
            {
                Name = "Soul Searcher",
                Health = 300,
                Attack = 700,
                Defense = 500,
                isEnemy = false,

            };
            string jsonString = JsonSerializer.Serialize(character);
            Console.WriteLine(jsonString);
        }
    }

    class Character
    {
        private string _name;
        public string Name
        {
            get => _name; set => _name = value;
        }

        private int _health;

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        private int _attack;

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        int _defense;

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        public bool isEnemy { get; set; }
    }
}
