namespace Otus.HomeWork.Planet.num.three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> validatorMaxCall = (counter) => counter == 0;
            Func<string, bool> validatorName = (name) => name == "Лимония";

            var planetCatalog = new PlanetCatalog();

            var planets = new List<PlanetCatalogValue>()
            {
                planetCatalog.GetPlanet("Лимония", validatorMaxCall, validatorName),
                planetCatalog.GetPlanet("Венера", validatorMaxCall, validatorName),
                planetCatalog.GetPlanet("Земля", validatorMaxCall, validatorName),
                planetCatalog.GetPlanet("Марс", validatorMaxCall, validatorName)
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