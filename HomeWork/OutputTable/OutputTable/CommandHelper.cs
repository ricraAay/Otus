namespace Otus.HomeWork.OutputTable
{
    /// <summary>
    /// Статический класс для взаимодействия пользователя с консолью приложения
    /// </summary>
    #region CommandHelper
    static internal class CommandHelper
    {
        /// <summary>
        /// Статический метод для получения размерности таблицы от пользователя
        /// </summary>
        /// <param name="value">Возвращаемое значение</param>
        static internal void GetTableDimension(out int value)
        {
            Console.Write("Введите размерность таблицы: ");

            string? outputUserText = Console.ReadLine();

            if (int.TryParse(outputUserText, out int number))
            {
                if (number >= 1 && number <= 6)
                {
                    value = number;
                    return;
                }
            }

            GetTableDimension(out value);
        }
        /// <summary>
        /// Статический метод для получения произвольного текста от пользователя
        /// </summary>
        /// <param name="value">Возвращаемое значение</param>
        static internal void GetText(out string value)
        {
            Console.Write("Введите произвольный текст: ");

            string? outputUserText = Console.ReadLine();

            if (outputUserText.Trim() != string.Empty)
            {
                value = outputUserText.Trim();
                return;
            }

            GetText(out value);
        }
    }
    #endregion
}
