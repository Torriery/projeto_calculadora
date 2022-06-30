using Calculadora_taro.Lib;

string opcaoDesejada;

Console.Clear();

Console.WriteLine("---calculadora_taro---\n");

Console.WriteLine("[1] Soma");
Console.WriteLine("[2] Subtração");
Console.WriteLine("[3] Multiplicação");
Console.WriteLine("[4] Divisão");
Console.WriteLine("[5] Exponenciação");
Console.WriteLine("[6] Radiciação");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "1":
        calculadora_taro.Soma();
        break;
    case "2":
        calculadora_taro.Subtracao();
        break;
    case "3":
        calculadora_taro.Multiplicacao();
        break;
    case "4":
        calculadora_taro.Divisao();
        break;
    case "5":
        calculadora_taro.Exponenciacao();
        break;
    case "6":
        calculadora_taro.Radiciacao();
        break;

    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar o meu programa :D ");