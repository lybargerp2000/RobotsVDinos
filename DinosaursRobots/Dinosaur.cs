﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    class Dinosaur
    {
        public string DinoType;
        public int DinoHealth;
        public int DinoEnergy;
        public int DinoAttackPWR;
     
        public Dinosaur()
        {
            DinoType = "";
            DinoHealth = 10;
            DinoEnergy = 10;
            DinoAttackPWR = 10;
        }

        public void CreateTRex()
        {
            DinoType = "TRex";
            DinoHealth = 10;
            DinoEnergy = 10;
            DinoAttackPWR = 10;

            Console.WriteLine();
            Console.ReadLine();

        }
            
      
     
        

        

    }
}
