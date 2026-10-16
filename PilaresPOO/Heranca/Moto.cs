using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PilaresPOO.Heranca
{
    internal class Moto : Veiculo

    {
        public Moto(string marca, string modelo) : base(marca, modelo)
        {
        }
        public string Cilindradas { get; set; }

        public void ExibirCilindradas()
        {
            Console.WriteLine(Cilindradas);
        }
    }
}
