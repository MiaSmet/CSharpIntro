using System.Net.WebSockets;

namespace MS.Character
{
    internal class Program
    {
        
        public class GameCharacter
        {
            public bool GameOver = false;
            public int Exp { get; set; }
            public string Name { get; set; }
            public int Health { get; set; }
            public int Level { get; set; }
            public int Gold { get; set; }
            public int Potions { get; set; }
            public int Strength { get; set; }

            public void Train()
            {
                int gainedExp = Random.Shared.Next(20, 101);
                Exp += gainedExp;
                Console.WriteLine(Name + " gained " + gainedExp + " experience!");
                if(Exp >= 100)
                Level++;
                Strength += Random.Shared.Next(1, 10);
                Console.WriteLine(Name + " gained a level!");
                Health += 20;
                if (Health > 100) Health = 100;
            }

            public void TakeDamage()
            {
                int lostHealth = Random.Shared.Next(5, 26);
                Health -= lostHealth;
                Console.WriteLine(Name + " lost " + lostHealth + " health.");
                if (Health <= 0)
                {
                    Health = 0;
                    Console.WriteLine("Game over!");
                    GameOver = true;
                }
            }

            public void Heal()
            {
                int gainedHealth = 10;
                Health += gainedHealth;
                if (Health > 100)
                {
                    gainedHealth = 10 - (Health - 100);
                    Health = 100;
                }
                Console.WriteLine(Name + " gained " + gainedHealth + " health!");
            }

            public void ShowStats()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Health: " + Health);
                Console.WriteLine("Level: " + Level);
                Console.WriteLine("Gold: " + Gold);
            }

            public void Search()
            {
                int gainedGold = Random.Shared.Next(1, 21);
                Gold += gainedGold;
                Console.WriteLine(Name + " gained " + gainedGold + " gold!");
            }

            public void UsePotion()
            {
                if (Potions > 0)
                {
                    int gainedHealth = 25;
                    Health += gainedHealth;
                    if (Health > 100)
                    {
                        gainedHealth = 25 - (Health - 100);
                        Health = 100;
                    }
                    Potions--;
                    Console.WriteLine(Name + " gained " + gainedHealth + " health! " + Name + " has " + Potions + " left.");
                }
                else
                {
                    Console.WriteLine("You don't have any potions!");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();
            Console.Write("choose Warrior, Wizard, or Archer: ");
            string classChoice = Console.ReadLine();
            var character = new GameCharacter
                {
                    Name = name,
                    Exp = 0,
                    Health = 100,
                    Level = 1,
                    Gold = 50,
                    Potions = 3,
                    Strength = 5
                };
            if(classChoice.ToLower() == "wizard")
            {
                character.Health = 60;
                character.Strength = 3;
                character.Potions = 6;
            }
            else if(classChoice.ToLower() == "archer")
            {
                character.Health = 50;
                character.Strength = 8;
            }
            character.ShowStats();
            var goblin = new GameCharacter
            {
                Name = "Goblin",
                Exp = 0,
                Health = 60,
                Level = 1,
                Gold = 50,
                Potions = 3,
                Strength = 5
            };
            Console.WriteLine("What would you like to do? ");
            do
            {
                Console.WriteLine("1. Train");
                Console.WriteLine("2. Take Damage");
                Console.WriteLine("3. Heal");
                Console.WriteLine("4. Show Stats");
                Console.WriteLine("5. Search for gold");
                Console.WriteLine("6. Use a potion");
                Console.WriteLine("7. Attack the enemy");
                Console.WriteLine("8. Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        character.Train();
                        break;
                    case "2":
                        character.TakeDamage();
                        break;
                    case "3":
                        character.Heal();
                        break;
                    case "4":
                        character.ShowStats();
                        break;
                    case "5":
                        character.Search();
                        break;
                    case "6":
                        character.UsePotion();
                        break;
                    default:
                        break;
                }
                int gobChoice = Random.Shared.Next(1, 8);
                switch (gobChoice)
                {
                    case 1:
                        goblin.Train();
                        break;
                    case 2:
                        character.TakeDamage();
                        break;
                    case 3:
                        character.Heal();
                        break;
                    case 4:
                        character.ShowStats();
                        break;
                    case 5:
                        character.Search();
                        break;
                    case 6:
                        character.UsePotion();
                        break;
                    default:
                        break;
                }
                if (character.GameOver) break;
            } while (Console.ReadLine() != "8");
            Console.WriteLine("Goodbye!");

            void charAttack()
            {
                goblin.Health -= character.Strength;
                Console.WriteLine(goblin.Name + " lost " + character.Strength + " health!");
            }
            void gobAttack()
            {
                character.Health -= goblin.Strength;
                Console.WriteLine(character.Name + " lost " + goblin.Strength + " health.");
            }
        }
    }
}
