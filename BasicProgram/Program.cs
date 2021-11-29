using BasicProgram;

Console.WriteLine("\tEnter any key to run and n to End the program");
char choice = Convert.ToChar(Console.ReadLine());
while (choice != 'n')
{
    Console.WriteLine("\t(((((Choose any one!)))))");
    Console.WriteLine("\t(((((1.Flip Coin )))))))))");
    Console.WriteLine("\t(((((2.Leap Year)))))");
    Console.WriteLine("\t(((((3.Prime Factors)))))");
    int n = Convert.ToInt32(Console.ReadLine());
    switch (n)
    {
        case 1:
            FlipCoin fc = new FlipCoin();
            fc.Flip_coin();
            break;
        case 2:
            LeapYear leapYear = new LeapYear();
            leapYear.Year();
            break;
        case 3:
            PrimeFactor obj = new PrimeFactor();
            obj.Prime();
            break;
    }
}