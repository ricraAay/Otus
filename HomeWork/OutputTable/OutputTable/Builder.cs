namespace Otus.HomeWork.OutputTable
{
    /// <summary>
    /// Класс для формирования строк таблицы
    /// </summary>
    #region Builder
    static public class Builder
    {
        /// <summary>
        /// Метод формирования первой строки
        /// </summary>
        /// <param name="padding">Отступы</param>
        /// <param name="idx">Индекс текущей итерации</param>
        /// <param name="text">Текст пользователя</param>
        static public void Execute(int padding, int idx, string text)
        {
            // Получение пустой рамки
            string border = StringHelper.GetBorder(Constants.Space, padding == 0 ? 1 : padding);
            // Формирование текста с отступами 
            string stringWithText = border + text + border;

            if (idx == padding)
            {
                StringHelper.ToWrite(stringWithText);
            } else if (padding == 0)
            {
                StringHelper.ToWrite(stringWithText);
            }
            else
            {
                StringHelper.ToWrite(StringHelper.GetBorder(Constants.Space, stringWithText.Length));
            }
        }

        /// <summary>
        /// Метод формирования второй строки
        /// </summary>
        /// <param name="width">Ширина таблицы</param>
        /// <param name="idx">Индекс текущей итерации</param>
        static public void Execute(int width, int idx)
        {
            // Получение горизонтальной рамки
            string primaryRow = StringHelper.GetBorder(Constants.Horizontal, width);

            // Преобразование горизонтальной рамки в массив символов с последующей заменной
            char[] whiteSymbols = primaryRow.ToCharArray()
                .Select((v, i) => i % 2 == 0 ? Convert.ToChar(Constants.Space) : Convert.ToChar(Constants.Horizontal))
                .ToArray();

            // Преобразование горизонтальной рамки в массив символов с последующей заменной
            char[] blackSymbols = primaryRow.ToCharArray()
                .Select((v, i) => i % 2 == 0 ? Convert.ToChar(Constants.Horizontal) : Convert.ToChar(Constants.Space))
                .ToArray();

            if (idx % 2 == 0)
            {
                StringHelper.ToWrite(string.Concat(blackSymbols));
            }
            else
            {
                StringHelper.ToWrite(string.Concat(whiteSymbols));
            }
        }

        /// <summary>
        /// Метод формирования третьей строки
        /// </summary>
        /// <param name="height">Высота таблицы</param>
        /// <param name="width">Ширина таблицы</param>
        /// <param name="idx">Индекс текущей итерации</param>
        static public void Execute(int height, int width, int idx)
        {
            // Высота рамки
            int borderHeight = 1;
            // Получение пустой рамки
            string secondaryRow = StringHelper.GetBorder(Constants.Space, width);
            // Преобразования строки в массив символов
            char[] mainSymbols = secondaryRow.ToCharArray();
            // Определение первого индекса для каждой строки
            int firstSymbolIdx = height - idx - borderHeight;
            // Определение второго индекса для каждой строки
            int lastSymbolIdx = mainSymbols.Length - firstSymbolIdx - borderHeight;
            // Подстановка разделителя для текущей строки
            mainSymbols[firstSymbolIdx] = mainSymbols[lastSymbolIdx] = Convert.ToChar(Constants.Horizontal);

            StringHelper.ToWrite(string.Concat(mainSymbols));
        }
    }
    #endregion
}
