using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Frota
    {
        public int IDCADFROTA { get; set; }
        public string CADTIPODEVEICULO { get; set; }
        public string CADVEICULO { get; set; }
        public string CADPLACA { get; set; }
        public string CADCOR { get; set; }
        public string CADANO { get; set; }
        public string CADDOCUMENTACAO { get; set; }
        public DateTime CADDATAVENCIMENTO { get; set; }
        public string CADSTATUS { get; set; }
        public DateTime CADDATACADASTROFROTA { get; set; }
    }
}
