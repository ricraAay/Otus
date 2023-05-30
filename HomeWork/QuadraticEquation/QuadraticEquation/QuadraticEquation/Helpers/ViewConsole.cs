using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Otus.HomeWork.QuadraticEquation
{
    static internal class ViewConsole
    {
        static private readonly string _border = new StringBuilder()
           .Insert(0, "-", 50)
           .ToString();

        static internal string InputData(string message)
        {
            Console.Write(message);
            return Console.ReadLine();    
        }

        static internal void OutputData(string message)
        {
            Console.WriteLine(_border);
            Console.WriteLine($"{message}");
            Console.WriteLine(_border);
        }

        static internal void OutputData(string message, IDictionary data)
        {
            List<string> dataParams = new List<string>();

            foreach (DictionaryEntry item in data)
            {
                dataParams.Add($"{item.Key} = {item.Value}");
            }

            Console.WriteLine(_border);
            Console.WriteLine(string.Format("{0}\n{1}", message, string.Join("\n", dataParams.ToArray())));
            Console.WriteLine(_border);
        }

        static internal void OutputData(Dictionary<string, double> data)
        {
            List<string> dataParams = new List<string>();

            foreach (var item in data)
            {
                dataParams.Add($"{item.Key} = {item.Value}");
            }

            Console.WriteLine(string.Join("\n", dataParams.ToArray()));
        }
    }
}
