using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        // List<T> specifies a list of type T; in this case list of Car obj
        public List<Car> carList { get; set; }
        public List<Car> shoppingList { get; set; }

        public Store()
        {
            this.carList = new List<Car>();
            this.shoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            // init total cost
            decimal totalCost = 0;

            // iterate through all cars in shopping list
            foreach (Car car in shoppingList)
            {
                totalCost += car.price;
            }

            // empty out the shopping list as the price has been totalled already
            shoppingList.Clear();

            return totalCost;
        }


    }
}
