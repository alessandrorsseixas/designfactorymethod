using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ITeam TeamChoice(string team)
        {
            switch (team)
            {
                case "Bahia":return new Bahia();
                case "SPFC": return new SPFC();
                case "Boca": return new BocaJuniors();
                case "River": return new Bahia();
                default:return null;
            }
        }

    }
}
