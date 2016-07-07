namespace NerkSoft.FrameWork.MetroUI
{
    partial class NerkFormModulo
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
            this.pnlMenuTop = new System.Windows.Forms.Panel();
            this.lblTitleModuleMenuTop = new System.Windows.Forms.Label();
            this.pnlContainerSeccion = new System.Windows.Forms.Panel();
            this.Seccion = new System.Windows.Forms.Panel();
            this.lblShowHideMenu = new System.Windows.Forms.Label();
            this.MenuLeft = new System.Windows.Forms.Panel();
            this.pnlMainContainer.SuspendLayout();
            this.pnlMenuTop.SuspendLayout();
            this.pnlContainerSeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.pnlContainerSeccion);
            this.pnlMainContainer.Controls.Add(this.pnlMenuTop);
            this.pnlMainContainer.Controls.SetChildIndex(this.pnlMenuTop, 0);
            this.pnlMainContainer.Controls.SetChildIndex(this.pnlContainerSeccion, 0);
            // 
            // pnlMenuTop
            // 
            this.pnlMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenuTop.Controls.Add(this.lblTitleModuleMenuTop);
            this.pnlMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuTop.Location = new System.Drawing.Point(1, 1);
            this.pnlMenuTop.Name = "pnlMenuTop";
            this.pnlMenuTop.Size = new System.Drawing.Size(1182, 40);
            this.pnlMenuTop.TabIndex = 18;
            // 
            // lblTitleModuleMenuTop
            // 
            this.lblTitleModuleMenuTop.BackColor = System.Drawing.Color.White;
            this.lblTitleModuleMenuTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitleModuleMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleModuleMenuTop.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleModuleMenuTop.Location = new System.Drawing.Point(0, 0);
            this.lblTitleModuleMenuTop.Name = "lblTitleModuleMenuTop";
            this.lblTitleModuleMenuTop.Size = new System.Drawing.Size(1182, 38);
            this.lblTitleModuleMenuTop.TabIndex = 1;
            this.lblTitleModuleMenuTop.Text = "Form Menu Title";
            this.lblTitleModuleMenuTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContainerSeccion
            // 
            this.pnlContainerSeccion.Controls.Add(this.Seccion);
            this.pnlContainerSeccion.Controls.Add(this.lblShowHideMenu);
            this.pnlContainerSeccion.Controls.Add(this.MenuLeft);
            this.pnlContainerSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerSeccion.Location = new System.Drawing.Point(1, 41);
            this.pnlContainerSeccion.Name = "pnlContainerSeccion";
            this.pnlContainerSeccion.Size = new System.Drawing.Size(1182, 792);
            this.pnlContainerSeccion.TabIndex = 21;
            // 
            // Seccion
            // 
            this.Seccion.BackColor = System.Drawing.Color.White;
            this.Seccion.Location = new System.Drawing.Point(256, 83);
            this.Seccion.Name = "Seccion";
            this.Seccion.Size = new System.Drawing.Size(1002, 792);
            this.Seccion.TabIndex = 24;
            // 
            // lblShowHideMenu
            // 
            this.lblShowHideMenu.BackColor = System.Drawing.Color.Red;
            this.lblShowHideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowHideMenu.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.lblShowHideMenu.Image = global::NerkSoft.FrameWork.MetroUI.NrkRecursos.menu_24_w_icon_chevron_left;
            this.lblShowHideMenu.Location = new System.Drawing.Point(519, 26);
            this.lblShowHideMenu.Name = "lblShowHideMenu";
            this.lblShowHideMenu.Size = new System.Drawing.Size(34, 34);
            this.lblShowHideMenu.TabIndex = 23;
            this.lblShowHideMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblShowHideMenu.Click += new System.EventHandler(this.lblShowHideMenu_Click);
            this.lblShowHideMenu.MouseLeave += new System.EventHandler(this.pnlMenu_MouseLeave);
            this.lblShowHideMenu.MouseHover += new System.EventHandler(this.lblShowHideMenu_MouseHover);
            // 
            // MenuLeft
            // 
            this.MenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLeft.Location = new System.Drawing.Point(0, 0);
            this.MenuLeft.Name = "MenuLeft";
            this.MenuLeft.Size = new System.Drawing.Size(180, 792);
            this.MenuLeft.TabIndex = 22;
            this.MenuLeft.MouseEnter += new System.EventHandler(this.pnlMenu_MouseEnter);
            this.MenuLeft.MouseLeave += new System.EventHandler(this.pnlMenu_MouseLeave);
            // 
            // NerkFormModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "NerkFormModulo";
            this.Resize += new System.EventHandler(this.NerkFormModulo_Resize);
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMenuTop.ResumeLayout(false);
            this.pnlContainerSeccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.Label lblTitleModuleMenuTop;
        protected System.Windows.Forms.Label lblShowHideMenu;
        protected System.Windows.Forms.Panel MenuLeft;
        protected System.Windows.Forms.Panel pnlContainerSeccion;
        protected System.Windows.Forms.Panel Seccion;
    }
}
