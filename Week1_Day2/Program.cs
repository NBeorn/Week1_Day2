using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Types
            //An int is a whole number
            //A string is a collection of characters
            
            //A char is a single character
            char firstInitial = 'D';
           
            //bool (boolean) is true or false, will default to true
            bool isTired = true;

            //other number data types
            //float requires a letter f at the end of the value
            //decimal requires m
            //double uses d
            //float is shortest, decimal is longest
            float number = 2.164403304897294849383961032f;
            decimal partialNum = 2.164403304897294849383961032m;
            double someNumber = 2.164403304897294849383961032d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Operators
            //Arithmetic Operators
            // + adds two operands
            // - subtracts
            // * multiplies
            // / divides
            // % (Modulus) checks the remainder
            // ++ increments operator by 1, primarily used for ints
            // -- decrements by 1
            //Relational Operators
            // == checks if the values are equal, if they are it returns bool true
            // != checks if values are not equal
            // > checks for greater than
            // < checks for less than
            // >= greater than or equal to
            // <= less than or equal to
            //Logical Operators
            // && and operator - checks two conditions at once
            // || or operator - if any conditions are true, it is true
            // ! not operator - used to reverse the logical state of the operand
        }
    }
}
