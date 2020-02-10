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
            myDinosaur.DinosaurCreations();

            Robot myRobot = new Robot();
            myRobot.RobotCreations();

            Herd myHerd = new Herd();
            myHerd.AddDinosaurs();

            Fleet myFleet = new Fleet();
           

            Battlefield battlefield = new Battlefield();
            battlefield.RunBattle();
        }
    }
}
