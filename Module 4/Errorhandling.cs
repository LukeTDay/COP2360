//Creating a method to display the list since this is done multiple times
void displayDict(Dictionary<int,string> gList)
{
    Console.WriteLine("Printing List:");
    foreach (KeyValuePair<int, string> List in gList){
        Console.WriteLine("Key: {0}, Value: {1}", List.Key, List.Value);
    }
    Console.WriteLine();
}

bool endLoop = false;
//This instantiates the Grocery List with the dictionary class
Dictionary<int, string> groceryList = new Dictionary<int, string>();

//Here we add the base items to the grocery list
groceryList.Add(1,"Milk");
groceryList.Add(2,"Honey");

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
            continue;
        case "3":
            //Add a new key and item to the list
            Console.WriteLine("Please enter the key of the item that you would like to add:\nIf you would like to abort enter \"x\"");
            string? addItemKey = Console.ReadLine();     
            Console.WriteLine("Please enter the name of the item that you would like to add:\nIf you would like to abort enter \"x\"");
            string? addItemName = Console.ReadLine();      
            try
            {
                groceryList.Add(Convert.ToInt32(addItemKey),addItemName);
            } 
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} is an invalid input, please try again");
                Console.WriteLine();
                continue;
            }
            continue;
        case "4": 
            //Edit the list based on a key
            Console.WriteLine("Please enter the key of the item that you would like to edit:\nIf you would like to abort enter \"x\"");
            string? editItemKey = Console.ReadLine();
            Console.WriteLine("Please enter the name of the item that you would like to edit:\nIf you would like to abort enter \"x\"");
            string? editItemname = Console.ReadLine();

            try
            {
                if (!groceryList.ContainsKey(Convert.ToInt32(editItemKey)))
                {
                    Console.WriteLine($"There is not an item with a key of {editItemKey}. Please review the list before trying to edit again.");
                    Console.WriteLine();
                    continue;
                }
                groceryList[Convert.ToInt32(editItemKey)] = editItemname;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} caused an unknown error...");

            }
            continue;
        case "5":
            //Sort the list numerically
            continue;
        case "6": 
            endLoop = true;
            Console.WriteLine("Thank you for using this program.");
            break;
        default:
            //Should be ran when the user has an invalid choice (i.e. entering -1)
            Console.WriteLine("You selected the option \"{0}\", this is not a valid option. Please re-read instructions.\n", userChoice);       
            continue;
        

    }
    break;
}
