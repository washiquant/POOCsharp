using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    public class Contato
    {
        string Nome;
        string Telefone;
        string Email;

        public Contato(string Nome, string Telefone, string Email)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
        public Contato(string Nome, string Telefone)
        {
            this.Nome = Nome;
            this.Telefone= Telefone;
            this.Email = "Não informado";

            
        }
        public void Exibir()
        {
            Console.WriteLine($"{Nome}, {Telefone}, {Email}");
        }
    }
}
    
