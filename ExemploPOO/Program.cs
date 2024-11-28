using ExemploPOO.Models;
using ExemploPOO.Interfaces;

Aluno a1 = new Aluno();
a1.Nome = "Danillo";
a1.Idade = 21;
a1.Nota = 10;

Professor p1 = new Professor();
p1.Nome = "Isaque";
p1.Idade = 45;
p1.Salario = 4000;

p1.Apresentar();



// abstrata

Corrente c = new Corrente();

c.Creditar(500);
c.ExibirSaldo();


Pessoa pe1 = new Pessoa("Danillo");
Aluno al2 = new Aluno("Isaque");
al2.Apresentar();

// object

Computador pc = new Computador();

Console.WriteLine(pc.ToString());

ICalculadora calc = new Calculadora(); // a classe que implementa essa interface

Console.WriteLine(calc.Multiplicar(5,6));