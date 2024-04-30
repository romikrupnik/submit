using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פסח
{
    internal class Fraction
    {
        private int n;
        private int d;
        private int whole;

        public Fraction(int n, int d)
        {
            this.d = d;
            this.n = n;
            this.whole = n / d;
            this.n %= d;
        }
        public int GetN()
        {
            return this.n;
        }
        public int GetD()
        { return this.d; }
        public int GetWhole()
        { return this.whole; }

        public void SetN(int n)
        {
            this.n = n;
            this.whole = n / d;
            this.n %= d;
        }
        public void SetD(int d)
        { this.d = d; }
        public void SetWhole(int whole)
        { this.whole = whole; }

        public override string ToString()
        {
            if (whole > 0)
            {
                if (n == 0)
                    return $"{whole}";
                else
                    return $"{whole} {n}/{d}";
            }
            else
            {
                if (n == 0)
                    return "0";
                else
                    return $"{n}/{d}";
            }
        }
        public int CommonDen()
        {
            for(int i = this.n; i > 1; i--)
            {
                if(this.n % i == 0 && this.d % i == 0)
                {
                    return i;
                }
            }
            return 1;

        }

        public void Reduce()
        {
            if (CommonDen() != 1)
            {
                int gcd = CommonDen();
                this.n = this.n / gcd;
                this.d = this.d / gcd;
            }
        }
        public double Real()
        {
            return (double)this.n / this.d;
        }
        public Fraction Add(Fraction other)
        {
            int mechane = 0;
            int mone = 0;
            if (this.d != other.d)
            {
                mechane = this.d * other.d;
                mone = this.n * (mechane / this.d) + other.n * (mechane / other.d);
            }
            else { mechane = other.d;
                    mone=this.n+other.n;
            }
            Fraction new1 = new Fraction(mone, mechane);
            return new1;
        }

        public Fraction Subtraction(Fraction other)
        {
            int mechane = 0;
            int mone = 0;
            if (this.d != other.d)
            {
                mechane = this.d * other.d;
                mone = this.n * (mechane / this.d) - other.n * (mechane / other.d);
            }
            else
            {
                mechane = other.d;
                mone = this.n - other.n;
            }
            Fraction new1 = new Fraction(mone, mechane);
            return new1;
        }
        public Fraction Multiplying(Fraction other)
        {
            int numerator = this.n * other.n;
            int denominator = this.d * other.d;
            return new Fraction(numerator, denominator);
        }
        public Fraction Division(Fraction other)
        {
            int numerator = this.n * other.d;
            int denominator = this.d * other.n;
            return new Fraction(numerator, denominator);
        }

    
}
}
