namespace Otus.HomeWork.Planet.num.two
{
    public class PlanetCatalog
    {
        /// <summary>
        /// Каталог планет
        /// </summary>
        private List<Planet> _catalog;

        /// <summary>
        /// Максимальное количество запросов
        /// </summary>
        private int _maxCounter = 3;

        public PlanetCatalog()
        {
            this._catalog = new List<Planet>()
            {
                new Planet()
                { 
                    Name = "Венера", 
                    Number = 2, 
                    EquatorLength = 24535 
                },
                new Planet() 
                { 
                    Name = "Земля", 
                    Number = 3, 
                    EquatorLength = 24535 
                },
                new Planet() 
                { 
                    Name = "Марс",
                    Number = 4, 
                    EquatorLength = 24535 
                }
            };
        }

        public PlanetCatalogValue GetPlanet(string name)
        {
            if (--this._maxCounter == 0)
            {
                return new PlanetCatalogValue 
                {
                    Name = null, 
                    Number = null,
                    ErrorMessage = "Вы спрашиваете слишком часто" 
                };
            }

            var findPlanet = this._catalog.Find(planet => planet.Name == name);

            if (findPlanet == null)
            {
                return new PlanetCatalogValue
                {
                    Name = null,
                    Number = null,
                    ErrorMessage = "Не удалось найти планету"
                };
            }

            return new PlanetCatalogValue
            {
                Name = findPlanet.Name,
                Number = findPlanet.Number,
                ErrorMessage = null
            };
        }
    }
}
