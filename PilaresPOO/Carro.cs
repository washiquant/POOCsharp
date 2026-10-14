using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    public class Carro
    {
        public string Marca;

        public string Modelo;


        //Pilares da POO
        //Evitar Estados Invalidos

        
        // Metodo Construtor
        // Não tem tipo de retorno
        // Tem o mesmo nome da classe
        public Carro(string Marca, string Modelo)
        {
            this.Marca = Marca;

            this.Modelo = Modelo;
        }
        

        
    }
}