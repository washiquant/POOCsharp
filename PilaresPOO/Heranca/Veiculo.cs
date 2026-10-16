using System;
using System.Collections.Generic;
using System.Text;
/*
 * 🚗 Exercício 3: Veículo, Carro e Moto
Crie as classes:
Veiculo (classe pai): propriedades Marca e Modelo, um construtor que recebe as duas e o método Exibir(), que mostra "{Marca} {Modelo}".
Carro (filha de Veiculo): propriedade Portas, construtor que recebe marca, modelo e portas, e o método ExibirPortas().
Moto (filha de Veiculo): propriedade Cilindradas, construtor que recebe marca, modelo e cilindradas, e o método ExibirCilindradas().
*/
namespace PilaresPOO.Heranca
{
    internal class Veiculo
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public void ExibirPortas()
        {
            Console.WriteLine($"Marca : {Marca} | Modelo : {Modelo}");
        }

    }
}
