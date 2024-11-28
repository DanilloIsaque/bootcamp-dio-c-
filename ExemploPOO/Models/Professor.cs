using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // public sealed class Professor : Pessoa  classe selada, ngm pode herdar essa
    public  class Professor : Pessoa 
    {
        public Professor (string nome) : base(nome){ //passando para classe pai o "nome"
            
        }
        
         public double Salario {get;set;}

         public sealed override void Apresentar(){ // método selado
             Console.WriteLine($"Meu nome é {Nome} , tenho {Idade} anos e meu salário é {Salario}"); 
        }
    }
}