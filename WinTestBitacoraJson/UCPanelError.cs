using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingBE;

namespace WinTestBitacoraJson
{
    public partial class UCPanelError : UserControl
    {


        public UCPanelError()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {

        }

        public void DisplayRespProc (GeneralResponseCylBE<RespProcesoBE> pResProc)
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
                                 (pResProc.Data.Metadata == null)? "null" : pResProc.Data.Metadata);
            lblRequestId.Text = pResProc.Data.RequestId;
            lblStatus.Text = pResProc.Data.Status;

            // fill datagrid
            var list = new BindingList<DetalleProcesoBE>(pResProc.Data.Data.Data);
            dgrList.DataSource = list;
        }
    }
}
