namespace tests;

public class UnitTest1
{
    [Fact]
    public void ZeroCase()
    {
        double celsius = 0.0;
        Assert.Equal(32,Program.Convert_CelsiusToFahrenheit(celsius));
    }

    [Fact]
    public void PositiveCase()
    {
        double celsius = 50.0;
        Assert.Equal(122,Program.Convert_CelsiusToFahrenheit(celsius));
    }

    [Fact]
    public void NegativeCase()
    {
        double celsius = -75.0;
        Assert.Equal(-103,Program.Convert_CelsiusToFahrenheit(celsius));
    }

    [Fact]
    public void DecimalCase()
    {
        double celsius = 80.66;
        Assert.Equal(177.188,Program.Convert_CelsiusToFahrenheit(celsius));
    }
}