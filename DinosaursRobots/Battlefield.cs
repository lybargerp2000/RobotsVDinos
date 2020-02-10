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
            DinoHealth = 30;
            RoboHealth = 30;
        }
        public int Fight(int min, int max)
        {
            int num = fight.Next(min, max);
            return num;
        }

        public void BattleOutcome(int Herd, int Fleet)
        {
            Console.WriteLine(Herd);
            Console.WriteLine(Fleet);
            if (Herd > Fleet)
            {
             RoboHealth--;
            }
            else if (Fleet > Herd)
            {
             DinoHealth--;
            }
        }
        public void DeclareWinner()
        {
            if (DinoHealth > RoboHealth)
            {
                Console.WriteLine("Dinosaurs Win!");
            }
            else if (RoboHealth  > DinoHealth)
            {
                Console.WriteLine("Robots Win!");
            }




        }

        public void RunBattle()
        {
            while (DinoHealth > 0 && RoboHealth > 0)
            {
                int Herd = Fight(1, 10);
                int Fleet = Fight(1, 10);
                BattleOutcome(Herd, Fleet);
            }



            DeclareWinner();
            Console.ReadLine();



        }   }
}
