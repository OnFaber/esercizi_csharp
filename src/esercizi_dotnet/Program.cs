using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        
        serviceCollection.AddSingleton<ISortingAlgorithm, BubbleSort>();
        serviceCollection.AddTransient<IEsercizio, EsercizioCinque>();

        
        var serviceProvider = serviceCollection.BuildServiceProvider();
        var esercizio = serviceProvider.GetRequiredService<IEsercizio>();
        esercizio.Run();
    }
}
