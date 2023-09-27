namespace Conversoes;

class Program
{

    static void Main(string[] args)
    {
        //Conversão implicita

        float valor = 25.8F;
        int outro = 25;

        valor = outro; //Conversão implicita

        //Conversão explicita
        int inteiro = 100;
        uint inteiroSemSinal = (uint)inteiro; //Conversão explicita 

        //Usando Parse
        int dado01 = int.Parse("100");
        int dado02 = char.Parse("1");
        Console.WriteLine(dado02);

        //Usando Convert

        int dado03 = Convert.ToInt32("100");
        string dados04 = Convert.ToString(100);
        
        //Convertendo tipos
        int inteiro01 = 100;
        float real01 = 25.6F;
        real01 = inteiro01; //Conversão implicita acontecendo aqui -> 100.0F


        inteiro = (int)real01; //Conversão explicita acontecendo aqui -> 25
       
        string valorReal = real01.ToString();
        inteiro = int.Parse(valorReal); // Isso dará um erro por que string vai vim com um ponto


        inteiro = Convert.ToInt32(real01);

        Console.WriteLine(Convert.ToBoolean(0)); //False
        Console.WriteLine(Convert.ToBoolean(1)); //True
        Console.WriteLine(Convert.ToBoolean(2)); //True

    }
}
