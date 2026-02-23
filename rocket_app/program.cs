string[] rocket = { "   /\\   ", "  /  \\  ", " /____\\ ", " |    | ", " |    | ", " |____| ", "  /||\\  ", "   ||   ", "   ||   ", "  /  \\  ", " /____\\ " };
Console.WriteLine("[CONTROL TOWER] Rocket detected entering atmosphere...");
for (int altidute = 5000; altidute >= 0; altidute -= 1000)
{
    if (altidute == 0)
    {
        Console.WriteLine("altidute 0m");
        Console.WriteLine("Deploying Landing Gear\nTouchdown Confirmed!");
        Console.WriteLine("WELCOME HOME");
        return;
    }
    else
    {
        //Printing the Full Rocket First
        foreach (string line in rocket)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("\n");
        //Wait about 1 minute
        Thread.Sleep(2000);
        //This is Counter
        Console.WriteLine($"Altidute: {altidute}m");
    }
}
