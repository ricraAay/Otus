namespace Otus.HomeWork.OtusDictionary
{
    public class OtusDictionary : OtusDictionaryBase
    {
        private Entry[] _entries = new Entry[32];

        public string this[int i]
        {
            get => Get(i);
            set => Add(i, value);
        }

        public void Add(int key, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Значение не должно быть пустым!");
            }

            if (!string.IsNullOrEmpty(Get(key)))
            {
                throw new Exception("Такой ключ уже есть!");
            }

            var hashCode = key % _entries.Length;

            if (_entries[hashCode] != null)
            {
                base.Resize(ref _entries, _entries.Length);
                hashCode = key % _entries.Length;
            }

            _entries[hashCode] = new Entry { Key = key, Value = value, HashCode = hashCode };
        }

        public string Get(int key)
        {
            var findEntry = Array.Find(_entries, (entry) => entry?.Key == key);

            return findEntry?.Value != null ? findEntry.Value : string.Empty;
        }
    }
}
