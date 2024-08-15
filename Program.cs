// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int numero = 10;
// double pi = 3.1415;
// char letra = 'A';
// bool isTrue = true;
// string mensagem = "olá mundo!";

// // var numero3 = "texto";

// double outroNumero = numero;


// int terraDeAreia = (int)pi;
// Console.whiteLine(pi);
// Console.whiteLine(terraDeAreia);

// int numero2 = 5;
// string texto = Convert.ToString(numero2);
double soma,divisao,subtracao,multiplicacao;
int x;
Console.WriteLine("Digite o valor de X: ");
x = Convert.ToInt32(Console.ReadLine()); 

int y;
Console.WriteLine("Digite o valor de y:");
y= Convert.ToInt32(Console.ReadLine());
// // Formação usando concatenação
Console.WriteLine("O susario digitou: " + x + y +"Parabens");

// // Interpolação
// Console.WhiteLine($"O usuario digitou{x}parabens");
// // Usando placeholders
// Console.WhiteLine("O usuario digitou{0}parabens!", x);

soma =(double) x + y;
Console.WriteLine("A soma de x e y é : " + soma);

subtracao =(double) x - y;
Console.WriteLine($"A subtração de x e y é : {subtracao}");

multiplicacao =(double) x * y;
Console.WriteLine("A multiplicação de x e y é : {0} " , multiplicacao );

divisao = (double)x / y;
Console.WriteLine("A Divisão de x e y é : {0}" , divisao) ;


