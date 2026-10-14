using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PilaresPOO
{
    internal class ContaBancaria
    {
        public string Titular;
        private double Saldo;


        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Console.WriteLine("Valor inválido");
            }
            Saldo += valor;
            Console.WriteLine($"Saldo Atualizado para R${Saldo}");
        }


  
   }
}
//public ->  pode ser acessado de qualquer lugar
//internal -> so pode ser acessado 
//private -> Só consigo acessar de dentro da classe (Onde foi criado).
