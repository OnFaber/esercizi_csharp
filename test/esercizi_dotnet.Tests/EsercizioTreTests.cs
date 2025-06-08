using System;
using Xunit;
using Xunit.Abstractions;
using esercizi_dotnet;

namespace esercizi_dotnet.Tests;

public class EsercizioTreTests
{
    EsercizioTre sut = new EsercizioTre();

    private readonly ITestOutputHelper output;

    public EsercizioTreTests(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void AskInput_Should_Show_Error_For_Invalid_Input()
    {
        var input = new StringReader("abc\n25\n");
        var output = new StringWriter();

        double result = sut.AskInput(input, output);

        Assert.Equal(25, result);
        string outputText = output.ToString();
        Assert.Contains("valore non valido", outputText);
        Assert.Contains("Inserisci un valore di temperatura", outputText);
    }

    [Fact]
    public void AskInput_Should_Parse_Valid_Double()
    {
        var input = new StringReader("25");
        double result = sut.AskInput(input);
        Assert.Equal(25, result);
    }

    [Theory]
    [InlineData("c", 'C')]
    [InlineData("f", 'F')]
    public void AskInput_Should_Parse_Valid_Unit(string unitInput, char expectedUnit)
    {
        var input = new StringReader(unitInput);

        char result = sut.AskUnit(input);
        Assert.Equal(expectedUnit, result);
    }

    [Theory]
    [InlineData(32, 0)]
    public void FahrToCelsius_Should_Return_Correct_Value_For_Celsius(double fahreneit, double expectedCelsius)
    {
        double result = sut.FahrToCelsius(fahreneit);
        Assert.Equal(expectedCelsius, result);
    }

    [Theory]
    [InlineData(0, 32)]
    public void CelsiusToFahr_Should_Return_Correct_Value_For_Celsius(double celsius, double expectedFahrenheit)
    {
        double result = sut.CelsiusToFahr(celsius);
        Assert.Equal(expectedFahrenheit, result);
    }
}
