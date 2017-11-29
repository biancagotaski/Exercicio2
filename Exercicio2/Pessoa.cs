using System;

namespace Exercicio2
{
    public class Pessoa: IComparable<Pessoa>
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public decimal Salario { get; set; }

        public int CompareTo(Pessoa other)
        {
            return Salario.CompareTo(other.Salario);
        }
    }
}
