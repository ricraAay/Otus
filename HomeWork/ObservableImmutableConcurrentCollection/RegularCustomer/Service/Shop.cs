using System.Collections.ObjectModel;

namespace Otus.HomeWork.RegularCustomer
{ 
    public class Shop
    {
        public ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public void Add(string name)
        {
            Items.Add(new Item { Id = Items.Count(), Name = name });
        }

        public void Remove(int id)
        {
            var item = Items.Where(x => x.Id == id).FirstOrDefault();

            if (item != null)
            {
                Items.Remove(item);
            }
        }
    }
}
