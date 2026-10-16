using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Heranca
{
    internal class Carro : Veiculo
    {
        public Carro(string marca, string modelo) : base(marca, modelo)
        {
        }
        public double Portas { get; set; }
        public void ExibirPortas()
        {
            Console.WriteLine(Portas);
        }

    }
}
