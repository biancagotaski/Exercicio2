using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {5, 4, 3, 6, 2, 1};
            Program.Ordena(array);

            foreach (var numero in array)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }

        public static void Ordena(int[] array)
        {
            bool trocou;
            int rodada = 1;
            do
            {
                trocou = false;

                for (int i = 0; i < (array.Length - rodada); i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Troca(array, i, i + 1);
                        trocou = true;
                    }
                }

                rodada++;
            }
            while (trocou);
        }

        private static void Troca(int[] array, int pos1, int pos2)
        {
            int temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }
    }
}
