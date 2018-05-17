using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello
{
    public class Configuracao
    {
        public bool RastrearLocalizacao { get; set; }
        public bool PermitirCookies { get; set; }
        public bool DisponibilizarNoMural { get; set; }
        public bool EnviarPorEmail { get; set; }
        public bool ReceberSms { get; set; }
    }
}
