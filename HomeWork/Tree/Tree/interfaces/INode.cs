namespace Otus.HomeWork.Tree
{
    /// <summary>
    /// Узел дерева
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ЗП сотрудника
        /// </summary>
        int Value { get; set; }

        /// <summary>
        /// Левый узел
        /// </summary>
        INode Left { get; set; }
     
        /// <summary>
        /// Правый узел
        /// </summary>
        INode Right { get; set; }
    }
}
