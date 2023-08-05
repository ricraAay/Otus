namespace Otus.HomeWork.Tree
{
    public interface ITreeFind
    {
        /// <summary>
        /// Поиск по дереву
        /// </summary>
        /// <param name="node">Узел</param>
        /// <param name="value">Значение для поиска</param>
        void Find(INode node, int value);
    }
}
