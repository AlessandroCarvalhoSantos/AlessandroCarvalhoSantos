namespace String;

class Program
{
    static void Main(string[] args)
    {
        var guid = Guid.NewGuid();
        var id = guid.ToString();
        Console.WriteLine(id);

        //Convertendo hash em guid

        var guid2 = new Guid("124c434c-72e9-4e1d-92c1-e1f4f9e40f8b");
        Console.WriteLine(guid2);

        var id2 = "124c434c-72e9-4e1d-92c1-e1f4f9e40f8b";
        var guid4 = Guid.Parse(id2);

        //Pegar uma quantidade de string por meio da manipulação de string

        var guid3 = new Guid("124c434c-72e9-4e1d-92c1-e1f4f9e40f8b");
        Console.WriteLine(guid3.ToString().Substring(0,8));

        //Comparando GUIDs
        if(new Guid() == new Guid())
            Console.WriteLine("Guid iguais");

        //Guids zerado
        Console.WriteLine(new Guid());

        // Guid vazios
        Console.WriteLine(Guid.Empty);

        //Convertendo para array bytes
        Guid guid5 = Guid.NewGuid();
        byte[] guidBytes = guid.ToByteArray();

        //Convertendo de/para formato de string sem hífen:

        Guid guid6 = Guid.NewGuid();
        string guidSemHifen = guid6.ToString("N"); // Formato sem hífen
        Guid guidConvertido = Guid.ParseExact(guidSemHifen, "N");

        Console.WriteLine(guidConvertido);

    }
}
