using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class ConsContrParamsInBE 
    {
        public string __type { get; set; }
        public string NumeroMercado { get; set; }
        public string CompraOVenta { get; set; }
        public string FechaConcertacionDesde { get; set; }
        public string FechaConcertacionHasta { get; set; }
        public string FechaLiquidacionDesde { get; set; }
        public string FechaLiquidacionHasta { get; set; }
        public string Estados { get; set; }

        public override string ToString()
        {
            string res = "( _type: " + this.__type + Environment.NewLine +
                          "NumeroMecado: " + this.NumeroMercado + Environment.NewLine +
                          "CompraVenta:  " + this.CompraOVenta + Environment.NewLine +
                          "FechaConcertacionDesde:  " + this.FechaConcertacionDesde + Environment.NewLine +
                          "FechaConcertacionHasta:  " + this.FechaConcertacionHasta + Environment.NewLine +
                          "FechaLiquidacionDesde:  " + this.FechaLiquidacionDesde + Environment.NewLine +
                          "FechaLiquidacionHasta:  " + this.FechaLiquidacionHasta + Environment.NewLine +
                          "Estados:  " + this.Estados + Environment.NewLine + ")";
            return res;
        }

    }
}
