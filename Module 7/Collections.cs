//This instantiates the Grocery List with the dictionary class
Dictionary<int, string> groceryList = new Dictionary<int, string>();

//Here we add the base items to the grocery list
groceryList.Add(1,"Milk");
groceryList.Add(2,"Honey");

//This outputs the grocery list to the user when the program first begins because it assumes the user has not used the program before
Console.WriteLine("This is what we currently have on the grocery list: ");
foreach (KeyValuePair<int, string> List in groceryList){
    Console.WriteLine("Key: {0}, Value: {1}", List.Key, List.Value);
}

Console.WriteLine();
Console.WriteLine("Hello this is a program that will allow you to interact with the grocery list above you: \n");

while (true){
    Console.WriteLine("This program will allow you to do different things based on your needs:");
    Console.WriteLine("Enter 1 to display the List\nEnter 2 to remove an item from the list\nEnter 3 to add a new item to the list\n" +
    "Enter 4 to edit one of the exisitng things on the list\nEnter 5 to sort the list numerically\nEnter 6 to exit the program\nEnter your choice: ");

    //Prompting the user for what they want to do
    string userChoice = Console.ReadLine();

    switch(userChoice){
        case "1":
            //Display the list
            continue;
        case "2":
            //Remove an item from the list based on a key
            continue;
        case "3":
            //Add a new key and item to the list
            continue;
        case "4": 
            //Edit the list based on a key
            continue;
        case "5":
            //Sort the list numerically
            continue;
        case "6": 
            break;
        default:
            //Should be ran when the user has an invalid choice (i.e. entering -1)
            Console.WriteLine("You selected the option \"{0}\", this is not a valid option. Please re-read instructions.\n", userChoice);       
            continue;
        

    }
}
