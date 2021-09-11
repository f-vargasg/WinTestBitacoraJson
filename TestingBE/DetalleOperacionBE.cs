using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public class DetalleOperacionBE
    {
        public DateTime Fechaliquidacion { get; set; }
        public DateTime FechaConcertacion { get; set; }
        public decimal Monto { get; set; }
        public decimal Cantidad { get; set; }
        public int IdOperacion { get; set; }
        public string Compraoventa { get; set; }
        public string Nombreparticipanteparte { get; set; }
        public string Nombreparticipantecontraparte { get; set; }
        public string Descripcionproducto { get; set; }
        public string Descripcionmoneda { get; set; }
        public string NroMercado { get; set; }
        public string CodigoIsin { get; set; }
        public string Estado { get; set; }
        public int Pata { get; set; }
        public string CodigoEstado { get; set; }
        public string ClienteCompradorCUIT { get; set; }
        public string ClasificacionComprador { get; set; }
        public string ClienteVendedorCUIT { get; set; }
        public string ClasificacionVendedor { get; set; }
        public string CodigoLiquidacion { get; set; }
        public string RuedaSiopel { get; set; }
        public string CodigoRuedaSiopel { get; set; }
        public string CodigoMAE { get; set; }
        public decimal Precio { get; set; }
        public string CodigoMAEComprador { get; set; }
        public string CodigoMAEVendedor { get; set; }
    }
}
