using PilaresPOO.Polimorfismo.Exercicios.exercicio_um;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * Crie a classe `Saudacao` com **três versões** do método `Cumprimentar`:

- `Cumprimentar()`: mostra "Olá!".
- `Cumprimentar(string nome)`: mostra "Olá, {nome}!".
- `Cumprimentar(string nome, int idade)`: mostra "Olá, {nome}! Você tem {idade} anos.".
*/

using PilaresPOO;
Saudacao s = new Saudacao();

s.Cumprimentar();
s.Cumprimentar("Ana");
s.Cumprimentar("Bruno", 25);

