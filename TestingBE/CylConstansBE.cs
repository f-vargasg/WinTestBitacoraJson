using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingBE
{
    public enum TipoOperador
    {
        PuestoOperador = 0,
        CustodioOperador = 1
    };

    public static class CylConstansBE
    {
        // ---------------------------------------------------------
        // Remote Bnv Methods
        // nombres de Funciones
        public const string zAutenticarOper = "AutenticaCommand:#Mae.Clear.api";

        // Operaciones Puesto bolsa
        public const string zCrearAsignacionOper = "CrearAsignacion:#Mae.Clear.api";
        public const string zDerivarAsignacionOper = "DerivarAsignacion:#Mae.Clear.api";
        public const string zConfirmarAsignacionOper = "ConfirmarAsignacion:#Mae.Clear.api";
        public const string zEliminarAsignacionOper = "EliminarAsignacion:#Mae.Clear.api";

        // Operaciones Custodio
        public const string zConfirmarAsignaCustodOper = "ConfirmarAsignacionCustodio:#Mae.Clear.api";
        public const string zEliminarAsignaCustodOper = "EliminarAsignacionCustodio:#Mae.Clear.api";

        // Metodos de Consula
        public const string zObtenerOperacionesOper = "ObtenerOperaciones:#Mae.Clear.api";
        public const string zObtenerAsignacionesOper = "ObtenerAsignaciones:#Mae.Clear.api";

        // ---------------------------------------------------------
        // Local Proxy Bnv Methods
        // nombres de Funciones
        public const string zProxyGeneralTest = "/TestCylController";
        public const string zProxyAutenticarOper = "/Autentica";

        // Operaciones Puesto bolsa
        public const string zProxyCrearAsignaOper = "/CreaAsignacion";
        public const string zProxyDerivarAsignacionOper = "/CreaDerivacion";
        public const string zProxyConfirmarAsignacionOper = "/ConfirmaAsigna";
        public const string zProxyEliminarAsignacionOper = "/EliminaAsigna";

        // Operaciones Custodio
        public const string zProxyConfAsignaCustodOper = "/ConfirmaAsigCust";
        public const string zProxyElimAsignaCustodOper = "/EliminaAsigCust";

        // Metodos de Consula
        public const string zProxyObtOperacionesOper = "/ObtOperaciones";
        public const string zProxyObtAsignacionesOper = "/ObtAsignaciones";



        //---------------------------------------------------------------------------------
        // Estados
        public const string zSTATUSOK = "EX0000";
    }
}
