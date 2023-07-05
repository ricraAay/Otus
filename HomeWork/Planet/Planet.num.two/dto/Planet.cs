namespace Otus.HomeWork.Planet.num.two
{
    public class Planet
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Длина эквартора
        /// </summary>
        public double EquatorLength { get; set; }

        /// <summary>
        /// Ссылка на предыдущую планету
        /// </summary>
        public Planet? PreviousPlanet { get; set; }
    }
}
