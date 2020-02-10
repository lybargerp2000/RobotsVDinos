using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursRobots
{
    public class Herd
    {

        public List<Dinosaur> dinosaurs;

        public Herd()
        {
            dinosaurs = new List<Dinosaur>();

        }
        public void AddDinosaur(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
            dinosaurs.Add(dinosaur);
            dinosaurs.Add(dinosaur);
        }







    }
}
