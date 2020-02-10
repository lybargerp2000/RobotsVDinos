using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    public class Battlefield
 
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

        public void BattleOutcome(int DinoAttackPWR, int RoboAttackPWR)
        {
            Console.WriteLine(DinoAttackPWR);
            Console.WriteLine(RoboAttackPWR);
            if (DinoAttackPWR  > RoboAttackPWR)
            {
             RoboHealth--;
            }
            else if (RoboAttackPWR  > DinoAttackPWR)
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
                int DinoAttackPWR = Fight(1, 10);
                int RoboAttackPWR = Fight(1, 10);
                BattleOutcome(DinoAttackPWR , RoboAttackPWR);
            }



            DeclareWinner();
            Console.ReadLine();



        }   }
}
