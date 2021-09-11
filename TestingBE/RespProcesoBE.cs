using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class RespProcesoBE 
    {
        public DetalleRespProcesoBE Data { get; set; }
        public string Metadata { get; set; }
        public string RequestId { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            string res = string.Empty;
            string scrap = string.Empty;

            if (this.Data != null)
            {
                res =  "{ Data => " +   this.Data.ToString() + "}";
            }
            else
            {
                res = "{ Data =>  null }";
            }
            res += (Environment.NewLine + "{ Metadata => " + this.Metadata + "}");
            res += (Environment.NewLine + "{ RequestId => " + this.RequestId + "}");
            res += (Environment.NewLine + "{ Status => " + this.Status + "}");


            return res;
        }
    }
}
