namespace Otus.HomeWork.Tree
{
    public interface ITreeFill
    {
        /// <summary>
        /// Заполнение дерева
        /// </summary>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="value">ЗП сотрудника</param>
        void Fill(string name, int value);
    }
}
