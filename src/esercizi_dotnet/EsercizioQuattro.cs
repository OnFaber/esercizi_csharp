/*
  Esercizio 4: Tabellina Moltiplicativa
  Stampa a video una tabella moltiplicativa da 1 fino a N x N, dove N è fornito in input.
 */

class EsercizioQuattro : IEsercizio
{
    public void StampaTabellina(int n, TextWriter output)
    {
        int max = n * n;
        int width = max.ToString().Length + 1;
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                output.Write((i * j).ToString().PadLeft(width));
            }
            output.WriteLine();
        }
    }

    public void Run (TextReader? input = null, TextWriter? output = null)
    {
        input ??= Console.In;
        output ??= Console.Out;

        while (true)
        {
            output.Write("Inserisci un numero N per la tabellina moltiplicativa: ");
            string? line = input.ReadLine();
            
            if (int.TryParse(line, out int n) && n > 0)
            {
                StampaTabellina(n, output);
                break;
            }
            else
            {
                output.WriteLine("inserisci un numero maggiore di 0");
            }
        }
    }
}
