using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerkSoft.FrameWork.MetroUI
{
    public partial class NerkForm : Form
    {
        private bool mblnIsMouseDown = false;
        private Point mpMouseOffset;
        public bool mblnAllowMoving = true;

        private clsNotifyManager _nerkNotificador = null;

        public NerkForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;            


            this.pnlHeader.BackColor = clsProjectTemplate.objMain.HeaderBackColor;
            this.lblFormTitle.BackColor = clsProjectTemplate.objMain.HeaderBackColor;
            this.lblFormTitle.ForeColor = clsProjectTemplate.objMain.HeaderForeColor;

            pnlLeft.Visible = false;
            pnlTop.Visible = false;
            pnlRight.Visible = false;
            pnlBottom.Visible = false;
        }

        /// <summary>
        /// Manager de Notificaciones
        /// </summary>
        protected clsNotifyManager NotyManager
        {
            get 
            { 
                if (this._nerkNotificador == null)
                {
                    this._nerkNotificador = new clsNotifyManager();
                    this._nerkNotificador.Container = this;
                }

                return this._nerkNotificador;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NerkForm_Resize(object sender, EventArgs e)
        {
            this.picClose.Left = this.Width - 16 - 5;
            this.picMinimize.Left = this.Width - 32 - 7;
            this.lblFormTitle.Width = this.picMinimize.Left - this.lblFormTitle.Left;
        }

        private void lblFormTitle_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FixedFrameBorderSize.Width - this.lblFormTitle.Left;
                yOffset = -e.Y - SystemInformation.FixedFrameBorderSize.Height;

                mpMouseOffset = new Point(xOffset, yOffset);

                mblnIsMouseDown = true;
            }
        }

        private void lblFormTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && mblnAllowMoving)
            {
                mblnIsMouseDown = false;
            }
        }

        private void lblFormTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mblnIsMouseDown && mblnAllowMoving)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mpMouseOffset.X, mpMouseOffset.Y);
                Location = mousePos;
            }
        }

        protected void DisableTitleBar()
        {
            this.pnlHeader.Visible = false;
        }

        protected void SetFormTitle(string ptitle)
        {
            this.lblFormTitle.Text = ptitle;
        }

        protected void SetFormTitle(string ptitle, ContentAlignment ca)
        {
            this.lblFormTitle.Text = ptitle;
            this.lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
        }


        protected void CreateFrame()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.pnlHeader.BackColor = clsProjectTemplate.objMainFrame.BackColor;
            this.lblFormTitle.BackColor = clsProjectTemplate.objMainFrame.BackColor;
            this.lblFormTitle.ForeColor = clsProjectTemplate.objMainFrame.ForeColor;

            this.pnlLeft.BackColor = clsProjectTemplate.objMainFrame.BackColor;
            this.pnlTop.BackColor = clsProjectTemplate.objMainFrame.BackColor;
            this.pnlRight.BackColor = clsProjectTemplate.objMainFrame.BackColor;
            this.pnlBottom.BackColor = clsProjectTemplate.objMainFrame.BackColor;

            this.picIcon.Visible = false;
            //this.picClose.Visible = false;
            this.picMinimize.Visible = false;

            this.pnlLeft.Visible = true;
            this.pnlTop.Visible = true;
            this.pnlRight.Visible = true;
            this.pnlBottom.Visible = true;
        }

    }
}
