namespace Construtores_Propriedades_Delegates_e_Eventos_em_.NET.Models
{
    public class Data
    {
        private int mes;

        public int Mes
        {
            get
            {
                return this.mes;
            }

            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                    System.Console.WriteLine($"mes valido: {mes}");
                    Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine("mes invalido");
                    Console.ReadLine();
                }
            }
        }

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                System.Console.WriteLine($"mes valido: {mes}");
                Console.ReadLine();
            }
            else
            {
                System.Console.WriteLine("mes invalido");
                Console.ReadLine();
            }
        }


    }
}