using Newtonsoft.Json;

namespace Otus.HomeWork.Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeView(new TreeAction());

            tree.Execute();
        }
    }   
}