namespace K19_Treinamento.orientacao_a_objetos
{
    public class TestaCartaoDeCredito
    {
        public static void Main()
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 111111;
            cdc1.dataDeValidade = "01/01/2013";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 222222;
            cdc2.dataDeValidade = "01/01/2014";

            Console.WriteLine($"{cdc1.numero}\n{cdc1.dataDeValidade}");
            Console.WriteLine($"{cdc2.numero}\n{cdc2.dataDeValidade}");
        }
    }
}