using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPropConstMet.Models
{
    public class LeituraArquivo
    {
        // quero retornar mais de um tipo de dado
        public (bool Sucesso, string[] Linhas, int Qtd) LerArquivo(string caminho){ 
            try{
            string[] linhas = File.ReadAllLines(caminho);

            return(true, linhas , linhas.Count());
            }catch(Exception){
                return (false, new string[0], 0);
            }
        }
    }
}