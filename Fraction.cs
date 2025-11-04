using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Fraction
    {
        int numerator, denominator;      
        
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;     
        }
        
        public Fraction Addition(Fraction n)
        {
            
            return new Fraction((numerator * n.denominator + n.numerator * denominator), (denominator * n.denominator)); 
        }
        public Fraction Subtraction(Fraction n)
        {
            return new Fraction((numerator * n.denominator - n.numerator * denominator), (denominator * n.denominator));
        }
        public Fraction Multiplication(Fraction n)
        {
            return new Fraction((numerator * n.numerator), (denominator * n.denominator));
        }
        public Fraction Division(Fraction n)
        {
            return new Fraction((numerator * n.denominator), (denominator * n.numerator));
        }

        public bool ErrorZero()
        {
            if (denominator == 0)
            {
                return true;
            }
            return false;
        }

        public override string ToString() 
        {
            return numerator + "/" + denominator;
        }
    }
}
