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
            Console.Write("Insira a string:");
            str = Console.ReadLine();
            //pedir ao utilizador caracter
            Console.Write("Insira a caracter:");
            cInString = Console.ReadLine();
            c = Convert.ToChar(cInString)
            //percorrer a string
            foreach( char cInString in str);
                if(cInString != c)
                {
                    Console.Write(cDastr);
                }
            // imprimir string sem caracter
        }
    }
}
