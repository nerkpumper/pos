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

                    this.BackColor = clsProjectTemplate.objColors.Default.BackColor;
                    this.lblMsg.BackColor = this.BackColor;

                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;

                    break;
                case enumTipoMsgBox.Danger:

                    this.BackColor = clsProjectTemplate.objColors.Danger.BackColor;
                    this.lblMsg.BackColor = this.BackColor;

                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Danger.ForeColor;                    
                    
                    break;
                case enumTipoMsgBox.Success:

                    this.BackColor = clsProjectTemplate.objColors.Success.BackColor;
                    this.lblMsg.BackColor = this.BackColor;

                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Success.ForeColor;                   

                    break;

                case enumTipoMsgBox.Primary:

                    this.BackColor = clsProjectTemplate.objColors.Primary.BackColor;
                    this.lblMsg.BackColor = this.BackColor;

                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Primary.ForeColor;

                    break;

                case enumTipoMsgBox.Warning:

                    this.BackColor = clsProjectTemplate.objColors.Warning.BackColor;
                    this.lblMsg.BackColor = this.BackColor;

                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Warning.ForeColor;

                    break;
                default:

                    this.BackColor = clsProjectTemplate.objColors.Default.BackColor;
                    this.lblMsg.BackColor = this.BackColor;

                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;

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
