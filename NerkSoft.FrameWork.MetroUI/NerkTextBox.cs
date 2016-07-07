using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;

namespace NerkSoft.FrameWork.MetroUI
{
    public enum enumModoForma
    {
        NUEVO,
        MODIFICAR,
        BORRAR
    }

    public enum enumFormatoTextBox
    {
        STRING,
        INT,
        FLOAT,
        DATE,
        EMAIL
    }

    [ToolboxBitmap(typeof(TextBox))]
    public partial class NerkTextBox : UserControl
    {
        bool mblnToolTipShow = false;
        bool mblnImgDerechaAdelante = false;
        int mintPasosAnimImgDerecha = 0;
        int mintPosLeftDerecha = 0;
        bool mblnValid = false;

        #region Eventos
        public event KeyEventHandler eKeyDown;
        public event EventHandler eTextChanged;
        public delegate void delegateforevent(KeyPressEventArgs pKeyCode);
        public event delegateforevent eKeyPress;
        private Color colEntrar = clsProjectTemplate.objNrkTextBox.ColorEnter;
        private Color colSalir = clsProjectTemplate.objNrkTextBox.ColorLeave;
        private int intBorde = 1;

        private bool imEmpty = false;
        private bool blnImgCumtom = false;

        private bool showLeftImg = false;
        private bool showRightImg = false;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("Segoe UI", (float)10);
            Redimencionar();
            //colEntrar = clsProjectTemplate.objNrkTextBox.ColorEnter;
            //colSalir = clsProjectTemplate.objNrkTextBox.ColorLeave;
            //intBorde = 1;
        }

        public void CursorAtLast()
        {
            //this.txtTexto.SelectionStart = txtTexto.Text.Length;
            this.txtTexto.SelectionStart = 0;
            this.txtTexto.SelectionLength = txtTexto.Text.Length;
        }


        private void OnEnter(object sender, EventArgs e)
        {
            //if (!this.IsReadOnly)
            //{
            txtTexto.SelectionStart = 0;
            txtTexto.SelectionLength = txtTexto.Text.Length;
            //    if (imEmpty)
            //        txtTexto.Select(0, 0);
            //}
            //currentColor = colEntrar;
            currentColor = clsProjectTemplate.objNrkTextBox.ColorEnter;
            this.txtTexto.BackColor = clsProjectTemplate.objNrkTextBox.BackColorEnter;

            this.BackColor = clsProjectTemplate.objNrkTextBox.BackColorEnter;
            this.txtTexto.ForeColor = clsProjectTemplate.objNrkTextBox.ForeColorEnter;
            DrawRec();
        }

        private void OnLeave(object sender, EventArgs e)
        {
            //currentColor = colSalir;
            currentColor = clsProjectTemplate.objNrkTextBox.ColorLeave;

            this.txtTexto.BackColor = clsProjectTemplate.objNrkTextBox.BackColorLeave;

            this.BackColor = clsProjectTemplate.objNrkTextBox.BackColorLeave;
            this.txtTexto.ForeColor = clsProjectTemplate.objNrkTextBox.ForeColorLeave;
            DrawRec();
        }

        private void OnResize(object sender, EventArgs e)
        {
            Redimencionar();
        }

