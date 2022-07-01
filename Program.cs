using Calculadora_taro.Lib;

string opcaoDesejada;

do
{
    Console.Clear();

    Console.WriteLine("---calculadora_taro---\n");

    Console.WriteLine("[1] Soma");
    Console.WriteLine("[2] Subtração");
    Console.WriteLine("[3] Multiplicação");
    Console.WriteLine("[4] Divisão");
    Console.WriteLine("[5] Exponenciação");
    Console.WriteLine("[6] Radiciação");

    Console.WriteLine("\n[?] Sobre");
    Console.WriteLine("[0] Sair");

    Console.Write("\nInsira sua operação desejada: ");
    opcaoDesejada = Console.ReadLine()!;

    switch (opcaoDesejada)
    {
        case "1":
            calculadora_taro.Soma();
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;
        case "2":
            calculadora_taro.Subtracao();
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;
        case "3":
            calculadora_taro.Multiplicacao();
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;
        case "4":
            calculadora_taro.Divisao();
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;
        case "5":
            calculadora_taro.Exponenciacao();
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;
        case "6":
            calculadora_taro.Radiciacao();
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;
        case "0":
            break;
        case "?":
            ExibeSobre();
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;

        default:
            Console.WriteLine("\nOpção inválida.");
            Console.Write("\nPressione uma tecla para continuar... ");
            Console.ReadKey();
            break;
    }
} while (opcaoDesejada != "0");

Console.WriteLine("\nObrigado por utilizar o meu programa :D\n");

void ExibeSobre()
{
    Console.WriteLine("\nSobre o criador:");
    Console.WriteLine("Esse programa foi feito por um iniciante em programação que deseja melhorar suas propias abilidades.");
    Console.WriteLine("\nSobre o programa:");
    Console.WriteLine("Esse e uma calculadora feita em c# que pode realizar operações matematicas simples.");
    Console.WriteLine("\nTodas as operações da calculadora:");
    Console.WriteLine("Soma\nSubtração\nMultiplicação\nDivisão\nExponenciação\nRadiciação");
    Console.WriteLine("\nHomenagens:");
    Console.WriteLine("Eu o menageio Ermogenes Palacio e Diego Neri de Souza Felix por serem profesores muito bons e um amigo/colega Sebastian-Devus que me ajudou nesse processo.");
}