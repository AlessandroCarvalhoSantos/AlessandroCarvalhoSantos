using System.Text;

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


        //StartsWith
        //-------------------------------------------------------------

        var texto9 = "Esse texto é um teste";
        Console.WriteLine(texto9.StartsWith("teste"));

        Console.WriteLine(texto9.StartsWith("teste", StringComparison.OrdinalIgnoreCase));

        //EndsWith
        //-------------------------------------------------------------

        var texto10 = "Esse texto é um teste";
        Console.WriteLine(texto10.EndsWith("teste"));

        Console.WriteLine(texto10.EndsWith("teste", StringComparison.OrdinalIgnoreCase));
        
        //Equal
        //-------------------------------------------------------------

        var texto11 = "Esse texto é um teste";
        Console.WriteLine(texto11.Equals("teste"));
        Console.WriteLine(texto11.Equals("teste", StringComparison.OrdinalIgnoreCase));

                
        //Índices
        //-------------------------------------------------------------
        var texto12 = "Esse texto é um teste";
        Console.WriteLine(texto12.IndexOf("a")); // Retorna -1
        Console.WriteLine(texto12.LastIndexOf("e")); //Retorna 21

        //Métodos adicionais
        //-------------------------------------------------------------

        //ToUpper e ToLower

        var texto13 = "Esse texto é um teste";
        Console.WriteLine(texto13.ToLower()); // esse texto é um teste
        Console.WriteLine(texto13.ToUpper()); // ESSE TEXTO É UM TESTE

        //Insert
        var texto14 = "Esse texto é um teste";
        Console.WriteLine(texto14.Insert(0,"a"));

        var texto15 = "Esse texto é um teste";
        Console.WriteLine(texto15.Remove(0,1));

        // Length
        var texto16 = "texto";
        Console.WriteLine(texto16.Length); // 5 caracteres

        //Manipulando strings
        //-------------------------------------------------------------

        //replace
        var texto17 = "Esse texto é um teste";
        Console.WriteLine(texto17.Replace("teste", "teste2")); 

        //Split
        var texto18 = "Esse texto é um teste";
        Console.WriteLine(texto18.Split("a")[0]); 

        //Substring

        var texto19 = "Esse texto é um teste";
        Console.WriteLine(texto19.Substring(0,4)); 

        //Trim

        var texto20 = "  Esse texto é um teste  ";
        Console.WriteLine(texto20.Trim()); 
        Console.WriteLine(texto20.TrimEnd()); 
        Console.WriteLine(texto20.TrimStart()); 

        
        //String builder
        //-------------------------------------------------------------

        var texto21 = new StringBuilder();
        texto21.Append("Teste");
        texto21.Append(" de texto");

        Console.WriteLine(texto21.ToString());

    }
}
