using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Practice
{
    class Program
    {
        // Setter
        private void SetValues(float value1, float value2)
        {
            this._value1 = value1;
            this._value2 = value2;
        }

        // Getters
        private float GetValue1()
        {
            return _value1;
        }

        private float GetValue2()
        {
            return _value2;
        }
        
        // Main method 
        public static void Main(string[] args)
        {
            var obj = new Program();

            if (args != null && args.Length != 0 && args.Length <= 2)
            { 
                try
                {
                    var firstValue = Convert.ToDecimal(args[0]);
                    var secondValue = Convert.ToDecimal(args[1]);

                    obj._value1 = (float) firstValue;
                    obj._value2 = (float) secondValue;
                }
                catch (FormatException)
                {
                    obj._value1 = 0;
                    obj._value2 = 0;
                    
                    Console.WriteLine("Values are not being passed in. Returning 0!");
                }
            }
            else
            {
                Console.WriteLine("There are no arguments passed in, or more than two arguments are passed in!");
                return;
            }

            var value1 = obj.GetValue1();
            var value2 = obj.GetValue2();

            // Printing out values
            Console.WriteLine("Value 1: " + value1);
            Console.WriteLine("Value 2: " + value2);
            
            // Doing the calculations
            var addValues = AddValues(value1, value2);
            var multiplyValues = MultiplyValues(value1, value2);
            var divideValues = DivideValues(value1, value2);
            var subtractValues = SubtractValues(value1, value2);
            
            // Printing out he calculations
            Console.WriteLine("{0} + {1} = {2}", value1, value2, addValues);
            Console.WriteLine("{0} * {1} = {2}", value1, value2, multiplyValues);
            Console.WriteLine("{0} / {1} = {2}", value1, value2 ,divideValues);
            Console.WriteLine("{0} - {1} = {2}", value1, value2 , subtractValues);
        }

        private static float AddValues(float value1, float value2)
        {
            return value1 + value2;
        }

        private static float MultiplyValues(float value1, float value2)
        {
            return value1 * value2;
        }

        private static float DivideValues(float value1, float value2)
        {
            try
            {
                return (value1 / value2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
                return 0;
            }
        }

        private static float SubtractValues(float value1, float value2)
        {
            return value1 - value2;
        }
        
        // Member variables:
        private float _value1 = 0;
        private float _value2 = 0;
    }
}
