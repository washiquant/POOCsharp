using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO.Heranca
{
    internal class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome}: Au au!");
        }
    }
}


