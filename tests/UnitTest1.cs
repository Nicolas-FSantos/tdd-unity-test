using application;

namespace tests;

public class UnitTest1
{

    public Calculadora construirClasse()
    {
        string data = "02/02/2020";
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData(3, 4, 7)]
    [InlineData(5, 5, 10)]
    public void TestAdd(int number1, int number2, int result)
    {
        Calculadora calc = construirClasse();

        int calcResult = calc.Add(number1, number2);

        Assert.Equal(result, calcResult);
    }

    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(5, 5, 25)]
    public void TestMultiply(int number1, int number2, int result)
    {
        Calculadora calc = construirClasse();

        int calcResult = calc.Multiply(number1, number2);

        Assert.Equal(result, calcResult);
    }

    [Theory]
    [InlineData(3, 4, -1)]
    [InlineData(5, 2, 3)]
    public void TestSub(int number1, int number2, int result)
    {
        Calculadora calc = construirClasse();

        int calcResult = calc.Sub(number1, number2);

        Assert.Equal(result, calcResult);
    }

    [Theory]
    [InlineData(9, 3, 3)]
    [InlineData(10, 2, 5)]
    public void TestDivide(int number1, int number2, int result)
    {
        Calculadora calc = construirClasse();

        int calcResult = calc.Divide(number1, number2);

        Assert.Equal(result, calcResult);
    }
    [Fact]
    public void TestDivideByZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Divide(3,0)
        );
    }

    [Fact]
    public void TestHistory()
    {
        Calculadora calc = construirClasse();

        calc.Add(1,2);
        calc.Add(1,3);
        calc.Add(1,4);
        calc.Add(1,5);

        var lista = calc.History();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}