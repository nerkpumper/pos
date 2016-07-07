namespace NerkSoft.Pos.Main.POS
{
    partial class frmPOS
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
            this.nerkPanel1 = new NerkSoft.FrameWork.MetroUI.NerkPanel();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeccionName
            // 
            this.SeccionName.Text = "Punto de Venta";
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.nerkPanel1);
            this.pnlMainContainer.Controls.SetChildIndex(this.SeccionName, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.pnlLineaTop, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.nerkPanel1, 0);
            // 
            // nerkPanel1
            // 
            this.nerkPanel1.AllowDrop = true;
            this.nerkPanel1.BackColor = System.Drawing.Color.White;
            this.nerkPanel1.HeadingFont = new System.Drawing.Font("Segoe UI", 11F);
            this.nerkPanel1.HeadingHeight = 25;
            this.nerkPanel1.IsCollapsed = false;
            this.nerkPanel1.Location = new System.Drawing.Point(76, 99);
            this.nerkPanel1.Name = "nerkPanel1";
            this.nerkPanel1.PanelStyle = NerkSoft.FrameWork.MetroUI.NerkPanel.enumTipoPanel.Success;
            this.nerkPanel1.Size = new System.Drawing.Size(444, 273);
            this.nerkPanel1.SizeMaxHeigth = 273;
            this.nerkPanel1.TabIndex = 6;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Name = "frmPOS";
            this.pnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FrameWork.MetroUI.NerkPanel nerkPanel1;
    }
}
