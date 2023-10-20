using System.Collections.Immutable;

namespace Otus.HomeWork.Home
{
    public class Part4
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> poem)
        {
            Poem = poem.Add("Вот кот,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.");
        }
    }
}
