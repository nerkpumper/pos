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
    public partial class NerkComboBox : ComboBox
    {
        #region Variables

        bool mblnToolTipShow = false;

        ToolTip ttmsg;
        bool isRequerido;
        string strWhatIControl;

        private Color _colorLeave;
        private Color _colorLeaveTmp;
        private Color _colorEnter;
        private Color _colorError;
        private Color _borderColor;
        private Color _flechita;
        private ButtonBorderStyle _borderStyle;
        private static int WM_PAINT = 0x000F;
        #endregion

        #region Load
        public NerkComboBox()
        {
            InitializeComponent();
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter += NrkComboBox_Enter;
            this.Leave += NrkComboBox_Leave;
            this.ttmsg = new ToolTip();

            //ttmsg.IsBalloon = true;
            ttmsg.ToolTipIcon = ToolTipIcon.Info;
            ttmsg.ShowAlways = false;

            this.Font = new Font(clsProjectTemplate.objFont.Fuente, (float)10);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            //_colorLeave = clsProjectTemplate.objNrkComboBox.ColorLeave;
            //_colorLeaveTmp = clsProjectTemplate.objNrkComboBox.ColorLeave;
            //_colorEnter = clsProjectTemplate.objNrkComboBox.ColorEnter;
            //_colorError = clsProjectTemplate.objNrkComboBox.ColorError;
            //_borderColor = clsProjectTemplate.objNrkComboBox.ColorLeave;
            //_flechita = clsProjectTemplate.objNrkComboBox.FlechitaLeave;
            //_borderStyle = ButtonBorderStyle.Solid;
            InitControl();
        }

        public void InitControl()
        {
            _colorLeave = clsProjectTemplate.objNerkComboBox.ColorLeave;
            _colorLeaveTmp = clsProjectTemplate.objNerkComboBox.ColorLeave;
            _colorEnter = clsProjectTemplate.objNerkComboBox.ColorEnter;
            _colorError = clsProjectTemplate.objNerkComboBox.ColorError;
            _borderColor = clsProjectTemplate.objNerkComboBox.ColorLeave;
            _flechita = clsProjectTemplate.objNerkComboBox.FlechitaLeave;

            Invalidate();
        }

        void NrkComboBox_Leave(object sender, EventArgs e)
        {
            this._borderColor = this._colorLeave;
            _flechita = clsProjectTemplate.objNerkComboBox.FlechitaLeave;
            this.BackColor = clsProjectTemplate.objNerkComboBox.BackColorLeave;

            Invalidate();
        }

        void NrkComboBox_Enter(object sender, EventArgs e)
        {
            this._borderColor = this._colorEnter;
            _flechita = clsProjectTemplate.objNerkComboBox.FlechitaEnter;
            this.BackColor = clsProjectTemplate.objNerkComboBox.BackColorEnter;
            Invalidate();
        }
        #endregion

        #region Funciones
        public bool isValid()
        {
            bool result = true;
            this._colorLeave = _colorLeaveTmp;

            ttmsg.Hide(this);
            if (isRequerido)
            {
                if (((MyListItem)this.SelectedItem).intValue == 0)
                {
                    ttmsg.SetToolTip(this, "Debes seleccionar un elemento");
                    //ttmsg.Show("Debes seleccionar un elemeno", this, new Point(this.Width - 14, 10));
                    this._colorLeave = ColorError;
                    result = false;
                }
            }

            this._borderColor = _colorLeave;
            this.Invalidate();
            return result;
        }


        public bool isValidText()
        {
            bool result = true;
            this._colorLeave = _colorLeaveTmp;

            ttmsg.Hide(this);
            if (isRequerido)
            {
                if (((MyListItem)this.SelectedItem).strValue == clsUtilerias.Formatos.CeroIndexCombo)
                {
                    ttmsg.SetToolTip(this, "Debes seleccionar un elemento");
                    //ttmsg.Show("Debes seleccionar un elemeno", this, new Point(this.Width - 14, 10));
                    this._colorLeave = ColorError;
                    result = false;
                }
            }

            this._borderColor = _colorLeave;
            this.Invalidate();
            return result;
        }

        public void StartSelect()
        {
            try
            {
                this.SelectedIndex=0;
            }
            catch(Exception ex)
            {

            }
        }
        #endregion

        #region Eventos

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            try
            {
                if (!mblnToolTipShow && isRequerido)
                {
                    this.ttmsg.Show("Debes seleccionar un elemento", this);
                    mblnToolTipShow = true;
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            try
            {
                if (mblnToolTipShow && isRequerido)
                {
                    this.ttmsg.Hide(this);
                    mblnToolTipShow = false;
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);

                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                Rectangle bounds2 = new Rectangle(1, 1, Width - 2, Height - 2);

                
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
                
                //ControlPaint.DrawBorder(g, bounds2, _borderColor, _borderStyle);

                if (this.FlatStyle == System.Windows.Forms.FlatStyle.Flat)
                {

                    Rectangle varSRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                    PaintEventArgs varSe = new PaintEventArgs(this.CreateGraphics(), varSRectangle);
                    //Con este código dibujaremos la flechita del desplegable según el valor
                    //de las propiedades ArrowColor y ArrowStyle.
                    //If varCArrowPersonalized Then
                    int varSWidthIni = this.Width - 14;
                    int varSHeightIni = (int)((this.Height - 6) / 2) + 1;
                    //int varSHeightIni = (int)((this.Height - 6) / 2) + 5;
                    if (this.Height / 2 == (int)(this.Height / 2))
                    {
                        varSHeightIni = varSHeightIni - 1;
                    }
                    Point varSpoint1;
                    Point varSpoint2;
                    Point varSpoint3;
                    Point varSpoint4;
                    Point varSpoint5;
                    Point varSpoint6;
                    //if (varCArrowStyle == enumArrowStyle.Arrow3D)
                    //varSpoint1 = new Point(varSWidthIni, varSHeightIni + 1);
                    //varSpoint2 = new Point(varSWidthIni + 1, varSHeightIni);
                    //varSpoint3 = new Point(varSWidthIni + 4, varSHeightIni + 3);
                    //varSpoint4 = new Point(varSWidthIni + 7, varSHeightIni);
                    //varSpoint5 = new Point(varSWidthIni + 8, varSHeightIni + 1);
                    //varSpoint6 = new Point(varSWidthIni + 4, varSHeightIni + 5);
                    //Else
                    //varSpoint1 = new Point(varSWidthIni, varSHeightIni + 1);
                    //varSpoint2 = new Point(varSWidthIni + 1, varSHeightIni - 1);
                    //varSpoint3 = new Point(varSWidthIni + 4, varSHeightIni + 3);
                    //varSpoint4 = new Point(varSWidthIni + 7, varSHeightIni - 1);
                    //varSpoint5 = new Point(varSWidthIni + 9, varSHeightIni + 1);
                    //varSpoint6 = new Point(varSWidthIni + 4, varSHeightIni + 6);


                    varSpoint1 = new Point(varSWidthIni - 1, varSHeightIni + 1);
                    varSpoint2 = new Point(varSWidthIni, varSHeightIni + 3);
                    varSpoint3 = new Point(varSWidthIni + 1, varSHeightIni + 1);
                    //End If
                    //Point[] varSPoint = new Point[6] { varSpoint1, varSpoint2, varSpoint3, varSpoint4, varSpoint5, varSpoint6 };
                    Point[] varSPoint = new Point[3] { varSpoint1, varSpoint2, varSpoint3 };

                    
                    //varSe.Graphics.FillRectangle(new SolidBrush(_borderColor), new Rectangle(this.Width - 17, 1, 16, varSRectangle.Height - 1));
                    varSe.Graphics.FillRectangle(new SolidBrush(_borderColor), new Rectangle(this.Width - 17, 1, 16, varSRectangle.Height - 1));
                    varSe.Graphics.DrawRectangle(new Pen(new SolidBrush(_borderColor)), new Rectangle(1, 1, varSRectangle.Width - 1, varSRectangle.Height - 1));
                    
                    //varSe.Graphics.FillPolygon(new SolidBrush(_borderColor), varSPoint);
                    //Pen p = new Pen(new SolidBrush(Color.Black));
                    Pen p = new Pen(new SolidBrush(_flechita));
                    varSe.Graphics.DrawLine(p, new Point(varSWidthIni + 3, varSHeightIni + 2), new Point(varSWidthIni + 7, varSHeightIni + 2));
                    varSe.Graphics.DrawLine(p, new Point(varSWidthIni + 4, varSHeightIni + 3), new Point(varSWidthIni + 6, varSHeightIni + 3));
                    varSe.Graphics.DrawLine(p, new Point(varSWidthIni + 5, varSHeightIni + 2), new Point(varSWidthIni + 5, varSHeightIni + 4));



                    //varSe.Graphics.FillPolygon(new SolidBrush(_borderColor), varSPoint);
                    varSPoint = null;
                    //End If
                    varSe.Dispose();
                }
            }
        }
        #endregion

        #region Atributos
        [Browsable(true),
        Category("NerkSoft"),
        Description("Color de borde cuando el control obtiene el foco.")]
        public Color ColorEnter
        {
            get { return _colorEnter; }
            set
            {
                _colorEnter = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Color de borde cuando el control pierde el foco.")]
        public Color ColorLeave
        {
            get { return _colorLeave; }
            set
            {
                _colorLeave = value;
                _colorLeaveTmp = _colorLeave;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Color de borde cuando el control tiene error.")]
        public Color ColorError
        {
            get { return _colorError; }
            set
            {
                _colorError = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        DefaultValue(ButtonBorderStyle.Solid),
        Description("Tipo de borde del control.")]
        public ButtonBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }

        [Description("Poner en TRUE si se desea obligar al usuario a seleccionar un elemento"), Category("NerkSoft"), DefaultValue(false)]
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
            }
        }

        [Description("Poner en TRUE si se desea obligar al usuario a seleccionar un elemento"), Category("NerkSoft"), DefaultValue(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Indica si el texto es obligatorio
        /// </summary>
        public string WhatIControl
        {
            get { return strWhatIControl; }
            set
            {
                strWhatIControl = value;
                ttmsg.ToolTipTitle = this.strWhatIControl;
            }
        }

        #endregion
    }
}
