namespace desafio;

//Escreva uma função que retorne a soma de dois números.

class Add{
    public int Solution(int param1, int param2) {
        return param1+param2;
    }

    public void TesteSolution(){
        Teste(1,2,3);
        Teste(10,22,32);
        Teste(0,0,0);
        Teste(-2,2,0);
    }

    private void Teste(int valor1, int valor2, int resultadoEsperado){
        var passou = Solution(valor1,valor2) == resultadoEsperado;
        PrintTestes(passou, valor1, valor2, Solution(valor1,valor2), resultadoEsperado);
    }

    private void PrintTestes(bool teste, int valor1, int valor2, int resultado, int resultadoEsperado){
        string passou = teste ? "Passou": "Não passou";
        Console.WriteLine($"Teste: {valor1} + {valor2} = {resultado} -> Esperado: {resultadoEsperado} ({passou})");
    }
}

