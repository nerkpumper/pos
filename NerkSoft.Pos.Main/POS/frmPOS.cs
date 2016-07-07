using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NerkSoft.Pos.Main.POS
{
    public partial class frmPOS : NerkSoft.FrameWork.MetroUI.NerkFormSeccion
    {
        public frmPOS()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DisableTitleBar();
        }
    }
}
