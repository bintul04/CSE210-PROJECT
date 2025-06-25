using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor 1: Default to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor 2: One parameter (numerator), denominator = 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor 3: Two parameters (numerator and denominator)
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        SetDenominator(denominator); // validation
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    // Setter for numerator
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Setter for denominator with validation
    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            _denominator = denominator;
        }
        else
        {
            Console.WriteLine("⚠️ Error: Denominator cannot be zero.");
            _denominator = 1;
        }
    }

    // Returns the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
