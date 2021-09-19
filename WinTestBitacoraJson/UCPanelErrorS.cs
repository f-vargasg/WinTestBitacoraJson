using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingBE;

namespace WinTestBitacoraJson
{
    public partial class UCPanelErrorS : UserControl
    {
        public UCPanelErrorS()
        {
            InitializeComponent();
            InitMyComponents();
        }

        public bool MyProperty { get; set; }

        private void InitMyComponents()
        {
            foreach (var item in CommonUtils.GetAll(this, typeof(Label)))
            {
                if (item is Label)
                {
                    Console.WriteLine(item.Name);
                    if (item.Name.Substring(0, 3) == "lbl")
                    {
                        ((Label)item).Text = string.Empty;
                    }
                }
            }
        }

        public void FillData(string pStatusResponseCode,
                     string pCodError,
                     string pMessage,
                     bool pOcurrioExcepcion,
                     bool pSuccess,
                     string pCodigo,
                     string pDescripcion,
                     string pMetaData,
                     string pRequestId,
                     string pStatus,
                     string pNroMercado,
                     string pCompraOVenta,
                     string pNroAsignacion,
                     string pDetalleRta)
        {
            // General structure
            lblStatusResponseCode.Text = pStatusResponseCode;
            lblCodError.Text = (pCodError == string.Empty ? "No hay Error" : pCodError);
            lblMessage.Text = pMessage;
            lblOcurrioExcepcion.Text = (pOcurrioExcepcion ? "Sí" : "No");


            // Data.RespProc.Data
            lblSuccess.Text = (pSuccess ? "Sí" : "No");
            // Data.RespProc.Data.Process
            lblCodigo.Text = pCodigo;
            lblDescripcion.Text = pDescripcion;

            // Data.RespProcBE
            lblMetaData.Text = ((pMetaData == string.Empty) ||
                                 (pMetaData == null) ? "null" : pMetaData);
            lblRequestId.Text = pRequestId;
            lblStatus.Text = pStatus;

            // detalle 
            lblNroMercado.Text = pNroMercado;
            lblCompraOVenta.Text = pCompraOVenta;
            lblNroAsignacion.Text = pNroAsignacion;
            lblDetalleRta.Text = pDetalleRta;

        }

        
    }
}
