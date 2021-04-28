using System;

namespace FactoryMethod
{
    /*
     
     Padrão de Criação
        
    Eu nao posso
    
     
    

    Caracteristicas
    Dispoe de uma interface que cria um objeto , mas são as subclasse que decidem qual classe concreta instanciar.
    Ex Mega Sena
     */
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();
            Console.WriteLine("Bahia|SPFC|Boca Juniors|River Plate");
            Console.WriteLine("");
            Console.WriteLine("A bolinha sorteada foi:");
            string choice = Console.ReadLine();
            ITeam team = factoryMethod.TeamChoice(choice);
            Console.WriteLine("");
            Console.WriteLine("O time está na libertadores:");
            team.ChosenTeam();
            Console.ReadKey();

        }
    }
}
