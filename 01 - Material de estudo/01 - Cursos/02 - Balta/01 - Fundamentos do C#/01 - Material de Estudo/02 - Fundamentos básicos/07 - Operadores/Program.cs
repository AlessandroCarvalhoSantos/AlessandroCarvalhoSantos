namespace Operadores;

class Program
{

    static void Main(string[] args)
    {
        //Operadores aritméticos
        int a = 5;
        int b = 3;

        int soma = a + b; // 8 Adição
        int subtracao = a - b; // 2 Subtração
        int multiplicacao = a * b; // 15 Multiplicação
        int divisao = a / b; //1 Divisão (resultado será 1, pois ambos são inteiros)
        int modulo = a % b; // 2 Módulo (resto da divisão)

        int x = 2 + 2 * 2;  // 6
        int y = 2 + (2 * 2);  // 6
        int z = (2 + 2) * 2;  // 8

        //Operadores de atribuição

        a += b; // Equivalente a a = a + b; ('a' agora é 8)
        Console.WriteLine($"a += b: {a}");

        int c = 7;
        c -= 4; // Equivalente a c = c - 4; ('c' agora é 3)
        Console.WriteLine($"c -= 4: {c}");

        int d = 2;
        d *= 3; // Equivalente a d = d * 3; ('d' agora é 6)
        Console.WriteLine($"d *= 3: {d}");

        int e = 10;
        e /= 2; // Equivalente a e = e / 2; ('e' agora é 5)
        Console.WriteLine($"e /= 2: {e}");

        int f = 11;
        f %= 3; // Equivalente a f = f % 3; ('f' agora é 2)
        Console.WriteLine($"f %= 3: {f}");

        //Operadores de incremento e decremento

        // Incremento
        a++; // Agora 'a' é igual a 6
        Console.WriteLine($"a depois do incremento: {a}");

        // Decremento
        b--; // Agora 'b' é igual a 2
        Console.WriteLine($"b depois do decremento: {b}");

        
        // Incremento antes 
        ++a; // Agora 'a' é igual a 6
        Console.WriteLine($"a depois do incremento: {a}");

        // Decremento antes
        --b; // Agora 'b' é igual a 2
        Console.WriteLine($"b depois do decremento: {b}");

        //Operadores de comparação

        
        bool igual = (a == b);
        bool diferente = (a != b);
        bool maiorQue = (a > b);
        bool maiorOuIgualQue = (a >= b);
        bool menorQue = (a < b);
        bool menorOuIgualQue = (a <= b);

        Console.WriteLine($"a == b: {igual}");
        Console.WriteLine($"a != b: {diferente}");
        Console.WriteLine($"a > b: {maiorQue}");
        Console.WriteLine($"a >= b: {maiorOuIgualQue}");
        Console.WriteLine($"a < b: {menorQue}");
        Console.WriteLine($"a <= b: {menorOuIgualQue}");


        //Operadores lógicos
        
        bool a1 = true;
        bool b1 = false;

        bool resultadoE = (a1 && b1);
        bool resultadoOu = (a1 || b1);
        bool resultadoNegacaoA = !a1;
        bool resultadoNegacaoB = !b1;

        Console.WriteLine($"a && b: {resultadoE}");
        Console.WriteLine($"a || b: {resultadoOu}");
        Console.WriteLine($"!a: {resultadoNegacaoA}");
        Console.WriteLine($"!b: {resultadoNegacaoB}");

    }
}
