
namespace WinTestBitacoraJson
{
    partial class FrmShowSimpleDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMessageControl = new System.Windows.Forms.TabControl();
            this.tbPgRtaEnvio = new System.Windows.Forms.TabPage();
            this.tbPageRtaConfRech = new System.Windows.Forms.TabPage();
            this.ucPnlErrEnvio = new WinTestBitacoraJson.UCPanelErrorS();
            this.ucPnlErrConfRech = new WinTestBitacoraJson.UCPanelErrorS();
            this.tbMessageControl.SuspendLayout();
            this.tbPgRtaEnvio.SuspendLayout();
            this.tbPageRtaConfRech.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMessageControl
            // 
            this.tbMessageControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessageControl.Controls.Add(this.tbPgRtaEnvio);
            this.tbMessageControl.Controls.Add(this.tbPageRtaConfRech);
            this.tbMessageControl.Location = new System.Drawing.Point(4, 59);
            this.tbMessageControl.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessageControl.Name = "tbMessageControl";
            this.tbMessageControl.SelectedIndex = 0;
            this.tbMessageControl.Size = new System.Drawing.Size(1186, 642);
            this.tbMessageControl.TabIndex = 1;
            // 
            // tbPgRtaEnvio
            // 
            this.tbPgRtaEnvio.Controls.Add(this.ucPnlErrEnvio);
            this.tbPgRtaEnvio.Location = new System.Drawing.Point(4, 22);
            this.tbPgRtaEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.tbPgRtaEnvio.Name = "tbPgRtaEnvio";
            this.tbPgRtaEnvio.Padding = new System.Windows.Forms.Padding(4);
            this.tbPgRtaEnvio.Size = new System.Drawing.Size(1178, 616);
            this.tbPgRtaEnvio.TabIndex = 0;
            this.tbPgRtaEnvio.Text = "Respuesta Envio";
            this.tbPgRtaEnvio.UseVisualStyleBackColor = true;
            // 
            // tbPageRtaConfRech
            // 
            this.tbPageRtaConfRech.Controls.Add(this.ucPnlErrConfRech);
            this.tbPageRtaConfRech.Location = new System.Drawing.Point(4, 22);
            this.tbPageRtaConfRech.Margin = new System.Windows.Forms.Padding(4);
            this.tbPageRtaConfRech.Name = "tbPageRtaConfRech";
            this.tbPageRtaConfRech.Padding = new System.Windows.Forms.Padding(4);
            this.tbPageRtaConfRech.Size = new System.Drawing.Size(1178, 616);
            this.tbPageRtaConfRech.TabIndex = 1;
            this.tbPageRtaConfRech.Text = "Respuesta de Conf./Rech";
            this.tbPageRtaConfRech.UseVisualStyleBackColor = true;
            // 
            // ucPnlErrEnvio
            // 
            this.ucPnlErrEnvio.Location = new System.Drawing.Point(5, 6);
            this.ucPnlErrEnvio.Name = "ucPnlErrEnvio";
            this.ucPnlErrEnvio.Size = new System.Drawing.Size(1168, 605);
            this.ucPnlErrEnvio.TabIndex = 1;
            // 
            // ucPnlErrConfRech
            // 
            this.ucPnlErrConfRech.Location = new System.Drawing.Point(3, 3);
            this.ucPnlErrConfRech.Name = "ucPnlErrConfRech";
            this.ucPnlErrConfRech.Size = new System.Drawing.Size(1168, 605);
            this.ucPnlErrConfRech.TabIndex = 0;
            // 
            // FrmShowSimpleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 705);
            this.Controls.Add(this.tbMessageControl);
            this.Name = "FrmShowSimpleDialog";
            this.Text = "FrmShowSimpleDialog";
            this.tbMessageControl.ResumeLayout(false);
            this.tbPgRtaEnvio.ResumeLayout(false);
            this.tbPageRtaConfRech.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMessageControl;
        private System.Windows.Forms.TabPage tbPgRtaEnvio;
        private System.Windows.Forms.TabPage tbPageRtaConfRech;
        private UCPanelErrorS ucPnlErrConfRech;
        private UCPanelErrorS ucPnlErrEnvio;
    }
}