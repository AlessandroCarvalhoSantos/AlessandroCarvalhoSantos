namespace String;

class Program
{
    static void Main(string[] args)
    {
        //GUID
        //--------------------------------------------------
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
    
        //-------------------------------------------------------------

        // .Format()
        //-------------------------------------------------------------

        //Concatenando com o +
        Console.WriteLine("Teste " + "Teste 2");

        var price = 10.2;
        var texto = "O preço do produto é " + price + " apenas na promoção.";

        Console.WriteLine(texto);

        //Usando o método format de string

        Console.WriteLine(string.Format("O preço do produto é {0} apenas na promoção {1}",price, "."));


        //Interporlação de string
        //-------------------------------------------------------------


        var texto2 = $"O preço do produto é {price}";
        var texto3 = $"O preço do produto é {price + 1}";

        var textolongo = @"Preço  Preço Preço
        Preço Preço Preço";

        var textoLongoInterpolado = $@" preço:{price} preço:{price} preço:{price} 
        preço:{price} 
        preço:{price} ";

        var texto4= "Texto" +
        "Texto";

        var texto5 = @" Texto \n \n texto";
        Console.WriteLine(texto5);

        //CompareTo
        //-------------------------------------------------------------

        var texto6 = "Testando";
        Console.WriteLine(texto6.CompareTo("Testando")); 



        //Contains
        //-------------------------------------------------------------

        var texto7 = "Esse texto é um teste";
        Console.WriteLine(texto7.Contains("teste"));

        var texto8 = "Esse texto é um teste";
        Console.WriteLine(texto8.Contains("teste", StringComparison.OrdinalIgnoreCase));
    }
}
