namespace Otus.HomeWork.Tree
{
    public interface ITreeFillNode
    {
        /// <summary>
        /// Заполнение узлов корня дерева
        /// </summary>
        /// <param name="root">Узел</param>
        /// <param name="node">Добавляемый узел</param>
        void FillNode(INode root, INode node);
    }
}

