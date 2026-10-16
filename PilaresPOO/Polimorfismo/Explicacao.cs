using System;
using System.Collections.Generic;
using System.Text;
/*POLIMORFISMO :
 * POLI - MUITAS
 * MORFISMO - FORMAS
 * 
 * SOBRECARGA : Mesmo nome, parametros diferentes
 * EXEMPLO :
 * 
 * ------------- SOBRECARGA EXEMPLO : ------------------------------------------------------------:
internal class PolimorfismoExemplo
{
    public int Somar(int a, int b) -> Diferente                      
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    // Inválido
    //public int Somar(int a, int b)
    //{
    //    return a - b;
    //}

    public int Somar(int a, int b, int c)
    {
        Console.WriteLine("Somei 3 numeros!");
        return a + b + c;
    }
}
 * ---------------------------------------------------------------------------------------
 * SOBRESCRITA -> VIRTUAL || OVERRIDE
 * VIRTUAL -> ESSE METODO PODE SER SOBRESCRITO
 * OVERRIDE -> SOBRESCREVER
 * ------------- SOBRESCRITA EXEMPLO : ------------------------------------------------------------:
 * ------------- Sobrescrita:
internal class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som");
    }
}

internal class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Au au!");
    }
}


internal class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Miau!");
    }
}
 * 
 * 
 * 
 * 
 * 
 * */
