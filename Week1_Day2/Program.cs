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
        }
    }
}
