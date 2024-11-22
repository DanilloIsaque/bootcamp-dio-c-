using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPropConstMet.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int QtdAlunosMatriculados (){
            return Alunos.Count();
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno); // retorna o resultado desse método
            //return true;
        }

        public void ListaAlunos(){
            Console.WriteLine($"Curso:{Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}