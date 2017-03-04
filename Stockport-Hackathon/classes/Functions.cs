using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIXULib;

using System.IO;

namespace Stockport_Hackathon.classes
{
    static class Functions
    {
        /// <summary>
        /// take a CSV file and return it split into matrix form
        /// </summary>
        /// <param name="csvFile"></param>
        /// <returns></returns>
        public static List<List<string>> CSVPopulateMatrix(string csvFile)
        {
            List<List<string>> matrix = new List<List<string>>();

            using (var fs = File.OpenRead(csvFile))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    List<string> lineData = new List<string>();
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    for (int i = 0; i < values.Length; i++)
                    {
                        lineData.Add(values[i]);
                    }
                    matrix.Add(lineData);
                }
            }

            return matrix;
        }
    }
}
