namespace FuncoesAndMetodos;


class MinhaClasse
{
    public void MeuMetodo() // Definição de um método chamado "MeuMetodo"
    {
        Console.WriteLine("Este é o meu método.");
    }
}

class Program
{
    static void MinhaFuncao(string nome, string sobrenome, bool possuiDocumento = false) // Definição de uma função chamada "MinhaFuncao"
    {
        Console.WriteLine(nome + " " + sobrenome);

        if(possuiDocumento)
            Console.WriteLine("Possui documentos!");
    }

    static void Main()
    {
        //Funções
        MinhaFuncao("Alessandro", "Carvalho Santos"); // Chamando a função

        //Métodos
        MinhaClasse objeto = new MinhaClasse(); // Criando uma instância da classe
        objeto.MeuMetodo(); // Chamando o método
    }
}