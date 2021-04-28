using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RiverPlate : ITeam
    {
        public void ChosenTeam()
        {
            Console.WriteLine("O RiverPlate foi sorteado no grupo");
        }
    }
}
