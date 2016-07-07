namespace NerkSoft.FrameWork.MetroUI
{
    partial class NerkNotify
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
            this.lblMsg = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.lblClose = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.lblTitle = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font(clsProjectTemplate.objFont.Fuente, 10F);
            this.lblMsg.Location = new System.Drawing.Point(3, 27);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(297, 93);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "nerkLabel1";
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font(clsProjectTemplate.objFont.Fuente, 11.7F);
            this.lblClose.Location = new System.Drawing.Point(274, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font(clsProjectTemplate.objFont.Fuente, 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "nerkLabel1";
            // 
            // NerkNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "NerkNotify";
            this.Size = new System.Drawing.Size(300, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private NerkLabel lblTitle;
        private NerkLabel lblClose;
        private NerkLabel lblMsg;
    }
}
