/*
 * esercizio_uno: Analizza frase
 * Scrivi un metodo che, data una frase, calcoli il numero di parole, di
 * vocali e di consonanti contenuti in essa
 *
 * Usage:
 * EsercizioUno es1 = new EsercizioUno("Ciao, come stai? Io sto bene, grazie!");
 * es1.AnalizzaFrase();
 */

public class EsercizioUno
{
    private readonly string  _frase;
    private static readonly char[] _separators = new char[] { ' ', ',', '?', '!', '.', ';', ':' };
    private static readonly HashSet<char> _vocali = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

    public EsercizioUno(string frase)
    {
        _frase = frase.ToLowerInvariant();
    }

    /// <summary>
    /// Restituisce le parole della frase, separate da spazi e punteggiatura.
    /// </summary>
    public IEnumerable<string> Parole => _frase.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
    
    /// <summary>
    /// Restituisce il numero di parole nella frase.
    /// </summary>    
    public int NumeroParole => Parole.Count();

    /// <summary>
    /// Restituisce il numero di vocali nella frase.
    /// </summary>
    public int NumeroVocali => Parole
        .SelectMany(parola => parola)
        .Where(carattere => _vocali.Contains(carattere))
        .Count();

    /// <summary>
    /// Restituisce il numero di consonanti nella frase.
    /// </summary>
    public int NumeroConsonanti => Parole
        .SelectMany(parola => parola)
        .Where(carattere => char.IsLetter(carattere))
        .Where(carattere => !_vocali.Contains(carattere))
        .Count();    

    /// <summary>
    /// Analizza la frase e stampa il numero di parole, vocali e consonanti.
    /// </summary>
    public void AnalizzaFrase()
    {
        Console.WriteLine($"Frase: {_frase}");
        Console.WriteLine($"Numero di parole: {NumeroParole}");
        Console.WriteLine($"Numero di vocali: {NumeroVocali}");
        Console.WriteLine($"Numero di consonanti: {NumeroConsonanti}");
    }
    /// EsercizioUno.cs ends here
}
