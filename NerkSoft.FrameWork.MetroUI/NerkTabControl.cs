using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NerkSoft.FrameWork.MetroUI
{
    public partial class NerkTabControl : TabControl
    {
        private static int WM_PAINT = 0x000F;

        public NerkTabControl()
        {
            InitializeComponent();

            this.Font = new Font(clsProjectTemplate.objFont.Fuente, (float)10);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

        }

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);

        //    if (m.Msg == WM_PAINT)
        //    {
        //        Graphics g = Graphics.FromHwnd(Handle);

        //        Rectangle bounds = new Rectangle(0, 0, Width, Height);
        //        Rectangle bounds2 = new Rectangle(1, 1, Width - 2, Height - 2);


        //        ControlPaint.DrawBorder(g, bounds, Color.Pink, ButtonBorderStyle.None);



        //        Rectangle varSRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        //        PaintEventArgs varSe = new PaintEventArgs(this.CreateGraphics(), varSRectangle);

        //        varSe.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, 0, varSRectangle.Width, varSRectangle.Height - 1));

        //        varSe.Dispose();

        //    }


        //}



        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics g = Graphics.FromHwnd(Handle);

        //    Rectangle bounds = new Rectangle(0, 0, Width, Height);
        //    Rectangle bounds2 = new Rectangle(1, 1, Width - 2, Height - 2);


        //    ControlPaint.DrawBorder(g, bounds, Color.Pink, ButtonBorderStyle.None);



        //    Rectangle varSRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        //    PaintEventArgs varSe = new PaintEventArgs(this.CreateGraphics(), varSRectangle);

        //    varSe.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, 0, varSRectangle.Width, varSRectangle.Height - 1));

        //    varSe.Dispose();
        //}

        //internal void DrawControl(Graphics g)
        //{
        //    if (!Visible)
        //        return;

        //    Brush br = new SolidBrush(Color.Black);
        //    Brush brTab = new SolidBrush(Color.Yellow);

        //    Rectangle TabControlArea = ClientRectangle;
        //    Rectangle TabArea = DisplayRectangle;

        //    g.FillRectangle(br, TabControlArea);
        //    g.FillRectangle(brTab, TabArea);

        //    br.Dispose();
        //    brTab.Dispose();

        //    for (int i = 0; i < TabCount; i++)
        //        DrawTab(g, TabPages[i], i, false);

        //    if (_mouseTabIndex != null && _mouseTabIndex != _mouseTabIndexSave && _mouseTabIndex != SelectedIndex)
        //        DrawTab(g, TabPages[(int)_mouseTabIndex], (int)_mouseTabIndex, true);

        //    _mouseTabIndexSave = _mouseTabIndex;

        //}

        //internal void DrawTab(Graphics g, TabPage tabPage, int nIndex, bool mouseOverTab)
        //{

        //    var recBounds = GetTabRect(nIndex);


        //    SetBounds(ref recBounds);
        //    var pt = SetPointsForTabFill(recBounds);


        //    DrawTabBounds(g, recBounds);


        //    FillTabl(g, recBounds, pt, false);


        //    DrawTabSeparators(g, recBounds, nIndex, 0 /*y-bottom*/);


        //    if (SelectedIndex == nIndex)
        //    {
        //        DrawTabGradient(g, recBounds, pt, nIndex, 0/*width*/, 1/*height*/);
        //        DrawTabSeparators(g, recBounds, nIndex, 1 /*y-bottom*/);
        //    }

        //    if (mouseOverTab)
        //        DrawTabGradient(g, recBounds, pt, nIndex, -2/*width*/, 0/*height*/);

        //    DrawText(g, recBounds, tabPage.Text);

        //}

        //private void DrawText(Graphics g, Rectangle recBounds, string text)
        //{
        //    var strFormat = new StringFormat();
        //    strFormat.Alignment = strFormat.LineAlignment = StringAlignment.Center;

        //    g.TextRenderingHint =
        //        System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        //    //var fnt = new Font(MsFonts.familyPTSans, 8F, FontStyle.Regular,  GraphicsUnit.Point, (byte)204);
        //    var fnt = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));

        //    RectangleF tabTextArea = recBounds;
        //    var br = new SolidBrush(clr_txt);
        //    g.DrawString(text, fnt, br, tabTextArea, FormatString());

        //    br.Dispose();
        //    strFormat.Dispose();
        //    fnt.Dispose();
        //}

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            RectangleF tabTextArea = RectangleF.Empty;
            RectangleF tabArea = RectangleF.Empty;
            for (int nIndex = 0; nIndex < this.TabCount; nIndex++)
            {
                if (nIndex != this.SelectedIndex)
                {
                    /*if not active draw ,inactive close button*/
                    //tabTextArea = (RectangleF)this.GetTabRect(nIndex);
                    //using (Bitmap bmp = new Bitmap(GetContentFromResource(
                    //    "closeinactive.bmp")))
                    //{
                    //    e.Graphics.DrawImage(bmp,
                    //        tabTextArea.X + tabTextArea.Width - 16, 5, 13, 13);
                    //}

                    tabTextArea = (RectangleF)this.GetTabRect(nIndex);
                    Rectangle r = this.DisplayRectangle;
                    //this.TabPages[e.Index].BackColor = Color.Yellow;
                    LinearGradientBrush br = new LinearGradientBrush(tabTextArea, Color.FromArgb(255, 217, 217, 217), Color.FromArgb(255, 217, 217, 217), LinearGradientMode.Vertical);
                    e.Graphics.FillRectangle(br, tabTextArea);

                    string str = this.TabPages[nIndex].Text;
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    using (SolidBrush brush = new SolidBrush(
                        this.TabPages[nIndex].ForeColor))
                    {
                        /*Draw the tab header text*/
                        e.Graphics.DrawString(str, this.Font, brush,
                        tabTextArea, stringFormat);
                    }

                }
                else
                {
                    tabTextArea = (RectangleF)this.GetTabRect(nIndex);
                    LinearGradientBrush br = new LinearGradientBrush(tabTextArea, Color.FromArgb(255, 32, 134, 191), Color.FromArgb(255, 32, 134, 191), LinearGradientMode.Vertical);
                    e.Graphics.FillRectangle(br, tabTextArea);

                    string str = this.TabPages[nIndex].Text;
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    using (SolidBrush brush = new SolidBrush(
                        Color.White))
                    {
                        /*Draw the tab header text*/
                        e.Graphics.DrawString(str, this.Font, brush,
                        tabTextArea, stringFormat);
                    }

                    /////*if active draw ,inactive close button*/
                    ////using (Bitmap bmp = new Bitmap(
                    ////    GetContentFromResource("close.bmp")))
                    ////{
                    ////    e.Graphics.DrawImage(bmp,
                    ////        tabTextArea.X + tabTextArea.Width - 16, 5, 13, 13);
                    ////}
                    //br.Dispose();
                }


            }
        }

        ///// <span class="code-SummaryComment"><summary></span>
        ///// Get the stream of the embedded bitmap image
        ///// <span class="code-SummaryComment"></summary></span>
        ///// <span class="code-SummaryComment"><param name="filename"></param></span>
        ///// <span class="code-SummaryComment"><returns></returns></span>
        //private Stream GetContentFromResource(string filename)
        //{
        //    Assembly asm = Assembly.GetExecutingAssembly();
        //    Stream stream = asm.GetManifestResourceStream(
        //        "MyControlLibrary." + filename);
        //    return stream;
        //}

        //private bool confirmOnClose = true;
        //public bool ConfirmOnClose
        //{
        //    get
        //    {
        //        return this.confirmOnClose;
        //    }
        //    set
        //    {
        //        this.confirmOnClose = value;
        //    }
        //}

        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    RectangleF tabTextArea = (RectangleF)this.GetTabRect(SelectedIndex);
        //    tabTextArea =
        //        new RectangleF(tabTextArea.X + tabTextArea.Width - 16, 5, 13, 13);
        //    Point pt = new Point(e.X, e.Y);
        //    if (tabTextArea.Contains(pt))
        //    {
        //        if (confirmOnClose)
        //        {
        //            if (MessageBox.Show("You are about to close " +
        //                this.TabPages[SelectedIndex].Text.TrimEnd() +
        //                " tab. Are you sure you want to continue?", "Confirm close",
        //                MessageBoxButtons.YesNo) == DialogResult.No)
        //                return;
        //        }
        //        //Fire Event to Client
        //        if (OnClose != null)
        //        {
        //            OnClose(this, new CloseEventArgs(SelectedIndex));
        //        }
        //    }
        //}
    }
}
