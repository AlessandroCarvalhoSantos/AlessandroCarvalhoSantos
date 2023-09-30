namespace desafio;

/*
Dado um ano, retorne o século em que ele se encontra. 
O primeiro século abrange do ano 1 até o ano 100 inclusive, o segundo - do ano 101 até o ano 200 e assim por diante.
*/

class CenturyFromYear{
    int Solution(int year) {
        return (year - 1) / 100 + 1;
    }


    public void TesteSolution(){
        Teste(1905, 20);
        Teste(1700, 17);
        Teste(1988, 20);
        Teste(2001,21);
    }

    private void Teste(int ano, int resultadoEsperado){
        var passou = Solution(ano) == resultadoEsperado;
        PrintTestes(passou, ano, Solution(ano), resultadoEsperado);
    }

    private void PrintTestes(bool teste, int ano, int seculo, int resultadoEsperado){
        string passou = teste ? "Passou": "Não passou";
        Console.WriteLine($"Teste: Ano: {ano}, Século: {seculo} -> Esperado: {resultadoEsperado} ({passou})");
    }
}

