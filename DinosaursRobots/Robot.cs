using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    public class Robot
    {
        public string RoboName;
        public int RoboHealth;
        public int RoboPWR;
        public int RoboAttackGunPWR;

        public Robot()
        {
            RoboName = "";
            RoboHealth = 10;
            RoboPWR = 10;
            RoboAttackGunPWR = 10;
        }

        public void newrobot()
        {
            Robot Zor = new Robot();
            Robot Frank = new Robot();
            Robot Keith = new Robot();
        }

        public void RobotCreations()
        {
            newrobot();
            //Console.WriteLine();
            //Console.ReadLine();



        }
    }
}
