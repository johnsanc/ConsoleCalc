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
            string basePattern = @"([^\s,\\n]*)";
            Regex splitter = new Regex(basePattern);
            var unprocessedNums = splitter.Split(text).Where(s => s != String.Empty);
            
            string[] unprocessedNumsArr = unprocessedNums.ToArray();
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
                    // else if (tempNum > 1000)
                    // {
                    //     processedValues.Add(0);
                    // } 
                    else if (tempNum < 0)
                    {
                        negatives.Add(tempNum);
                    }
                }
                // else
                // {
                //     processedValues.Add(0);
                // }
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