namespace esercizi_dotnet;
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
