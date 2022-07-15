using Construtores_Propriedades_Delegates_e_Eventos_em_.NET.Models;



public delegate void Operacao(int x, int y);



internal class Program
{
    private static void Main(string[] args)
    {



        Matematica m = new Matematica(10, 20);
        m.Somar();
        


        static void Delegate()
        {
            //Operacao op = Calculadora.Somar;
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op.Invoke(10, 10);
            //op(10, 10);
        }

        static void Constante()
        {
            const double pi = 3.14;
            // pi = 3.14;
            Console.WriteLine(pi);
            Console.ReadLine();
        }

        static void GetSet()
        {
            Data data = new Data();
            //data.SetMes(10);
            data.Mes = 12;
            Console.WriteLine(data.Mes);
        }

        static void OrdemConstrutores()
        {
            Aluno a1 = new Aluno("Pedro", "Silva", "Matemática");
            a1.Apresentar();
        }



        static void UsandoConstrutor()
        {
            Pessoa p1 = new Pessoa("João", "Roas");
            p1.Apresentar();
        }



        static void MesmaInstancia()
        {
            Log log = Log.GetInstance();

            log.PropriedadeLog = "teste instancia";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);
        }
    }
}