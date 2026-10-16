using System;
using System.Collections.Generic;
using System.Text;
/*
 * 💼 Exercício 2: Funcionário e Gerente
Crie as classes:
Funcionario (classe pai): propriedades Nome e Salario,
e um construtor que recebe as duas.

Gerente (filha de Funcionario): propriedade Bonus, 
construtor que recebe nome, salário e bônus,

e o método SalarioComBonus(), que retorna Salario + Bonus.
*/
namespace PilaresPOO.Heranca
{
    internal class Funcionario
    {
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome {  get; set; }
        public double Salario { get; set; }

    }
}
