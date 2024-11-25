using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPropConstMet.Models
{
    public class ExemploExcecao
    {
        
        
        public void Metodo1(){
// tem condição de tratar a exceção q é jogada de volta pra cá
            try{
                Metodo2();
            }catch(Exception e){
                Console.WriteLine("Exceção tratada" + e.Message);
            }
            
        }

        public void Metodo2(){
            Metodo3();

        }
        
        public void Metodo3(){
            Metodo4();

        }

        public void Metodo4(){
            throw new Exception("Ocorreu uma exceção");
        }
    }
}