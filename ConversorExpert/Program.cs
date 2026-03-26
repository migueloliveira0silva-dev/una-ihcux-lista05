// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;


Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===========================================");
Console.WriteLine("       GLOBAL EXCHANGE - CONVERSOR v1.0    ");
Console.WriteLine("===========================================");
Console.ResetColor();

try 
{
    
    Console.Write("\nDigite o valor em REAIS (R$): ");
    string entrada = Console.ReadLine();
    double valorReais = double.Parse(entrada);

    Console.Write("Digite a cotação do DÓLAR hoje (ex: 5,20): ");
    double cotacaoDolar = double.Parse(Console.ReadLine());

    
    Console.WriteLine("\n[SISTEMA]: Conectando ao Banco Central...");
    Thread.Sleep(1000);
    Console.Write("[SISTEMA]: Calculando taxas");
    for(int i = 0; i < 3; i++) { Thread.Sleep(500); Console.Write("."); }

    
    double resultado = valorReais / cotacaoDolar;

    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\n-------------------------------------------");
    Console.WriteLine($"VALOR CONVERTIDO: $ {resultado:F2} (Dólares)");
    Console.WriteLine("-------------------------------------------");
    Console.ResetColor();
}
catch (Exception)
{

    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n\n [ERRO CRÍTICO] ");
    Console.ResetColor();
    Console.WriteLine("Entrada inválida! Use apenas números e vírgula para decimais.");
}
finally
{
    Console.WriteLine("\nObrigado por usar o Global Exchange. Volte sempre!");
    Console.WriteLine("Pressione qualquer tecla para finalizar...");
    Console.ReadKey();
}
