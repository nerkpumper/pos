using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NerkSoft.FrameWork.MetroUI;

namespace NerkSoft.Pos.Main
{
    public partial class frmModulos : NerkSoft.FrameWork.MetroUI.NerkFormModulo
    {
        public frmModulos()
        {
            InitializeComponent();
            this.DisableTitleBar();
            this.SetModuleTitle("Productos", ContentAlignment.MiddleCenter);
            this.DisableMenuTop();

            this.AddMouseEvents(mnuDashboard);
            this.AddMouseEvents(mnuPOS);
            this.AddMouseEvents(mnuClientes);
            this.AddMouseEvents(mnuProductos);
            this.AddMouseEvents(mnuReportes);
            this.AddMouseEvents(mnuEmpleados);
            this.AddMouseEvents(mnuPerfiles);
            this.AddMouseEvents(mnuConfiguracion);
            NerkFormModulo.OrderLeftMenuItemMenu(MenuLeft, 100);

            mnuDashboard.Click += mnuOption_Click;
            mnuPOS.Click += mnuOption_Click;
            mnuClientes.Click += mnuOption_Click;
            mnuProductos.Click += mnuOption_Click;
            mnuReportes.Click += mnuOption_Click;
            mnuEmpleados.Click += mnuOption_Click;
            mnuPerfiles.Click += mnuOption_Click;
            mnuConfiguracion.Click += mnuOption_Click;

            clsViewManager.ViewManager = this;
        }

        void mnuOption_Click(object sender, EventArgs e)
        {
            NerkFormModulo.DesSeleccionarBotonesMenu(MenuLeft);            
            ((NerkLeftMenuItem)sender).IsSelected = true;

            clsViewManager.Show(((NerkLeftMenuItem)sender).Tag.ToString());
        }

        private void frmModulos_Load(object sender, EventArgs e)
        {
            mnuOption_Click(mnuDashboard, new EventArgs());
        }

        

    }
}
