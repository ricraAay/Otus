namespace Otus.HomeWork.Interfaces
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents() => this._components;

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public string GetRobotType() => throw new NotImplementedException();

        public string GetInfo() => throw new NotImplementedException();

    }
}
