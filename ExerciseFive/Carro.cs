using System.Text.RegularExpressions;

namespace ExerciseFive;
public class Carro
{
    public string Placa { get; set; }
    
    public bool IsPlacaValida()
    {
        if (Placa.Count() != 7)
        {
            return false;
        }
        
        var primeirosCaracteres = Placa.Substring(0, 3);
        var ultimosCaracteres = Placa.Substring(3, 4);

        var placaValida = PrimeirosCaracteresTemLetras(primeirosCaracteres) && UltimosCaracteresTemLetras(ultimosCaracteres);

        if (placaValida)
        {
            return true;
        }

        return false;
    }

    private bool PrimeirosCaracteresTemLetras(string caracteres)
    {
        int valorNumerico;
        bool naoContemNumeros = !int.TryParse(caracteres, out valorNumerico);
        
        if (naoContemNumeros)
        {
            return true;
        }
        return false;
    }
    
    private bool UltimosCaracteresTemLetras(string caracteres)
    {
        int valorNumerico;
        bool contemNumeros = int.TryParse(caracteres, out valorNumerico);
        
        if (contemNumeros)
        {
            return true;
        }
        return false;
    }
}