using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Console.WriteLine($"Frac1: {defaultFraction.GetTop()}/{defaultFraction.GetBottom()}");

        Fraction oneFraction = new Fraction(5);
        Console.WriteLine($"Frac2: {oneFraction.GetTop()}/{oneFraction.GetBottom()}");

        Fraction twoFraction = new Fraction(2, 7);
        Console.WriteLine($"Frac3: {twoFraction.GetTop()}/{twoFraction.GetBottom()}");

        double decDefault = defaultFraction.GetDecimalValue();
        Console.WriteLine(decDefault);
        string strDefault = defaultFraction.GetFractionString();
        Console.WriteLine(strDefault);

        double decOne = oneFraction.GetDecimalValue();
        Console.WriteLine(decOne);
        string strOne = oneFraction.GetFractionString();
        Console.WriteLine(strOne);

        double decTwo = twoFraction.GetDecimalValue();
        Console.WriteLine(decTwo);
        string strTwo = twoFraction.GetFractionString();
        Console.WriteLine(strTwo);


    }
}