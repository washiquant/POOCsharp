using System;
using System.Collections.Generic;
using System.Text;

internal class Pessoa
{
    public string Nome{ get; set; }
    public int idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine("Oi! Eu sou" + Nome);
    }
}