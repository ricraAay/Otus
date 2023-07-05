namespace Otus.HomeWork.Planet.num.two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planetCatalog = new PlanetCatalog();

            var planets = new List<PlanetCatalogValue>()
            {
                planetCatalog.GetPlanet("Земля"),
                planetCatalog.GetPlanet("Лимония"),
                planetCatalog.GetPlanet("Марс")
            };

            planets.ForEach(planet =>
            {
                if (planet.ErrorMessage == null) 
                { 
                    Console.WriteLine($"Наименование: {planet.Name}\nПорядковый номер: {planet.Number}\n");
                } 
                else
                {
                    Console.WriteLine(planet.ErrorMessage);
                }
            });
        }
    }
}