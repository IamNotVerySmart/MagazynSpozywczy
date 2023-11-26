using Werehouse;

string input1;
string input2;
int tmpNr = 1;

Console.WriteLine("werehouse");

Product product1 = new("Heinz", "Keczup", "SAUCE", 14, 5.79, "good food sauce");
Product product2 = new("nie heinz", "pomidory", "FOOD", 15, 2.79, "food");
Adress adress1 = new("t1", 155413, "Warsaw", 13, 2);
List<Product> productsList1 = new();
productsList1.Add(product1);
productsList1.Add(product2);

Magazyn werehouse1 = new(productsList1, adress1);
Magazyn wereh2 = new(productsList1, adress1);

List<Magazyn> magazyny = new List<Magazyn>();
magazyny.Add(werehouse1);
magazyny.Add(wereh2);

Console.WriteLine("Type number to chose option: ");
Console.WriteLine("[1] Show products in werehouse.");
Console.WriteLine("[2] Show products in werehouse.");
input1 = Console.ReadLine();

switch(input1)
{
    case "1":
        Console.WriteLine("Which werehouse you want to look into? ");
        foreach (var m in magazyny)
        {
            Console.WriteLine("["+ tmpNr++ + "] " + m);
        }
        input2 = Console.ReadLine();
        
        foreach (Product product in magazyny[int.Parse(input2) - 1].Products)
        {
            Console.WriteLine(product.ToString());
        }

        break;
}

/*foreach(Product product in werehouse1.Products)
{
    Console.WriteLine(product.ToString());
}*/