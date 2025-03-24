//Creating a method to display the list since this is done multiple times
void displayDict(Dictionary<int,string> gList)
{
    Console.WriteLine("Printing List:");
    foreach (KeyValuePair<int, string> List in gList){
        Console.WriteLine("Key: {0}, Value: {1}", List.Key, List.Value);
    }
    Console.WriteLine();
}
//This instantiates the Grocery List with the dictionary class
Dictionary<int, string> groceryList = new Dictionary<int, string>();

//Here we add the base items to the grocery list
groceryList.Add(2,"Milk");
groceryList.Add(1,"Honey");

displayDict(groceryList);

Console.WriteLine();
Console.WriteLine("Hello this is a program that will allow you to interact with the grocery list above you: \n");

while (true){
    Console.WriteLine("This program will allow you to do different things based on your needs:");
    Console.WriteLine("Enter 1 to display the List\nEnter 2 to remove an item from the list\nEnter 3 to add a new item to the list\n" +
    "Enter 4 to edit one of the exisitng things on the list\nEnter 5 to sort the list numerically\nEnter 6 to exit the program\nEnter your choice: ");

    //Prompting the user for what they want to do
    string? userChoice = Console.ReadLine();

    switch(userChoice){
        case "1":
            //Display the list
            displayDict(groceryList);
            continue;
        case "2":
            //Remove an item from the list based on a key
            Console.WriteLine("Please enter the key of the item that you would like to remove:\nIf you would like to abort enter \"x\"");
            string? removeItem = Console.ReadLine();
            if (removeItem.Equals("x"))
            {
                Console.WriteLine("Returning to beginning...\n\n");
                continue;
            }
            try
            {
                groceryList.Remove(Convert.ToInt32(removeItem));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a number not a string...");
                Console.WriteLine();
                continue;

            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown eror has occured");
                Console.WriteLine($"{e.Message} caused an unknown error\n {e.Source} was the source of the error\n\n");
            }
            continue;
        case "3":
            //Add a new key and item to the list
            Console.WriteLine("Please enter the key of the item that you would like to add:\nIf you would like to abort enter \"x\"");
            string? addItemKey = Console.ReadLine();
            if (addItemKey.Equals("x"))
            {
                Console.WriteLine("Returning to beginning...\n\n");
                continue;
            }
            Console.WriteLine("Please enter the name of the item that you would like to add:\nIf you would like to abort enter \"x\"");
            string? addItemName = Console.ReadLine(); 
            if (addItemName.Equals("x"))
            {
                Console.WriteLine("Returning to beginning...\n\n");
                continue;
            }     
            try
            {
                groceryList.Add(Convert.ToInt32(addItemKey),addItemName);
            } 
            catch (FormatException e)
            {
                Console.WriteLine($"{e.Message} is an invalid input, please try again\n\n");
                continue;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown eror has occured");
                Console.WriteLine($"{e.Message} caused an unknown error\n {e.Source} was the source of the error\n\n");
            }
            continue;
        case "4": 
            //Edit the list based on a key
            Console.WriteLine("Please enter the key of the item that you would like to edit:\nIf you would like to abort enter \"x\"");
            string? editItemKey = Console.ReadLine();
            if (editItemKey.Equals("x"))
            {
                Console.WriteLine("Returning to beginning...\n\n");
                continue;
            }
            Console.WriteLine("Please enter the name of the item that you would like to edit:\nIf you would like to abort enter \"x\"");
            string? editItemname = Console.ReadLine();
            if (editItemname.Equals("x"))
            {
                Console.WriteLine("Returning to beginning...\n\n");
                continue;
            }
            try
            {
                if (!groceryList.ContainsKey(Convert.ToInt32(editItemKey)))
                {
                    Console.WriteLine($"There is not an item with a key of {editItemKey}. Please review the list before trying to edit again.\n\n");
                    Console.WriteLine();
                    continue;
                }
                groceryList[Convert.ToInt32(editItemKey)] = editItemname;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e.Message} is not entered correctly, please only used integers for keys and strings for values...\n\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown eror has occured");
                Console.WriteLine($"{e.Message} caused an unknown error\n {e.Source} was the source of the error\n\n");
            }
            continue;
        case "5":
            //Sort the list numerically
            groceryList = groceryList.OrderBy(pair => pair.Key).ToDictionary();
            
            Console.WriteLine("Dictionary has been sorted.\n");
            continue;
        case "6": 
            Console.WriteLine("Thank you for using this program.");
            break;
        default:
            //Should be ran when the user has an invalid choice (i.e. entering -1)
            Console.WriteLine("You selected the option \"{0}\", this is not a valid option. Please re-read instructions.\n", userChoice);       
            continue;
    }
    break;
}
