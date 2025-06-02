using Xunit;
using esercizi_dotnet;

namespace esercizi_dotnet.Tests;

public class EsercizioUnoTests    
{
    
    [Theory]
    [InlineData("Ciao, come stai? Io sto bene, grazie!", 7)]
    public void NumeroParole_Should_Return_Correct_Number_Of_Words(string frase, int paroleAttese)
    {
        EsercizioUno sut = new EsercizioUno(frase);
        Assert.Equal(paroleAttese, sut.NumeroParole);
    }

    [Theory]
    [InlineData("Ciao, come stai? Io sto bene, grazie!", 15)]
    public void NumeroVocali_Should_Return_Correct_Number_Of_Vowels(string frase, int vocaliAttese)
    {
        EsercizioUno sut = new EsercizioUno(frase);
        Assert.Equal(vocaliAttese, sut.NumeroVocali);
    }

    [Theory]
    [InlineData("Ciao, come stai? Io sto bene, grazie!", 12)]
    public void NumeroConsonanti_Should_Return_Correct_Number_Of_Consonanti(string frase, int consonantiAttese)
    {
        EsercizioUno sut = new EsercizioUno(frase);
        Assert.Equal(consonantiAttese, sut.NumeroConsonanti);
    }
}
