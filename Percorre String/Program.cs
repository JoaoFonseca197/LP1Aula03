using System;

namespace Percorre_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string str,cInString;
            char c;

            //pedir ao utilizador string
            Console.Write("Insira uma string:");
            str = Console.ReadLine();

            //pedir ao utilizador caracter
            Console.Write("Insira um carater:");
            cInString = Console.ReadLine();
            c = Convert.ToChar(cInString);

            //percorrer a string
            foreach(char cDaStr in str)
                if(cDaStr != c)
                {
                    Console.Write(cDaStr);
                }
            // imprimir string sem caracter

            Console.WriteLine();
        }
    }
}
