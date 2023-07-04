namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaClienteECartao
    {
        public static void Main()
        {
            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito();

            c.nome = "Rafael Consentino";
            cdc.numero = 111111;

            cdc.cliente = c;

            Console.WriteLine($"{cdc.numero}\n{cdc.cliente.nome}\n");
        }
    }
}
