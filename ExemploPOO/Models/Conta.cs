using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo; // protegido contra alteraçoes externas, com exceção de classes filhas

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo é {saldo}");
        }

        public abstract void Creditar(decimal valor); // não vamos colocar nada nele
// quem herdar a classe Conta, vai obrigatoriamente implementar esse método

    }
}