using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercicio2
{
    public class ListaPessoas: IEnumerable<Pessoa>
    {
        private List<Pessoa> pessoas;

        public ListaPessoas()
        {
            pessoas = new List<Pessoa>();
        }

        public void AddPessoa(Pessoa p)
        {
            pessoas.Add(p);
        }

        public void Sort()
        {
            bool trocou;
            int rodada = 1;
            do
            {
                trocou = false;

                for (int i = 0; i < (pessoas.Count - rodada); i++)
                {
                    if (pessoas[i].CompareTo(pessoas[i + 1]) > 0)
                    {
                        Troca(i, i + 1);
                        trocou = true;
                    }
                }

                rodada++;
            }
            while (trocou);
        }

        private void Troca(int pos1, int pos2)
        {
            Pessoa temp = pessoas[pos1];
            pessoas[pos1] = pessoas[pos2];
            pessoas[pos2] = temp;
        }

        public void Print()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Código: {pessoa.Codigo}\nNome: {pessoa.Nome}\nSalário: {pessoa.Salario}");
            }
        }

        public IEnumerator<Pessoa> GetEnumerator()
        {
            return pessoas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        

        
    }
}
