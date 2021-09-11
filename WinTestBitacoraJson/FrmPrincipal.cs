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

namespace WinTestBitacoraJson
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = ConfigurationManager.AppSettings["frmCaption"]  + " (" + this.Name + ")";
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
                var objeto = JsonConvert.DeserializeObject(jsonString);
                var frm = new FrmShowMessage();
                frm.ShowDialog();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
