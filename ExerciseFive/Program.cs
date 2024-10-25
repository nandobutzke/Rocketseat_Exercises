namespace ExerciseFive;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma placa de veículo válida (-):");

        var placa = Console.ReadLine();

        if (placa is not null)
        {
            var carro = new Carro();
            carro.Placa = placa;
            
            if (carro.IsPlacaValida())
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }

    }
}