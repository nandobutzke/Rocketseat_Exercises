namespace ExerciseThree;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        
        var primeiroNumero = Console.ReadLine();
        
        Console.WriteLine("Digite o segundo número:");
        
        var segundoNumero = Console.ReadLine();

        bool numerosDigitados = primeiroNumero is not null && segundoNumero is not null;

        if (numerosDigitados)
        {
            double primeiroNumeroConvertido = Convert.ToDouble(primeiroNumero);
            double segundoNumeroConvertido = Convert.ToDouble(segundoNumero);
            
            Console.WriteLine($"O resultado da soma é: {OperacoesMatematicas.Somar(primeiroNumeroConvertido, segundoNumeroConvertido)}");
            Console.WriteLine($"O resultado da subtração é: {OperacoesMatematicas.Subtrair(primeiroNumeroConvertido, segundoNumeroConvertido)}");
            Console.WriteLine($"O resultado da multiplicação é: {OperacoesMatematicas.Multiplicar(primeiroNumeroConvertido, segundoNumeroConvertido)}");
            Console.WriteLine($"O resultado da divisão é: {OperacoesMatematicas.Dividir(primeiroNumeroConvertido, segundoNumeroConvertido)}");
            Console.WriteLine($"O resultado da média é: {OperacoesMatematicas.CalcularMedia(primeiroNumeroConvertido, segundoNumeroConvertido)}");
        }


    }
}