namespace IfAndSwitch;

class Program
{
    static void Main(string[] args)
    {
        //Condicionais IF

        int nota = 75;

        if (nota >= 90)
        {
            Console.WriteLine("A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("F");
        }


        //condicionais Switch

        //Switch como multiplos valores semelhantes e conversão explicita

        double par = 2;

        switch(par)
        {
            case 0.0:
            case 2:
            case 4:
            case 6:
            case 8:
                Console.WriteLine("Par");
            break;
            default:
                Console.WriteLine("Impar");
            break;
        }

        //Switch normal

    }
}
