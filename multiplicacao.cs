int multi(int num, int vezes)
{
    int r;
    if (vezes == 0)
     r = 0;

    else
    r = num + (multi(num, vezes - 1));
    return r;
}


Console.WriteLine("Digite o numero: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o expoente: ");
int vezes = int.Parse(Console.ReadLine()!);

int result = multi(num, vezes);
Console.WriteLine(result);

