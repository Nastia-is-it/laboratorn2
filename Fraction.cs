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
        int newNum, newDen;
        bool func = false;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;     
        }
        
        public void Addition(Fraction n)
        {
            newNum = (numerator * n.denominator) + (n.numerator * denominator);
            newDen = denominator * n.denominator;
            func = true;
        }
        public void Subtraction(Fraction n)
        {
            newNum = (numerator * n.denominator) - (n.numerator * denominator);
            newDen = denominator * n.denominator;
            func = true;
        }
        public void Multiplication(Fraction n)
        {
            newNum = numerator * n.numerator;
            newDen = denominator * n.denominator;
            func = true;
        }
        public void Division(Fraction n)
        {
            newNum = numerator * n.denominator;
            newDen = denominator * n.numerator;
            func = true;
        }

        private string result
        {
            get
            {
                if (func)
                {
                    return newNum + "/" + newDen;
                }
                return numerator + "/" + denominator;
            }

        }
        public override string ToString() 
        {
            return result;
        }
    }
}
