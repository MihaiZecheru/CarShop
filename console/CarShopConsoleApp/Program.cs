using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        public static string dl = "\n---------------------------------\n"; // dotted line
        public static string megaDottedLine = "\n---------------------------------|---------------------------------\n";


        static void Main(string[] args)
        {
            // create a store
            Store store = new Store();

            // welcome message
            Console.WriteLine("---------------------------------|---------------------------------\n\n" + "Welcome to the car store. You will create a car inventory, add cars you like to your shopping list, and then checkout.");

            Console.WriteLine(megaDottedLine);
            int action = ChooseAction();

            while (action != 0)
            {   
                Console.WriteLine(megaDottedLine);
                switch (action)
                {
                    // add to inv
                    case 1:
                        Console.WriteLine($"{dl}Add car to inventory ->");

                        string make = "";
                        string model = "";
                        decimal price = 0;

                        // get car information
                        Console.WriteLine("\nWhat is the make of your car? (ford, gm, nissan, etc.)");
                        make = Console.ReadLine();

                        Console.WriteLine("\nWhat is the model of your car? (escalade, corvette, mustang, etc.)");
                        model = Console.ReadLine();

                        Console.WriteLine("\nWhat is the price of your car?");
                        try
                        {
                            price = Convert.ToDecimal(Console.ReadLine());
                        } catch (FormatException)
                        {
                            Console.WriteLine($"{dl}Price must be a number{dl}");
                            continue; // choose new action
                        }

                        Car car = new Car(make, model, price);
                        store.carList.Add(car);

                        PrintInventory(store);
                        break;

                    // add to cart
                    case 2:
                        Console.WriteLine($"{dl}Add car to shopping cart ->");

                        Console.WriteLine("\nCar Inventory:");
                        PrintInventory(store);

                        Console.WriteLine($"{dl}Which item would you like to buy? (1, 2, 3, etc.){dl}");

                        try
                        {
                            int chosenCar = int.Parse(Console.ReadLine());
                            store.shoppingList.Add(store.carList[chosenCar - 1]);
                        } catch(FormatException)
                        {
                            Console.WriteLine("Response must be a number (1+)");
                            continue;
                        }

                        PrintShoppingCart(store);
                        break;

                    // checkout
                    case 3:
                        Console.WriteLine(dl + "Checkout ->");
                        PrintShoppingCart(store);
                        Console.WriteLine("The total cost of your items are $" + store.Checkout());
                        break;

                    // if num is 4 (user didnt pick) or some other num
                    default:
                        break;
                }
                    Console.WriteLine(megaDottedLine);
                action = ChooseAction();
            }
        }

        private static void PrintShoppingCart(Store store)
        {
            Console.WriteLine(dl + "Cars you have chosen to buy ->");
            foreach (Car car in store.shoppingList)
            {
                Console.WriteLine($"{dl}Car #{store.carList.IndexOf(car) + 1}:{dl}Make: {car.make}{dl}Model: {car.model}{dl}Price: {car.price}{dl}");
            }
        }

        private static void PrintInventory(Store store)
        {
            foreach (Car car in store.carList)
            {
                Console.WriteLine($"{dl}Car #{store.carList.IndexOf(car) + 1} is as follows:{dl}Make: {car.make}{dl}Model: {car.model}{dl}Price: {car.price}{dl}");
            }
        }

        public static int ChooseAction()
        {
            int choice = 4; // for when user does not enter a num 0-3
            Console.WriteLine($"{dl}Choose an action:\n(0) - quit\n(1) - add new car to inventory\n(2) - add car to cart\n(3) - checkout{dl}");
            try
            {
                choice = int.Parse(Console.ReadLine());
            } catch(FormatException)
            {
                Console.WriteLine($"{dl} Choice must be a number (0 - 3){dl}");
            }

            return choice;
        }
    }
}