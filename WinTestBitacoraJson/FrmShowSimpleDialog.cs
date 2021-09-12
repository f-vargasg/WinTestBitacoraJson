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
    }
}
