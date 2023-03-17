using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16OOP
{
    public class Fraction
    {
        public void SortFractions(Fraction[] fractions)
        {
            Array.Sort(fractions, (a, b) => a.ToDouble().CompareTo(b.ToDouble()));
        }

        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(Fraction other)
        {
            this.numerator = other.numerator;
            this.denominator = other.denominator;
        }

        public void SetNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public void SetDenominator(int denominator)
        {
            this.denominator = denominator;
        }

        public int GetNumerator()
        {
            return this.numerator;
        }

        public int GetDenominator()
        {
            return this.denominator;
        }

        public void Reduce()
        {
            int gcd = GetGcd(this.numerator, this.denominator);
            this.numerator /= gcd;
            this.denominator /= gcd;
        }

        public double ToDouble()
        {
            return (double)this.numerator / this.denominator;
        }

        public Fraction Add(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator + other.numerator * this.denominator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Subtract(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator - other.numerator * this.denominator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int newNumerator = this.numerator * other.numerator;
            int newDenominator = this.denominator * other.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Divide(Fraction other)
        {
            int newNumerator = this.numerator * other.denominator;
            int newDenominator = this.denominator * other.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Power(int n)
        {
            int newNumerator = (int)Math.Pow(this.numerator, n);
            int newDenominator = (int)Math.Pow(this.denominator, n);
            return new Fraction(newNumerator, newDenominator);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.ToDouble() == b.ToDouble();
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.ToDouble() != b.ToDouble();
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return a.ToDouble() > b.ToDouble();
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.ToDouble() < b.ToDouble();
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            return a.ToDouble() >= b.ToDouble();
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.ToDouble() <= b.ToDouble();
        }

        private int GetGcd(int a, int b)
        {
            if (b == 0) return a;
            return GetGcd(b, a % b);
        }

        public override string ToString()
        {
            return this.numerator + "/" + this.denominator;
        }
    }
}

