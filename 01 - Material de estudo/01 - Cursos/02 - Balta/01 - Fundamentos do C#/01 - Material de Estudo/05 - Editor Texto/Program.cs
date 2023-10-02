namespace EditorTexto;


class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer? ");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine());

        switch(option)
        {
            case 0:
                Environment.Exit(0);
            break;
            case 1:
                Abrir();
            break;

            case 2:
                Editar();
            break;
            default:
                Menu();
            break;
        }

    }

    static void Abrir()
    {

    }

    static void Editar()
    {
        
    }
}