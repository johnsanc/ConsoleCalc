using System.Collections.Generic;
namespace Program
{
    public static class InputParser
    {
        public static List<double> ParseTextToDouble(string text)
        {
            string[] unprocessedNums = text.Split(',');
            List<double> processedValues = new List<double>(2);

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