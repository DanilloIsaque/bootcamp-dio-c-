using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
         public double Salario {get;set;}

         public override void Apresentar(){
             Console.WriteLine($"Meu nome é {Nome} , tenho {Idade} anos e meu salário é {Salario}"); 
        }
    }
}