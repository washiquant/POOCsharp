using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//Crie a classe Usuario com:
//Propriedade pública Login.
//Campo private string senha.
//Um construtor que recebe login e senha.
//Método público ConferirSenha(string tentativa): retorna true se a tentativa for igual à senha.
//Método público TrocarSenha(string senhaAtual, string novaSenha): só troca se a senha atual estiver correta. Mostra "Senha alterada!" ou "Senha atual incorreta.".

namespace PilaresPOO.Encapsulamento
{
    internal class Usuario
    {
        public string login { get; set; }
        private string senha {  get; set; }

        public Usuario(string login, string senha) 
        { 
            this.login = login;
            this.senha = senha;
        }
        public bool ConferirSenha(string tentativa)
        {
            if (tentativa == senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TrocarSenha(string senhaAtual, string novaSenha)
        {
            if (senhaAtual == senha)
            {
                senha = novaSenha;
                Console.WriteLine("Senha Alterada!");
            }
            else
            {
                Console.WriteLine("Senha atual incorreta.");
            }

        }     


    }
}
