using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BocaJuniors : ITeam
    {
        public void ChosenTeam()
        {
            Console.WriteLine("O Boca Juniors foi sorteado no grupo");
        }
    }
}
