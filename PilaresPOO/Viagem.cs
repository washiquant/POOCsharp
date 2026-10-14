using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Viagem
    {
        string Destino;
        int Dias;
        double ValorDiaria;

        public Viagem(string destino, int dias, double valorDiaria)
        {
            Destino = destino;
            Dias = dias;
            ValorDiaria = valorDiaria;
        }
        public double CalcularTotal()
        {
            return Dias * ValorDiaria;
        }
        public void Exibir()
        {
            Console.WriteLine($"O valor total é {CalcularTotal()} ");
        }
    }
}