        private void Redimencionar()
        {
            txtTexto.Top = 2 + intBorde;
            txtTexto.Left = 2 + (this.blnImgCumtom ? (this.showLeftImg ? this.picIzquierda.Width : 0) : (this.showLeftImg ? 20 : 0)) + intBorde;
            txtTexto.Width = this.Width - (this.blnImgCumtom ? (this.showLeftImg ? this.picIzquierda.Width : 0) : this.showLeftImg ? 20 : 0) - (this.showRightImg ? 22 : 0) - (intBorde * 2) - 2;

            //txtTexto.Height = this.Height-4;                                
            this.Height = txtTexto.Height + 4 + (intBorde * 2);

            if (this.blnImgCumtom)
                txtTexto.Height = this.Height - (this.intBorde * 2) + 2;

            picDerecha.Left = this.Width - 17 - (intBorde * 2);
            picDerecha.Top = this.Height / 2 - 8;

            picDerecha.Width = 16;
            picDerecha.Height = 16;


            if (!blnImgCumtom)
            {
                picIzquierda.Width = 8;
                picIzquierda.Height = 8;

                picIzquierda.Left = 3 + intBorde;
                picIzquierda.Top = this.Height / 2 - 4;
            }



            mintPosLeftDerecha = picDerecha.Left;

            //if (this.isRequerido && !showLeftImg)
            //{
            //    showLeftImg = true;
            //    picIzquierda.Visible = true;
            //}
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            //if (imEmpty)
            //{
            //    if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Space || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            //    {
            //        procesaTecla = false;
            //        e.Handled = true;
            //        return;
            //    }

            //}

            //procesaTecla = true;
            if (eKeyDown != null)
            {
                eKeyDown(this, e);
            }
        }



        //bool procesaTecla = false;
        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            //if (imEmpty)
            //{
            //    if (!procesaTecla)
            //    {
            //        e.Handled = true;
            //        return;
            //    }

            //    this.txtTexto.Text = "";
            //    this.imEmpty = false;
            //    this.txtTexto.ForeColor = Color.Black;
            //}




