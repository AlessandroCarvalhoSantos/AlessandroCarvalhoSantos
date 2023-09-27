namespace Variaveis_Constantes;

class Variaveis_Constantes{
    static void Main(string[] args){
        int idade01; 
        int idade02 = 25;
        var idade03 = 25;
        //var idade04;  Formato inválido, pois tem que inicializar a variável. 

        //Console.WriteLine(idade01);
        Console.WriteLine(idade03);
        Console.WriteLine(idade02);
        //Console.WriteLine(idade04);

        const int IDADE = 25;
        const int IDADE_MINIMA = 20;
        Console.WriteLine(IDADE);
        Console.WriteLine(IDADE_MINIMA);
    }
}