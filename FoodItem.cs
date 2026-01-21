using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Mission3
{
    internal class FoodItem
    {
        // define variables for the class
        string name;
        string category;
        int quantity;
        string expirationDate;

        // Constructor that sets user inputs automatically
        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
        }

        // Method to add a foodItem to the array
        public static FoodItem addItem()
        {
            // Get the inputs neccessary for the constructor
            Console.WriteLine("Please enter your item: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your item category (e.g. Dairy, Produce, Canned Goods): ");
            string category = Console.ReadLine();
            Console.WriteLine("Please enter your item quantity: ");
            int quantity;
            // Error handling for negative integers
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer: ");
            }
            Console.WriteLine("Please enter your items expiration date: ");
            string expirationDate = Console.ReadLine();

            return new FoodItem(name, category, quantity, expirationDate);

        }
        // Method to print an individual item
        public void PrintItem()
        {
            Console.WriteLine($"Name: {name}, Category: {category}, Quantity: {quantity}, Expiration: {expirationDate}");
        }

        // Method to print the whole list
        public static void PrintAllItems(List<FoodItem> items)
        {
            // Make sure there is an item in the list
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
        // Method to remove an item from the list
        public static void RemoveItem(List<FoodItem> items)
        {
            Console.WriteLine("Enter the name of the food item you wish to remove.\n");
            string deleteItem = Console.ReadLine();
            bool found = false;
            for (int i =0; i < items.Count; i++)
            {
                // See if the item exists in the name
                if(deleteItem == items[i].name)
                {
                    items.Remove(items[i]);
                    found = true;
                    // Send a message when an item is deleted
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

