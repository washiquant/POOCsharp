using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Polimorfismo.Exercicios.exercicio_tres
{
    public class Violao : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("plim, plim");
        }
    }
}

