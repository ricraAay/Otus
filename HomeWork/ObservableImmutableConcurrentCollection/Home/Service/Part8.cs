﻿using System.Collections.Immutable;

namespace Otus.HomeWork.Home
{
    public class Part8
    {
        public ImmutableList<string> Poem { get; set; }

        public void AddPart(ImmutableList<string> poem)
        {
            Poem = poem.Add("А это ленивый и толстый пастух,\r\nКоторый бранится с коровницей строгою,\r\nКоторая доит корову безрогую,\r\nЛягнувшую старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.");
        }
    }
}
