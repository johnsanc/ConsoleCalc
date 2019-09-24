using System.Collections.Generic;
using System;
namespace Program
{
    public static class InputParser
    {
        public static List<double> ParseTextToDouble(string text)
        {
            string[] delimeters = new string[] { ",", "\\n", " " };
            string[] unprocessedNums = text.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            List<double> negatives = new List<double>();

            List<double> processedValues = new List<double>();

            for(var i = 0; i < unprocessedNums.Length; i++)
            {
                double tempNum;
                if (double.TryParse(unprocessedNums[i], out tempNum))
                {
                    if (tempNum>= 0)
                    {
                        processedValues.Add(tempNum);
                    } 
                    else if (tempNum < 0)
                    {
                        negatives.Add(tempNum);
                    }
                }
                else
                {
                    processedValues.Add(0);
                }
            }

            if (negatives.Count > 0)
            {
                string values = "";
                foreach(var neg in negatives)
                {
                    values += $"{neg} ";
                }
                string message = "Negative values are not allowed, please see the following values that were entered: " + values;
                throw new Exception(message);
            }
            return processedValues;
        }
    }
}