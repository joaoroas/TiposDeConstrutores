namespace Construtores_Propriedades_Delegates_e_Eventos_em_.NET.Models
{
    public class Pessoa
    {
        private readonly string nome;
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("construtor classe pessoa");
            Console.ReadLine();
        }

        public void Apresentar()
        {
            Console.WriteLine
            ($"Olá meu nome é: {nome} {sobrenome}");
            Console.ReadLine();
        }
    }
}