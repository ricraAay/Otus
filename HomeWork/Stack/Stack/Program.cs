namespace Otus.HomeWork.Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack("a", "b", "c");
                // size = 3, Top = 'c'
                Console.WriteLine($"size = {stack.Size}, Top = '{stack.Top}'");

                var deleted = stack.Pop();
                // Извлек верхний элемент 'c' Size = 2
                Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {stack.Size}");
                
                stack.Add("d");
                // size = 3, Top = 'd'
                Console.WriteLine($"size = {stack.Size}, Top = '{stack.Top}'");

                stack.Pop();
                stack.Pop();
                stack.Pop();
                // size = 0, Top = null
                Console.WriteLine($"size = {stack.Size}, Top = {(stack.Top == null ? "null" : stack.Top)}");    

                stack.Pop();

                stack.Add("d");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            var stackMerge = new Stack("a", "b", "c");
            stackMerge.Merge(new Stack("1", "2", "3"));
            // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний
            Console.WriteLine(stackMerge.Top);


            var stackConcat = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
            // в стеке s теперь элементы - "c", "b", "a" "3", "2", "1", "В", "Б", "А" <- верхний
            Console.WriteLine(stackConcat.Top);                                                                           
        }
    }
}