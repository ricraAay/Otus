namespace Otus.HomeWork.Planet.num.one
{
    public class Program
    {
        static void Main(string[] args)
        {
            var veneraFirst = new
            {
                Name = "Венера",
                Number = 2,
                EquatorLength = 34000,
                PreviousPlanet = new { }
            };

            var earth = new
            {
                Name = "Земля",
                Number = 3,
                EquatorLength = 34000,
                PreviousPlanet = veneraFirst
            };

            var mars = new
            {
                Name = "Марс",
                Number = 4,
                EquatorLength = 34000,
                PreviousPlanet = earth
            };

            var veneraSecond = new
            {
                Name = "Венера",
                Number = 4,
                EquatorLength = 34000,
                PreviousPlanet = mars
            };

            List<dynamic> planets = new List<dynamic>() { veneraFirst, earth, mars, veneraSecond };

            planets.ForEach(planet => {
                var format = "Назвение: {0}\nПорядковый номер от Солнца: {1}\nДлина экватора: {2}\nЭквивалентна Венере: {3}\n";

                var result = string.Format(format, planet.Name, planet.Number, planet.EquatorLength, Object.Equals(planet, veneraFirst));

                Console.WriteLine(result);
            });
        }
    }
}