namespace NerkSoft.FrameWork.MetroUI
{
    partial class NerkFormSeccion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SeccionName = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.pnlLineaTop = new System.Windows.Forms.Panel();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.pnlMainContainer.Controls.Add(this.pnlLineaTop);
            this.pnlMainContainer.Controls.Add(this.SeccionName);
            this.pnlMainContainer.Controls.SetChildIndex(this.SeccionName, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.pnlLineaTop, 0);
            // 
            // SeccionName
            // 
            this.SeccionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeccionName.BackColor = System.Drawing.Color.Transparent;
            this.SeccionName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeccionName.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.SeccionName.ForeColor = System.Drawing.Color.Black;
            this.SeccionName.Location = new System.Drawing.Point(21, 3);
            this.SeccionName.Name = "SeccionName";
            this.SeccionName.Size = new System.Drawing.Size(1151, 36);
            this.SeccionName.TabIndex = 4;
            this.SeccionName.Text = "Seccion Name";
            this.SeccionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLineaTop
            // 
            this.pnlLineaTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineaTop.BackColor = System.Drawing.Color.Silver;
            this.pnlLineaTop.Location = new System.Drawing.Point(17, 38);
            this.pnlLineaTop.Name = "pnlLineaTop";
            this.pnlLineaTop.Size = new System.Drawing.Size(1150, 1);
            this.pnlLineaTop.TabIndex = 5;
            // 
            // NerkFormSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Name = "NerkFormSeccion";
            this.pnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected NerkLabel SeccionName;
        protected System.Windows.Forms.Panel pnlLineaTop;
    }
}
