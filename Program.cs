using System;

namespace Calculator_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstValue = 0;
            float secondValue = 0;
            float result = 0;
            int? operation = 0;
            string? operatorSimbol = "", stop = "";

            do
            {
                Console.WriteLine("\r\n\r\n");

                Console.WriteLine("Calculadora");

                Console.WriteLine("Digite o primeiro valor: \r\n");
                firstValue = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: \r\n");
                secondValue = float.Parse(Console.ReadLine());

                Console.WriteLine("\r\nEscolha e digite o símbolo correspondende: \r\n \r\n 1 -> Adição \r\n 2 -> Subtração \r\n 3 -> Divisão \r\n 4 -> Multiplicação ");
                do
                {
                    int number;
                    string? value = Console.ReadLine();


                    bool success = int.TryParse(value, out number);

                    if (success)
                    {
                        operation = Convert.ToInt32(value);
                    }
                    else
                    {
                        Console.WriteLine("Algo deu errado!");
                    }

                } while (operation != 1 && operation != 2 && operation != 3 && operation != 4);

                switch (operation)
                {
                    case 1:
                        {
                            result = Add(firstValue, secondValue);
                            operatorSimbol = "+";
                            break;
                        }
                    case 2:
                        {
                            result = Sub(firstValue, secondValue);
                            operatorSimbol = "-";
                            break;
                        }
                    case 3:
                        {
                            result = Division(firstValue, secondValue);
                            operatorSimbol = "/";
                            break;
                        }
                    case 4:
                        {
                            result = Multiply(firstValue, secondValue);
                            operatorSimbol = "x";
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Algo deu errado!");
                            break;
                        }
                }

                Console.WriteLine($"\r\n Operação: {firstValue} {operatorSimbol} {secondValue} = {result} ");


                Console.WriteLine("\r\n\r\n Quer parar? (y)");
                stop = Console.ReadLine();

            } while (stop != "y" && stop != "Y");
        }


        static float Add(float a, float b) { return a + b; }
        static float Multiply(float a, float b) { return a * b; }
        static float Sub(float a, float b) { return a - b; }
        static float Division(float a, float b) { return a / b; }
    }

}
