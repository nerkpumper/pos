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
    //ProfessionalColorTable  ToolStripProfessionalRenderer
    

    public partial class NerkMenu : MenuStrip
    {
        private static int WM_PAINT = 0x000F;

        public NerkMenu()
        {
            InitializeComponent();

        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            //this.BackColor = Color.FromArgb(255, 0, 114, 198);
            //this.ForeColor = Color.White;

            this.BackColor = Color.FromArgb(255, 255, 255, 255);
            this.ForeColor = Color.Black;
            
            
        
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            //this.Renderer = new ToolStripProfessionalRenderer(new NerkColorTable());
            //this.Renderer = new NerkColorTable();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Rectangle varSRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                PaintEventArgs varSe = new PaintEventArgs(this.CreateGraphics(), varSRectangle);

                varSe.Graphics.FillRectangle(new SolidBrush(clsProjectTemplate.objModulo.MenuBackColor), new Rectangle(0, 0, this.Width, 1));
                varSe.Graphics.FillRectangle(new SolidBrush(clsProjectTemplate.objModulo.MenuBackColor), new Rectangle(0, this.Height - 1, this.Width, 1));

                
            }


        }

    }

    public class NerkColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(255, 0, 86, 150);
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromArgb(255, 0, 86, 150);
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 0, 114, 198);
            }
        }


        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 0, 114, 198);
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 0, 114, 198);
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.Pink;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.Pink;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(255, 0, 114, 198);
            }
        }

        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return Color.Pink;
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return Color.Pink;
            }
        }

    }

}
