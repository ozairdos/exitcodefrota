using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class MovAbastecimento
    {
        public int IDABAFROTA { get; set; }
        public DateTime ABADATAFROTA { get; set; }
		public string ABAVEICULO { get; set; }
		public string ABAPOSTO { get; set; }
		public string ABACOMBUSTIVEL { get; set; }
		public decimal ABAVALORUNITARIO { get; set; }
		public decimal ABATOTALPAGO { get; set; }
		public decimal ABAQUANTIDADE { get; set; }
		public decimal ABAKMINICIAL { get; set; }
		public decimal ABAKMFINAL { get; set; }
		public decimal ABAKMTOTAL { get; set; }
		public string ABAMOTORISTA { get; set; }
		public string ABAORIGEM { get; set; }
		public string ABADESTINO { get; set; }
        public decimal ABATOTALCUSTO { get; set; }
        public DateTime ABADATACADASTRO { get; set; }
        public string ABAPLACA { get; set; }
    }
}
