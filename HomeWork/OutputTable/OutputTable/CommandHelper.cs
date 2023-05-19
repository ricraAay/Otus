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
        /// <summary>
        /// Статический метод для получения необходимых параметров для построения таблицы
        /// </summary>
        /// <param name="value">Размерность таблицы</param>
        /// <param name="text">Текст</param>
        /// <param name="padding">Размер отступа</param>
        /// <param name="width">Ширина всей таблицы</param>
        static internal void Execute(out int value, out string text, out int padding, out int width)
        {
            // Получение размерности таблицы
            GetTableDimension(out int _value);
            // Получение размерности текста
            GetText(out string _text);

            // Отсупы с каждой стороны, (размерность таблицы - 1)
            int _padding = _value - 1;
            // Ширина таблицы
            int _width = _padding * 2 + _text.Length;
            // Максимальная ширина таблицы
            int _maxWidth = 40;

            if (_width <= _maxWidth)
            {
                value = _value;
                text = _text;
                padding = _padding;
                width = _width;
                return;
            }

            Console.WriteLine($"Ширина таблицы = {_width}, что привышает {_maxWidth} символов\nУменьшите размерность таблицы или размерность текста!");

            Execute(out value, out text, out padding, out width);

        }
    }
    #endregion
}
