using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NerkSoft.FrameWork.MetroUI;

namespace NerkSoft.Pos.Main.Acceso
{
    public partial class frmLogIn : NerkSoft.FrameWork.MetroUI.NerkForm
    {
        public frmLogIn()
        {
            InitializeComponent();
            this.DisableTitleBar();
            this.NavBar.BackColor = clsProjectTemplate.objMain.NavBarBackColor;
        }
    }
}
