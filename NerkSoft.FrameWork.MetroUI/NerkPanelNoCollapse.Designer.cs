namespace NerkSoft.FrameWork.MetroUI
{
    partial class NerkPanelNoCollapse
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLineaTop = new System.Windows.Forms.Panel();
            this.SeccionName = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.SuspendLayout();
            // 
            // pnlLineaTop
            // 
            this.pnlLineaTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLineaTop.BackColor = System.Drawing.Color.Silver;
            this.pnlLineaTop.Location = new System.Drawing.Point(23, 38);
            this.pnlLineaTop.Name = "pnlLineaTop";
            this.pnlLineaTop.Size = new System.Drawing.Size(283, 1);
            this.pnlLineaTop.TabIndex = 7;
            // 
            // SeccionName
            // 
            this.SeccionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeccionName.BackColor = System.Drawing.Color.Transparent;
            this.SeccionName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeccionName.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.SeccionName.ForeColor = System.Drawing.Color.Black;
            this.SeccionName.Location = new System.Drawing.Point(27, 3);
            this.SeccionName.Name = "SeccionName";
            this.SeccionName.Size = new System.Drawing.Size(284, 36);
            this.SeccionName.TabIndex = 6;
            this.SeccionName.Text = "Seccion Name";
            this.SeccionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NerkPanelNoCollapse
            // 
            this.Controls.Add(this.pnlLineaTop);
            this.Controls.Add(this.SeccionName);
            this.Name = "NerkPanelNoCollapse";
            this.Size = new System.Drawing.Size(314, 148);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlLineaTop;
        protected NerkLabel SeccionName;
    }
}
