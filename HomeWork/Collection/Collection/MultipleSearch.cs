using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    static internal class MultipleSearch
    {
        static internal string Execute(List<int> collection, int multiple)
        {
            List<int> foundValues = new List<int>();
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] % multiple == 0)
                {
                    foundValues.Add(collection[i]);
                }
            }

            stopwatch.Stop();

            result.AppendFormat("Время поиска чисел [{0}]\nкратных {1} = {2} в коллекции List<int>",
                string.Join(", ", foundValues), multiple, 
                StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }

        static internal string Execute(ArrayList collection, int multiple)
        {
            List<int> foundValues = new List<int>();
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            for (int i = 0; i < collection.Count; i++)
            {
                if (Convert.ToInt32(collection[i]) % multiple == 0)
                {
                    foundValues.Add(Convert.ToInt32(collection[i]));
                }
            }

            stopwatch.Stop();

            result.AppendFormat("Время поиска чисел [{0}]\nкратных {1} = {2} в коллекции ArrayList",
                string.Join(", ", foundValues), multiple,
                StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }

        static internal string Execute(LinkedList<int> collection, int multiple)
        {
            List<int> foundValues = new List<int>();
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            int count = 0;

            for (var node = collection.First; node != null; node = node.Next, count++)
            {
                if (node.Value % multiple == 0)
                {
                    foundValues.Add(Convert.ToInt32(node.Value));
                }
            }

            stopwatch.Stop();

            result.AppendFormat("Время поиска чисел [{0}]\nкратных {1} = {2} в коллекции LinkedList<int>",
                string.Join(", ", foundValues), multiple,
                StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }
    }
}
