using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    class Herd
    {
       public List<Dinosaur> SuperHerd;

        public Herd()
        {
            SuperHerd = new List<Dinosaur>();

        }
       
       public void AddDinosaurs()
        {
           //List<Dinosaur> SuperHerd = new List<Dinosaur>();

            {
                SuperHerd.Add(TRex);
            }
         
        }
       
        
        
    }
}
