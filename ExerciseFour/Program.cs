namespace ExerciseFour;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite palavras:");
        
        var palavras = Console.ReadLine();

        var listaDePalavras = palavras.Split(" ");

        for (int i = 0; i < listaDePalavras.Length; i++)
        {
            Console.WriteLine($"A palavra '{listaDePalavras[i]}' tem {listaDePalavras[i].Length} {(listaDePalavras[i].Length > 1 ? "caracteres" : "caracter")}");
        }
    }
}