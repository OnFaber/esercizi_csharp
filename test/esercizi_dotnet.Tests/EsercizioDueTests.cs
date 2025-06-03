using Xunit;
using esercizi_dotnet;

namespace esercizi_dotnet.Tests;

public class EsercizioDueTests
{
    [Fact]
    public void  EnsureArrayIsNotEmpty_Should_Raise_An_Exception_If_Array_Is_Empty()
    {
        EsercizioDue sut = new EsercizioDue();
        Assert.Throws<ArgumentException>(() => sut.EnsureArrayIsNotEmpty(new int[] {}));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 1, 3)]
    [InlineData(new int[] { -5, 0, 5 }, -5, 5)]
    [InlineData(new int[] { 10, 20, 30, 40 }, 10, 40)]
    public void FindMinMax_Should_Return_MinMaxValue_WhenArray_Is_Not_Empty(int[] array, int expectedMin, int expectedMax)
    {
        EsercizioDue sut = new EsercizioDue();
        (int min, int max) = sut.FindMinMax(array);
        Assert.Equal(expectedMin, min);
        Assert.Equal(expectedMax, max);
    }
}
