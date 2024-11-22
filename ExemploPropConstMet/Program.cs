using ExemploPropConstMet.Models;
using System.Globalization;

Pessoa p1 = new Pessoa();
p1.Nome = "Fulano";
p1.Sobrenome = "de Tal";
p1.Idade = 21;

Pessoa p2 = new Pessoa(nome:"Ciclano", sobrenome:"de Tal", idade:31);

Pessoa p3 = new Pessoa("Maria","Jose",51);

Curso cursoDeInformatica = new Curso();
cursoDeInformatica.Nome = "Informática";
cursoDeInformatica.Alunos = new List<Pessoa>();

cursoDeInformatica.AdicionarAluno(p1);
cursoDeInformatica.AdicionarAluno(p2);
cursoDeInformatica.AdicionarAluno(p3);
cursoDeInformatica.ListaAlunos();
cursoDeInformatica.RemoverAluno(p2);
cursoDeInformatica.ListaAlunos();

// formatação monetária
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // troca localização
decimal valor = 1594.32M;
Console.WriteLine($"{valor:C}"); //pega de acordo com a região que estamos
Console.WriteLine(valor.ToString("C",CultureInfo.CreateSpecificCulture("pt-br")));
Console.WriteLine(valor.ToString("C1")); //significa as casas decimais que serão representadas, no caso uma
Console.WriteLine(valor.ToString("N1")); // mesma coisa das casas decimais, mas não exibirá o prefixo monetário


double porcentagem = .3521;

Console.WriteLine(porcentagem.ToString("P")); //mostrará a porcentagem(35,21%)

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());