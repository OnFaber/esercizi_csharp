namespace esercizi_dotnet;

public class EsercizioUno
{
    private readonly string  _frase;
    private static readonly char[] _separators = new char[] { ' ', ',', '?', '!', '.', ';', ':' };
    private static readonly HashSet<char> _vocali = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

    public EsercizioUno(string frase)
    {
        _frase = frase.ToLowerInvariant();
    }

    private IEnumerable<string> Parole => _frase.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
    
    private int NumeroParole => Parole.Count();

    private int NumeroVocali => Parole
        .SelectMany(parola => parola)
        .Where(c => _vocali.Contains(c))
        .Count();

    private int NumeroConsonanti => Parole
        .SelectMany(parola => parola)
        .Where(c => char.IsLetter(c))
        .Where(c => !_vocali.Contains(c))
        .Count();    

    public void AnalizzaFrase()
    {
        Console.WriteLine($"Frase: {_frase}");
        Console.WriteLine($"Numero di parole: {NumeroParole}");
        Console.WriteLine($"Numero di vocali: {NumeroVocali}");
        Console.WriteLine($"Numero di consonanti: {NumeroConsonanti}");
    }
}
    
public class Program
{

    public static void Main(string[] args)
    {
        /*
         * esercizio_uno: Analizza frase
         * Scrivi un metodo che, data una frase, calcoli il numero di parole, di
         * vocali e di consonanti contenuti in essa         
         */
        EsercizioUno es1 = new EsercizioUno("Ciao, come stai? Io sto bene, grazie!");
        es1.AnalizzaFrase();
    }
}
