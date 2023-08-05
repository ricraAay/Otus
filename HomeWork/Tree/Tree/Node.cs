namespace Otus.HomeWork.Tree
{
    public class Node : INode
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public INode Left { get; set; }

        public INode Right { get; set; }

        public Node (string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
