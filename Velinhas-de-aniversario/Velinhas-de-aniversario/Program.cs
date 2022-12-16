// See https://aka.ms/new-console-template for more information
double anonasc = 0;
double anoatual = 0;
double idade = 0;

Console.WriteLine("----QUANTAS VELINHAS POR NO BOLO?----");
Console.WriteLine("-------------------------------------");
Console.WriteLine("Em que ano você nasceu?");
anonasc = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ótimo! Agora diga em que ano estamos.");
anoatual = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------");
idade = anoatual - anonasc;
Console.WriteLine("Parabéns!");
Console.WriteLine($"Seu bolo deve ter " + idade + " velinhas");

Console.ReadKey();
