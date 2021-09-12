namespace WinTestBitacoraJson
{
    partial class FrmShowMessage
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
            this.ucPnlErrEnvio = new WinTestBitacoraJson.UCPanelError();
            this.tbPageRtaConfRech = new System.Windows.Forms.TabPage();
            this.ucPnlErrConfRech = new WinTestBitacoraJson.UCPanelError();
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
            this.tbMessageControl.Location = new System.Drawing.Point(0, 39);
            this.tbMessageControl.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessageControl.Name = "tbMessageControl";
            this.tbMessageControl.SelectedIndex = 0;
            this.tbMessageControl.Size = new System.Drawing.Size(1119, 714);
            this.tbMessageControl.TabIndex = 0;
            // 
            // tbPgRtaEnvio
            // 
            this.tbPgRtaEnvio.Controls.Add(this.ucPnlErrEnvio);
            this.tbPgRtaEnvio.Location = new System.Drawing.Point(4, 25);
            this.tbPgRtaEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.tbPgRtaEnvio.Name = "tbPgRtaEnvio";
            this.tbPgRtaEnvio.Padding = new System.Windows.Forms.Padding(4);
            this.tbPgRtaEnvio.Size = new System.Drawing.Size(1111, 685);
            this.tbPgRtaEnvio.TabIndex = 0;
            this.tbPgRtaEnvio.Text = "Respuesta Envio";
            this.tbPgRtaEnvio.UseVisualStyleBackColor = true;
            // 
            // ucPnlErrEnvio
            // 
            this.ucPnlErrEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPnlErrEnvio.Location = new System.Drawing.Point(4, 0);
            this.ucPnlErrEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.ucPnlErrEnvio.Name = "ucPnlErrEnvio";
            this.ucPnlErrEnvio.Size = new System.Drawing.Size(1103, 662);
            this.ucPnlErrEnvio.TabIndex = 0;
            // 
            // tbPageRtaConfRech
            // 
            this.tbPageRtaConfRech.Controls.Add(this.ucPnlErrConfRech);
            this.tbPageRtaConfRech.Location = new System.Drawing.Point(4, 25);
            this.tbPageRtaConfRech.Margin = new System.Windows.Forms.Padding(4);
            this.tbPageRtaConfRech.Name = "tbPageRtaConfRech";
            this.tbPageRtaConfRech.Padding = new System.Windows.Forms.Padding(4);
            this.tbPageRtaConfRech.Size = new System.Drawing.Size(1111, 581);
            this.tbPageRtaConfRech.TabIndex = 1;
            this.tbPageRtaConfRech.Text = "Respuesta de Conf./Rech";
            this.tbPageRtaConfRech.UseVisualStyleBackColor = true;
            // 
            // ucPnlErrConfRech
            // 
            this.ucPnlErrConfRech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPnlErrConfRech.Location = new System.Drawing.Point(4, 4);
            this.ucPnlErrConfRech.Margin = new System.Windows.Forms.Padding(5);
            this.ucPnlErrConfRech.Name = "ucPnlErrConfRech";
            this.ucPnlErrConfRech.Size = new System.Drawing.Size(1103, 573);
            this.ucPnlErrConfRech.TabIndex = 1;
            // 
            // FrmShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 755);
            this.Controls.Add(this.tbMessageControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmShowMessage";
            this.Text = "FrmShowMessage";
            this.tbMessageControl.ResumeLayout(false);
            this.tbPgRtaEnvio.ResumeLayout(false);
            this.tbPageRtaConfRech.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMessageControl;
        private System.Windows.Forms.TabPage tbPgRtaEnvio;
        private System.Windows.Forms.TabPage tbPageRtaConfRech;
        private UCPanelError ucPnlErrEnvio;
        private UCPanelError ucPnlErrConfRech;
    }
}