﻿using Werehouse;

string input1 = "";
string prName;
string prdName;
string prdType;
string prdValue;
string prdCode;
string prdDescription;
int tmpNr = 1;

Console.WriteLine("werehouse");

Product product1 = new("Heinz", "Keczup", "SAUCE", 14, 5.79, "good food sauce");
Product product2 = new("nie heinz", "pomidory", "FOOD", 15, 2.79, "food");
Adress adress1 = new("t1", 155413, "Warsaw", 13, 2);
List<Product> productsList1 = new();
productsList1.Add(product1);
productsList1.Add(product2);

Magazyn werehouse1 = new(productsList1, adress1, "mag1");
Magazyn wereh2 = new(productsList1, adress1,"magazyne2");

List<Magazyn> magazyny = new List<Magazyn>();
magazyny.Add(werehouse1);
magazyny.Add(wereh2);
while(input1 != "exit")
{
    input1 = "";
    Console.WriteLine("Type number to chose option(anything else will result in going back to this menu): ");
    Console.WriteLine("[1] Show products in werehouse. ");
    Console.WriteLine("[2] Show products. ");
    input1 = Console.ReadLine()!;

    switch(input1)
    {
    case "1":
            input1 = "";
            Console.Clear();
            Console.WriteLine("Which werehouse you want to look into? ");
            foreach (var m in magazyny)
            {
                Console.WriteLine("["+ tmpNr++ + "] " + m.Name);
            }
            input1 = Console.ReadLine()!;
        
            foreach (Product product in magazyny[int.Parse(input1) - 1].Products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine("Do you want to edit content of werehouse? ");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            input1 = Console.ReadLine()!;
            switch(input1)
            {
                case "1":
                    input1 = "";
                    Console.Clear();
                    Console.WriteLine("[1] Add product to werehouse");
                    Console.WriteLine("[2] Delete product from werehouse");
                    input1 = Console.ReadLine()!;
                    switch(input1)
                    {
                        case "1":
                            input1 = "";
                            Console.Clear();
                            Console.WriteLine();
                            
                            break;
                        case "2":
                            input1 = "";
                            Console.Clear();
                            Console.WriteLine();
                            break;
                    }
                    break;
                case "2":
                    input1 = "";

                    break;
            }
            break;
    case "2":
            input1 = "";
            Console.WriteLine("Products: ");
            foreach(var p in productsList1)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\nDo you want to add another product? ");
            Console.WriteLine("[1] YES");
            Console.WriteLine("[2] NO");
            input1 = Console.ReadLine()!;
            switch(input1)
            {
                case "1":
                    input1 = "";
                    Console.Clear();
                    Console.WriteLine("Type producer name: ");
                    prName = Console.ReadLine()!;
                    Console.WriteLine("Type name of product: ");
                    prdName = Console.ReadLine()!;
                    Console.WriteLine("Type product type: ");
                    prdType = Console.ReadLine()!;
                    Console.WriteLine("Type product value: ");
                    prdValue = Console.ReadLine()!;
                    Console.WriteLine("Type product code: ");
                    prdCode = Console.ReadLine()!;
                    Console.WriteLine("Type product description: ");
                    prdDescription = Console.ReadLine()!;
                    productsList1.Add(new(prName, prdName, prdType, int.Parse(prdCode), double.Parse(prdValue), prdDescription));
                    break;
                case "2":
                    input1 = "";
                    //exit
                    break;
            }
        break;
    }

}

/*foreach(Product product in werehouse1.Products)
{
    Console.WriteLine(product.ToString());
}*/