using System;
using System.Collections.Generic;
using System.Text;
/*
 * /*
 * Crie as classes:

- `Instrumento` (classe pai): método `virtual` `Tocar()`, que mostra "Tocando um instrumento...".
- `Violao` (filha de `Instrumento`): **sobrescreve** `Tocar()` para mostrar "Violão: plim plim".

*/

namespace PilaresPOO.Polimorfismo.Exercicios.exercicio_tres
{
    public class Instrumento 
    {
        public virtual void Tocar()
        {
            Console.WriteLine("");
        }
    }
}
