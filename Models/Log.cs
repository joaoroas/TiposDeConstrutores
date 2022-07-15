namespace Construtores_Propriedades_Delegates_e_Eventos_em_.NET.Models
{
    public class Log
    {
        private static Log? _log;

        public string PropriedadeLog { get; set; }

        private Log()
        {

        }

        public static Log GetInstance()
        {
            if(_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }
}