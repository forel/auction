Console.WriteLine("*** Welcome to the auction! ***\n\n" +
    "Rules:\n" +
    "1. Enter initial price\n" +
    "2. Suggest new price greater than previous\n" +
    "3. To exite type 'q'\n\n" +
    "Enjoy!\n");

double initialPrice = 0;

while (initialPrice <= 0)
{
    Console.Write("Enter inital price: ");
    string initialPriceString = Console.ReadLine();

    if (initialPriceString.ToLower() == "q")
    {
        break;
    }

    double.TryParse(initialPriceString, out initialPrice);
}


if (initialPrice > 0)
{
    double lastPrice = initialPrice;

    while (true)
    {
        Console.Write("Enter suggested price: ");
        string suggestedPriceString = Console.ReadLine();

        if (suggestedPriceString.ToLower() == "q")
        {
            Console.WriteLine($"Sold for last price: {lastPrice}");
            break;
        }

        bool isCorrectPrice = double.TryParse(suggestedPriceString, out double suggestedPrice);
        
        if (isCorrectPrice == true && suggestedPrice > lastPrice)
        {
            lastPrice = suggestedPrice;
            Console.WriteLine($"Last price: {lastPrice}");
        }
        else
        {
            Console.WriteLine($"Last price: {lastPrice}");
        }
    }
}


