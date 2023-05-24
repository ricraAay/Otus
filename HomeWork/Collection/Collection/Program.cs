using System.Collections;

namespace Otus.HomeWork.Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bufferTimesResult = new List<string>();

            const int MILLION = 1000000;
            const int INDEX = 496753;
            const int MULTIPLE = 777;

            List<int> list = new List<int>();
            ArrayList arrayList = new ArrayList();
            LinkedList<int> linkedList = new LinkedList<int>();

            string timeForList = CompleteTheCollection.Execute(ref list , MILLION);
            string timeForArrayList = CompleteTheCollection.Execute(ref arrayList, MILLION);
            string timeForLinkedList = CompleteTheCollection.Execute(ref linkedList, MILLION);

            string timeForListUniqueIndexLookup = UniqueIndexLookupTime.Execute(list, INDEX);
            string timeForArrayListUniqueIndexLookup = UniqueIndexLookupTime.Execute(arrayList, INDEX);
            string timeForLinkedListUniqueIndexLookup = UniqueIndexLookupTime.Execute(linkedList, INDEX);

            string timeForListMultipleSearch = MultipleSearch.Execute(list, MULTIPLE);
            string timeForArrayListMultipleSearch = MultipleSearch.Execute(arrayList, MULTIPLE);
            string timeForLinkedListMultipleSearch = MultipleSearch.Execute(linkedList, MULTIPLE);

            bufferTimesResult.AddRange(new string[] 
            { 
                timeForList, 
                timeForArrayList, 
                timeForLinkedList, 
                timeForListUniqueIndexLookup, 
                timeForArrayListUniqueIndexLookup, 
                timeForLinkedListUniqueIndexLookup,
                timeForListMultipleSearch,
                timeForArrayListMultipleSearch,
                timeForLinkedListMultipleSearch
            });

            Console.WriteLine(string.Join("\n", bufferTimesResult));
        }
    }
}