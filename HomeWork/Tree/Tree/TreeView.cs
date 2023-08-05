namespace Otus.HomeWork.Tree
{
    public class TreeView
    {
        private readonly TreeAction _action;

        public TreeView(TreeAction action)
        {
            this._action = action;
        }

        private void FillTheTree()
        {
            Console.Write("Введите имя сотрудника: ");

            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return;
            }

            Console.Write("Введите зп сотрудника: ");

            var value = Convert.ToInt32(Console.ReadLine());

            this._action.Fill(name, value);

            this.FillTheTree();
        }

        private void Traverse()
        {
            this._action.Traverse(this._action.Root);
        }

        private void Find()
        {
            Console.Write("Укажите размер зарплаты: ");

            this._action.Find(this._action.Root, Convert.ToInt32(Console.ReadLine()));
        }

        private void AskCode(string code)
        {
            if (code == "0")
            {
                this._action.Clear();
                this.Execute();
            }

            if (code == "1")
            {
                Console.WriteLine("\n# Поиск сотрудника по зп");
                this.Find();
            }

            this.AskCode(code);
        }

        public void Execute()
        {
            Console.WriteLine("# Заполнение дерева");
            this.FillTheTree();

            Console.WriteLine("\n# Список сотрудников и их зарплаты в порядке возрастания");
            this.Traverse();

            Console.WriteLine("\n# Поиск сотрудника по зп");
            this.Find();

            Console.WriteLine("\n# Введите 0 - для перехода к началу программы или 1 - для поиска ЗП");
            this.AskCode(Console.ReadLine());
        }
    }
}
