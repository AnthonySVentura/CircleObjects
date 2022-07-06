using CircleObjects;

Console.WriteLine("Welcome to the Circle Tester");

double radius = 0;
Console.WriteLine("Enter a radius");

while (true)
{
    Console.WriteLine("Enter a radius");

    while (double.TryParse(Console.ReadLine(), out radius))
    {
        if (radius < 0)
        {
            break;
        }
        else
        {
            Console.WriteLine(CalculateCurcumference(radius));
        }
    }

}
