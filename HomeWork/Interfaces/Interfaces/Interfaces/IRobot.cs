using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HomeWork.Interfaces
{
    public interface IRobot
    {
        /// <summary>
        /// Получение данных
        /// </summary>
        public string GetInfo();

        /// <summary>
        /// Получение коллекции компонентов
        /// </summary>
        public List<string> GetComponents();

        /// <summary>
        /// Получение типа робота
        /// </summary>
        public string GetRobotType() => "I am a simple robot.";
    }
}
