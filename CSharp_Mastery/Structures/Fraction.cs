using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Structures
{
    public struct Fraction
    {
        private readonly int _numerator;
        private readonly int _denumerator;

        public Fraction(int numerator, int denumerator)
        {
            this._numerator = numerator;
            this._denumerator = denumerator;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int newNumerator = f1._numerator * f2._denumerator + f2._numerator * f1._denumerator;
            int newDenominator = f1._denumerator * f2._denumerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a._numerator, a._denumerator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + (-b);
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denumerator}";
        }
    }
}
