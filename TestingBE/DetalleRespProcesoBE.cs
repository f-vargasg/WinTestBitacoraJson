using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class DetalleRespProcesoBE
    {
        public List<DetalleProcesoBE> Data { get; set; }
        public bool Success { get; set; }
        public DetalleProcesoBE Process { get; set; }

        public override string ToString()
        {
            string scrap = string.Empty;
            string tmpStr = string.Empty;
            bool wft = true;
            
            if (this.Data !=null)
            {
                foreach (var item in (List<DetalleProcesoBE>)Data)
                {
                    scrap += ((wft ? string.Empty : Environment.NewLine) + item.ToString());
                    wft = false;
                }    
            }
            else
            {
                scrap = "{ Data = null }";
            }
            
            if (!wft)
            {
                tmpStr = "Data { " +  scrap + " } ";
            }
            tmpStr += (Environment.NewLine +  "Success => " + this.Success.ToString());
            if (this.Process != null)
            {
                tmpStr += Environment.NewLine + (this.Process.ToString());
            }
            else
            {
                tmpStr += Environment.NewLine + "Process => null";
            }

            return tmpStr;
        }


    }
}
