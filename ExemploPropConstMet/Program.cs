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

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Lendo arquivo");

try{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas){
        Console.WriteLine(linha);
    }

//}catch(Exception e){
  //  Console.WriteLine($"Ocorreu uma exceção genérica.{e.Message}"); // pegamos apenas o problema e não exibimos todas os detalhes de quando dispara algum erro
}catch (FileNotFoundException ex){
     Console.WriteLine($"Ocorreu um erro na leitura do arquivo.{ex.Message}");
}catch(DirectoryNotFoundException ex ){
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado {ex.Message}");
}finally{ // serve para executar um bloco de código mesmo que ocorra uma execução ou não
    Console.WriteLine("Finally");
    //útil para fechar conexão com o banco,por exemplo
}


Console.WriteLine("Ele executa mesmo depois da exceção ser disparada");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Queue");

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila){
    Console.WriteLine(item);
}

Console.WriteLine($"removendo o elemento :{fila.Dequeue()}"); // não passa nada, ele sempre vai remover o primeiro elemento

foreach (int item in fila){
    Console.WriteLine(item);
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Stack/Pilha"); // obedece a ordem LIFO (Last in, First Out) , o último que entrou , será o primeiro a sair

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha){
    Console.WriteLine(item); // mostra na ordem contrária, pelo último adicionado até o primeiro
}

 // remove e retorna o objeto no topo da pilha, no caso o 10
Console.WriteLine($"Removendo o elemento do topo : {pilha.Pop()}");


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Dictionary");

Dictionary<string,string> estados = new Dictionary<string,string>();
estados.Add("SP","São Paulo");
estados.Add("MG","Minas Gerais");
estados.Add("RS","Rio Grande do Sul");
estados.Add("RJ","Rio de Janeiro");
estados.Add("BA","Bahia");

foreach(KeyValuePair<string,string>  item in estados ){ //
    Console.WriteLine($"Chave: {item.Key},  Valor: {item.Value}");
}

estados.Remove("RJ");
// alterar valor
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados ){ //var
    Console.WriteLine($"Chave: {item.Key},  Valor: {item.Value}");
}

//verificar se existe chave
string chave = "BA";

if(estados.ContainsKey("BA")){
    Console.WriteLine("Valor existente");
}else{
    Console.WriteLine("Não existe.");
}

//acessar o valor
 Console.WriteLine(estados["MG"]);
