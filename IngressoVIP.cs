namespace Aula19dojo2
{
    public class IngressoVIP : Ingresso
    {
        public float ValorAdicional { get; set; }

        public void ValorIngressoVIP()
        {
            float resultado = Valor = ValorAdicional;
            System.Console.WriteLine($"O valor a ser pago pelo ingresso VIP é R${resultado}");
        }
    }
}