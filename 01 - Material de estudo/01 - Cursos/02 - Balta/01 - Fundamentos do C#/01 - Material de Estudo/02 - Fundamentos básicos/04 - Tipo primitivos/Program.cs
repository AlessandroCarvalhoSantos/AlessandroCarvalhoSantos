namespace Comentarios;

class Comentarios{
    static void Main(string[] args){

        // byte
        byte meuByte = 127;
        sbyte meuByteNegativo = -10;
        byte[] meuByteArray = new byte[] { 1, 2, 3, 4, 5};
        sbyte[] meuByteNegativoArry = new sbyte[] { -1, -2, 3, 4, 5};

        // Inteiros
            //16bit
            short inteiroPequeno = 0;
            ushort inteiroPequenoPositivo = 0;
            //32bit
            int inteiroMedio = 0;
            uint inteiroMedioPositivo = 0;
            //64bit
            long inteiroLongo =0;
            ulong inteiroLongoPositivo = 0;
        
        // Número flutantes

        float numeroFlutuantePequenoF = 2.5F; 
        float numeroFlutuantePequenof = 2.5f; 

        double numeroFlutuanteMedio= 2.5; 
        double numeroFlutuanteMedioD= 2.5D; 
        double numeroFlutuanteMediod= 2.5d; 

        decimal numeroFlutuanteLongoM = 2.5M; 
        decimal numeroFlutuanteLongom = 2.5m;
        
        //Números booleanos

        bool verdadeiro = true;
        bool falso = false;

        // Caracteres
        char caractere = 'a';

        //string

        string unicaLetra = "a";
        string letras = "alessandro";

        //var
        var idade = 25; // será do tipo int
        var nome = "André"; //Será do tipo string

        //IEnumerable<String> nomeVariavel01 = new IEnumerable<String>(){};
        //var nomeVariavel02 = new IEnumerable<String out i>{};


        // Tipo object

        object objeto01 = 10;
        object objeto02 = "Teste";
        object objeto03 = 10.5;
        object objeto04 = new List<string>();
        objeto04 = new List<int>();
    }
}