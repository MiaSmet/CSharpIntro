namespace MS.MiniArcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("=========================");
                Console.WriteLine("       MINI ARCADE       ");
                Console.WriteLine("=========================");

                Console.WriteLine("1. Rocket Countdown");
                Console.WriteLine("2. Number Guessing Game");
                Console.WriteLine("3. Lucky Number Generator");
                Console.WriteLine("4. Exit");

                Console.Write("\nChoose an option: ");
                //?? "" sets it to an empty string if null
                input = Console.ReadLine() ?? "";

                switch (input.Trim())
                {
                    case "1":
                        //Game 1: Rocket Countdown
                        Console.WriteLine("ROCKET COUNTDOWN");
                        Console.Write("Please enter the starting number: ");
                        if((int.TryParse(Console.ReadLine(), out int value)) && value > 0)
                        {
                            for (int i = value; i >= 1; i--)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("Blast off!");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a whole positive number");
                        }
                        break;
                    case "2":
                        //Game 2: Number Guessing Game
                        Console.WriteLine("NUMBER GUESSING GAME");
                        int secretNumber = Random.Shared.Next(1, 11);
                        int guess = 0;
                        int attempts = 0;
                        while (guess != secretNumber)
                        {
                            Console.Write("Enter a number between 1 and 10: ");
                            if (int.TryParse(Console.ReadLine(), out guess) && guess > 0 && guess < 11)
                            {
                                attempts++;
                                if (guess < secretNumber)
                                {
                                    Console.WriteLine("Too low! Try again.");
                                }
                                else if (guess > secretNumber)
                                {
                                    Console.WriteLine("Too high! Try again.");
                                }
                                else
                                {
                                    Console.WriteLine("Correct!");
                                    Console.WriteLine("Attempts: " + attempts);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                                
                        }
                        break;
                    case "3":
                        //Game 3: Lucky Number Generator
                        Console.WriteLine("LUCKY NUMBER GENERATOR");
                        Console.Write("How many lucky numbers would you like?   ");
                        if(int.TryParse(Console.ReadLine(), out int count) && count > 0)
                        {
                            for (int i = 1; i <= count; i++)
                            {
                                int random = Random.Shared.Next(1, 101);
                                if (i != count)
                                {
                                    Console.Write(random + ", ");
                                }
                                else
                                {
                                    Console.Write(random);
                                }
                            }
                            Console.WriteLine("\nGood luck!");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a positive whole number.");
                        }
                        break;
                    case "4":
                        //Exit
                        Console.WriteLine("Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose 1-4");
                        break;

                }
            }
            while (input != "4");
        }
    }
}
