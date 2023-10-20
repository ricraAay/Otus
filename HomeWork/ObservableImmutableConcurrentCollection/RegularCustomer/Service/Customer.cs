using System.Collections.Specialized;

namespace Otus.HomeWork.RegularCustomer
{
    public class Customer
    {
        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs evn)
        {
            switch (evn.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (evn.NewItems[0] is Item newitem)
                        Console.WriteLine($" - Добавлен новый товар: {newitem.Id} - {newitem.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (evn.OldItems[0] is Item olditem)
                        Console.WriteLine($"\n**** Удален товар: {olditem.Id} - {olditem.Name} ****\n");
                    break;
            }
        }
    }
}
