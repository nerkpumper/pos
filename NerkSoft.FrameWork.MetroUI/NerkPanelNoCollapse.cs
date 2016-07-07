using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerkSoft.FrameWork.MetroUI
{
    public partial class NerkPanelNoCollapse :Panel
    {
        private bool mShowTitle = true;

        public NerkPanelNoCollapse()
        {
            InitializeComponent();
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Establece el titulo del Panel")]
        public string Titulo
        {
            get { return this.SeccionName.Text; }
            set
            {
                this.SeccionName.Text = value;
                                
                this.Invalidate();
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Muestra u oculta el titulo del panel")]
        public bool ShowTitle
        {
            get { return this.mShowTitle; }
            set
            {                
                this.mShowTitle= value;

                if (this.mShowTitle)
                {
                    pnlLineaTop.Visible = true;
                    SeccionName.Visible = true;
                }
                else
                {
                    pnlLineaTop.Visible = false;
                    SeccionName.Visible = false;
                }
                
                this.Invalidate();
            }
        }
    }
}
