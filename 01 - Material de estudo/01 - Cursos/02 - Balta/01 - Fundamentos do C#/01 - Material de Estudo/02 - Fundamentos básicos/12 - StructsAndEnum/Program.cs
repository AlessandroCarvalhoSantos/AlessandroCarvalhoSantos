namespace StructsAndEnum;

enum EEstadoCivil
{
	//Enumeradores
	Solteiro = 1,
	Casado = 2,
	Divorciado = 3
}

struct Produto
{
	//Propriedades
	public int Id;
	public string Nome;
	public float Preco;

	//Métodos
	public Produto(int id, string nome, float preco)
	{
		Id = id;
		Nome = nome;
		Preco = preco;
	}


	public float PrecoEmDolar(float dolar)
	{
		return Preco * dolar;
	}
}

struct Cliente
{
	public string Nome;
	public EEstadoCivil EstadoCivil;

	public Cliente(string nome, EEstadoCivil estadoCivil)
	{
		Nome = nome;
		EstadoCivil = estadoCivil;
	}
}


class Program
{
    static void Main(string[] args)
    {
        //structs
        var produto = new Produto();

        produto.Id = 155163;
        produto.Nome = "NomeProduto";
        produto.Preco = 26.5f;

        Console.WriteLine(produto.Id);
        Console.WriteLine(produto.Nome);
        Console.WriteLine(produto.Preco);

        //Enums
        
        var cliente = new Cliente("Ale", EEstadoCivil.Solteiro);

        Console.WriteLine((int)EEstadoCivil.Solteiro);
        Console.WriteLine(EEstadoCivil.Solteiro);
    }
}
