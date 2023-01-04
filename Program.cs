using Second_Practice;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Guessing Game
            string password = "ready";
            string guess = "";
            string first;
            int i = 0;
            while (guess.ToLower() != password)
            {
                Console.WriteLine("Type ready:  ");
                guess = Console.ReadLine();
                i++;
                switch (guess.ToLower())
                {
                    case "no":
                        Console.WriteLine("Take your time");
                        break;
                    case "yes":
                        Console.WriteLine("Yes! Type Ready!");
                        break;
                    case "":
                        Console.WriteLine("Try typing ready");
                        break;
                }
                if (i >= 5)
                {
                    Console.WriteLine("You ran out of chances!");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            if (guess == password)
            {
                string[] passwords = { "\nthree", "two", "one\n" };
                for (int j = 0; j < passwords.Length; j++)
                {
                    Console.WriteLine(passwords[j]);
                }
            }
            Console.WriteLine("Whats 3 + 9 - 6? :  ");
            first = Console.ReadLine();
            string[,] numberGrid = {
                { "1", "2", "3"},
                { "4", "5", "6"},
                { "7", "8", "9"} };
            if (first == numberGrid[1, 2])
            {
                Console.WriteLine("\nWhats 12 - ((5 / 100) x 100) :  ");
                string second = Console.ReadLine();
                if (second == numberGrid[2, 0])
                {
                    Console.WriteLine("\nNice!");
                    Console.WriteLine("Are you ready for the real challenge");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadLine();
                    Console.WriteLine("\nGuess a number from 1 - 10");
                    Console.WriteLine("I'll give you three chances!");
                    string guess2 = Console.ReadLine();
                    Random rnd = new Random();
                    int num = rnd.Next(1, 11);
                    int z = 1;
                    while (Convert.ToInt32(guess2) != num)
                    {
                        Console.WriteLine("Try again!");
                        Console.WriteLine("Guess a number from 1 - 10:  ");
                        guess2 = Console.ReadLine();
                        z++;
                        if (z >= 3)
                        {
                            Console.WriteLine("You ran out of chances!");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                        }
                    }
                    Console.WriteLine("You won!");
                    Console.WriteLine("Press any key to escape.");
                    Console.ReadKey();
                }
                else
                {
                    Youlost();
                }
            }
            else
            {
                Youlost();
            }
        }
        static void Youlost()
        {
            Console.WriteLine("You lost!");
            Console.WriteLine("Press any key to escape.");
            Console.ReadKey();
        }*/

            Song song1 = new Song("Day n Nite", "Kid Cudi", 500, "PG");

            Song song2 = new Song("Young, Wild & Free", "Wiz Khalifa", 200, "R");

            Producer producer = new Producer();
            producer.MakeUpbeat();

            SeniorProducer seniorproducer = new SeniorProducer();
            seniorproducer.MakeUpbeat();
            seniorproducer.Custombeat();


            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Error with number");
            }
            Console.Write("Good bye");

        }
    }
}