namespace ExerciseTwo;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um nome:");
        
        var nome = Console.ReadLine();
        
        Console.WriteLine("Digite um sobrenome:");
        
        var sobrenome = Console.ReadLine();
        
        Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    }
}
