/*
 *  Esercizio 3: Converti Temperatura
 *  Chiedi all'utente un valore e l'unità di misura (C o F) e converti la temperatura da Celsius a
 *  Fahrenheit o viceversa.
 */

public class EsercizioTre : IEsercizio
{
    public static void Print(string? message, TextWriter? output = null)
    {
        output ??= Console.Out;
        output.Write(message ?? "");
    }
    
    public double AskInput(TextReader input, TextWriter? output = null)
    {
        Print("Inserisci un valore di temperatura: ", output);
        string? line = input.ReadLine();
        
        if (double.TryParse(line, out double temperatura))
        {
            return temperatura;
        }
        else
        {
            Print("valore non valido", output);
            return AskInput(input, output);
        }
    }

    public char AskUnit(TextReader input, TextWriter? output = null)
    {
        Print("Inserisci l'unita di misura (C per Celsius, F per Fahrenheit): ", output);
        int key = input.Read();
        char unit = char.ToUpper((char)key);
        output?.WriteLine();
        
        if (unit == 'C' || unit == 'F')
        {
            return unit;
        }
        else
        {
            Console.WriteLine("Unita di misura non valide.");
            return AskUnit(input, output);
        }        
    }

    public double FahrToCelsius(double temperatura) => 5 * (temperatura - 32) / 9.0;
    public double CelsiusToFahr(double temperatura) => temperatura * 9.0 / 5.0 + 32;
    
    public void Run(TextReader? input = null, TextWriter? output = null)
    {
        input ??= Console.In;
        output ??= Console.Out;
        
        double risultato;
        double temperatura = AskInput(input, output);
        char unit = AskUnit(input, output);
        
        switch (unit) {
            case 'C':
                risultato = CelsiusToFahr(temperatura);
                break;
            case 'F':
                risultato = FahrToCelsius(temperatura);
                break;
            default:
                return;
        }

        Console.WriteLine(
            "{0} in gradi {1} sono {2} in gradi {3}",
            temperatura,
            unit,
            risultato,
            char.Equals(unit, 'C') ? 'F' : 'C'
        );
    }
}
