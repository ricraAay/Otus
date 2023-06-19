using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.HomeWork.Interfaces
{
    public interface IFlyingRobot : IRobot
    {
        public new string GetRobotType() => "I am a flying robot.";
    }
}
