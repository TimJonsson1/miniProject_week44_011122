
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

            funk.SearchProduct(products);
            
            break;
        case "Q":

            isRunning = false;

            Console.WriteLine("the sum of all products are: " + funk.SumOfPice(products));

            break;

            default:
                Console.WriteLine("Something went wrong check your input");
            break;
    }
    //this comment is from test1 branch
    //this comment is from test2 branch
    Console.ReadLine();
}