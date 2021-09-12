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

        public void DisplayRespProc(GeneralResponseCylBE<RespProcesoBE> pResProc)
        {
            // General structure
            lblStatusResponseCode.Text = pResProc.StatusResponseCode.ToString();
            lblCodError.Text = (pResProc.CodError == string.Empty ? "No hay Error" : pResProc.CodError);
            lblMessage.Text = pResProc.Mensaje;
            lblOcurrioExcepcion.Text = (pResProc.OcurrioExcepcion ? "Sí" : "No");


            // Data.RespProc.Data
            lblSuccess.Text = (pResProc.Data.Data.Success ? "Sí" : "No");
            // Data.RespProc.Data.Process
            lblCodigo.Text = pResProc.Data.Data.Process.Codigo;
            lblDescripcion.Text = pResProc.Data.Data.Process.Descripcion;

            // Data.RespProcBE
            lblMetaData.Text = ((pResProc.Data.Metadata == string.Empty) ||
                                 (pResProc.Data.Metadata == null) ? "null" : pResProc.Data.Metadata);
            lblRequestId.Text = pResProc.Data.RequestId;
            lblStatus.Text = pResProc.Data.Status;

            // detalle 
            lblNroMercado.Text = pResProc.Data.Data.Data[0].Descripcion;
            lblCompraOVenta.Text = (pResProc.Data.Data.Data[1].Descripcion == "C" ? "Compra" : "Venta");
            lblNroAsignacion.Text = pResProc.Data.Data.Data[2].Descripcion;
            lblDetalleRta.Text = pResProc.Data.Data.Data[3].Codigo + "-" +
                                 pResProc.Data.Data.Data[3].Descripcion;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pnlRespMetaBnv_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
