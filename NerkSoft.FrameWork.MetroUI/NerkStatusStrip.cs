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
    public partial class NerkStatusStrip : StatusStrip
    {
        private static int WM_PAINT = 0x000F;

        public NerkStatusStrip()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = Color.White;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Rectangle varSRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                PaintEventArgs varSe = new PaintEventArgs(this.CreateGraphics(), varSRectangle);

                varSe.Graphics.FillRectangle(new SolidBrush(clsProjectTemplate.objModulo.MenuBackColor), new Rectangle(0, 0, this.Width, 1));


            }


        }
    }
}
