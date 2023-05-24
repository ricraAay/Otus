using System.Text;

namespace Collection
{
    static internal class StringHelper
    {
        static internal string GetConvertTime(TimeSpan ts)
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);

            return result.ToString();
        }
    }
}
