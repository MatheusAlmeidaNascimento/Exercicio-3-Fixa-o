using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeAdquirida;
            double preçoUnitario = 8;
            double total;
            double totalApagar;

            Console.WriteLine("Quantas Coca Cola de 2L você quer?");
            quantidadeAdquirida = int.Parse(Console.ReadLine());

            if (quantidadeAdquirida <= 5)
            {
                total = quantidadeAdquirida * preçoUnitario;
                totalApagar = total - (total * 0.02);
            }
            else if (quantidadeAdquirida > 5 && quantidadeAdquirida <= 10)
            {
                total = quantidadeAdquirida * preçoUnitario;
                totalApagar = total - (total * 0.03);

            }
            else
            {
                total = quantidadeAdquirida * preçoUnitario;
                totalApagar = total = (total * 0.05);
            }

                Console.WriteLine("O total será de: " + total);
                Console.WriteLine("Porém você receberá um desconto e poderá pagar: " + totalApagar);
            }
        }
    }

