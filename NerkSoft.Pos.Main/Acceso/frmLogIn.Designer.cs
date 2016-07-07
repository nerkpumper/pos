namespace NerkSoft.Pos.Main.Acceso
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.NavBar = new System.Windows.Forms.Panel();
            this.lblSistemaLabel = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.lblSystemName = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.txtUsuario = new NerkSoft.FrameWork.MetroUI.NerkTextBox();
            this.nerkLabel1 = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.nerkLabel2 = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.txtPassword = new NerkSoft.FrameWork.MetroUI.NerkTextBox();
            this.btnEntrar = new NerkSoft.FrameWork.MetroUI.NerkButton();
            this.pnlMainContainer.SuspendLayout();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.btnEntrar);
            this.pnlMainContainer.Controls.Add(this.nerkLabel2);
            this.pnlMainContainer.Controls.Add(this.txtPassword);
            this.pnlMainContainer.Controls.Add(this.nerkLabel1);
            this.pnlMainContainer.Controls.Add(this.txtUsuario);
            this.pnlMainContainer.Controls.Add(this.NavBar);
            this.pnlMainContainer.Size = new System.Drawing.Size(516, 403);
            this.pnlMainContainer.Controls.SetChildIndex(this.NavBar, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.txtUsuario, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.nerkLabel1, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.txtPassword, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.nerkLabel2, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.btnEntrar, 0);
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NavBar.Controls.Add(this.lblSistemaLabel);
            this.NavBar.Controls.Add(this.lblSystemName);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(1, 1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(514, 79);
            this.NavBar.TabIndex = 5;
            // 
            // lblSistemaLabel
            // 
            this.lblSistemaLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblSistemaLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblSistemaLabel.ForeColor = System.Drawing.Color.White;
            this.lblSistemaLabel.Location = new System.Drawing.Point(36, 3);
            this.lblSistemaLabel.Name = "lblSistemaLabel";
            this.lblSistemaLabel.Size = new System.Drawing.Size(93, 31);
            this.lblSistemaLabel.TabIndex = 7;
            this.lblSistemaLabel.Text = "Sistema";
            // 
            // lblSystemName
            // 
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI Light", 32F);
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(3, 23);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(500, 49);
            this.lblSystemName.TabIndex = 6;
            this.lblSystemName.Text = "Punto de Venta";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.blnImgIzqCustom = false;
            this.txtUsuario.BordeSize = 1;
            this.txtUsuario.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(191)))));
            this.txtUsuario.ColorLostFocus = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Formato = NerkSoft.FrameWork.MetroUI.enumFormatoTextBox.STRING;
            this.txtUsuario.Fuente = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ImgPicIzquierda = ((System.Drawing.Image)(resources.GetObject("txtUsuario.ImgPicIzquierda")));
            this.txtUsuario.IsReadOnly = false;
            this.txtUsuario.Location = new System.Drawing.Point(25, 198);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Message = null;
            this.txtUsuario.Multilinea = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NoCaracteres = 32767;
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceHolder = "";
            this.txtUsuario.Requerido = false;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.ShowLeftImg = false;
            this.txtUsuario.ShowRightImg = false;
            this.txtUsuario.Size = new System.Drawing.Size(468, 38);
            this.txtUsuario.strText = "";
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.WhatIControl = null;
            // 
            // nerkLabel1
            // 
            this.nerkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nerkLabel1.Location = new System.Drawing.Point(22, 175);
            this.nerkLabel1.Name = "nerkLabel1";
            this.nerkLabel1.Size = new System.Drawing.Size(76, 19);
            this.nerkLabel1.TabIndex = 7;
            this.nerkLabel1.Text = "Usuario";
            // 
            // nerkLabel2
            // 
            this.nerkLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nerkLabel2.Location = new System.Drawing.Point(22, 254);
            this.nerkLabel2.Name = "nerkLabel2";
            this.nerkLabel2.Size = new System.Drawing.Size(102, 19);
            this.nerkLabel2.TabIndex = 9;
            this.nerkLabel2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.blnImgIzqCustom = false;
            this.txtPassword.BordeSize = 1;
            this.txtPassword.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(191)))));
            this.txtPassword.ColorLostFocus = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Formato = NerkSoft.FrameWork.MetroUI.enumFormatoTextBox.STRING;
            this.txtPassword.Fuente = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ImgPicIzquierda = ((System.Drawing.Image)(resources.GetObject("txtPassword.ImgPicIzquierda")));
            this.txtPassword.IsReadOnly = false;
            this.txtPassword.Location = new System.Drawing.Point(25, 277);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Message = null;
            this.txtPassword.Multilinea = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NoCaracteres = 32767;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceHolder = "";
            this.txtPassword.Requerido = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.ShowLeftImg = false;
            this.txtPassword.ShowRightImg = false;
            this.txtPassword.Size = new System.Drawing.Size(467, 38);
            this.txtPassword.strText = "";
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.WhatIControl = null;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(191)))));
            this.btnEntrar.ButtonStyle = NerkSoft.FrameWork.MetroUI.NerkButton.enumTipoBoton.Primary;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(191)))));
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(110)))), ((int)(((byte)(174)))));
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(191)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.IsCustom = false;
            this.btnEntrar.IsSelectableByTab = false;
            this.btnEntrar.IsSelected = false;
            this.btnEntrar.Location = new System.Drawing.Point(25, 348);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(468, 40);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(516, 430);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogIn";
            this.pnlMainContainer.ResumeLayout(false);
            this.NavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private FrameWork.MetroUI.NerkLabel lblSistemaLabel;
        private FrameWork.MetroUI.NerkLabel lblSystemName;
        private FrameWork.MetroUI.NerkButton btnEntrar;
        private FrameWork.MetroUI.NerkLabel nerkLabel2;
        private FrameWork.MetroUI.NerkTextBox txtPassword;
        private FrameWork.MetroUI.NerkLabel nerkLabel1;
        private FrameWork.MetroUI.NerkTextBox txtUsuario;
    }
}
