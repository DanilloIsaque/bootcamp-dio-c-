using ExemploFundamentos.Models;

Pessoa p = new Pessoa();

p.Nome = "Danillo";
p.Idade = 20;
p.Apresentar();

DateTime DataAtual = DateTime.Now;
Console.WriteLine(DataAtual.ToString("dd/MM/yyyy"));

DateTime DataModificada = DataAtual.AddDays(5);
int a = Convert.ToInt32("5");
int b = int.Parse("5");

string valor = a.ToString();


string valor2 = "15-";
int valorAtribuidoAoParse = 0;
int.TryParse(valor2,out valorAtribuidoAoParse );

Calculadora calc = new Calculadora();
calc.Somar(10,30);
calc.Subtrair(10,5);
calc.Multiplicar(6,6);
calc.Dividir(12,2);
calc.Potencia(3,3);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);

int[] arrayInteiro = new int [3];
arrayInteiro[0] = 72;
arrayInteiro[1] = 64;
arrayInteiro[2] = 50;

int[] arrayCopia = new int [arrayInteiro.Length+2];
Array.Copy(arrayInteiro,arrayCopia,2); // ultimo parâmetro é a quantidade que quero copiar

Array.Resize(ref arrayInteiro,arrayInteiro.Length*2);

for(int i = 0; i < arrayInteiro.Length; i++){
    Console.WriteLine($"Valor do indice {i}: {arrayInteiro[i]}");
}


foreach (int item in arrayInteiro)
{
    Console.WriteLine(item);
}


List<string> lista = new List<>(string);
lista.add("SP");
lista.add("RJ");
lista.add("MG");
lista.add("ES");

for(int x = 0; x < lista.Length; x++){
    Console.WriteLine($"Valor do indice {x}: {lista[i]}");
}


foreach (string valor in lista)
{
    Console.WriteLine(valor);
}

//lista.Capacity = quando a gente adiciona um valor a mais, ele aumenta a capacidade da lista e mesmo q seja removido depois um
//elemento, ele manterá a capacidade aumentada



//converte converte valor nulo para 0, o parse não consegue tratar

/* IF

int quantidadeEmEstoque = 3;
int quantidadeDeCompra=0;
bool possivelVenda = quantidadeDeCompra> 0 &&  quantidadeEmEstoque>= quantidadeDeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeDeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if(quantidadeDeCompra ==0 ){
    Console.WriteLine("Venda inválida");
}else if(possivelVenda){
    Console.WriteLine("Venda realizada");
}else{
    Console.WriteLine("Não temos a quantidade no estoque");
}


 switch case
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    Console.WriteLine("Vogal");
    break;

    default:
    Console.WriteLine("Consoante");
    break;
}

for

int numero = 5;

for (int i = 0 ;i<=10; i++){
    Console.WriteLine($"{numero} x {i} = {numero*i}");
}

int contador = 1;

while (contador<=10){
     Console.WriteLine($"{numero} x {contador} = {numero*contador}");
        contador++;
     if(contador == 5 ){
        break;
     }
}





**menu
while(true){

Console.WriteLine("Escolha uma opção: ");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.WriteLine("4 - Dividir");
Console.WriteLine("5 - Potência");
Console.WriteLine("6 - Seno");
Console.WriteLine("7 - Cosseno");
Console.WriteLine("8 - Tangente");
Console.WriteLine("9 - Raiz Quadrada");
Console.WriteLine("0 - Sair");

string opcao = Console.ReadLine(); // Solicita a opção do usuário

switch (opcao)
{
    case "1":
        Console.WriteLine("Digite um número:");
        int x1 = Convert.ToInt32(Console.ReadLine()); // Converte a entrada para int
        Console.WriteLine("Digite outro número:");
        int y1 = Convert.ToInt32(Console.ReadLine());
        calc.Somar(x1, y1);
        break;

    case "2":
        Console.WriteLine("Digite um número:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número:");
        int y2 = Convert.ToInt32(Console.ReadLine());
        calc.Subtrair(x2, y2);
        break;

    case "3":
        Console.WriteLine("Digite um número:");
        int x3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número:");
        int y3 = Convert.ToInt32(Console.ReadLine());
        calc.Multiplicar(x3, y3);
        break;

    case "4":
        Console.WriteLine("Digite um número:");
        int x4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número:");
        int y4 = Convert.ToInt32(Console.ReadLine());
        calc.Dividir(x4, y4);
        break;

    case "5":
        Console.WriteLine("Digite um número:");
        int x5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número:");
        int y5 = Convert.ToInt32(Console.ReadLine());
        calc.Potencia(x5, y5);
        break;

    case "6":
        Console.WriteLine("Digite um ângulo:");
        double angulo1 = Convert.ToDouble(Console.ReadLine()); // Converte para double
        calc.Seno(angulo1);
        break;

    case "7":
        Console.WriteLine("Digite um ângulo:");
        double angulo2 = Convert.ToDouble(Console.ReadLine());
        calc.Cosseno(angulo2);
        break;

    case "8":
        Console.WriteLine("Digite um ângulo:");
        double angulo3 = Convert.ToDouble(Console.ReadLine());
        calc.Tangente(angulo3);
        break;

    case "9":
        Console.WriteLine("Digite um número:");
        double raiz = Convert.ToDouble(Console.ReadLine());
        calc.RaizQuadrada(raiz);
        break;

    case "0":
        Console.WriteLine("Encerrando...");
        Environment.Exit(0);
        break;

    default:
        Console.WriteLine("Opção inválida");
        break;
    }
}

*/


