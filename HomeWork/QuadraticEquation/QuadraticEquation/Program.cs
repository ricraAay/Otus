using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Otus.HomeWork.QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var payload = DiscriminantCalculation.GetData();

                DiscriminantCalculation.Validity(payload);

                var result = DiscriminantCalculation.Сalculate(payload);

                ViewConsole.OutputData(result);

            }
            catch (InvalidParameterFormatException ex)
            {
                FormData(ex.Message, Severity.Error, ex.Data);
                Main(args); // TODO: костыль
            }
            catch (NoRealValuesException ex)
            {
                FormData(ex.Message, Severity.Warning, ex.Data);
            }
        }

        internal static void FormData(string message, Severity severity, IDictionary data)
        {
            switch (severity)
            {
                case Severity.Warning:
                    ThrowWarning(message);
                    break;
                case Severity.Error:
                    ThrowError(message, data);
                    break;
                default:
                    break;
            }
        }

        internal static void ThrowError(string message, IDictionary data)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            ViewConsole.OutputData(message, data);
            Console.ResetColor();
        }

        internal static void ThrowWarning(string message)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            ViewConsole.OutputData(message);
            Console.ResetColor();
        }
    }
}