// Esercizio 2: Trova Max e Min
// Scrivi un metodo che riceva una lista di numeri interi tramite 'params' e restituisca il valore massimo
// e minimo.
public class EsercizioDue
{
    public static void EnsureArrayIsNotEmpty(int[] args)
    {
        if (!args.Any())
        {
            throw new ArgumentException("La lista non può essere vuote");
        }
    }
    
    public static (int Min, int Max) FindMinMax(params int[] args)
    {
        EnsureArrayIsNotEmpty(args);
        int min = args.Min();
        int max = args.Max();
        return (min, max);
    }

    public static void Run()
    {
        try
        {
            (int, int) result = FindMinMax(34, 12, 45, 67, 23, 89, 1);
            Console.WriteLine($"Min: {result.Item1}, Max: {result.Item2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
