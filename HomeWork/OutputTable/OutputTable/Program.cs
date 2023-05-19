using Microsoft.VisualBasic;

namespace Otus.HomeWork.OutputTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandHelper.Execute(out int tableDimension, out string text, out int padding, out int width );

            // Максимальный индекс для первой строки (+ 2 границы)
            int maxIndexFirstColumn = padding * 2 + 2;
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