using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
/* Exercício 1: Animal e Cachorro
Crie as classes:
Animal (classe pai): propriedade Nome e método Comer(), que mostra "{Nome} está comendo.".
Cachorro (classe filha de Animal): método Latir(), que mostra "{Nome}: Au au!".
O Cachorro não deve declarar Nome nem Comer(): ele herda do Animal.
*/
namespace PilaresPOO.Heranca
{
    internal class Animal
    {
        public string Nome { get; set; }
        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
    }
}
