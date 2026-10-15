using System;
using System.Collections.Generic;
using System.Text;
/*Crie a classe `Boletim` com:

- Propriedade pública `Aluno`: `public string Aluno { get; set; }`
- Campo `private double nota`.
- Método público `DefinirNota(double valor)`: só aceita notas de 0 a 10. Fora disso, mostra "Nota inválida: {valor}" e não altera a nota.
- Método público `ObterNota()`: **retorna** a nota.
*/

namespace PilaresPOO.Encapsulamento
{
    internal class Boletim
    {
        public string Aluno { get; set; }
        private double nota;
        
        public void DefinirNota(double nota)
        {
            if ((nota < 0) || (nota > 10))
            {
                Console.WriteLine($"Nota inválida: {{valor}}\" e não altera a nota.");
            }
            else
            {
                Console.WriteLine(nota);
            }

        }
        public double ObterNota(double nota) 
            {
            return nota;
            }
        


      
    }
}
