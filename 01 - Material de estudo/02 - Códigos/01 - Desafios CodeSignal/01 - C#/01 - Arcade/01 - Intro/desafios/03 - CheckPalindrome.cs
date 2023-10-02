namespace desafio;

/*
Dada a string, verifique se é um palíndromo.
Uma string que não muda quando invertida (ela lê a mesma coisa para frente e para trás).

Examples:

"eye" is a palindrome
"noon" is a palindrome
"decaf faced" is a palindrome
"taco cat" is not a palindrome (backwards it spells "tac ocat")
"racecars" is not a palindrome (backwards it spells "sracecar")

*/

class CheckPalindrome{

    public bool Solution(string inputString) {
        for(var i = 0; i < inputString.Length/2; i++)
            if(inputString[i] != inputString[inputString.Length-1-i])
                return false;
        return true;
    }


    public void TesteSolution(){
        Teste("aabaa", true);
        Teste("abac", false);
        Teste("a", true);
        Teste("az",false);
    }

    private void Teste(string palavra, bool resultadoEsperado){
        var passou = Solution(palavra) == resultadoEsperado;
        PrintTestes(passou, palavra, Solution(palavra), resultadoEsperado);
    }

    private void PrintTestes(bool teste, string palavra, bool resposta, bool resultadoEsperado){
        string passou = teste ? "Passou": "Não passou";
        Console.WriteLine($"Teste: Palavra: {palavra}, Resultado: {resposta} -> Esperado: {resultadoEsperado} ({passou})");
    }
}

