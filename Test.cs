<<<<<<< HEAD
using NUnit.Framework;



public class ConverterTests
{
    private ConverterTests converter;

    public void Setup()
    {
        converter = new ConverterTests();
    }

    public void InchesToMm_Conversion()
    {
        double result = converter.converter(1, "-mm");
        Assert.AreEqual(25.4, result);
    }

    public void InchesToCm_Conversion()
    {
        double result = converter.converter(1, "-cm");
        Assert.AreEqual(2.54, result);
    }

    public void InchesToM_Conversion()
    {
        double result = converter.converter(1, "-m");
        Assert.AreEqual(0.0254, result);     
    }
}
=======
using NUnit.Framework;

public class ConverterTests
{
    private ConverterTests converter;

    public void Setup()
    {
        converter = new ConverterTests();
    }

    public void InchesToMm_Conversion()
    {
        double result = converter.converter(1, "-mm");
        Assert.AreEqual(25., result);
    }

    public void InchesToCm_Conversion()
    {
        double result = converter.converter(1, "-cm");
        Assert.AreEqual(2.54, result);
    }

    public void InchesToM_Conversion()
    {
        double result = converter.converter(1, "-m");
        Assert.AreEqual(0.0254, result);
    }
>>>>>>> 9035d6dd261c420662a8f77bf6640308f8e17801
}