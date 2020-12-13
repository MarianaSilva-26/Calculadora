using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        double numero1, numero2;
        double resultado;
        bool n1Valido, n2Valido;

        string op, sair;           
            
            do
            {
            Console.Clear();

            Console.WriteLine("Calculadora\n");

            Console.WriteLine("Operações Basicas");
            Console.WriteLine("Soma +");
            Console.WriteLine("Subtração -");
            Console.WriteLine("Multiplicação *");
            Console.WriteLine("Divisão /");
                
            Console.Write("\n");
            Console.Write("Escolha a Operação!");
            op = Console.ReadLine().ToUpper();

            if (op == "+" || op == "-" || op == "*" || op == "/" || op == "P")
            {
            Console.Clear();

            Console.Write("Digite o 1ºNumero: ");
            n1Valido = double.TryParse(Console.ReadLine(), out numero1);

            if (!n1Valido)
            {
            Console.WriteLine();
            Console.WriteLine("Você digitou um valor invalido!");
            Console.WriteLine("Pressione ENTER para sair, e recomece!");
            Console.ReadKey();
            Environment.Exit(-1);
            }

            Console.Write("Digite o 2º Número: ");
            n2Valido = double.TryParse(Console.ReadLine(), out numero2);

            if (!n2Valido)
            {
            Console.WriteLine();
            Console.WriteLine("Você digitou um valor invalido!");
            Console.WriteLine("Pressione ENTER para sair, e recomece!");
            Console.ReadKey();
            Environment.Exit(-1);
            }

            switch (op)
            {
            case "+":
            resultado = numero1 + numero2;
            Console.WriteLine();
            Console.WriteLine($"Resultado de Soma: {Math.Round(resultado, 2)}");
            break;

            case "-":
            resultado = numero1 - numero2;
            Console.WriteLine();
            Console.WriteLine($"Resultado de Subtração: {Math.Round(resultado, 2)}");
            break;

            case "*":
            resultado = numero1 * numero2;
            Console.WriteLine();
            Console.WriteLine($"Resultado de Multiplicação: {Math.Round(resultado, 2)}");
            break;

            case "/":
            resultado = numero1 / numero2;
            Console.WriteLine();
            Console.WriteLine($"Resultado da Divisão: {Math.Round(resultado, 2)}");
            break;
            }
            
            }
            else
            {
            Console.Clear();
            Console.WriteLine("Você digitou um valor invalido!");
            Console.WriteLine("Pressione ENTER para sair, e recomece!");
            Console.ReadKey();
            Environment.Exit(-1);
            }

            Console.Write("Deseja Sair? S/N: ");
            sair = Console.ReadLine().ToUpper();
            }
            while (sair != "S" && sair != "SIM");
            {
            Console.WriteLine();
            Console.WriteLine("obrigado!");
            }        
        }
    }
}
