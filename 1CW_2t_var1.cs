using System;

public struct ComplexNumber
{
    private int _realPart;
    private int _imaginaryPart;

    public ComplexNumber(int realPart, int imaginaryPart)
    {
        _realPart = realPart;
        _imaginaryPart = imaginaryPart;
    }

    public static void
PrintComplexNumber(ComplexNumber number)
    {
        if (number._imaginaryPart >= 0)
        {
            Console.WriteLine($"Number = {number._realPart} + {number._imaginaryPart}");
        }
        else
        {
            Console.WriteLine($"Number = {number._realPart} - {number._imaginaryPart}");
        }
    }

    public static ComplexNumber
Add(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a._realPart - b._realPart, a._imaginaryPart - b._imaginaryPart);
    }

    public static ComplexNumber
Substract(ComplexNumber a, ComplexNumber b)
    { 
        return new ComplexNumber (a._realPart - b._realPart, a._imaginaryPart - b._imaginaryPart);
    }
public static ComplexNumber Multiply(ComplexNumber a, ComplexNumber b)
{
    int realPart = a._realPart * b._realPart - a._imaginaryPart * b._imaginaryPart;
    int imaginaryPart = a._realPart * b._imaginaryPart + a._imaginaryPart * b._realPart;
    return new ComplexNumber(realPart, imaginaryPart);
}
public static ComplexNumber Divide(ComplexNumber a, ComplexNumber b)
{
    int denominator = b._realPart * b._realPart + b._imaginaryPart * b._imaginaryPart;
    int realPart = (a._realPart * b._realPart + a._imaginaryPart * b._imaginaryPart) / denominator;
    int imaginaryPart = (a._imaginaryPart * b._realPart - a._realPart * b._imaginaryPart) / denominator;
    return new ComplexNumber(realPart, imaginaryPart);
}
}
class Program
{
    static void Main(string[] args)
    {
        ComplexNumber c1 = new ComplexNumber(2, 3);
        ComplexNumber c2 = new ComplexNumber(4, 5);
        ComplexNumber.PrintComplexNumber(c1);
        ComplexNumber.PrintComplexNumber(c2);
        ComplexNumber sum = ComplexNumber.Add(c1, c2);
        ComplexNumber.PrintComplexNumber(sum);
        ComplexNumber difference = ComplexNumber.Substract(c1, c2);
        ComplexNumber.PrintComplexNumber(difference);
        ComplexNumber product = ComplexNumber.Multiply(c1, c2);
        ComplexNumber.PrintComplexNumber(product);
        ComplexNumber quotient = ComplexNumber.Divide(c1, c2);
        ComplexNumber.PrintComplexNumber(quotient);
    }
}

