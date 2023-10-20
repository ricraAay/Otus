using System.Collections.Immutable;

namespace Otus.HomeWork.Home
{
    public class Part1
    {
        public  ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> poem)
        {
            Poem = poem.Add("Вот дом,\nКоторый построил Джек.");
        }
    }
}
