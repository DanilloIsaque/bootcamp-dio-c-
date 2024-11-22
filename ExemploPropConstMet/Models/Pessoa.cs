using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPropConstMet.Models
{
    public class Pessoa
    {

/*
a partir do momento que eu criei o construtor com parametros, precisa iniciar OBRIGATORIAMENTE com os parâmetros

o vazio seria para passar os valores depois , como é o caso do exemplo em Program.cs
*/

        public Pessoa(){

        }

        public Pessoa (string nome, string sobrenome , int idade){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _nome;
        private int _idade;

        public string Nome {
             get
             {
                return _nome;
             }
             
              set{
              
                    if(value == ""){
                        throw new ArgumentException("O nome não pode ser vazio");
                    }
                    _nome = value;
              }
        }


        public int Idade { 

            get => _idade;
             

            set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            } }

        public string Sobrenome { get; set; }
        
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar(){
            Console.WriteLine($"Nome :{NomeCompleto} , Idade: {Idade}");
        }
    }
}