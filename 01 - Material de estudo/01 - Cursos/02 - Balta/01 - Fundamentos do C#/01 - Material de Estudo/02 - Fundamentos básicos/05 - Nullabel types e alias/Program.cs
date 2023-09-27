namespace NullabelTypesAliasAndValoresPadroes;

class NullabelTypesAliasAndValoresPadroes{
    static void Main(string[] args){

        // Nullabel types

        int? idade;
        int? idadeMaxima = null;

        object? teste = null;


        //Alias
        int idade01 = 25;  //Alias
        Int32 idade02 = 25; //Tipo
        UInt128 idade03 = 25; // Tipo com alias ulong 
        String nome = "sadsd"; //Tipo com alias string

        //Valores padrões

        int teste01 = 0;
        float teste02 = 0;
        decimal teste03 = 0;
        bool teste04 = false;
        char teste05 = '\0';
        string teste06 = "";

        int teste07 = default;
    }   
}
