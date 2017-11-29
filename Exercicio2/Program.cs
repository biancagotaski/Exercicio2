using System;

namespace Exercicio2
{
    class Program
    {
        private ListaPessoas lp = new ListaPessoas();

        public Program()
        {
            Init();
        }

        private void Init()
        {
            lp.AddPessoa(new Pessoa() {Codigo = 0, Idade = 30, Sexo = 'M', Nome = "João", Salario = 3000.0M });
            lp.AddPessoa(new Pessoa() { Codigo = 1, Idade = 25, Sexo = 'M', Nome = "Carlos", Salario = 1000.0M });
            lp.AddPessoa(new Pessoa() { Codigo = 2, Idade = 17, Sexo = 'F', Nome = "Ana", Salario = 5000.0M });
            lp.AddPessoa(new Pessoa() { Codigo = 3, Idade = 35, Sexo = 'F', Nome = "Maria", Salario = 10000.0M });
            lp.AddPessoa(new Pessoa() { Codigo = 4, Idade = 50, Sexo = 'M', Nome = "Antônio", Salario = 4000.0M });
        }

        public void Sort()
        {
            lp.Sort();
        }

        public decimal CalculaMediaSalarioHomens()
        {
            return CalculaMediaSalarialPorSexo('M');

        }

        public decimal CalculaMediaSalarioMulheres()
        {
            return CalculaMediaSalarialPorSexo('F');
        }

        public decimal CalculaMediaSalarialPorSexo(char sexo)
        {
            int totalPessoas = 0;
            decimal totalSalario = 0.0M;

            foreach (var pessoa in lp)
            {
                if (pessoa.Sexo == sexo)
                {
                    totalPessoas++;
                    totalSalario += pessoa.Salario;
                }
            }

            return totalSalario / totalPessoas;
        }

        public void ImprimirMenoresDeIdade(int menorIdade)
        {
            foreach(var pessoa in lp)
            {
                if (pessoa.Idade < menorIdade)
                {
                    ImprimirPessoa(pessoa);
                }
            }
        }

        public void ImprimirMenoresDeIdade()
        {
            ImprimirMenoresDeIdade(18);
        }

        public void ImprimirPessoa(Pessoa pessoa)
        {
            Console.WriteLine($"Código: {pessoa.Codigo}\nNome: {pessoa.Nome}\nSalário: {pessoa.Salario}");
        }

        public void ImprimirLista()
        {
            lp.Print();
        }

        static void Main(string[] args)
        {
            //int length = 6;
            //int[] array = new int[20];
            //array[0] = 5;
            //array[1] = 4;
            //array[2] = 3;
            //array[3] = 6;
            //array[4] = 2;
            //array[5] = 1;
            //Program.Ordena(array, length);

            //for(int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            var p = new Program();

            p.Sort();
            Console.WriteLine("A lista ordenada de pessoas é:" );
            p.ImprimirLista();

            Console.WriteLine("A média salarial dos homens é: {0:C}", p.CalculaMediaSalarioHomens());
            Console.WriteLine("A média salarial das mulheres é: {0:C}", p.CalculaMediaSalarioMulheres());

            Console.WriteLine("As pessoas com menos de 18 anos são:");
            p.ImprimirMenoresDeIdade();


            Console.ReadKey();
        }

        public static void Ordena(int[] array, int lenght)
        {
            bool trocou;
            int rodada = 1;
            do
            {
                trocou = false;

                for (int i = 0; i < (lenght - rodada); i++)
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
