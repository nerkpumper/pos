using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NerkSoft.FrameWork.MetroUI
{
    public partial class NerkFormModuloTop : NerkSoft.FrameWork.MetroUI.NerkForm
    {
        private int mintHeigthMenu = 65;
        
        public NerkFormModuloTop()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DisableTitleBar();

            this.lblTitleModuleMenuTop.BackColor = clsProjectTemplate.objModulo.MenuBackColor;
            this.lblTitleModuleMenuTop.ForeColor = clsProjectTemplate.objModulo.MenuForeColor;
            this.MenuTop.BackColor = clsProjectTemplate.objModulo.MenuBackColor;
            this.MenuTop.Width = mintHeigthMenu;
            
            this.Seccion.Dock = DockStyle.Fill;            
        }

        public static void OrderTopMenuItemMenu(Control parent)
        {
            //mintLeftStartMenu;
            int top = 0;
            int left = 200;

            for (int i = parent.Controls.Count - 1; i >= 0; i--)
            {
                if (parent.Controls[i] is NerkLeftMenuItem)
                {
                    if (top == 0)
                        top = parent.Height - ((NerkLeftMenuItem)parent.Controls[i]).Height;


                    ((NerkLeftMenuItem)parent.Controls[i]).Top = top;
                    ((NerkLeftMenuItem)parent.Controls[i]).Left = left;
                    left += ((NerkLeftMenuItem)parent.Controls[i]).Width;                    
                }
            }
        }

        public static void OrderTopMenuItemMenu(Control parent, int pleft)
        {
            //mintLeftStartMenu;
            int top = 0;
            int left = pleft;

            for (int i = parent.Controls.Count - 1; i >= 0; i--)
            {
                if (parent.Controls[i] is NerkLeftMenuItem)
                {
                    if (top == 0)
                        top = parent.Height - ((NerkLeftMenuItem)parent.Controls[i]).Height;


                    ((NerkLeftMenuItem)parent.Controls[i]).Top = top;
                    ((NerkLeftMenuItem)parent.Controls[i]).Left = left;
                    left += ((NerkLeftMenuItem)parent.Controls[i]).Width;
                }
            }
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
