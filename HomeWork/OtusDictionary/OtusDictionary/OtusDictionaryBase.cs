namespace Otus.HomeWork.OtusDictionary
{
    public abstract class OtusDictionaryBase
    {
        /// <summary>
        /// Изменение размера массива
        /// </summary>
        /// <param name="currentEntries">Массив</param>
        /// <param name="sizeEntries">Размер массива</param>
        protected void Resize(ref Entry[] currentEntries, int sizeEntries)
        {
            var newEntries = new Entry[sizeEntries * 2];

            foreach (var entry in currentEntries)
            {
                if (entry != null)
                {
                    entry.HashCode = entry.Key % newEntries.Length;

                    if (newEntries[entry.HashCode] != null)
                    {
                        Resize(ref currentEntries, sizeEntries);
                    }

                    newEntries[entry.HashCode] = entry;
                }
            }

            currentEntries = newEntries;
        }
    }
}
