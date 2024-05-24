using System;

struct Number
{
    public int Real;
    public Number(int real)
    {
        Real = real;
    }
    public static Number Add(Number n1, Number n2)
    {
        return new Number(n1.Real + n2.Real);
    }

    public static Number Substract(Number n1, Number n2)
    {
        return new Number(n1.Real - n2.Real);
    }
    public static Number Multiply(Number n1, Number n2)
    {
        return new Number(n1.Real * n2.Real);
    }
    public static Number Divide(Number n1, Number n2)
    {
        return new Number(n1.Real / n2.Real);
    }
    public void Print()
    {
        Console.WriteLine($"Number = {Real}");
    }
}
class Programm
{
    static void Main()
    {
        Number n1 = new Number(5);
        Number n2 = new Number(3);
        Number sum = Number.Add(n1, n2);
        Number difference = Number.Substract(n1, n2);
        Number product = Number.Multiply(n1, n2);
        Number quotient = Number.Divide(n1, n2);

        n1.Print();
        n2.Print();
        sum.Print();
        difference.Print();
        product.Print();
        quotient.Print();
    }
}



       
