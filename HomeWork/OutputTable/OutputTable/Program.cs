using Microsoft.VisualBasic;

namespace Otus.HomeWork.OutputTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получение введенной размерности таблицы
            CommandHelper.GetTableDimension(out int tableDimension);
            // Получение введенного слова
            CommandHelper.GetText(out string text);

            // Отсупы с каждой стороны, (размерность таблицы - 1)
            int padding = tableDimension - 1;
            // Ширина таблицы
            int width = padding * 2 + text.Length;
            // Максимальный индекс для первой строки
            int maxIndexFirstColumn = padding * 2;
            // Максимальный индекс для второй строки
            int maxIndexSecondColumn = maxIndexFirstColumn * 2;
            // Максимальный индекс для третьей строки
            int maxIndexThireeColumn = maxIndexSecondColumn + width + 1;

            // Высота таблицы
            int height = maxIndexThireeColumn;

            for (int idx = 0; idx <= height; idx++)
            {
                switch (idx)
                {
                    case int i when i > 0 && i < maxIndexFirstColumn:
                        Builder.Execute(padding, idx, text);
                        break;
                    case int i when i > maxIndexFirstColumn && i < maxIndexSecondColumn:
                        Builder.Execute(width, idx);
                        break;
                    case int i when i > maxIndexSecondColumn && i < maxIndexThireeColumn:
                        Builder.Execute(height, width, idx);
                        break;
                    default:
                        StringHelper.ToWrite(StringHelper.GetBorder(Constants.Horizontal, width));
                        break;
                }
            }
        }
    }
}