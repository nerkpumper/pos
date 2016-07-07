namespace NerkSoft.Pos.Main
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.NavBar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.lblSystemName = new NerkSoft.FrameWork.MetroUI.NerkLabel();
            this.ModuleContainer = new System.Windows.Forms.Panel();
            this.pnlMainContainer.SuspendLayout();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.ModuleContainer);
            this.pnlMainContainer.Controls.Add(this.NavBar);
            this.pnlMainContainer.Controls.SetChildIndex(this.NavBar, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.ModuleContainer, 0);
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NavBar.Controls.Add(this.pictureBox3);
            this.NavBar.Controls.Add(this.lblUserName);
            this.NavBar.Controls.Add(this.lblSystemName);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(1, 1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1182, 63);
            this.NavBar.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::NerkSoft.Pos.Main.NerkRes32.comunication_32_w_icon_user;
            this.pictureBox3.Location = new System.Drawing.Point(789, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(815, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(363, 45);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSystemName
            // 
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(3, 10);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(603, 45);
            this.lblSystemName.TabIndex = 6;
            this.lblSystemName.Text = "SystemName";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModuleContainer
            // 
            this.ModuleContainer.BackColor = System.Drawing.Color.DarkGray;
            this.ModuleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModuleContainer.Location = new System.Drawing.Point(1, 64);
            this.ModuleContainer.Name = "ModuleContainer";
            this.ModuleContainer.Size = new System.Drawing.Size(1182, 769);
            this.ModuleContainer.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMainContainer.ResumeLayout(false);
            this.NavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private FrameWork.MetroUI.NerkLabel lblSystemName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FrameWork.MetroUI.NerkLabel lblUserName;
        private System.Windows.Forms.Panel ModuleContainer;
    }
}
