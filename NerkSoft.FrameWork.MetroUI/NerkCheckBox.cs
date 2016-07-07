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
    public partial class NerkCheckBox : CheckBox
    {
        public NerkCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Font = new Font("Segoe UI", (float)10);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.Padding = new Padding(6,0,0,0);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (this.Checked)
            {
                pevent.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 3, 18, 18));
                pevent.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(255, 217, 217, 217))), new Rectangle(0, 3, 18, 18));
                pevent.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(4, 7, 11, 11));
            }
            else
            {
                //pevent.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, 0, 16, 16))
                pevent.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 3, 18, 18));
                pevent.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(255, 217, 217, 217))), new Rectangle(0, 3, 18, 18));                
                //pevent.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(0, 0, 16, 16));
            }
        }
    }
}
