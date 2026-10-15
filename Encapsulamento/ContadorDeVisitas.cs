using System;
using System.Collections.Generic;
using System.Text;
/*
 * ### 👀 Exercício 1: Contador de Visitas

Crie a classe `ContadorDeVisitas` com:

- Campo `private int visitas` (ninguém de fora pode mexer).
- Método público `RegistrarVisita()`: soma 1 às visitas.
- Método público `ObterTotal()`: **retorna** o total de visitas.
*/
namespace ConsoleApp1
{
    internal class ContadorDeVisitas
    {
        private int visitas;
        public int RegistrarVisita() 
        {
            return visitas += 1;
        }  
        public void ObterTotal()
        {
            Console.WriteLine(visitas);
        }


    }
}

