using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class TextAdventureGameUI
    {
        private readonly ItemsRepo _iRepo = new ItemsRepo();

        public void Run()
        {
            SeedData();
            StartScreen();
            First();
        }

        private void SeedData()
        {
            Items flashlight = new Items("Flashlight");
            Items firstaidKit = new Items("Firstaid Kit");
            Items rope = new Items("Rope");
            Items waterBottle = new Items("Water Bottle");
            Items pocketKnife = new Items("Pocket Knife");

            _iRepo.AddItemToBackpack(flashlight); 
            _iRepo.AddItemToBackpack(firstaidKit); 
            _iRepo.AddItemToBackpack(rope); 
            _iRepo.AddItemToBackpack(waterBottle); 
            _iRepo.AddItemToBackpack(pocketKnife); 
        }

        public void StartScreen()
        {
                System.Console.WriteLine("Welcome To The Forest. Good Luck On Your Adventure");
                System.Console.WriteLine("You May Come Across Some Items To Pick Up...... Choose Wisely");
                System.Console.WriteLine("You still have some items in your bag that you can use. Don't waste them.");
                System.Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                Console.Clear();
                First();                     
        }

        public void First()
        {
            string choice;

            System.Console.WriteLine("You are lost in a forest with no cellphone reception");
            System.Console.WriteLine("What do you do?");
            System.Console.WriteLine("1. seek out help");
            System.Console.WriteLine("2. look for water");
            System.Console.WriteLine("3. Build a Shelter");
            System.Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch(choice)
            {
                case "1":
                case "seek out help":
                {
                    System.Console.WriteLine("You walk down the forest path seeking out help.");
                        System.Console.WriteLine("You shout for help and your voice echoes through the area.");
                        System.Console.WriteLine("There's no path to be seen and trees as far as the eye can see.");
                        System.Console.WriteLine("You hear sticks breaking behind you.... you turn around slowly");
                        System.Console.WriteLine("It's just a deer..... PHEW");
                        System.Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        PressAnyKey();
                        Second();
                        break;
                }
                case "2":
                case "look for water":
                {
                    System.Console.WriteLine("You hear running water....");
                        System.Console.WriteLine("It's a creek! Now that you have a nearby water source you begin drinking from it");
                        System.Console.WriteLine("After drinking some water, you are no longer thirsty and continue your journey");
                        System.Console.WriteLine(" ");
                        Console.ReadLine();
                        // Fourth();
                        break;
                }
                case "3":
                case "build a shelter":
                {
                    System.Console.WriteLine("You gather materials for building a shelter in the forest.");
                        System.Console.WriteLine("After a few hours you are able to erect a sturdy shelter.");
                        System.Console.WriteLine("While building your shelter you manage to make a wooden spear for protection. Hopefully you won't have to use it");
                        System.Console.WriteLine("You feel a bit safer in your shelter but night is soon approaching."); 
                        Console.ReadLine();
                        this.Second();
                        break;
                }
                default:
                {
                System.Console.WriteLine("Command is invalid...");
                        System.Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        First();
                        break;
                }
            }
        }

        public void Second()
        {
            Random random = new Random();
            System.Console.WriteLine("It's starting to get dark and you start to feel small rain drops. You hear rumbles of thunder in the distance. Do you stay in your covered shelter or look for food?");
            string[] secondOptions = {$""};
            int randomNumber = random.Next(0, 3);
            string secondText = secondOptions[randomNumber];
            if(secondText != null)
            {
                System.Console.WriteLine("Index doesn't exist"); 
            }

            string secondChoice;

            System.Console.WriteLine(secondText);
            System.Console.WriteLine("Option 1");
            System.Console.Write("Choice: ");
            secondChoice = Console.ReadLine().ToLower();

            if(secondChoice == "1" || secondChoice == "shelter")
            {
            Console.WriteLine("You end up getting soaked from the rain. You'll need to dry your clothes soon.");
                Console.ReadLine();
                Console.Clear();
                Third();
            }
            else if (secondChoice == "2" || secondChoice == "n")
            {
                Console.WriteLine("Before you leave be sure to grab your flashlight out of your bag!");
                
                Console.ReadLine();
                gameOver();

            }
            else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Second();
            }

        }
        
        public void Third()

        {
            int Decision;
            Console.WriteLine("A low growl can be heard amongst the trees");
            Console.WriteLine("your stomach sinks and your eyes go wide as you scan the direction of the sound");
            Console.WriteLine("Will you fight or flee? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Decision);
            int loop = 0;
            bool dead = false;
            while (Decision != 1 && dead == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("You are too slow, a large bear leaps out and claws you in the chest.");
                    Console.WriteLine("You are bleeding profusely now, will your flee or fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop ++ ;
                }
                else if (loop >= 1)
                {
                    Console.WriteLine("The bear grabs you by your pants, you are kicking and screaming.");
                    Console.WriteLine("Fear and adrenaline surge with in you. Fight or Flee? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    dead = true;
                }              
            }
            if (dead == true )
                {
                Console.WriteLine("You feel a sharp claw swipe your back , and jagged teeth tear at your legs");
                Console.WriteLine("All is pain, followed by darkness.");
                Console.ReadLine();
                gameOver();
                }
            else 

                {
                Console.WriteLine("You fight with all your might, punching the bear in the nose and causing it to flee.");
                Console.ReadLine();
                youWin();
                }
        }


        public void gameOver()
        {
            Console.Clear();
            Console.WriteLine("You have died.");
            Console.WriteLine("All is good in the multiverse and nature continues it's course.");
            Console.WriteLine("The End?");
            Console.ReadLine();
            Console.Clear();
            StartScreen();
        }

        public void youWin()
        {
            Console.Clear();
            Console.WriteLine("You have survived.");
            Console.WriteLine("A group of rangers spot you.");
            Console.WriteLine("You are saved.");
            Console.ReadLine();
            Console.Clear();
            StartScreen();
        }

        public void Options()
        {
            System.Console.WriteLine("Choose an option: \n" +
            "1. View All Items In Your Backpack \n" +
            "2. Get An Item \n" +
            "3. Put Away Backpack \n" 
            );

            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                case "one":
                    ViewAllItems();
                    break;
                case "2":
                case "two":
                    GetItemByID();
                    break;
                case "3":
                case "three":
                    // CloseBackpack();
                    break;
                default:
                        System.Console.WriteLine("Invalid selection. Please choose from the options provided.");
                        break;
                
            }
        }

        public void ViewAllItems()
        {
            Console.Clear();

            List<Items> ListOfItems = _iRepo.ViewAllItems();

            foreach(Items item in ListOfItems)
            {
                DisplayAllItems(item);
            }
            
            // PressAnyKey();
        }

        private void DisplayAllItems(Items item)
        {
            System.Console.WriteLine($"Item Name: {item.Name}\n"); 
        }

        private void GetItemByID(int id)
        {
            Console.Clear();

            // System.Console.WriteLine("=== Backpack Item List ===");
            // var items = _iRepo.ViewAllItems();
            // foreach(Items i in items)
            // {
            //     DisplayAllItems(i);
            // }
            try
            {
                System.Console.WriteLine("Please selct an item by ID: ");
                int userInput = int.Parse(Console.ReadLine());
                var selectedItem = _iRepo.GetItemByID(userInput);
                if(selectedItem != null)
                {
                    DisplayAllItems(selectedItem);
                }
                else
                {
                    System.Console.WriteLine($"Sorry, the item with ID: {userInput} does not exist.");
                }
            }
            catch
            {
                System.Console.WriteLine("Invalid selection.");
            }

        }

        private void PressAnyKey()
        {
            System.Console.WriteLine("Press any Key to continue...");
            Console.ReadKey();
        }

        private bool CloseApplication1()
        {
            Console.Clear();
            System.Console.WriteLine("Thanks for playing!");
            return false;
        }
        private bool CloseApplication2()
        {
            Console.Clear();
            System.Console.WriteLine("Whoops, better luck next time!");
            return false;
        }

    //     private bool CloseBackpack()
    //     {

    //     }

    }


