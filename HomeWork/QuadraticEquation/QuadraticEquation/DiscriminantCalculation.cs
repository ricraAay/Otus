using Otus.HomeWork.QuadraticEquatio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HomeWork.QuadraticEquation
{
    static internal class DiscriminantCalculation
    {
        /// <summary>
        /// Получение данных от пользователя
        /// </summary>
        /// <returns>Справочник введенных значений</returns>
        static internal Dictionary<string, string> GetData()
        {
            return new Dictionary<string, string> { 
                { "a", ViewConsole.InputData("Введите значение a: ") }, 
                { "b", ViewConsole.InputData("Введите значение b: ") }, 
                { "c", ViewConsole.InputData("Введите значение c: ") } 
            };
        }

        /// <summary>
        /// Валидация введенных данных
        /// </summary>
        /// <param name="data">Справочник введенных значений</param>
        static internal void Validity(Dictionary<string, string> data)
        {
            List<MessageError> errorsCollection = new List<MessageError>();

            foreach(var item in data)
            {
                if (!int.TryParse(item.Value, out int number))
                {
                    // Сообщение ошибки
                    string errorMessage = $"Невереный формат параметра: {item.Key}";
                    // Парметры ошибки
                    Dictionary<string, string> errorData = new Dictionary<string, string>() { { item.Key, item.Value } };

                    errorsCollection.Add(new MessageError(errorData, errorMessage));
                }
            }

            if (errorsCollection.Count > 0)
            {
                var errorMessage = errorsCollection.Select(error => error.Message).ToArray();
                var exception = new InvalidParameterFormatException(string.Join("\n", errorMessage));

                var errorData = errorsCollection.Select(error => error.Data);

                foreach(var kvp in errorData) {
                    
                    exception.Data.Add(kvp.FirstOrDefault().Key, kvp.FirstOrDefault().Value);
                }

                throw exception;
            }
        }

        /// <summary>
        /// Расчет квадратного уровнения
        /// </summary>
        /// <param name="data">Справочник введенных значений</param>
        /// <returns>Значение квадратного уровнения</returns>
        static internal Dictionary<string, double> Сalculate(Dictionary<string, string> data)
        {
            int a = Convert.ToInt32(data["a"]);
            int b = Convert.ToInt32(data["b"]);
            int c = Convert.ToInt32(data["c"]);

            double d = Math.Pow(b, 2) - 4 * a * c;

            double x1, x2;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;

                return new Dictionary<string, double>() { { "x1", x1 }, { "x2", x2} };
            }

            if (d == 0)
            {
                return new Dictionary<string, double>() { { "x", d } };
            }

            throw new NoRealValuesException("Вещественных значений не найдено");
        }
    }
}
