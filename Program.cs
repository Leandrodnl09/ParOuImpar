// Exercício do site URI "Par ou Impar"
// Nesse programa iremos usar um "for" para saber a quantidade de numeros a ser digitado. Depois o usuário irá digitar essa
// quantidade e o programa mostrará se esse numero e par ou impa, negativo ou positivo.


int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int X = int.Parse(Console.ReadLine());

    if (X < 0 && X % 2 == 0)
    {
        Console.WriteLine("EVEN NEGATIVE");
    }
    if (X < 0 && X % 2 != 0)
    {
        Console.WriteLine("ODD NEGATIVE");
    }
    if (X > 0 && X % 2 == 0)
    {
        Console.WriteLine("EVEN POSITIVE");
    }
    if (X > 0 && X % 2 != 0)
    {
        Console.WriteLine("ODD POSITIVE");
    }
    if (X == 0)
    {
        Console.WriteLine("NULL");
    }
}
