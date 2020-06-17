using System;

namespace Aula19dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP bilhete = new IngressoVIP();
            bilhete.Valor = 15;
            bilhete.ValorAdicional = 10.35f;
            bilhete.ImprimirValor();
            bilhete.ValorIngressoVIP();
            System.Console.WriteLine($"O valor adicional a ser pago é R${bilhete.ValorAdicional}");
        }
    }
}
