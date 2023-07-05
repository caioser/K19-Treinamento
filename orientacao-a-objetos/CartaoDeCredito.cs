namespace K19_Treinamento.orientacao_a_objetos
{
    class CartaoDeCredito
    {
        public int numero;
        public string dataDeValidade;
        public Cliente cliente; // Agregação

        public CartaoDeCredito(int numero)
        {
            this.numero = numero;
        }
    }
}
