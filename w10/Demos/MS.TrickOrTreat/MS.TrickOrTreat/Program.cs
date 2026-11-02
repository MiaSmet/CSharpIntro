//name: Mia Smet
//This is an extra credit project for an introductory c# class

namespace MS.TrickOrTreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again;
            do
            {
                //while loop
                int housenum = 0;
                while (housenum < 1 || housenum > 10)
                {
                    Console.WriteLine("How many houses will you visit? ");
                    //check for number and negative
                    if(int.TryParse(Console.ReadLine(), out housenum))
                    {
                        if (housenum < 1)
                        {
                            Console.WriteLine("You can't visit no or negative houses! Try again.");
                        }
                        else if (housenum > 10)
                        {
                            Console.WriteLine("Too many houses! Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a number!");
                    }
                }
                //for loop #1
                int totalCandy = 0;
                int highestCandy = 0;
                string bestHouse = "0";
                for (int i = 1; i <= housenum; i++)
                {
                    Console.WriteLine("This is house number " + i);
                    int candyNum = Random.Shared.Next(1, 6);
                    //haunted check
                    int haunted = Random.Shared.Next(1, 6);
                    int stolen = 3;
                    int lights = Random.Shared.Next(1, 7);
                    if (haunted == 5)
                    {
                        if(totalCandy == 0)
                        {
                            stolen = 0;
                        }
                        else if(totalCandy == 1)
                        {
                            stolen = 1;
                        }
                        else if(totalCandy == 2)
                        {
                            stolen = 2;
                        }
                        totalCandy -= stolen;
                        Console.WriteLine("This house is haunted! A ghost steals " + stolen + " candy.");
                    }
                    else if(lights == 6)
                    {
                        Console.WriteLine("Nobody's home...");
                        continue;
                    }
                    //not haunted or lights off
                    else
                    {
                        totalCandy += candyNum;
                        Console.WriteLine("You got " + candyNum + " candy");
                        //find best house
                        if (highestCandy < candyNum)
                        {
                            highestCandy = candyNum;
                            bestHouse = i.ToString();
                        }
                        else if(highestCandy == candyNum && bestHouse.Length == 1)
                        {
                            highestCandy = candyNum;
                            string bestHouse2 = bestHouse + " and " + i;
                            bestHouse = bestHouse2;
                        }
                        else if(highestCandy == candyNum && bestHouse.Length > 1)
                        {
                            highestCandy = candyNum;
                            string bestHouse2 = i.ToString() + ", " + bestHouse;
                            bestHouse = bestHouse2;
                        }
                        //check if total is 20+
                        if (totalCandy >= 20)
                        {
                            Console.WriteLine("Your bag ripped! Too bad.");
                            totalCandy = 0;
                            break;
                        }
                    }
                }
                //final roundup
                Console.WriteLine("Your final total tonight is " + totalCandy);
                for (int i = 0; i < totalCandy; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                if(bestHouse.Length == 1)
                {
                    Console.WriteLine("Your best house was house number " + bestHouse + " with " + highestCandy + " candy.");
                }
                else
                {
                    Console.WriteLine("Your best houses were house numbers " + bestHouse + " with " + highestCandy + " candy.");
                }
            
                Console.Write("Go trick-or-treating again? (y/n): ");
                again = Console.ReadLine().ToLower();
            } while (again == "y" || again == "yes");
            Console.WriteLine("Happy Halloween!");
        }
    }
}
