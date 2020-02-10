using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    class Battlefield
 
    {
        int DinoHealth;
        int RoboHealth;
        Random fight = new Random();
        public Battlefield ()
        {
            DinoHealth = 10;
            RoboHealth = 10;
        }
        public int Fight(int min, int max)
        {
            int num = fight.Next(min, max);
            return num;
        }

        public void BattleOutcome(int DinoDo, int RoboDo)
        {
            Console.WriteLine(DinoDo);
            Console.WriteLine(RoboDo);
            if (DinoDo > RoboDo)
            {
             RoboHealth--;
            }
            else if (RoboDo > DinoDo)
            {
             DinoHealth--;
            }
        }
        public void DeclareWinner()
        {
            if (DinoHealth > RoboHealth)
            {
                Console.WriteLine("Dinosaur is Winner!");
            }
            else if (RoboHealth  > DinoHealth)
            {
                Console.WriteLine("Robot is Winner!");
            }




        }

        public void RunBattle()
        {
            while (DinoHealth < 0 && RoboHealth < 0)
            {
                int DinoDo = Fight(1, 10);
                int RoboDo = Fight(1, 10);
                BattleOutcome(DinoDo, RoboDo);
            }



            DeclareWinner();
            Console.ReadLine();



        }   }
}
