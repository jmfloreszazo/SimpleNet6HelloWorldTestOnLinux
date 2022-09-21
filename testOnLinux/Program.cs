int x = 12345;
int y = DoSomeWork();
Console.WriteLine($"X Value is {x}");
Console.WriteLine($"Y Value is {y}");

static int DoSomeWork()
{
    int y = 98765;
    Console.WriteLine("Please enter key to show variables values allocated in memory...");
    Console.ReadKey();
    return y;
}
