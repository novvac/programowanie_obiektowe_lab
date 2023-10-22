// main
exercise1();

// exercise 1
static void exercise1()
{
    Console.Write("Enter a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    calculateZeros(a, b, c);
}

/// <summary>
/// This function calculates the delta of a given square function
/// </summary>
/// <param name="a">Coefficient a</param>
/// <param name="b">Coefficient b</param>
/// <param name="c">Coefficient c</param>
static double calculateDelta(double a, double b, double c)
{
    return Math.Pow(b, 2) - 4 * a * c;
}

/// <summary>
/// The function calculates the zeros of a given square function
/// </summary>
/// <param name="a">Coefficient a</param>
/// <param name="b">Coefficient b</param>
/// <param name="c">Coefficient c</param>
static void calculateZeros(double a, double b, double c)
{
    double delta = calculateDelta(a, b, c);
    double sqrtDelta = Math.Sqrt(delta);

    Console.WriteLine("Delta: " + delta);

    if (delta > 0)
    {
        double p1 = (-b - sqrtDelta) / (2 * a);
        double p2 = (-b + sqrtDelta) / (2 * a);

        Console.WriteLine("First zero of function: " + p1);
        Console.WriteLine("Second zero of function: " + p2);
    }
    else if (delta == 0)
    {
        double p0 = -b / 2 * a;

        Console.WriteLine("Zero of function: " + p0);
    }
    else
    {
        Console.WriteLine("There is no zeros of function");
    }
}