namespace Calculadora;


class Program
{
    static void Main(string[] args)
    {
   
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Selecione uma opção: ");
        short resultado = short.Parse(Console.ReadLine());
    }

    static void Soma(){
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        

        Console.WriteLine("");

        float resultado = v1+v2;
        // Console.WriteLine("O resultado da soma é " + resultado);
        Console.WriteLine("O resultado da soma é " + (v1 + v2));
        // Console.WriteLine($"O resultado da soma é {resultado}");
        // Console.WriteLine($"O resultado da soma é {v1+v2}");

        Console.WriteLine(Console.ReadKey());
    }

    static void Subtracao()
    {
        Console.Clear();
        
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1-v2;
        Console.WriteLine($"O resultado da subtração é {resultado}");

        Console.WriteLine(Console.ReadKey());
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("");

        float resultado = v1/v2;
        Console.WriteLine($"O resultado da divisão é {resultado}");
        Console.ReadKey();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro número:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo número:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação é {resultado}");

        Console.ReadKey();
    }

}