using System;

namespace NpcPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            Perks[] perks;
            string aux;
            int numNPCs;
            //pedir ao user o numero de npcs
            Console.WriteLine("Insira nº de NPCs:");
            aux = Console.ReadLine();
            numNPCs = Convert.ToInt32(aux);
            perks = new Perks[NpcPerks];
            //para cada npc pedir caracteristicas (guardar num array)
            for(int i = 0 ; i< numNPCs ; i++)
            {
                Console.Write($"NPC {i} tem Stealh (s/n)?");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Stealh;
                }
                 Console.Write($"NPC {i} tem Combat (s/n)?");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Combat;
                }
                 Console.Write($"NPC {i} tem Lockpick (s/n)?");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Lockpick;
                }
                 Console.Write($"NPC {i} tem Luck (s/n)?");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Luck;
                }
            }
            //mostrar no ecra
            Console.WriteLine();

            for (int i= 0; i < numNPCs; i++)
            {
                Perks p = Perks.Combat | Perks.Luck;
                Console.WriteLine($"Perks do NPC {i}: {perks[i]}");

                if( perks[i] & p==p)
                {
                    Console.WriteLine("\t You shall win all fights");
                }
            }
        }
    }
}
