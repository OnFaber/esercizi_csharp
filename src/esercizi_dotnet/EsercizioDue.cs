// Esercizio 2: Trova Max e Min
// Scrivi un metodo che riceva una lista di numeri interi tramite 'params' e restituisca il valore massimo
// e minimo.
public class EsercizioDue : IEsercizio
{
    public void EnsureArrayIsNotEmpty(int[] args)
    {
        if (!args.Any())
        {
            throw new ArgumentException("La lista non può essere vuote");
        }
    }
    
    public (int Min, int Max) FindMinMax(params int[] args)
    {
        this.EnsureArrayIsNotEmpty(args);
        int min = args.Min();
        int max = args.Max();
        return (min, max);
    }

    public void Run(TextReader? input, TextWriter? output)
    {
        output ??= Console.Out;
        
        try
        {
            (int, int) result = this.FindMinMax(34, 12, 45, 67, 23, 89, 1);
            output.WriteLine($"Min: {result.Item1}, Max: {result.Item2}");
        }
        catch (ArgumentException ex)
        {
            output.WriteLine(ex.Message);
        }
    }
}
