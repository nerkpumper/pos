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
    public partial class frmPrincipal : NerkSoft.FrameWork.MetroUI.NerkForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Location = new Point(0, 0);
            this.SetFormTitle(clsProjectTemplate.objMain.Title);
            this.DisableTitleBar();

            this.NavBar.BackColor = clsProjectTemplate.objMain.NavBarBackColor;
            this.lblSystemName.BackColor = clsProjectTemplate.objMain.NavBarBackColor;
            this.lblSystemName.ForeColor = clsProjectTemplate.objMain.NavBarForeColor;
            this.lblUserName.BackColor = clsProjectTemplate.objMain.NavBarBackColor;
            this.lblUserName.ForeColor = clsProjectTemplate.objMain.NavBarForeColor;

            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmModulos form = new frmModulos();
            form.TopLevel = false;

            if (ModuleContainer.Controls.Count > 0)
                ModuleContainer.Controls.Clear();

            form.Parent = ModuleContainer;

            ModuleContainer.Controls.Add(form);

            form.Dock = DockStyle.Fill;

            form.Show();
        }


    }

    
}
