using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinosaur  myDinosaur = new Dinosaur();
            myDinosaur.DinosaursCreations();

            Robot myRobot = new Robot();
            myRobot.RobotCreations();

            Herd myHerd = new Herd();
            myHerd.AddDinosaursHerd(); 

        }
    }
}
