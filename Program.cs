using System;

namespace EstudoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?\n1 - Soma\n2 - Subtracao\n3 - Multiplicação\n4 - Divisão\n5 - Sair\n6 - dizimo\n7 - SalarioMensal\n-----------------------\nSelecione uma opção");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                case 6: Dizimo(); break;
                case 7: SalarioMensal(); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é = {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é = {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é = {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é = {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Dizimo()
        {
            Console.Clear();
            Console.WriteLine("Qual valor você quer calcular?");
            float valor = float.Parse(Console.ReadLine());
            float dizimo = (valor * 10) / 100;

            Console.WriteLine($"O valor do seu dízimo é: {dizimo}");
            Console.ReadKey();
            Menu();
        }

        static void SalarioMensal()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor que você ganha por hora:");
            float valorHoraDia = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas que você trabalha por dia");
            float horasDia = float.Parse(Console.ReadLine());

            double salario = (valorHoraDia * horasDia) * 22;

            Console.WriteLine($"Você ganha {salario.ToString("C")} por mês");
            Console.ReadKey();
            Menu();
        }


    }
}
