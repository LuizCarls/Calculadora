using System;
using System.Globalization;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {

            Calc Cal = new Calc();

            Console.WriteLine("Digite o primeiro número");
            Cal.num = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            Cal.num1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Escolha a operação que deseja executar: ");
            Console.WriteLine("1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão, 0 - Volta");
            Cal.Opçao = int.Parse(Console.ReadLine());
            
            while (Cal.Opçao > 4) {
                Console.WriteLine("Opção inválida, favor inserir outra!");
                Cal.Opçao = int.Parse(Console.ReadLine());
            }
           
            switch (Cal.Opçao) {
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                case 1:
                    Cal.Resultado = Cal.num + Cal.num1;
                    Console.WriteLine("Resultado da soma: " + Cal.Resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    Cal.Resultado = Cal.num - Cal.num1;
                    Console.WriteLine("Resultado da divisão: " + Cal.Resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Cal.Resultado = Cal.num * Cal.num1;
                    Console.WriteLine("Resultado da multiplicação: " + Cal.Resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    while (Cal.num1 == 0) {
                        Console.WriteLine("Não há divisão por ZERO, favor digitar número novamente: ");
                        Cal.num1 = double.Parse(Console.ReadLine());
                    }
                    Cal.Resultado = Cal.num / Cal.num1;
                    Console.WriteLine("Resultado da divisão: " + Cal.Resultado.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                
            }

            Console.WriteLine();

        }
    }
}
