namespace Otus.HomeWork.Tree
{
    public interface ITreeTraverse
    {
        /// <summary>
        /// Перебор дерева
        /// </summary>
        /// <param name="node">Узел</param>
        void Traverse(INode node);
    }
}
