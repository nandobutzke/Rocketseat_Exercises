using System.Globalization;

namespace ExerciseSix;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecione o formato que deseja apresentar a data e hora atual (digite 1 a 4 e pressione Enter):");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato 01/03/2024");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        string opcao = Console.ReadLine();

        DateTime data = DateTime.Now;

        switch (opcao)
        {
            case "1":
                Console.WriteLine(data.ToString("F"));
                break;
            case "2":
                Console.WriteLine(data.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(data.ToString("HH:mm:ss"));
                break;
            case "4":
                Console.WriteLine(data.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Opcão inválida");
                break;
        }
    }
}