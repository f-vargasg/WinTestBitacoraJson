using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingBE
{
    public class DetalleRtaAsignaBE
    {
        public List<DetalleAsignacionBE> Data { get; set; }
        public bool Success { get; set; }
        public DetalleProcesoBE Process { get; set; }
    }
}
