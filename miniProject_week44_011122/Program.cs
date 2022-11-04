
using miniProject_week44_011122;


//initilize list and variables here
List<ProductClass> products = new List<ProductClass>();

FunctionsClass funk = new FunctionsClass();

bool isRunning = true;


//loop until we quit
while (isRunning)
{

    //menu code
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("To enter new product - enter 'P' | To search for a product - enter 'S' | To quit - enter 'Q'");
    Console.ResetColor();
    //code here
    string choice = Console.ReadLine().ToUpper().Trim();

    switch (choice)
    {
        case "P":
            //add code to create new product here

            products.Add(funk.NewProduct());

            foreach (ProductClass product in products)
            {
                if (product == null)
                {
                    products.Remove(product);
                    break;
                }
            }
           

            break;
        case "S":
            //add code to search product here
            funk.SearchProduct(products);
            
            break;
        case "Q":
            //add code to quit the program and list all the items added and give a total sum of all the prices
            isRunning = false;

            Console.WriteLine("the sum of all products are: " + funk.SumOfPice(products));

            break;

            default:
                Console.WriteLine("Something went wrong check your input");
            break;
    }
    
    Console.ReadLine();
}