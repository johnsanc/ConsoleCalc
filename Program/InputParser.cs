using System.Collections.Generic;
using System;
namespace Program
{
    public static class InputParser
    {
        public static List<double> ParseTextToDouble(string text)
        {
            string[] delimeters = new string[] { ",", "\\n" };
            string[] unprocessedNums = text.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            List<double> processedValues = new List<double>();

            for(var i = 0; i < unprocessedNums.Length; i++)
            {
                double tempNum;
                if (double.TryParse(unprocessedNums[i], out tempNum))
                {
                    processedValues.Add(tempNum);
                }
                else
                {
                    processedValues.Add(0);
                }
            }
            return processedValues;
        }
    }
}