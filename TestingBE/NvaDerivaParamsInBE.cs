using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class NvaDerivaParamsInBE 
    {
        public string __type { get; set; }
        public string NumeroMercado { get; set; }
        public string CompraOVenta { get; set; }
        public int ? NroAsignacion { get; set; }
        public string CuentaCustodioVN { get; set; }
        public decimal Comision { get; set; }
        public string NotasAgente { get; set; }
        public string CuentaCustodioEF { get; set; }
        public decimal Cantidad { get; set; }
        public string Custodio { get; set; }

        public override string ToString()
        {
            string res = "( _type: " + this.__type + Environment.NewLine +
              "NumeroMecado: " + this.NumeroMercado + Environment.NewLine +
              "CompraOVenta:  " + this.CompraOVenta + Environment.NewLine +
              "NroAsignacion:  " + this.NroAsignacion + Environment.NewLine +
              "Cantidad:  " + this.Cantidad.ToString() + Environment.NewLine +
              "Comision:  " + this.Comision.ToString() + Environment.NewLine +
              "NotasAgente:  " + this.NotasAgente + Environment.NewLine +
              "CuentaCustodioEF:  " + this.CuentaCustodioEF + Environment.NewLine +
              "CuentaCustodioVN:  " + this.CuentaCustodioVN + Environment.NewLine +
              "Custodio:  " + this.Custodio + Environment.NewLine + ")";
            return res;
        }
    }
}
