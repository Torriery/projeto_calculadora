public class Aritmetica_taro
{
    public static void Soma()
    {
        double numero1, numero2, resultado;

        Console.Clear();
        Console.WriteLine("----- Adição -----\n");

        Console.Write("Escreva um número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva outro número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        resultado = numero1 + numero2;

        Console.Write($"\nO resultado é ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(resultado);
        Console.ResetColor();
    }

    public static void Subtracao()
    {
        double numero1, numero2, resultado;

        Console.Clear();
        Console.WriteLine("----- Subtração -----\n");

        Console.Write("Escreva um número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva outro número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        resultado = numero1 - numero2;

        Console.Write($"\nO resultado é ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(resultado);
        Console.ResetColor();
    }

    public static void Multiplicacao()
    {
        double numero1, numero2, resultado;

        Console.Clear();
        Console.WriteLine("----- Multiplicação -----\n");

        Console.Write("Escreva um número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva outro número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        resultado = numero1 * numero2;

        Console.Write($"\nO resultado é ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(resultado);
        Console.ResetColor();
    }

    public static void Divisao()
    {
        double numero1, numero2, resultado;

        Console.Clear();
        Console.WriteLine("----- Divisão -----\n");

        Console.Write("Escreva um número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva outro número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDividir por 0 não da né burrinho tente novamente\n");
            Console.ResetColor();
        }
        else
        {
            resultado = numero1 / numero2;

            Console.Write($"\nO resultado é ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(resultado);
            Console.ResetColor();
        }
    }

    public static void Exponenciacao()
    {
        double numero1, numero2, resultado;

        Console.Clear();
        Console.WriteLine("----- Exponenciação -----\n");

        Console.Write("Escreva um número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva outro número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        resultado = Math.Pow(numero1, numero2);

        Console.Write($"\nO resultado é ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(resultado);
        Console.ResetColor();
    }

    public static void Radiciacao()
    {
        double numero1, numero2, resultado;

        Console.Clear();
        Console.WriteLine("----- Radiciação -----\n");

        Console.Write("Escreva um número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Escreva outro número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero1 < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Não existe raiz de número negativo né");
            Console.ResetColor();
        }
        else if (numero2 <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Não existe a raiz zero de um número");
            Console.ResetColor();
        }
        else
        {
            resultado = Math.Pow(numero1, 1 / numero2);
            Console.Write($"\nO resultado é ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(resultado);
            Console.ResetColor();
        }




    }
}