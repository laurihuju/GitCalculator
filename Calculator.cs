using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalculator
{
    class Calculator
    {
        private static float[] ParseNumbers(string input)
        {
            input = input.Replace(" ", "").Replace(',', '.');

            char[] separators = {'+', '-', '*', '/'};
            string[] splitInput = input.Split(separators);
            if (splitInput.Length <= 1)
                return null;

            float[] numbers = new float[splitInput.Length];
            try
            {
                for (int i = 0; i < splitInput.Length; i++)
                {
                    numbers[i] = float.Parse(splitInput[i], CultureInfo.InvariantCulture);
                }
            } catch (FormatException)
            {
                return null;
            }
            return numbers;
        }

        private static char[] ParseOperators(string input, int numberCount)
        {
            char[] separators = { '+', '-', '*', '/' };
            char[] operators = new char[numberCount - 1];
            int operatorIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];
                if (character == '+' || character == '-' || character == '*' || character == '/')
                {
                    operators[operatorIndex] = character;
                    operatorIndex++;
                }
            }
            if (operatorIndex != numberCount - 1)
                return null;
            return operators;
        }

        public static string CalculateInput(string input)
        {
            float[] numbers = ParseNumbers(input);
            if (numbers == null)
                return "e";
            char[] operators = ParseOperators(input, numbers.Length);
            if (operators == null)
                return "e";

            float calculation = numbers[0];
            int nextOperator = 0;
            for(int i = 1; i < numbers.Length; i++)
            {
                if (nextOperator >= operators.Length)
                    return "e";
                if(operators[nextOperator] == '+')
                {
                    calculation = sum(calculation, numbers[i]);
                    nextOperator++;
                }
                else if (operators[nextOperator] == '-')
                {
                    calculation = difference(calculation, numbers[i]);
                    nextOperator++;
                }
                else if (operators[nextOperator] == '*')
                {
                    calculation = multiply(calculation, numbers[i]);
                    nextOperator++;
                }
                else if (operators[nextOperator] == '/')
                {
                    calculation = divide(calculation, numbers[i]);
                    nextOperator++;
                }
            }
            return calculation + "";
        }

        private static float sum(float number1, float number2)
        {
            return number1 + number2;
        }

        private static float difference(float number1, float number2)
        {
            return number1 - number2;
        }

        private static float multiply(float number1, float number2)
        {
            return number1 * number2;
        }

        private static float divide(float number1, float number2)
        {
            return number1 / number2;
        }
    }
}
