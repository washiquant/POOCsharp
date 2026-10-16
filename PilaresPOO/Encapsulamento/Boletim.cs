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
                Console.WriteLine($"Nota inválida: {{valor}}\")                                                                                                                                                                ");
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
/*
 * Crie a classe Usuario com:
Propriedade pública Login.
Campo private string senha.
Um construtor que recebe login e senha.
Método público ConferirSenha(string tentativa): retorna true se a tentativa for igual à senha.
Método público TrocarSenha(string senhaAtual, string novaSenha): só troca se a senha atual estiver correta. Mostra "Senha alterada!" ou "Senha atual incorreta.".
*/