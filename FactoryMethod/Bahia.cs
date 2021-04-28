using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Bahia : ITeam
    {
        public void ChosenTeam()
        {
            Console.WriteLine("O Bahia foi sorteado no grupo");
        }
    }
}
