Console.Clear();

double a, b, c, delta, x1, x2;

Console.Write("Digite o valor de [a]: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de [b]: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de [c]: ");
c = Convert.ToDouble(Console.ReadLine());

if(a==0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("valor nulo, não pode");
}

else
{
    delta = Math.Pow(b, 2) - 4 *a *c;
    
    if(delta < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("não tem raizes reais, não pode");
    }

    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 *a);
        x2 = (-b - Math.Sqrt(delta)) / (2 *a);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@$"As raizes da equação são: X' = {x1:n1} e X"" = {x2:n1}.");
    }
}
Console.ResetColor();