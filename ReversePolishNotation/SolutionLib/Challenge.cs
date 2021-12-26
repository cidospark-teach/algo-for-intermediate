using System;
using System.Collections.Generic;

namespace SolutionLib
{
    public class Challenge
    {
        public static double Evaluate(string str)
        {
            // make sure the string expression is not empty
            if (string.IsNullOrWhiteSpace(str))
                return 0.0;

            // split string expression to get each character to evaluate
            var splittedStr = str.Trim().Split(" ");

            var result = new List<double>();

            // traverse the splitted list
            foreach(var item in splittedStr)
            {
                double number;

                // check if number is numeric and add to list else 
                var isNumeric = double.TryParse(item, out number);
                if (isNumeric)
                {
                    result.Add(number);
                }
                else
                {
                    try
                    {
                        // make sure items in the result is is more that one before evaluating the last two
                        if(result.Count >= 2)
                        {
                            // get the last two items in result list
                            var penUltimateItem = result[result.Count - 2];
                            var lastResultItem = result[result.Count - 1];

                            // evaluate the last two items
                            var evaluation = Calc(penUltimateItem, lastResultItem, Convert.ToChar(item));

                            // remove the last two evaluated items and add their evaluation
                            result.Remove(lastResultItem);
                            result.Remove(penUltimateItem);
                            result.Add(evaluation);
                        }
                        else
                        {
                            var lastResultItem = result[result.Count - 1];
                            var evaluation = Calc(0, lastResultItem, Convert.ToChar(item));

                            result.Remove(lastResultItem);
                            result.Add(evaluation);

                        }
                    }
                    catch
                    {
                        throw new Exception("Invalid! expects space between number and operator");
                    }
                }
            }

            return result[result.Count - 1]; // return the last item in the list if more than one
        }

        private static double Calc(double a, double b, char sign)
        {
            // evaluate params based on the sign
            switch (sign)
            {
                case '-':
                    return a - b;

                case '*':
                    return a * b;

                case '/':
                    return a / b;

                default:
                    return a + b;
            }
        }
    }
}
