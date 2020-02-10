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

        public void newDinosaur()
        {
            Dinosaur TRex = new Dinosaur();
            Dinosaur TriCer = new Dinosaur();
            Dinosaur Terry = new Dinosaur();
        }

        public void DinosaurCreations()
        {
            newDinosaur();
            //Console.WriteLine();
            //Console.ReadLine();
        }

    }
}


