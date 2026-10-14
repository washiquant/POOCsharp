using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Livro
    {
        string Titulo;
        string Autor;
        string Pagina;
        public Livro(string Titulo, string Autor, string Pagina)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Pagina = Pagina;

        }
        public void Exibir()
        {
            Console.WriteLine($"Livro : {Titulo}\n Autor : {Autor}\n pagina: {Pagina}");
        }
    
    }
}
