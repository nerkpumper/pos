namespace NerkSoft.FrameWork.MetroUI
{
    partial class NerkMsgBox
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
            this.lblMsg = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.pnlLineaArriba = new System.Windows.Forms.Panel();
            this.pnlLineaAbajo = new System.Windows.Forms.Panel();
            this.btnAceptar = new NerkSoft.FrameWork.MetroUI.NerkButton();
            this.btnCancelar = new NerkSoft.FrameWork.MetroUI.NerkButton();
            this.btnOK = new NerkSoft.FrameWork.MetroUI.NerkButton();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.BackColor = System.Drawing.Color.White;
            this.pnlMainContainer.Controls.Add(this.btnOK);
            this.pnlMainContainer.Controls.Add(this.btnCancelar);
            this.pnlMainContainer.Controls.Add(this.btnAceptar);
            this.pnlMainContainer.Controls.Add(this.lblMsg);
            this.pnlMainContainer.Controls.Add(this.pnlLineaAbajo);
            this.pnlMainContainer.Controls.Add(this.pnlLineaArriba);
            this.pnlMainContainer.Size = new System.Drawing.Size(1184, 259);
            this.pnlMainContainer.Controls.SetChildIndex(this.pnlLineaArriba, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.pnlLineaAbajo, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.lblMsg, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.btnAceptar, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.btnOK, 0);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.BackColor = System.Drawing.Color.White;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(26, 49);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(1102, 93);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "nerkLabel1 ejrlejlk ljeklrjkle ljklejlkr elkjrlk ejrj klelrel kleklr kel rer jl j" +
    "klj kl jlk rlk elkrlke jrkjekl rkle jlkrjelkr jle rje";
            // 
            // pnlLineaArriba
            // 
            this.pnlLineaArriba.BackColor = System.Drawing.Color.Silver;
            this.pnlLineaArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLineaArriba.Location = new System.Drawing.Point(1, 1);
            this.pnlLineaArriba.Name = "pnlLineaArriba";
            this.pnlLineaArriba.Size = new System.Drawing.Size(1182, 1);
            this.pnlLineaArriba.TabIndex = 5;
            // 
            // pnlLineaAbajo
            // 
            this.pnlLineaAbajo.BackColor = System.Drawing.Color.Silver;
            this.pnlLineaAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaAbajo.Location = new System.Drawing.Point(1, 257);
            this.pnlLineaAbajo.Name = "pnlLineaAbajo";
            this.pnlLineaAbajo.Size = new System.Drawing.Size(1182, 1);
            this.pnlLineaAbajo.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.ButtonStyle = NerkSoft.FrameWork.MetroUI.NerkButton.enumTipoBoton.Default;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11.7F);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.IsCustom = false;
            this.btnAceptar.IsSelectableByTab = false;
            this.btnAceptar.IsSelected = false;
            this.btnAceptar.Location = new System.Drawing.Point(851, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 55);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.ButtonStyle = NerkSoft.FrameWork.MetroUI.NerkButton.enumTipoBoton.Default;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.7F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IsCustom = false;
            this.btnCancelar.IsSelectableByTab = false;
            this.btnCancelar.IsSelected = false;
            this.btnCancelar.Location = new System.Drawing.Point(983, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 55);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.ButtonStyle = NerkSoft.FrameWork.MetroUI.NerkButton.enumTipoBoton.Default;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 11.7F);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.IsCustom = false;
            this.btnOK.IsSelectableByTab = false;
            this.btnOK.IsSelected = false;
            this.btnOK.Location = new System.Drawing.Point(983, 180);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 55);
            this.btnOK.TabIndex = 9;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "&OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NerkMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 286);
            this.Name = "NerkMsgBox";
            this.pnlMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NerkLabel lblMsg;
        private System.Windows.Forms.Panel pnlLineaAbajo;
        private System.Windows.Forms.Panel pnlLineaArriba;
        private NerkButton btnOK;
        private NerkButton btnCancelar;
        private NerkButton btnAceptar;
    }
}
