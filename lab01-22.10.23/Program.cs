// main
// exercise1();
exercise2();

// exercise 1
static void exercise1()
{
    Console.WriteLine("Exercise one: calculate zeros of a given squere function.\n");

    Console.Write("Enter a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    calculateZeros(a, b, c);
}

// exercise 2
static void exercise2()
{
    int choice = 0;

    do
    {
        Console.WriteLine("Exercise two: calculator.\n");

        switch(choice)
        {
            case 0:
                printCalculatorMenu();
                break;
            case 1:
                sumValues();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            default:
                Console.WriteLine("[!] Undefined option!\n");
                printCalculatorMenu();
                break;
        }

        Console.Write("> ");
        choice = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
    } while (choice != 8);
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

/// <summary>
/// Function creates calculator numeric menu
/// </summary>
static void printCalculatorMenu()
{
    Console.WriteLine("============================");
    Console.WriteLine("1. Sum");
    Console.WriteLine("2. Difference");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Pow");
    Console.WriteLine("6. Sqrt");
    Console.WriteLine("7. Trigonometric functions");
    Console.WriteLine("\n8. Exit");
    Console.WriteLine("============================");
}

static void sumValues()
{
    Console.Write("Enter a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(a + b);
}