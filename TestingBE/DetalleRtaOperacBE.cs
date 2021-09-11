using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingBE
{
    public class DetalleRtaOperacBE
    {
        public List<DetalleOperacionBE> Data { get; set; }
        public bool Success { get; set; }
        public DetalleProcesoBE Process { get; set; }

    }
}
