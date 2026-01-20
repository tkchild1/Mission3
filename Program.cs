// Tanner Child
// Mission 3 Food Bank Assignment

using Mission3;

Console.WriteLine("Welcome to your Food Bank");

bool keep = true;
List<FoodItem> foodInventory = new List<FoodItem>();

while (keep)
{
    Console.WriteLine("Here is the menu:\n\n1. Add Food Item\n2. Delete Food Item\n3. Print List of Current Food Items\n4. Exit the Program\n");
    string userResponse = Console.ReadLine();

    if (userResponse == "1")
    {
        FoodItem newItem = FoodItem.addItem(); // Call a static method to create item
        foodInventory.Add(newItem);
        Console.WriteLine("Item added successfully!\n");
    }
    else if (userResponse == "2")
    {
        FoodItem.RemoveItem(foodInventory);
    }
    else if (userResponse == "3")
    {
        FoodItem.PrintAllItems(foodInventory);
    }
    else if (userResponse == "4")
    {
        keep = false;
    }
    else
    {
        Console.WriteLine("Please enter a valid number.\n");
    }
}

Console.WriteLine("Thank you! Have a nice day");


