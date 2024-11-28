using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        //abstração - contexto que preciso 

        public string Nome { get; set; }
        public int Idade { get; set; }


        public Pessoa () {
            
        }

        public Pessoa (string nome ){
            Nome = nome; // para criar uma pessoa, é obrigatório enviar um nome
        }

        public virtual void Apresentar(){  // colocando virtual, queremos dizer q o método pode ser sobreescrito
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos"); 
        }
    }
}