using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestBitacoraJson
{
    public partial class FrmShowSimpleDialog : Form
    {

        public UCPanelErrorS PnlErrEnvio
        {
            get { return ucPnlErrEnvio; }
        }

        public UCPanelErrorS PnlErrConfRech
        {
            get { return ucPnlErrConfRech; }
        }
        public FrmShowSimpleDialog()
        {
            InitializeComponent();
            InitMyComponents();

        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void FillDataTab(int pWichTab,
                        string pStatusResponseCode,
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
            switch (pWichTab)
            {
                case 1:
                    ucPnlErrEnvio.FillData(pStatusResponseCode, pCodError, pMessage, pOcurrioExcepcion,
                                           pSuccess, pCodError, pDescripcion, pMetaData, pRequestId,
                                           pStatus, pNroMercado, pCompraOVenta, pNroAsignacion,
                                           pDetalleRta);
                    break;
                case 2:
                    ucPnlErrConfRech.FillData(pStatusResponseCode, pCodError, pMessage, pOcurrioExcepcion,
                                           pSuccess, pCodError, pDescripcion, pMetaData, pRequestId,
                                           pStatus, pNroMercado, pCompraOVenta, pNroAsignacion,
                                           pDetalleRta);
                    break;
                default:
                    break;
            }
        }
    }
}
