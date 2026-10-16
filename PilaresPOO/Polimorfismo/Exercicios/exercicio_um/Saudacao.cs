using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PilaresPOO.Polimorfismo.Exercicios.exercicio_um
{
    public class Saudacao
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Olá");
        }
        public void Cumprimentar(string nome)
        {
            Console.WriteLine($"Ola, {nome}");
        }
        public void Cumprimentar(string nome, int idade)
        {
            Console.WriteLine($"Olá, {nome}! Você tem {idade } anos");
        }
    }
}
