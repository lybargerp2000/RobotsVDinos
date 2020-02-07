using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    class Battlefield
 
    {
        int DinoScore;
        int RoboScore;
        Random fight = new Random();
        public Battlefield ()
        {
            DinoScore = 0;
            RoboScore = 0;
        }
        public int Fight(int min, int max)
        {
            int num = fight.Next(min, max);
            return num;
        }

        public void BattleOutcome(int DinoDo, int RoboDo)

    }
}
