using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declarar variaveid
           string str;
           int linhas, colunas;
           float [,] matriz;
           float somaDasMedias = 0;

           //Pedir ao useer nº linhas da matriz
           Console.Write("Insira nº de linhas:");
           str = Console.ReadLine();
           linhas = int.Parse(str);

           //pedir ao user num de colunas
            Console.Write("Insira nº de colunas:");
            str = Console.ReadLine();
            colunas = int.Parse(str);

           //inicializar a matriz
           matriz = new float [linhas, colunas];

           //Pedir ao user os valores float para colocar na matriz
           for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Insira valor em ({i}{j}):");
                    str = Console.ReadLine();
                    matriz[i, j] = Convert.ToSingle(str);
                }
            }
            //mostrar matriz e a media para cada linha
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                float soma = 0, media;
                Console.Write("| ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i,j];
                    Console.Write(matriz[i,j]+" ");
                }
                media = soma / matriz.GetLength(1);
                Console.WriteLine($"| -> {media}");
                somaDasMedias += media;
                //Mostrar soma das medias 
                Console.WriteLine("Soma das medias {0,10:f3}",somaDasMedias);
            }
        }
    }
}
