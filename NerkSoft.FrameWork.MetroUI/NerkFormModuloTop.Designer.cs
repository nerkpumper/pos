namespace NerkSoft.FrameWork.MetroUI
{
    partial class NerkFormModuloTop
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
            this.pnlContainSeccion = new System.Windows.Forms.Panel();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.lblTitleModuleMenuTop = new System.Windows.Forms.Label();
            this.Seccion = new System.Windows.Forms.Panel();
            this.pnlMainContainer.SuspendLayout();
            this.pnlContainSeccion.SuspendLayout();
            this.MenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.pnlContainSeccion);
            this.pnlMainContainer.Controls.SetChildIndex(this.pnlContainSeccion, 0);
            // 
            // pnlContainSeccion
            // 
            this.pnlContainSeccion.Controls.Add(this.Seccion);
            this.pnlContainSeccion.Controls.Add(this.MenuTop);
            this.pnlContainSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainSeccion.Location = new System.Drawing.Point(1, 1);
            this.pnlContainSeccion.Name = "pnlContainSeccion";
            this.pnlContainSeccion.Size = new System.Drawing.Size(1182, 832);
            this.pnlContainSeccion.TabIndex = 19;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuTop.Controls.Add(this.lblTitleModuleMenuTop);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1182, 105);
            this.MenuTop.TabIndex = 14;
            // 
            // lblTitleModuleMenuTop
            // 
            this.lblTitleModuleMenuTop.BackColor = System.Drawing.Color.White;
            this.lblTitleModuleMenuTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitleModuleMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleModuleMenuTop.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleModuleMenuTop.Location = new System.Drawing.Point(0, 0);
            this.lblTitleModuleMenuTop.Name = "lblTitleModuleMenuTop";
            this.lblTitleModuleMenuTop.Size = new System.Drawing.Size(1182, 31);
            this.lblTitleModuleMenuTop.TabIndex = 1;
            this.lblTitleModuleMenuTop.Text = "Form Menu Title";
            this.lblTitleModuleMenuTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Seccion
            // 
            this.Seccion.BackColor = System.Drawing.Color.White;
            this.Seccion.Location = new System.Drawing.Point(149, 138);
            this.Seccion.Name = "Seccion";
            this.Seccion.Size = new System.Drawing.Size(283, 341);
            this.Seccion.TabIndex = 19;
            // 
            // NerkFormModuloTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Name = "NerkFormModuloTop";
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlContainSeccion.ResumeLayout(false);
            this.MenuTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainSeccion;
        protected System.Windows.Forms.Panel Seccion;
        protected System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Label lblTitleModuleMenuTop;


    }
}
