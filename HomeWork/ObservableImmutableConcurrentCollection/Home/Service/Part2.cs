using System.Collections.Immutable;

namespace Otus.HomeWork.Home
{
    public class Part2
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> poem)
        {
            Poem = poem.Add("А это пшеница,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек."); ;
        }
    }
}
