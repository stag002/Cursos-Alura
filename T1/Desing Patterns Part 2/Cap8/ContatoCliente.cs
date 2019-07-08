namespace DesignPatterns2.Cap8
{
    public class Servico
    {
        public ContatoCliente Servico(Cliente cliente, Cobranca servico)
        {
            ContatoCliente Servico = new ContatoCliente(cliente, servico);
            contato.Dispara();
            return servico;
        }
    }
}