using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    public class Fleet
    {

        public List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();

        }
        public void AddRobot(Robot robot)
        {
            robots.Add(robot);
            robots.Add(robot);
            robots.Add(robot);
        }

   
    }


}
