namespace Otus.HomeWork.Tree
{
    public class TreeAction : ITreeRoot, ITreeFill, ITreeFillNode, ITreeFind, ITreeTraverse, ITreeClear
    {
        private INode _root;

        public TreeAction()
        {
            this._root = null;
        }

        public INode Root 
        { 
            get => this._root;
        }

        public void FillNode(INode node, INode newNode)
        {
            if (newNode.Value < node.Value)
            {
                if (node.Left != null)
                {
                    FillNode(node.Left, newNode);
                }
                else
                {
                    node.Left = newNode;
                }
            }
            else
            {
                if (node.Right != null)
                {
                    FillNode(node.Right, newNode);
                }
                else
                {
                    node.Right = newNode;
                }
            }
        }

        public void Fill(string name, int value)
        {
            if (this._root == null)
            {
                this._root = new Node(name, value);
            }
            else
            {
                this.FillNode(this._root, new Node(name, value));
            }
        }

        public void Find(INode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left != null)
                {
                    Find(node.Left, value);
                    return;
                }

                Console.WriteLine("Такой сотрудник не найден");
                return;
            }

            if (value > node.Value)
            {
                if (node.Right != null)
                {
                    Find(node.Right, value);
                    return;
                }

                Console.WriteLine("Такой сотрудник не найден");
                return;
            }

            Console.WriteLine($"{node.Name} - {node.Value}");
            return;
        }

        public void Traverse(INode node)
        {
            if (node.Left != null)
            {
                Traverse(node.Left);
            }

            Console.WriteLine($"{node.Name} - {node.Value}");

            if (node.Right != null)
            {
                Traverse(node.Right);
            }
        }

        public void Clear()
        {
            this._root = null;
        }
    }
}