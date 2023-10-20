using System.Collections.Concurrent;

namespace Otus.HomeWork.Librarian
{
    public class Librrary
    {
        public ConcurrentDictionary<string, int> Books = new ConcurrentDictionary<string, int>();

        public Librrary() 
        {
            new Thread(new ThreadStart(() => Reading())).Start();
        }

        public void Reading()
        {
            while (true)
            {
                if (Books.Count > 0)
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        foreach (var item in Books)
                        {
                            if (item.Value != 100)
                                Books.TryUpdate(item.Key, item.Value + 1, item.Value);
                            else
                                Books.TryRemove(item.Key, out int value);
                        }

                        Thread.Sleep(1000);
                    }
                }                
            }
        }

        public void Add(string name)
        {
            if (!Books.ContainsKey(name))
            {
                Books[name] = 0;
            }
        }
    }
}
