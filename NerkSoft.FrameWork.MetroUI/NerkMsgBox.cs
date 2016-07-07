using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NerkSoft.FrameWork.MetroUI
{
    public partial class NerkMsgBox : NerkSoft.FrameWork.MetroUI.NerkForm
    {
        public enum enumTipoMsgBox
        {
            Default,
            Primary,
            Success,
            Danger,
            Warning
        }

        public clsMessageBox.enumMsgBoxRespuestas menumRespuesta;

        public NerkMsgBox()
        {
            InitializeComponent();
            DisableTitleBar();
            //this.AllowTransparency = true;
            //this.Opacity = 0.3;
            //this.TransparencyKey = Color.Turquoise;
            //this.BackColor = Color.Turquoise;
        }

        public string strMsg
        {
            get { return this.lblMsg.Text; }
            set { this.lblMsg.Text = value; }
        }

        public void ShowYESNO(enumTipoMsgBox tipo)
        {
            btnOK.Visible = false;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            SetStyle(tipo);
        }

        public void ShowOK(enumTipoMsgBox tipo)
        {
            btnOK.Visible = true;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;

            SetStyle(tipo);
        }

        private void SetStyle(enumTipoMsgBox tipo)
        {
            switch (tipo)
            {
                case enumTipoMsgBox.Default:

                    this.BackColor = Color.FromArgb(255, 213, 213, 213);
                    this.lblMsg.BackColor = this.BackColor;
                    
                    

                    this.lblMsg.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    

                    break;
                case enumTipoMsgBox.Danger:

                    this.BackColor = Color.FromArgb(255, 206, 53, 44);
                    this.lblMsg.BackColor = this.BackColor;
                    
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    
                    
                    break;
                case enumTipoMsgBox.Success:

                    this.BackColor = Color.FromArgb(255, 96, 169, 23);
                    this.lblMsg.BackColor = this.BackColor;
                    
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    

                    break;

                case enumTipoMsgBox.Primary:

                    this.BackColor = Color.FromArgb(255, 29, 161, 226);
                    this.lblMsg.BackColor = this.BackColor;
                    
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);

                    break;

                case enumTipoMsgBox.Warning:

                    this.BackColor = Color.FromArgb(255, 250, 104, 0);
                    this.lblMsg.BackColor = this.BackColor;
                    
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);

                    break;
                default:

                    this.BackColor = Color.FromArgb(255, 213, 213, 213);
                    this.lblMsg.BackColor = this.BackColor;
                    

                    this.lblMsg.ForeColor = Color.FromArgb(255, 0, 0, 0);

                    break;
            }

            this.pnlMainContainer.BackColor = this.BackColor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.menumRespuesta = clsMessageBox.enumMsgBoxRespuestas.Yes;
            //this.Parent.Controls.Remove(this);
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.menumRespuesta = clsMessageBox.enumMsgBoxRespuestas.No;
            //this.Parent.Controls.Remove(this);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.menumRespuesta = clsMessageBox.enumMsgBoxRespuestas.No;
            //this.Parent.Controls.Remove(this);
            this.Close();
        }
    }
}
