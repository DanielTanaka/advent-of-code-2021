using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2021.Helpers
{
    public static class Parser
    {
        public static IReadOnlyList<int> GetIntegerListFromFile(string filePath)
        {
            var integerList = new List<int>();

            if (File.Exists(filePath))
            {
                using (var file = new StreamReader(filePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out var number))
                        {
                            integerList.Add(number);
                        }
                    }

                    file.Close();
                } 
            }
            else
            {
                throw new FileNotFoundException($"Could not find {filePath}");
            }

            return integerList;
        }
    }
}
