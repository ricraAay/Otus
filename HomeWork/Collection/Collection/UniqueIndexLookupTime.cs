using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Collection
{
    static internal class UniqueIndexLookupTime
    {
        static internal string Execute(List<int> collection, int value)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();
            
            for(int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    break;
                }
            }

            stopwatch.Stop();

            result.AppendFormat("Время поиска элемента {0} в коллекции List<int> = {1}", value, StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }

        static internal string Execute(ArrayList collection, int value)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            for (int i = 0; i < collection.Count; i++)
            {
                if (Convert.ToInt32(collection[i]) == value)
                {
                    break;
                }
            }

            stopwatch.Stop();

            result.AppendFormat("Время поиска элемента {0} в коллекции ArrayList = {1}", value, StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }

        static internal string Execute(LinkedList<int> collection, int value)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            int count = 0;

            for (var node = collection.First; node != null; node = node.Next, count++)
            {
                if (value.Equals(node.Value))
                {
                    break;
                }
            }

            stopwatch.Stop();

            result.AppendFormat("Время поиска элемента {0} в коллекции LinkedList<int> = {1}", value, StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }
    }
}
