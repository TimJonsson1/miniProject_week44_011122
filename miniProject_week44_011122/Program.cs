﻿
using miniProject_week44_011122;


//initilize list and variables here
List<ProductClass> products = new List<ProductClass>();

FunctionsClass funk = new FunctionsClass();

bool isRunning = true;


//loop until we quit
while (isRunning)
{
    //menu code
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("To enter new product - enter 'P' | To search for a product - enter 'S' | To quit - enter 'Q'");
    Console.ResetColor();
    //code here
    string choice = Console.ReadLine().ToUpper().Trim();

    switch (choice)
    {
        case "P":

           products.Add(funk.NewProduct());

            break;
        case "S":


           
            break;
        case "Q":
            break;
    }
   
    Console.ReadLine();
}