            if (eKeyPress != null)
            {
                eKeyPress(e);
            }
        }



        private void OnTextChanged(object sender, EventArgs e)
        {
            //if (!imEmpty)
            //{
            //    this.imEmpty = (this.txtTexto.Text.Trim().Length > 0 ? false : true);

            //    if (imEmpty)
            //    {
            //        if (this.strPlaceHolder.Trim().Length > 0) this.txtTexto.Text = this.strPlaceHolder;
            //        this.txtTexto.ForeColor = Color.LightGray;
            //    }
            //    else
            //    {

            //if (isRequerido && this.txtTexto.Text.Trim().Length == 0)
            //{
            //    PutToolTip();
            //    StartAnimationImgDerecha();
            //}
            //else
            //{
            //    this.ShowRightImg = false;
            //    ttMsgr.Hide(picDerecha);
            //}


            if (eTextChanged != null)
            {
                eTextChanged(this, e);
            }
            //    }
            //}
        }

        private void NSTextBox_Paint(object sender, PaintEventArgs e)
        {
            DrawRec();
        }

        private void NSTextBox_Load(object sender, EventArgs e)
        {
            DrawRec();
        }
        #endregion

        #region Load
        public NerkTextBox()
        {
            InitializeComponent();
            currentColor = this.colSalir;
            this.picIzquierda.Visible = false;
            this.picDerecha.Visible = false;
            this.ttMsgr.ShowAlways = true;
            Redimencionar();
        }
        #endregion

        #region Variables y Propiedades
        private enumFormatoTextBox typFormat;
        private string strMessage;
        private string strWhatIControl;
        private Color currentColor;
        private bool isRequerido = false;
        private string strPlaceHolder = "";

        [Description("Texto cuando la caja esta vacía"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Texto cuando la caja esta vacía
        /// </summary>
        public string PlaceHolder
        {
            get { return strPlaceHolder; }
            set { strPlaceHolder = value; }
        }

        [Description("Indica si es obligatorio el campo"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Indica si el texto es obligatorio
        /// </summary>
        public bool Requerido
        {
            get { return isRequerido; }
            set
            {
                isRequerido = value;
                if (isRequerido)
                {
                    picIzquierda.Image = NrkRecursos.requerido16;
                    picIzquierda.Width = 8;
                    picIzquierda.Height = 8;
                }
                else
                {
                    picIzquierda.Width = 16;
                    picIzquierda.Height = 16;
                }

                this.Invalidate();
            }
        }

        [Description("Alineación del texto"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Indica si el texto es obligatorio
        /// </summary>
        public HorizontalAlignment TextAlign
        {
            get { return this.txtTexto.TextAlign; }
            set
            {
                this.txtTexto.TextAlign = value;

                this.Invalidate();
            }
        }

        [Description("Grosor del Borde"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Grosor del Borde
        /// </summary>
        public int BordeSize
        {
            get { return intBorde; }
            set { intBorde = value; this.Redimencionar(); }
        }

        [Description("Grosor del Borde"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Imagen Izquierda se maneja customizable?
        /// </summary>
        public bool blnImgIzqCustom
        {
            get { return blnImgCumtom; }
            set { blnImgCumtom = value; this.Redimencionar(); }
        }

        [Description("Picture Izquierda"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Picture Izquierda
        /// </summary>
        public Image ImgPicIzquierda
        {
            get { return picIzquierda.Image; }
            set { picIzquierda.Image = value; }
        }

        [Description("Color Foco Control"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Color Foco Control
        /// </summary>
        public Color ColorFocus
        {
            get { return colEntrar; }
            set { colEntrar = value; }
        }

        [Description("Color NO Foco Control"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Color Foco Control
        /// </summary>
        public Color ColorLostFocus
        {
            get { return colSalir; }
            set { colSalir = value; currentColor = colSalir; DrawRec(); }
        }

        [Description("Fuente del Texto"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Fuente del Texto
        /// </summary>
        public Font Fuente
        {
            get { return txtTexto.Font; }
            set { txtTexto.Font = value; this.Redimencionar(); }
        }

        [Description("Formato del TextBox"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Formato del Texto
        /// </summary>
        public enumFormatoTextBox Formato
        {
            get { return typFormat; }
            set { typFormat = value; }
        }

        [Description("Caracter deseado cuando es un PassWordChar"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Caracter en Password
        /// </summary>
        public char PasswordChar
        {
            get { return txtTexto.PasswordChar; }
            set { txtTexto.PasswordChar = value; }
        }

        [Description("Máximo de Caracteres"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Numero Maximo de Caracteres
        /// </summary>
        public int NoCaracteres
        {
            get { return txtTexto.MaxLength; }
            set { txtTexto.MaxLength = (value != 0 ? value : 32767); }
        }

        [Description("Es solo lectura?"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Solo lectura            
        /// </summary>
        public bool IsReadOnly
        {
            get { return txtTexto.ReadOnly; }
            set { txtTexto.ReadOnly = value; }
        }

        [Description("Para ponerle ScrollBars"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Scroll Bar para Multilinea
        /// </summary>
        public ScrollBars ScrollBars
        {
            get { return txtTexto.ScrollBars; }
            set { txtTexto.ScrollBars = value; }
        }

        [Description("Mensage General"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Mensage gral
        /// </summary>
        public string Message
        {
            get { return strMessage; }
            set { strMessage = value; }
        }

        [Description("Que campo controlo yo?"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// A que control controla
        /// </summary>
        public string WhatIControl
        {
            get { return strWhatIControl; }
            set
            {
                strWhatIControl = value;
                this.ttMsgr.ToolTipTitle = this.strWhatIControl;
            }
        }

        [Description("Es Multilínea?"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Es multilinea
        /// </summary>
        public bool Multilinea
        {
            get { return txtTexto.Multiline; }
            set { txtTexto.Multiline = value; }
        }

        [Description("Texto del TextBox en String"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Texto del Textbox
        /// </summary>
        public string strText
        {
            get { return txtTexto.Text.Trim(); }
            set
            {
                txtTexto.Text = value.ToString().Trim();
                //this.imEmpty = (this.txtTexto.Text.Trim().Length > 0 ? false : true);

                //if (imEmpty)
                //{
                //    if (this.strPlaceHolder.Trim().Length > 0) this.txtTexto.Text = this.strPlaceHolder;
                //    this.txtTexto.ForeColor = Color.DarkGray;
                //}
            }
        }

        [Description("Texto del TextBox en Int"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Texto en Numero, al tiro con los errores aki
        /// </summary>
        public int intText
        {
            get
            {
                int valor = 0;
                try
                {
                    valor = Convert.ToInt32((txtTexto.Text.Length == 0 || imEmpty || !IsNumeric(txtTexto.Text) ? "0" : txtTexto.Text));
                }
                catch
                {

                }

                return valor;
            }
        }

        [Description("Texto del TextBox en Double"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Texto en Numero, al tiro con los errores aki
        /// </summary>
        public double dblText
        {
            get
            {

                return Convert.ToDouble((txtTexto.Text.Length == 0 ? "0" : txtTexto.Text));
            }
        }


        [Description("Muestra la Imagen de la Izquierda"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Muestra la Imagen de la izquierda
        /// </summary>
        public bool ShowLeftImg
        {
            get { return this.showLeftImg; }
            set { this.showLeftImg = value; this.picIzquierda.Visible = value; this.Redimencionar(); }
        }

        [Description("Imagen de la Izquierda"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Muestra la Imagen de la izquierda
        /// </summary>
        public PictureBox ImgIzquierda
        {
            get { return this.picIzquierda; }
            set { this.picIzquierda = value; this.Redimencionar(); }
        }

        [Description("Muestra la Imagen de la Derecha"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Muestra la Imagen de la izquierda
        /// </summary>
        public bool ShowRightImg
        {
            get { return this.showRightImg; }
            set { this.showRightImg = value; this.picDerecha.Visible = value; ; this.Redimencionar(); }
        }



        #endregion

        #region Funciones

        /// <summary>
        /// Esta vacía la caja de texto
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            bool blnResult;

            blnResult = false;

            if (txtTexto.Text.Trim().Length == 0)
            {
                //strMessage = "El Elemento \"" + strWhatIControl + "\" No debe ser vacío.";
                blnResult = true;
            }

            return (blnResult);
        }

        private void PutToolTip()
        {
            ttMsgr.SetToolTip(picDerecha, "Este dato es requerido");
            ttMsgr.Show("Este dato es requerido", picDerecha);

        }

        /// <summary>
        /// Realiza la validacion correspondiente al tipo de tado
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            bool blnResult;
            strMessage = "";
            blnResult = true;

            StopAnimationImgDerecha();
            ttMsgr.Hide(picDerecha);
            //if (isRequerido && imEmpty)
            if (isRequerido && this.txtTexto.Text.Trim().Length == 0)
            {
                this.strMessage = "El dato es requerido";
                //PutToolTip();
                StartAnimationImgDerecha();
                return false;
            }

            switch (typFormat)
            {
                case enumFormatoTextBox.FLOAT:
                    if (!IsFloat(txtTexto.Text))
                    {
                        blnResult = false;
                        strMessage = "El Elemento \"" + strWhatIControl + "\" debe ser numérico.";
                        //ttMsgr.SetToolTip(picDerecha, "El dato debe ser Numérico");
                        //ttMsgr.Show("El dato debe ser Numérico", picDerecha);
                    }
                    break;
                case enumFormatoTextBox.INT:
                    if (!IsNumeric(txtTexto.Text))
                    {
                        blnResult = false;
                        strMessage = "El Elemento \"" + strWhatIControl + "\" debe ser numérico (sin decimales).";
                        //ttMsgr.SetToolTip(picDerecha, "El dato debe ser Numérico (sin decimales)");
                        //ttMsgr.Show("El dato debe ser Numérico (sin decimales)", picDerecha);
                    }
                    break;
            }

            if (!blnResult)
                StartAnimationImgDerecha();

            this.ttMsgr.SetToolTip(this.txtTexto, strMessage);
            mblnValid = blnResult;
            return blnResult;
        }

        private void StopAnimationImgDerecha()
        {
            tmrAnimacionImgDerecha.Enabled = false;
            this.ShowRightImg = false;
            //this.ttMsgr.Hide(picDerecha);
        }

        private void StartAnimationImgDerecha()
        {
            tmrAnimacionImgDerecha.Enabled = true;
            this.ShowRightImg = true;
            //this.ttMsgr.Show(this.ttMsgr.GetToolTip(picDerecha), picDerecha, 10000);
        }

        /// <summary>
        /// Devuelve true si es con punto decimal el texto
        /// </summary>
        /// <param name="pstrCad"></param>
        /// <returns></returns>
        private bool IsFloat(string pstrCad)
        {
            if (pstrCad.Contains('.'))
            {
                if (pstrCad.IndexOf('.') != pstrCad.LastIndexOf('.'))
                {
                    return false;
                }
            }

            pstrCad = pstrCad.Replace(".", "");
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(pstrCad);
        }

        /// <summary>
        /// Devuelve true si es numerico el texto
        /// </summary>
        /// <param name="pstrCad"></param>
        /// <returns></returns>
        private bool IsNumeric(string pstrCad)
        {
            if (pstrCad.Contains('.'))
            {
                return false;
            }

            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(pstrCad);
        }

        /// <summary>
        /// Limpia la caja de texto
        /// </summary>
        public void Clear()
        {
            txtTexto.Text = "";
        }

        /// <summary>
        /// Pone el foco a la caja de texto
        /// </summary>
        public void SetFocus()
        {
            txtTexto.Focus();
            this.OnEnter(new EventArgs());
        }

        private void DrawRec()
        {
            for (int i = 0; i < intBorde; i++)
            {
                Rectangle rec2 = new Rectangle(this.ClientRectangle.Left + i, this.ClientRectangle.Top + i, this.ClientRectangle.Width - (i * 2), this.ClientRectangle.Height - (i * 2));
                ControlPaint.DrawBorder(this.CreateGraphics(), rec2, currentColor, ButtonBorderStyle.Solid);
            }

            ////Rectangle rec2 = new Rectangle(this.ClientRectangle.Left + i, this.ClientRectangle.Top + i, this.ClientRectangle.Width - i, this.ClientRectangle.Height - i);
            //ControlPaint.DrawBorder(this.CreateGraphics(), this.ClientRectangle, currentColor, ButtonBorderStyle.Solid);

        }

        private void picDerecha_Click(object sender, EventArgs e)
        {
            this.SetFocus();
            //this.ttMsgr.SetToolTip(picDerecha, this.strMessage);
            //this.ttMsgr.Show(this.strMessage, this.picDerecha);
            //tmrOcultaToolTip.Start();
        }

        private void picIzquierda_Click(object sender, EventArgs e)
        {
            this.SetFocus();
        }

        private void picDerecha_MouseHover(object sender, EventArgs e)
        {
            //this.PutToolTip();
            //this.ttMsgr.Show(ttMsgr.ToolTipTitle, this.picDerecha);
            //this.ttMsgr.Show("Hola mundo", this.txtTexto, 3000);                
        }

        private void NSTextBoxV2_Click(object sender, EventArgs e)
        {
            this.OnEnter(e);
        }

        private void tmrMueveImgDerecha_Tick(object sender, EventArgs e)
        {
            mintPasosAnimImgDerecha++;

            if (mblnImgDerechaAdelante)
            {
                picDerecha.Left = mintPosLeftDerecha - 2;
            }
            else
            {
                picDerecha.Left = mintPosLeftDerecha;
            }
            mblnImgDerechaAdelante = !mblnImgDerechaAdelante;

            if (mintPasosAnimImgDerecha == 6)
                tmrMueveImgDerecha.Enabled = false;
        }

        private void tmrAnimacionImgDerecha_Tick(object sender, EventArgs e)
        {
            mintPasosAnimImgDerecha = 0;
            mblnImgDerechaAdelante = false;
            tmrMueveImgDerecha.Enabled = true;
        }

        #endregion

        private void NrkTextBox_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (strMessage.Trim() != "")
                {
                    this.ttMsgr.Show(strMessage, this.picDerecha);
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void NrkTextBox_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (strMessage.Trim() != "")
                {
                    this.ttMsgr.Hide(this.picDerecha);
                }
            }
            catch (Exception ex)
            {

            }

        }






    }
}
