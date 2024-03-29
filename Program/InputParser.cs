using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;
namespace Program
{
    public static class InputParser
    {
        public static List<double> ParseTextToDouble(string text, params string[] options)
        {
            List<string> delimList = new List<string> { "\\n", "\n", ",", " " };
            foreach(var delim in options)
            {
                delimList.Add(delim);
            }
            string[] delimeters = delimList.ToArray();

            string[] unprocessedNumsArr = text.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            List<double> negatives = new List<double>();
            List<double> processedValues = new List<double>();

            for(var i = 0; i < unprocessedNumsArr.Length; i++)
            {
                double tempNum;
                if (double.TryParse(unprocessedNumsArr[i], out tempNum))
                {
                    if (tempNum>= 0 && tempNum <= 1000)
                    {
                        processedValues.Add(tempNum);
                    }
                    else if (tempNum < 0)
                    {
                        negatives.Add(tempNum);
                    }
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