using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora // tudo que ela pedir para implementar, tem q implementar
    {
        public int Somar (int num , int num2){
            return num + num2;
        }

        public int Somar (int num , int num2, int num3){
            return num + num2 +num3;
        }

        public int Subtrair (int num , int num2){
            return num - num2;
        }

        public int Multiplicar (int num , int num2){
            return num * num2;
        }


        public int Dividir (int num , int num2){
            return num / num2;
        }
    }
}