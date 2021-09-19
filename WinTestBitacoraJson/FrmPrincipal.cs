using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingBE;

namespace WinTestBitacoraJson
{
    public partial class FrmPrincipal : Form
    {
        private int conteo; 
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["frmCaption"]  + " (" + this.Name + ")";
            lblValor.Text = string.Empty;
            tmrPrueba.Enabled = false;
            prgWork.Value = 0;
        }

        private string GetJsonData ()
        {
            string res = "{ " + Environment.NewLine +
                         "      \"StatusResponseCode\": 200,  " + Environment.NewLine +
                         "      \"CodError\": \"\",  " + Environment.NewLine +
                         "      \"Mensaje\": \"\",  " + Environment.NewLine +
                         "      \"OcurrioExcepcion\": false,  " + Environment.NewLine +
                         "      \"Data\": {  " + Environment.NewLine +
                         "          \"Data\": {  " + Environment.NewLine +
                         "              \"Data\": [  " + Environment.NewLine +
                         "                  {  " + Environment.NewLine +
                         "                      \"Codigo\": \"NroMercado\",  " + Environment.NewLine +
                         "                      \"Descripcion\": \"21090768016\"  " + Environment.NewLine +
                         "                  },  " + Environment.NewLine +
                         "                  {  " + Environment.NewLine +
                         "                      \"Codigo\": \"CompraOVenta\",  " + Environment.NewLine +
                         "                      \"Descripcion\": \"C\"  " + Environment.NewLine +
                         "                  },  " + Environment.NewLine +
                         "                  {  " + Environment.NewLine +
                         "                      \"Codigo\": \"NroAsignacion\",  " + Environment.NewLine +
                         "                      \"Descripcion\": \"1\"  " + Environment.NewLine +
                         "                  },  " + Environment.NewLine +
                         "                  {  " + Environment.NewLine +
                         "                      \"Codigo\": \"EX0000\",  " + Environment.NewLine +
                         "                      \"Descripcion\": \"No puede modificar la operacion  por el estado de la misma.\"  " + Environment.NewLine +
                         "                  }  " + Environment.NewLine +
                         "              ],  " + Environment.NewLine +
                         "              \"Success\": false,  " + Environment.NewLine +
                         "              \"Process\": {  " + Environment.NewLine +
                         "                  \"Codigo\": \"CONFAC\",  " + Environment.NewLine +
                         "                  \"Descripcion\": \"Confirmar Asignación Custodio\"  " + Environment.NewLine +
                         "              }  " + Environment.NewLine +
                         "          },  " + Environment.NewLine +
                         "          \"Metadata\": null,  " + Environment.NewLine +
                         "          \"RequestId\": \"1080fd8d-d51c-4586-8261-1ad14931d081\",  " + Environment.NewLine +
                         "          \"Status\": \"EX0000\"  " + Environment.NewLine +
                         "      }  " + Environment.NewLine +
                         "  }";
            return res;
        }

        private void tlstrDo_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonString = GetJsonData();
                var respProc = JsonConvert.DeserializeObject<GeneralResponseCylBE<RespProcesoBE>>(jsonString);
                var frm = new FrmShowMessage();
                frm.PnlErrEnvio.DisplayRespProc(respProc);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tmrPrueba_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();
            if (prgWork.Value < 100)
            {
                prgWork.Value++;
            }
            if (prgWork.Value == 100)
            {
                tmrPrueba.Enabled = false;
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = true;
            prgWork.Value = 0;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = false;
        }

        private void bntCalculo_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 100000; n++)
            {
                // something do
                if (n % 100 == 0)
                {
                    prgWork.PerformStep();
                }
            }
        }

        private void tlsStrpTest_Click(object sender, EventArgs e)
        {
            string salida = string.Empty ; 
            // CommonUtils.GetAll(this, typeof(Label))
            foreach (var item in CommonUtils.GetAll(this, typeof(Label)))
            {
                Console.WriteLine(item.Name);
                salida += (item.Name + Environment.NewLine);
            }

            txtInput.Text = salida;
        }

        private void tlsStrDo2_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonString = GetJsonData();
                var respProc = JsonConvert.DeserializeObject<GeneralResponseCylBE<RespProcesoBE>>(jsonString);
                var frm = new FrmShowSimpleDialog();
                string metaData = ((respProc.Data.Metadata == string.Empty) ||
                                 (respProc.Data.Metadata == null) ? "null" : respProc.Data.Metadata);
                frm.FillDataTab(2, respProc.StatusResponseCode.ToString(), respProc.CodError, respProc.Mensaje,
                               respProc.OcurrioExcepcion, respProc.Data.Data.Success, respProc.Data.Data.Process.Codigo,
                               respProc.Data.Data.Process.Descripcion, metaData, respProc.Data.RequestId,
                               respProc.Data.Status, respProc.Data.Data.Data[0].Descripcion,
                               (respProc.Data.Data.Data[1].Descripcion == "C" ? "Compra" : "Venta"),
                               respProc.Data.Data.Data[2].Descripcion,
                               respProc.Data.Data.Data[3].Codigo + "-" + respProc.Data.Data.Data[3].Descripcion);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
