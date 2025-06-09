using Xunit;
using FluentAssertions;
using esercizi_dotnet;

namespace esercizi_dotnet.Tests;

public class EsercizioCinqueTests
{
    private readonly EsercizioCinque _sut;

    public EsercizioCinqueTests()
    {
        _sut = new EsercizioCinque(
            sorting: new BubbleSort(),
            arraySize: 20,
            minValue: 1,
            maxValue: 10
        );
    }

    [Fact]
    public void PrintArray_Should_Write_Array_To_Output()
    {
        StringWriter writer = new StringWriter();
        int[] array = new[] { 1, 2, 3 };
        _sut.PrintArray(writer, array);

        string output = writer.ToString();
        Assert.Equal("Array: 1, 2, 3\n", output);
    }

    [Theory]
    [InlineData(-1, "Il numero non è stato trovato\n", false)]
    [InlineData(5, "Il numero cercato si trova ad indice 5\n", true)]
    public void PrintSearchResult_Should_Write_Correct_Message(int index, string expectedMessage, bool expectedResult)
    {
        StringWriter writer = new StringWriter();
        bool result = _sut.PrintSearchResult(writer, index);
        string output = writer.ToString();
        
        Assert.Equal(expectedMessage, output);
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Should_Create_Array_Of_Integers()
    {
        int[] array = _sut.CreateArray();
        Assert.NotNull(array);
        Assert.IsType<int[]>(array);
    }

    [Fact]
    public void Should_Remove_Duplicates()
    {
        int[] array = _sut.CreateArray();
        int[] noDup = _sut.RemoveDuplicates(array);
        noDup.Should().OnlyHaveUniqueItems();
    }
}
