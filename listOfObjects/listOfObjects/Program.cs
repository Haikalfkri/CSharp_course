using System;


namespace listOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            //Player player1 = new Player("Player1");
            //Player player2 = new Player("Player2");
            //Player player3 = new Player("Player3");

            players.Add(new Player("player1"));
            players.Add(new Player("player2"));
            players.Add(new Player("player3"));

            foreach (Player player in players)
            {
                //Console.WriteLine(player.username);
                Console.WriteLine(player);
            }

        }
    }

    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}