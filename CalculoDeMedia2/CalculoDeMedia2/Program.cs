// See https://aka.ms/new-console-template for more information

double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double nota4 = 0;
double media = 0;

Console.WriteLine("---CÁLCULO DE MÉDIA---");
Console.WriteLine("----------------------");
Console.WriteLine("Digite sua primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua quarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine($"Sua média é: " + media);

if(media >= 6){
    Console.WriteLine("Parabéns! Você foi aprovado!");
}
else
{
    Console.WriteLine("Você foi reprovado.");
}

Console.ReadKey();