using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Mission3
{
    internal class FoodItem
    {
        string name;
        string category;
        int quantity;
        string expirationDate;
        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
        }

        public static FoodItem addItem()
        {
            Console.WriteLine("Please enter your item: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your item category (e.g. Dairy, Produce, Canned Goods): ");
            string category = Console.ReadLine();
            Console.WriteLine("Please enter your item quantity: ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer: ");
            }
            Console.WriteLine("Please enter your items expiration date: ");
            string expirationDate = Console.ReadLine();

            return new FoodItem(name, category, quantity, expirationDate);

        }
        public void PrintItem()
        {
            Console.WriteLine($"Name: {name}, Category: {category}, Quantity: {quantity}, Expiration: {expirationDate}");
        }

        public static void PrintAllItems(List<FoodItem> items)
        {
            Console.WriteLine("\nCurrent Food Inventory");
            if (items.Count == 0)
            {
                Console.WriteLine("No items in inventory.\n");
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    items[i].PrintItem();
                }
                Console.WriteLine();
            }
        }
        public static void RemoveItem(List<FoodItem> items)
        {
            Console.WriteLine("Enter the name of the food item you wish to remove.\n");
            string deleteItem = Console.ReadLine();
            bool found = false;
            for (int i =0; i < items.Count; i++)
            {
                if(deleteItem == items[i].name)
                {
                    items.Remove(items[i]);
                    found = true;
                    Console.WriteLine($"{deleteItem} was successfully removed.\n");
                    break;
                }
                
            }
            if (!found)
            {
                Console.WriteLine($"{deleteItem} was not found in inventory.\n");
            }
        }
    }
}
