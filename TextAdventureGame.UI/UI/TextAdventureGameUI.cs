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
                PressAnyKey();
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
                    System.Console.WriteLine("You walk down the forest path seeking out help.");
                        System.Console.WriteLine("You shout for help and your voice echoes through the area.");
                        System.Console.WriteLine("There's no path to be seen and trees as far as the eye can see.");
                        System.Console.WriteLine("You hear sticks breaking behind you.... you turn around slowly");
                        System.Console.WriteLine("It's just a deer..... PHEW");
                        PressAnyKey();
                        Second();
                        break;
                case "2":
                case "look for water":
                    System.Console.WriteLine("You hear running water....");
                        System.Console.WriteLine("It's a creek! Now that you have a nearby water source you begin drinking from it");
                        System.Console.WriteLine("After drinking some water, you are no longer thirsty and continue your journey");
                        PressAnyKey();
                        Second();
                        break;
                case "3":
                case "build a shelter":
                    System.Console.WriteLine("You gather materials for building a shelter in the forest.");
                        System.Console.WriteLine("After a few hours you are able to erect a sturdy shelter.");
                        System.Console.WriteLine("While building your shelter you manage to make a wooden spear for protection. Hopefully you won't have to use it");
                        System.Console.WriteLine("You feel a bit safer in your shelter but night is soon approaching."); 
                        PressAnyKey();
                        Second();
                        break;
                default:
                    System.Console.WriteLine("Please select a valid option.");
                        PressAnyKey();
                        First();
                        break;
            }
        }

        public void Second()
        {
            string secondChoice;

            System.Console.WriteLine("It's starting to get dark and you start to feel small rain drops. You hear rumbles of thunder in the distance.");
            System.Console.WriteLine("Do you stay in your covered shelter or look for food?");
            System.Console.WriteLine("1. Shelter");
            System.Console.WriteLine("2. Food");
            System.Console.Write("Choice: ");
            secondChoice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (secondChoice)
            {
                case "1":
                case "one":
                    System.Console.WriteLine("You end up getting a little wet from the rain. You're stomach is growling... hopefully you find food soon.");
                    PressAnyKey();
                    Third();
                    break;
                case "2":
                case "two":
                    System.Console.WriteLine("Before you leave be sure to grab your flashlight out of your bag!");
                    Options();
                    Console.ReadLine();
                    GameOver();
                    break;
                default:
                    System.Console.WriteLine("Please enter a valid option.");
            }
        }

        
        public void Third()
        {
            string Decision;
            Console.WriteLine("A low growl can be heard amongst the trees");
            Console.WriteLine("your stomach sinks and your eyes go wide as you scan the direction of the sound");
            Console.WriteLine("Will you fight or flee?");
            System.Console.WriteLine("1. Fight");
            System.Console.WriteLine("2. Flee");
            Console.Write("Decision: ");
            Decision = Console.ReadLine().ToLower();
            Console.Clear();

            switch(Decision)
            {
                case "1":
                case"one":
                    System.Console.WriteLine("Quick get your knife");
                    Options();
                    System.Console.WriteLine("You are too slow, and a large bear leaps out and claws you in the chest.");
                    System.Console.WriteLine("You are bleeding profusely and you can't move.");
                    PressAnyKey();
                    GameOver();
                    break;
                case "2":
                case "two":
                    System.Console.WriteLine("The bear grabs you by ypour pants, you are kicking and screaming.");
                    System.Console.WriteLine("Fear and adreanaline surge within you. Suddenly your pants tear, you're free! Hope you brought an extra pair...");
                    PressAnyKey();
                    YouWin();
                    break;
            }
        }

        public void GameOver()
        {
            string Redo;

            System.Console.Clear();
            System.Console.WriteLine("You have died.");
            System.Console.WriteLine("Things get wild in the forest, try to be a bit more careful!");
            System.Console.WriteLine("Try again?");
            System.Console.WriteLine("1. Retry");
            System.Console.WriteLine("2. Quit");
            Redo = Console.ReadLine().ToLower();
            Console.Clear();
            
            switch(Redo)
            {
                case "1":
                case "one":
                    First();
                    break;
                case "2":
                case "two":
                    CloseApplication2();
                    break;
                default:
                    System.Console.WriteLine("Please select a valid option");
                    break;
            }
        }


        public void YouWin()
        {
            string TryAgain;

            System.Console.Clear();
            System.Console.WriteLine("It's your lucky day");
            System.Console.WriteLine("A group of hikers spot you and call for help.");
            System.Console.WriteLine("They give you food and water, you're saved... or are you?");
            System.Console.WriteLine("Think you can do it again?");
            System.Console.WriteLine("1. Retry");
            System.Console.WriteLine("2. Quit");
            TryAgain = Console.ReadLine().ToLower();
            Console.Clear();
            
            switch (TryAgain)
            {
                case "1":
                case "one":
                    First();
                    break;
                case "2":
                case "two":
                    CloseApplication1();
                    break;
                default:
                    System.Console.WriteLine("Please select a valid option");
                    break;
            }
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
                    CloseApplication1();
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
                DisplayItem(item);
            }
        }

        private void DisplayItem(Items item)
        {
            System.Console.WriteLine("");
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
    }


