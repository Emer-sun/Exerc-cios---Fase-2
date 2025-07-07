Console.WriteLine("##Exercicios fase 2##\n");

string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"Aluno {nome} tem {idade} e nota {nota}"); //interpolação
Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota); //concatenação
Console.WriteLine($"Aluno {nome} \n tem {idade} \n e nota \n {nota}"); //sequência de escapes

Console.WriteLine("Pressione qualquer tecla para a próxima etapa"); 
Console.ReadLine();

Console.WriteLine("Digite seu nome");
string nome2 = Console.ReadLine(); //Entrada de dados
Console.WriteLine("Digite sua nota da prova 1");
double nota1 = Convert.ToDouble(Console.ReadLine()); //Convert
Console.WriteLine("Digite sua nota da prova 2");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A soma das suas notas é {nota1 + nota2}");
Console.WriteLine($"A subtração das suas notas é {nota1 - nota2}");
Console.WriteLine($"A multiplicação das suas notas é {nota1 * nota2}");
Console.WriteLine($"A divisão das suas notas é {nota1 / nota2}");
Console.WriteLine($"O módulo das suas notas é {nota1 % nota2}");
Console.WriteLine($"A exponenciação de {nota1} elevado a {nota2} é {Math.Pow(nota1, nota2)}"); //Elevado usando classe math

Console.WriteLine("Pressione qualquer tecla para a próxima etapa");
Console.ReadLine();

int a = 1;
int b = 12;
int c = -13;
double delta = Math.Pow(b, 2) - 4 * a * c;
double raizDelta = Math.Sqrt(delta); //Pegando a raiz de delta
double x1 = (-b + raizDelta) / (2 * a);
double x2 = (-b - raizDelta) / (2 * a);
Console.WriteLine($"x1 = {x1}");
Console.WriteLine($"x2 = {x2}");

Console.WriteLine("Pressione qualquer tecla para a próxima etapa");
Console.ReadLine();

Console.WriteLine("Digite seu login");
string login = Console.ReadLine(); //Entrada de dados
Console.WriteLine("Digite sua senha");
int senha = Convert.ToInt32(Console.ReadLine()); //Convert
var login2 = "admin";
var senha2 = 123;

if (login == login2 && senha == senha2) //operador "==" se for igual e && and
{
    Console.WriteLine("Login feito com sucesso");
}
else
{
    Console.WriteLine("Login ou senha incorretos");
}
Console.WriteLine("Pressione qualquer tecla para a próxima etapa");
Console.ReadLine();
Console.WriteLine("Digite o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());

string resultadoX = (x % 2 == 0) ? "par" : "ímpar";
string resultadoY = (y % 2 == 0) ? "par" : "ímpar";

Console.WriteLine($"O número x ({x}) é {resultadoX}");
Console.WriteLine($"O número y ({y}) é {resultadoY}");



Console.ReadKey();
