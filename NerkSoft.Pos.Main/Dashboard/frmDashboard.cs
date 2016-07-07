using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NerkSoft.Pos.Main.Dashboard
{
    public partial class frmDashboard : NerkSoft.FrameWork.MetroUI.NerkFormSeccion
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DisableTitleBar();
        }
    }
}
