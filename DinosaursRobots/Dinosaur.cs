using System;
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

        public void TRex()
        {
            DinoType = "TRex";
            DinoHealth = 10;
            DinoEnergy = 10;
            DinoAttackPWR = 10;


            Console.WriteLine(DinoType);
            //Console.WriteLine(DinoHealth);
            //Console.ReadLine();

        }
        public void TriCer()
        {
            DinoType = "TiCer";
            DinoHealth = 10;
            DinoEnergy = 10;
            DinoAttackPWR = 10;


            //Console.WriteLine(DinoType);
            //Console.WriteLine(DinoHealth);
            //Console.ReadLine();

        }
        public void Terry()
        {
            DinoType = "Terry";
            DinoHealth = 10;
            DinoEnergy = 10;
            DinoAttackPWR = 10;


            //Console.WriteLine(DinoType);
            //Console.WriteLine(DinoHealth);
            //Console.ReadLine();

        }

        public void DinosaursCreations()
        {
            TRex();
            TriCer();
            Terry();

            Console.WriteLine();
            Console.ReadLine();
        }


            
      
     
        

        

    }
}
