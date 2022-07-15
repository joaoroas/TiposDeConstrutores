namespace Construtores_Propriedades_Delegates_e_Eventos_em_.NET.Models
{
    public class Aluno : Pessoa
    {
        public Aluno
        (string nome, string sobrenome, string disciplina)
         : base(nome, sobrenome)
         
        {
            System.Console.WriteLine("construtor classe aluno");
            Console.ReadLine();

        }
    }
}