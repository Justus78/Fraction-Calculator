using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator { 
    public struct Fraction {

        // initialize variables
        int _numerator;
        int _denominator;

        // properties
        public int Numerator { get { return _numerator; } set { _numerator = value; } }
        public int Denominator {
            get { return _denominator; }
            set {
                if (_denominator == 0) {
                    throw new DivideByZeroException();
                }// end if
                _denominator = value;
            } // end set
        } // end property


        // declare multiple constructors
        // default constructor
        public Fraction() {
            this._denominator = 1;
            this._numerator = 1;
        } // end constructor

        // regular constructor taking 2 arguments
        public Fraction(int numerator, int denominator)
        {
            this._numerator = numerator;
            this._denominator = denominator;
        } // end constructor

        // copy constructor takes the fraction as an argument and assigns those 
        // arguments from that fraction to this fraction
        public Fraction(Fraction f) :
            this(f._numerator, f._denominator)
        { } // end constructor

        // declare the methods for overloading mathematical operators
        // overloading the operator for addition
        public static Fraction operator +(Fraction x, Fraction y) {
            // for adding fractions, you must find the common denominator by multiplying the denominators
            // then multiply each numerator by the opposite fraction's denominator, then add the numerators 
            Fraction f = new Fraction((x.Numerator * y.Denominator) + (y.Numerator * x.Denominator), (x.Denominator * y.Denominator)); 
            f.Reduce();// reduce the fraction with the reduce method
            return f; // return the fraction
        } // end overloading operator +

        //overloading the operator for subtraction
        public static Fraction operator -(Fraction x, Fraction y) {
            // for subtracting fractions, you must find the common denominator by multiplying the denominators
            // then multiply each numerator by the opposite fraction's denominator, then subract the right numerator from the left
            Fraction f = new Fraction((x.Numerator * y.Denominator) - (y.Numerator * x.Denominator), (x.Denominator * y.Denominator));
            
            // reduce and return the fraction
            f.Reduce(); 
            return f;
        } // end overloading operator -

        // overloaded operator for multiplication
        public static Fraction operator *(Fraction x, Fraction y) {
            // for multiplying fractions, multiply the numerators and denominators
            Fraction f = new Fraction(x.Numerator * y.Numerator, x.Denominator * y.Denominator);

            // reduce and return the fraction
            f.Reduce();
            return f;
        } // end overloading operator *

        // overloading the division operator
        public static Fraction operator /(Fraction x, Fraction y) {

            // for dividing fractions, multiply the first fraction's numerator and the second fraction's denominator
            // then multiply the first fraction denominator and the second fraction numerator
            Fraction f = new Fraction(x.Numerator * y.Denominator, x.Denominator * y.Numerator);

            // reduce and return the fraction
            f.Reduce();
            return f;
        } // end overloading operator /

        private void Reduce() {

            // initial the common variabele
            int common = 0;

            // for loop for looping until we find the first number that divides into both the
            // numerator and denominator evenly, start the loop at the highest number between
            // the numerator and denominator using Math.Max() and decrimenting instead of incrementing
             
            for (int i = Math.Max(Numerator, Denominator); i > 1; i--) {
                // when the first common divisor is found, set it to the variable and break from the loop
                if (Denominator % i == 0) {
                    if (Numerator % i == 0) {
                        common = i;
                        break;
                    } // end if
                } // end if 
            }// end for 
            // if no common was found, that means the fraction cannot be reduced and no calculations will occur
            if (common != 0) {
                Numerator = Numerator / common;
                Denominator = Denominator / common;
            } // end if 
        } // end method

        // ToString() Method to return a string
        public override string ToString() =>
            $"{this.Numerator} / {this.Denominator}";
        // end method

        // method to return the decimal equivalent of the fraction
        public double ToDecimal() {  
            return (double)Numerator / (double)Denominator;
        } // end method
    } // end class
} // end namespace
