static void main()
{
    List<int> xs = new List<int>();
    List<double> fxs = new List<double>();
    int n = 12;
    Console.WriteLine("введите х: ");
    for (int i = 0; i < n; i++)
    {
        xs[i] = int.Parse(Console.ReadLine());
        Console.WriteLine(xs[i] + " ");
    }

    for (int i = 0; i < n; i++)
    {
        fxs[i] = f(xs[i]);
        Console.WriteLine(fxs[i] + " ");
    }
}


static double f(int x)
{
    if (x < Math.PI / 2)
    {
        return 2 / 7;
    }

    else if (Math.PI <= x && x < 4)
    {
        return (Math.Pow((x + 1), 2) / (2 + x)) * ((x + (1 / (Math.Pow(x, 2) - 1)))) / Math.Pow(x, 3) + 3;
    }

    else
    {
        return Math.Pow(x - 2, 2) * Math.Sin(Math.Pow(x, 2) + 1);
    }
}

static void koord(int x, double y)
{
    int count = 0;
    if (x < 6 && x > -6 && y < 6)
    {
        //проблемы с алгеброй
    }
}