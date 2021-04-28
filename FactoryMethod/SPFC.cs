using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SPFC : ITeam
    {
        public void ChosenTeam()
        {
            Console.WriteLine("O São Paulo foi sorteado no grupo");
        }
    }
}
