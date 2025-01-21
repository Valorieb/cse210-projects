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

        
        Console.WriteLine(defaultFraction.GetDecimalValue());
        Console.WriteLine(defaultFraction.GetFractionString());

        Console.WriteLine(oneFraction.GetDecimalValue());
        Console.WriteLine(oneFraction.GetFractionString());

        Console.WriteLine(twoFraction.GetDecimalValue());
        Console.WriteLine(twoFraction.GetFractionString());


    }
}