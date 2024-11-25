using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        //propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){
           // @class = "teste"; // quando coloco @ , estou ciente de que isso é uma palavra reservada
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}