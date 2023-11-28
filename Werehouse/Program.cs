using Werehouse;

string input1 = "";
string input2;
string input3;
string input4;
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
/*while(input1 != "exit")
{*/
    input1 = "";
    input2 = "";
    input3 = "";
    input4 = "";
    Console.WriteLine("Type number to chose option: ");
    Console.WriteLine("[1] Show products in werehouse.");
    Console.WriteLine("[2] ");
    input1 = Console.ReadLine();

    switch(input1)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Which werehouse you want to look into? ");
            foreach (var m in magazyny)
            {
                Console.WriteLine("["+ tmpNr++ + "] " + m.Name);
            }
            input2 = Console.ReadLine();
        
            foreach (Product product in magazyny[int.Parse(input2) - 1].Products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine("Do you want to edit content of werehouse? ");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            input3 = Console.ReadLine();
            switch(input3)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("[1] Add product to werehouse");
                    Console.WriteLine("[2] Delete product from werehouse");
                    input4 = Console.ReadLine();
                    break;
                case "2":

                    break;
            }
            break;
    }

/*}*/

/*foreach(Product product in werehouse1.Products)
{
    Console.WriteLine(product.ToString());
}*/