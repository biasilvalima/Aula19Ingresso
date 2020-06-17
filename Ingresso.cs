namespace Aula19dojo2
{
    public class Ingresso
    {
        public float Valor { get; set; }

        public void ImprimirValor()
        {
            System.Console.WriteLine($"O valor a ser pago pelo ingresso é R${Valor}");
        }
    }
}