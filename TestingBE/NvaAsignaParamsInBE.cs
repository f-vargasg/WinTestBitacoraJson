using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class NvaAsignaParamsInBE 
    {
        public string __type { get; set; }
        public string NumeroMercado { get; set; }
        public string CompraOVenta { get; set; }
        public int ? NroAsignacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Comision { get; set; }
        public string NotasAgente { get; set; }
        public string NotasCustodio { get; set; }
        public string CuentaVN { get; set; }
        public string CuentaEF { get; set; }

        public override string ToString()
        {
            string res = "( _type: " + this.__type + Environment.NewLine +
              "NumeroMecado: " + this.NumeroMercado + Environment.NewLine +
              "CompraOVenta:  " + this.CompraOVenta + Environment.NewLine +
              "NroAsignacion:  " + this.NroAsignacion + Environment.NewLine +
              "Cantidad:  " + this.Cantidad.ToString() + Environment.NewLine +
              "Comision:  " + this.Comision.ToString() + Environment.NewLine +
              "NotasAgente:  " + this.NotasAgente + Environment.NewLine +
              "NotasCustodio:  " + this.NotasCustodio + Environment.NewLine +
              "CuentaVN:  " + this.CuentaVN + Environment.NewLine +
              "CuentaEF:  " + this.CuentaEF + Environment.NewLine + ")";
            return res;
        }
    }
}
