using StrategyPattern;

Console.WriteLine("***Strategy Pattern Demo***\n");
IChoice ic = null;
Context cxt = new Context();
//For simplicity, we are considering 2 user inputs only.
for (int i = 1; i <= 2; i++)
{
    Console.WriteLine("\nEnter ur choice(1 or 2 or France)");
    string c = Console.ReadLine();
    if (c == "France")
    {
        ic = new FranceChoice();
    }
    else if (c.Equals("1"))
    {
        ic = new FirstChoice();
    }
    else
    {
        ic = new SecondChoice();
    }
    cxt.SetChoice(ic);
    cxt.ShowChoice();
}
Console.ReadKey();