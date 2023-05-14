using System.Text;

namespace Otus.HomeWork.OutputTable
{
    /// <summary>
    /// Статический класс для формирования строки
    /// </summary>
    #region StringHelper
    static internal class StringHelper
    {
        /// <summary>
        /// Формирование строки
        /// </summary>
        /// <param name="symbol">Текст</param>
        /// <param name="numRepeat">Количетво повторений</param>
        /// <returns></returns>
        static internal string GetBorder(string symbol, int numRepeat)
        {
            return new StringBuilder()
                .Insert(0, symbol, numRepeat)
                .ToString();
        }
        /// <summary>
        /// Вывод текста в консоль
        /// </summary>
        /// <param name="text">Текст</param>
        static internal void ToWrite(string text)
        {
            Console.WriteLine("{0}{1}{2}", Constants.Horizontal, text, Constants.Horizontal);
        }
    }
    #endregion
}
