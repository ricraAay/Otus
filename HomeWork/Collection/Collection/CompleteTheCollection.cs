using System.Collections;
using System.Diagnostics;
using System.Text;

namespace Collection
{
    static internal class CompleteTheCollection
    {

        static internal string Execute(ref List<int> collection, int numberElements)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            for (int i = 1; i <= numberElements; i++)
            {
                collection.Add(i);
            }

            stopwatch.Stop();

            result.AppendFormat("Время заполнения коллекции List<int>: {0}", StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }

        static internal string Execute(ref ArrayList collection, int numberElements)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            for (int i = 1; i <= numberElements; i++)
            {
                collection.Add(i);
            }

            stopwatch.Stop();

            result.AppendFormat("Время заполнения коллекции ArrayList: {0}", StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }

        static internal string Execute(ref LinkedList<int> collection, int numberElements)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder result = new StringBuilder();

            stopwatch.Start();

            for (int i = 1; i <= numberElements; i++)
            {
                collection.AddLast(i);
            }

            stopwatch.Stop();

            result.AppendFormat("Время заполнения коллекции LinkedList<int>: {0}", StringHelper.GetConvertTime(stopwatch.Elapsed));

            return result.ToString();
        }

    }
}
