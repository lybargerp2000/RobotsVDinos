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
            Dinosaur dinosaur = new Dinosaur();
            myHerd.AddDinosaur(dinosaur);


            Fleet myFleet = new Fleet();
            Robot robot = new Robot();
            myFleet.AddRobot(robot);

           

            Battlefield battlefield = new Battlefield();
            battlefield.RunBattle();
        }
    }
}
