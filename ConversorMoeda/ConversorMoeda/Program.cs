using System;
using System.Globalization;

namespace ConversorMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dolares você vai comprar: ");
            double qtde = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser pao em reais = " + ConversorMoeda.Converter(qtde, cotacao));
        }
    }
}
