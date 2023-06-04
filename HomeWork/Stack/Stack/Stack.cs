namespace Otus.HomeWork.Stack
{

    public class Stack
    {   
        /// <summary>
        /// Модель объекта стека
        /// </summary>
        private class StackItem
        {
            /// <summary>
            /// Текущий элемент стека
            /// </summary>
            public string? Value { get; set; }

            /// <summary>
            /// Ссылка на предыдущий элемент стека
            /// </summary>
            public StackItem? Previous { get; set; }

            public StackItem(string? value, StackItem? previous)
            {
                this.Value = value;
                this.Previous = previous;
            }
        }

        /// <summary>
        /// Стек
        /// </summary>
        private List<StackItem> Collection = new List<StackItem>();

        public Stack(params string[] args)
        {
            this.Collection.AddRange(args.Select(value => new StackItem(value, this.StackItemTop)));
        }

        /// <summary>
        /// Верхний элемент из стека
        /// </summary>
        private StackItem? StackItemTop => this.Size > 0 
            ? this.Collection[this.Size - 1] 
            : null;

        /// <summary>
        /// Значение верхнего элемента из стека
        /// </summary>
        public string? Top  => this.StackItemTop != null 
            ? this.StackItemTop.Value 
            : null;

        /// <summary>
        /// Количество элементов из Стека
        /// </summary>
        public int Size => this.Collection.Count;

        /// <summary>
        /// Добавление элемента в стек
        /// </summary>
        /// <param name="value">Строка</param>
        public void Add(string value)
        {
            this.Collection.Add(new StackItem(value, this.StackItemTop));
        }

        /// <summary>
        /// Удаление последнего элемента
        /// </summary>
        /// <returns>Значение удаляемого элемента из стека</returns>
        public string Pop()
        {
            if (this.Size == 0)
            {
                throw new Exception("Стек пустой");
            }

            var value = this.Top;

            this.Collection.RemoveAt(this.Size - 1);

            return value;
        }

        /// <summary>
        /// Статический метод для объединения стеэка
        /// </summary>
        /// <param name="args">Неограниченное кол-во экземпляров стека</param>
        /// <returns>Новый экземпляр стека</returns>
        public static Stack Concat(params Stack[] args)
        {
            var result = new Stack();

            foreach(var arg in args)
            {
                while (arg.Size > 0)
                {
                    result.Add(arg.Pop());
                }
            }

            return result;
        }

    }
}
