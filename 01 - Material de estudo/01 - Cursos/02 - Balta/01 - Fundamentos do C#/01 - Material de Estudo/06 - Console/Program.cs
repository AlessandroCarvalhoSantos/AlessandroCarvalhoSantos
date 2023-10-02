namespace ConsoleComandos;

class Program
{
    static void Main(string[] args)
    {
        //Caractere  de escape
        Console.WriteLine("Primeira linha\nSegunda linha");
        Console.WriteLine("Olá\rMundo");
        Console.WriteLine("Texto\tcom\ttabulação");
        Console.WriteLine("Retro\bcesso");
        Console.WriteLine("abc\0def");
        Console.WriteLine("Texto\vcom\vtabulação");
        Console.WriteLine("Texto\fcom\ffeed");
        Console.WriteLine("\u03A9"); //Unicode
        Console.WriteLine("\x3A9"); //Hexadecimal
        Console.WriteLine("\\");
        Console.WriteLine("\'");
        Console.WriteLine("\"");

        //ConsoleKeyInfo
        ConsoleKeyInfo tecla = Console.ReadKey();

        Console.WriteLine("\nVocê pressionou a tecla: " + tecla.Key);
        Console.WriteLine("Caractere: " + tecla.KeyChar);
        Console.WriteLine("Shift: " + ((tecla.Modifiers & ConsoleModifiers.Shift) != 0));
        Console.WriteLine("Ctrl: " + ((tecla.Modifiers & ConsoleModifiers.Control) != 0));
        Console.WriteLine("Alt: " + ((tecla.Modifiers & ConsoleModifiers.Alt) != 0));


        if ((tecla.Modifiers & ConsoleModifiers.Alt) != 0)
        {
            Console.WriteLine("Tecla Alt foi pressionada.");
        }

        if ((tecla.Modifiers & ConsoleModifiers.Shift) != 0)
        {
            Console.WriteLine("Tecla Shift foi pressionada.");
        }

        if ((tecla.Modifiers & ConsoleModifiers.Control) != 0)
        {
            Console.WriteLine("Tecla Control (Ctrl) foi pressionada.");
        }


        if (tecla.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Tecla Enter foi pressionada.");
        }
        else if (tecla.Key == ConsoleKey.Tab)
        {
            Console.WriteLine("Tecla Tab foi pressionada.");
        }
    
        //New Line

        string mensagem = "Primeira linha" + Environment.NewLine + "Segunda linha";
        Console.WriteLine(mensagem);




    }
}