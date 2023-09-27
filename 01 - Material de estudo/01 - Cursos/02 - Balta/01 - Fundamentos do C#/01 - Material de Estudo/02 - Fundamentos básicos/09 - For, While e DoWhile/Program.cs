namespace ForWhileAndDoWhile;

class Program
{
    static void Main()
    {
        //Laço de repetição for

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteração {i}");
        }

        //for com multiplas expressoes
        for (int i = 1, j=0; i <= 5; i++, j+=2)
        {
            Console.WriteLine($"Iteração {i}");
            Console.WriteLine($"Iteração {j}");
        }

        //usando while
        int contador = 1;

        while (contador <= 5)
        {
            Console.WriteLine($"Iteração {contador}");
            contador++;
        }

        //Usando do while
        do
        {
            Console.WriteLine($"Iteração {contador}");
            contador++;
        }
        while (contador <= 5);
    }
}
