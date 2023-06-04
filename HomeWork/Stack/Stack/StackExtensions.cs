namespace Otus.HomeWork.Stack
{
    public static class StackExtensions
    {
        /// <summary>
        /// Метод расширения
        /// </summary>
        /// <param name="self">Текущий экземпляр класса Stack</param>
        /// <param name="stack">Экземпляр класса Stack</param>
        public static void Merge(this Stack self, Stack stack) 
        {
            while(stack.Size > 0)
            {
                self.Add(stack.Pop());
            }
        }
    }
}
