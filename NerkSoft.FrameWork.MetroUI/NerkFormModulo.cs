using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NerkSoft.FrameWork.MetroUI
{
    public partial class NerkFormModulo : NerkSoft.FrameWork.MetroUI.NerkForm
    {
        private bool mblnMenuExpanded = true;
        private int mintMenuMAXWidth = 180;
        private int mintMenuMINWidth = 40;
        private Panel mselectedPanel;

        public NerkFormModulo()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DisableTitleBar();

            this.MenuLeft.BackColor = clsProjectTemplate.objModulo.MenuBackColor;

            this.lblTitleModuleMenuTop.BackColor = clsProjectTemplate.objModulo.MenuBackColor;
            this.lblTitleModuleMenuTop.ForeColor = clsProjectTemplate.objModulo.MenuForeColor;
            this.pnlMenuTop.BackColor = clsProjectTemplate.objModulo.MenuBackColor;


            this.Seccion.Dock = DockStyle.Fill;

            this.lblShowHideMenu.BackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColor;
            this.lblShowHideMenu.ForeColor = clsProjectTemplate.objNrkLeftMenuItem.ForeColor;

            this.MenuLeft.Width = mintMenuMAXWidth;

            this.lblShowHideMenu.Top = this.MenuLeft.Top;
            this.lblShowHideMenu.Left = this.MenuLeft.Left + this.MenuLeft.Width;
        }

        protected void UnselecSeccion()
        {
            try
            {
                mselectedPanel.Visible = false;
                mselectedPanel.Dock = DockStyle.None;
            }
            catch (Exception ex)
            {

            }
        }

        protected void SelectSeccion(Panel s)
        {
            try
            {
                mselectedPanel = s;
                s.Visible = true;
                s.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {

            }
        }

        public Panel getSeccion
        {
            get { return this.Seccion; }
        }

        public void DisableMenuTop ()
        {
            this.pnlMenuTop.Visible = false;
        }

        private void NerkFormModulo_Resize(object sender, EventArgs e)
        {
            this.lblShowHideMenu.Top = this.MenuLeft.Top;
            this.lblShowHideMenu.Left = this.MenuLeft.Left + this.MenuLeft.Width - this.lblShowHideMenu.Width;
            SetTextInMenuHideShow();
        }

        private void SetTextInMenuHideShow()
        {
            if (mblnMenuExpanded)
            {
                //this.lblShowHideMenu.Text = "-";
                this.lblShowHideMenu.Image = NrkRecursos.menu_24_w_icon_chevron_left;

            }
            else
            {
                //this.lblShowHideMenu.Text = "+";
                this.lblShowHideMenu.Image = NrkRecursos.menu_24_w_icon_chevron_right;
            }
        }

        private void lblShowHideMenu_Click(object sender, EventArgs e)
        {
            if (mblnMenuExpanded)
            {
                for (int x = mintMenuMAXWidth; x >= mintMenuMINWidth; x -= 10)
                {
                    this.MenuLeft.Width = x;
                    this.lblShowHideMenu.Left = this.MenuLeft.Left + this.MenuLeft.Width - this.lblShowHideMenu.Width;
                }
                mblnMenuExpanded = !mblnMenuExpanded;
            }
            else
            {
                //for (int x = mintMenuMINWidth; x <= mintMenuMAXWidth; x += 10)
                //{
                //    this.pnlMenu.Width = x;
                //    this.lblShowHideMenu.Left = this.pnlMenu.Left + this.pnlMenu.Width;
                //}
                this.MenuLeft.Width = mintMenuMAXWidth;
                this.lblShowHideMenu.Left = this.MenuLeft.Left + this.MenuLeft.Width - this.lblShowHideMenu.Width;
                mblnMenuExpanded = !mblnMenuExpanded;
            }

            SetTextInMenuHideShow();
        }

        protected void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            if (!mblnMenuExpanded)
            {
                //this.MenuLeft.Width = mintMenuMAXWidth;
                //this.lblShowHideMenu.Left = this.MenuLeft.Left + this.MenuLeft.Width - this.lblShowHideMenu.Width;
            }
        }

        protected void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!mblnMenuExpanded)
            {
                //this.MenuLeft.Width = mintMenuMINWidth;
                //this.lblShowHideMenu.Left = this.MenuLeft.Left + this.MenuLeft.Width - this.lblShowHideMenu.Width;
            }
        }


        public void AddMouseEvents(Control c)
        {
            c.MouseEnter += this.pnlMenu_MouseEnter;
            c.MouseLeave += this.pnlMenu_MouseLeave;
        }

        public static void DesSeleccionarBotonesMenu(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is NerkLeftMenuItem)
                {
                    ((NerkLeftMenuItem)c).IsSelected = false;
                }
                else
                {
                    if (c is NerkButton)
                    {
                        ((NerkButton)c).IsSelected = false;
                    }
                }

            }
        }

        public static void OrderLeftMenuItemMenu(Control parent)
        {
            int top = 100;

            for (int i = parent.Controls.Count - 1; i >= 0; i--)
            {
                if (parent.Controls[i] is NerkLeftMenuItem)
                {
                    ((NerkLeftMenuItem)parent.Controls[i]).Top = top;
                    ((NerkLeftMenuItem)parent.Controls[i]).Width = parent.Width;
                    //((NerkLeftMenuItem)parent.Controls[i]).Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    top += ((NerkLeftMenuItem)parent.Controls[i]).Height;
                    ((NerkLeftMenuItem)parent.Controls[i]).Left = 0;
                }
            }
        }

        public static void OrderLeftMenuItemMenu(Control parent, int ptop)
        {
            int top = ptop + 70;
            

            for (int i = parent.Controls.Count - 1; i >= 0; i--)
            {
                if (parent.Controls[i] is NerkLeftMenuItem)
                {
                    ((NerkLeftMenuItem)parent.Controls[i]).Top = top;
                    top += ((NerkLeftMenuItem)parent.Controls[i]).Height;
                    ((NerkLeftMenuItem)parent.Controls[i]).Width = parent.Width;
                    //((NerkLeftMenuItem)parent.Controls[i]).Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    ((NerkLeftMenuItem)parent.Controls[i]).Left = 0;
                }
            }

            //foreach (Control c in parent.Controls)
            //{
            //    if (c is NerkLeftMenuItem)
            //    {
            //        ((NerkLeftMenuItem)c).Top = top;
            //        top += ((NerkLeftMenuItem)c).Height;
            //        ((NerkLeftMenuItem)c).Left = 0;
            //    }
            //}
        }

        protected void HideGoHome()
        {
            //lblInicio.Visible = false;
            //pnlSeparatorMenu.Visible = false;
        }

        private void lblShowHideMenu_MouseHover(object sender, EventArgs e)
        {
            this.lblShowHideMenu.BackColor = clsProjectTemplate.objNrkLeftMenuItem.FlatAppearanceMouseOverBackColor;
            this.lblShowHideMenu.ForeColor = clsProjectTemplate.objNrkLeftMenuItem.ForeColor;
        }

        private void lblShowHideMenu_MouseLeave(object sender, EventArgs e)
        {
            this.lblShowHideMenu.BackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColor;
            this.lblShowHideMenu.ForeColor = clsProjectTemplate.objNrkLeftMenuItem.ForeColor;
        }

        protected void SetModuleTitle(string ptitle)
        {
            this.lblTitleModuleMenuTop.Text = ptitle;
        }

        protected void SetModuleTitle(string ptitle, ContentAlignment ca)
        {
            this.lblTitleModuleMenuTop.Text = ptitle;
            this.lblTitleModuleMenuTop.TextAlign = ContentAlignment.MiddleCenter;
        }


    }
}
