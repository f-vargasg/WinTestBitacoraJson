using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class ConfirRechParamInBE 
    {
        public string __type { get; set; }
        public string NumeroMercado { get; set; }
        public string CompraOVenta { get; set; }
        public int ? NroAsignacion { get; set; }

        public override string ToString()
        {
            string res = "( _type: " + this.__type + Environment.NewLine +
                      "NumeroMecado: " + this.NumeroMercado + Environment.NewLine +
                      "CompraOVenta:  " + this.CompraOVenta + Environment.NewLine +
                      "NroAsignacion:  " + this.NroAsignacion + Environment.NewLine + ")";
            return res;
        }

    }
}
