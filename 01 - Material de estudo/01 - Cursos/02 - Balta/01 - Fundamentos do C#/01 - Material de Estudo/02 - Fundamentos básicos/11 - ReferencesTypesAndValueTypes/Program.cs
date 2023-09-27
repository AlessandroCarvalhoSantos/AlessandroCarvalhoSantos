namespace ValueTypesAndReferencesTypes;

class Program
{
    static void Main()
    {
        // Value Types
        int x = 25;
        int y = x; //Y é um cópia de X

        Console.WriteLine(x); //25
        Console.WriteLine(y); //25

        x = 32; // somente x foi alterado

        Console.WriteLine(x); //32
        Console.WriteLine(y); //25

        // References types

        var arr = new string[2];
        arr[0] = "Item 1";

        var arr2 = arr;

        Console.WriteLine(arr[0]); //Item 1
        Console.WriteLine(arr2[0]); //Item 1

        arr[0] = "Item 1 alterado"; //Ambos array foram alterados
        Console.WriteLine(arr[0]); //Item 1 alterado
        Console.WriteLine(arr2[0]);  //Item 1 alterado
    }
}