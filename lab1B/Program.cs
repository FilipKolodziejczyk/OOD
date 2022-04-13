using System;
using PM=Lab1.PotionsManipulator;
using MOD = Lab1.Modifiers;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPotion[] potions =
            {
                new OrdinaryPotion(
                    Name: "Health potion",
                    Price: 10f,
                    BestBefore: DateTime.Today.AddDays(60)
                ),
                new OrdinaryPotion(
                    Name: "Mana potion",
                    Price: 5f,
                    BestBefore: DateTime.Today.AddDays(-1)
                ),
                new OrdinaryPotion(
                    Name: "Acid resistance potion",
                    Price: 0.5f,
                    BestBefore: DateTime.Today.AddYears(3)
                ),
                new OrdinaryPotion(
                    Name: "Potion of Animal Friendship",
                    Price: 42f,
                    BestBefore: DateTime.Today.AddMonths(4)
                ),
                new OrdinaryPotion(
                    Name: "Potion of Clairvoyance",
                    Price: 100f,
                    BestBefore: DateTime.Today.AddDays(100)
                ),
                new OrdinaryPotion(
                    Name: "Apple juice",
                    Price: 3f,
                    BestBefore: DateTime.Today.AddMonths(10)
                ),
                new OrdinaryPotion(
                    Name: "Gold flake potion",
                    Price: 1000f,
                    BestBefore: DateTime.Today.AddYears(10)
                ),
                new OrdinaryPotion(
                    Name: "Sparkling water",
                    Price: 4f,
                    BestBefore: DateTime.Today.AddMonths(12)
                ),
                new OrdinaryPotion(
                    Name: "Potion of Invisibility",
                    Price: 200f,
                    BestBefore: DateTime.Today.AddYears(2)
                ),
                new OrdinaryPotion(
                    Name: "Potion of Vitality",
                    Price: 15f,
                    BestBefore: DateTime.Today.AddYears(3)
                ),
            };

            IPotion[] potions2 = new IPotion[10];
            for (int i = 0; i < 10; i++)
            {
                potions2[i] = potions[i];
            }

            foreach (var potion in potions)
            {
                Console.WriteLine($"{potion}\n");
            }

            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ChangedVolumePotion\n");
                Console.ForegroundColor = ConsoleColor.White;
                TestPrintPotion(potions[0]);
                potions[0] = PM.ChangedPotionVolume(potions[0], potions[0].GetVolume() + 10f);
                TestPrintPotion(potions[0]);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ColoredPotion\n");
                Console.ForegroundColor = ConsoleColor.White;
                TestPrintPotion(potions[1]);
                potions[1] = PM.MakePotionColored(potions[1], MyColor.Blue);
                TestPrintPotion(potions[1]);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OldPotion\n");
                Console.ForegroundColor = ConsoleColor.White;
                TestPrintPotion(potions[2]);
                potions[2] = PM.MakePotionOld(potions[2], 32);
                TestPrintPotion(potions[2]);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("RandomPotion\n");
                Console.ForegroundColor = ConsoleColor.White;
                TestPrintPotion(potions[3]);
                potions[3] = PM.MakePotionRandom(potions[3]);
                TestPrintPotion(potions[3]);
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ChangedPricePotion\n");
                Console.ForegroundColor = ConsoleColor.White;
                TestPrintPotion(potions[4]);
                potions[4] = PM.ChangePotionPrice(potions[4], 500);
                TestPrintPotion(potions[4]);
                Console.WriteLine("----------------------------------------------------------------------");
            }
            
            //Part 2
            {
                //Write your code here
                for (int i = 0; i < potions2.Length; i++)
                    TestPrintPotion(PM.MakePotionOld(PM.MakePotionColored(PM.ChangedPotionVolume(potions2[i], 2 * potions2[i].GetVolume()), MyColor.Red), 3));
            }
            
            //Part 3
            {
                //write your code here
                IPotion unreadablePotion = MOD.MakeDescriptionUnreadable(potions[5]);
                IPotion translatedDescriptionPotion = MOD.TranslateDescription(potions[5]);
                
                Console.WriteLine("Unreadable potion");
                Console.WriteLine($"{unreadablePotion.Name}");
                Console.WriteLine($"{unreadablePotion.GetDescription()}");
                
                Console.WriteLine("Translated description potion");
                Console.WriteLine($"{translatedDescriptionPotion.Name}");
                Console.WriteLine($"{translatedDescriptionPotion.GetDescription()}");
            }
        }

        private static void TestPrintPotion(IPotion potion)
        {
            Console.WriteLine($"Name: {potion.Name}");
            Console.WriteLine($"Price: {potion.Price}");
            Console.WriteLine($"Volume: {potion.GetVolume()}");
            Console.WriteLine($"Best before: {potion.BestBefore}");
            Console.WriteLine($"Description: {potion.GetDescription()}\n");
        }
        
    }
}