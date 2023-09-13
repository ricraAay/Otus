namespace Otus.HomeWork.OtusDictionary
{
    public class Entry
    {
        /// <summary>
        /// Ключ
        /// </summary>
        public int Key { get; set; }
        
        /// <summary>
        /// Значение
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Хэш-код
        /// </summary>
        public int HashCode { get; set; }
    }
}
