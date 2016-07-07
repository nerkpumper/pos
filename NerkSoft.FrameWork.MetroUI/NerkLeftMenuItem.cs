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
    public partial class NerkLeftMenuItem : Button
    {
        private bool mblnIsSelected = false;
        public Color myBackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColor;
        public Color myForeColor = clsProjectTemplate.objNrkLeftMenuItem.ForeColor;
        public Color myBackColorSelected = clsProjectTemplate.objNrkLeftMenuItem.BackColorSelected;
        public Color myForeColorSelected = clsProjectTemplate.objNrkLeftMenuItem.ForeColorSelected;
        private Image _imgSelected;
        private Image _img;

        private string mstrSeccionName;

        public NerkLeftMenuItem()
        {
            InitializeComponent();
            this.Font = new Font("Segoe UI ", (float)11);
            this.Height = 39;            
        }

        

        [Description("Indica si esta seleccionado"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Muestra la Imagen de la izquierda
        /// </summary>
        public bool IsSelected
        {
            get { return mblnIsSelected; }
            set { this.mblnIsSelected = value;
            if (!mblnIsSelected)
            {
                this.BackColor = myBackColor;
                this.ForeColor = myForeColor;
                this.FlatAppearance.MouseDownBackColor = clsProjectTemplate.objNrkLeftMenuItem.FlatAppearanceMouseDownBackColor;
                this.FlatAppearance.MouseOverBackColor = clsProjectTemplate.objNrkLeftMenuItem.FlatAppearanceMouseOverBackColor;
                this.Image = this._img;
            }
            else
            {
                this.BackColor = myBackColorSelected;
                this.ForeColor = myForeColorSelected;
                this.FlatAppearance.MouseDownBackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColorSelected;
                this.FlatAppearance.MouseOverBackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColorSelected;
                this.Image = this._imgSelected;
            }
                this.Invalidate();
            }
        }

        private void PutImg()
        {
            if (!mblnIsSelected)
            {                
                this.Image = this._img;
            }
            else
            {                
                this.Image = this._imgSelected;
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Establece la imagen cuando el boton esta seleccionado")]
        public Image ImageWhenSelected
        {
            get { return this._imgSelected; }
            set
            {
                this._imgSelected = value;
                PutImg();
                this.Invalidate();
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Establece la imagen cuando el boton NO esta seleccionado")]
        public Image ImageNormal
        {
            get { return this._img; }
            set
            {
                this._img = value;
                PutImg();
                this.Invalidate();
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Establece el nombre de la sección")]
        public string SeccionName
        {
            get { return this.mstrSeccionName; }
            set
            {
                this.mstrSeccionName = value;                
            }
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

        }

        protected override void OnClick(EventArgs e)
        {
            if (this.IsSelected) return;
            base.OnClick(e);            
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Font = new Font("Segoe UI ", (float)11);
            this.Height = 39;
            

            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackColor = myBackColor;
            this.FlatAppearance.BorderColor = clsProjectTemplate.objNrkLeftMenuItem.FlatAppearanceBorderColor;
            
            this.FlatAppearance.BorderSize = clsProjectTemplate.objNrkLeftMenuItem.FlatAppearanceBorderSize;
            this.Cursor = Cursors.Hand;

            this.TabStop = true;
            this.SetStyle(ControlStyles.Selectable, false);
            
            this.ForeColor = myForeColor;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;

            if (!mblnIsSelected)
            {
                this.BackColor = myBackColor;
                this.ForeColor = myForeColor;
                this.FlatAppearance.MouseDownBackColor = clsProjectTemplate.objNrkLeftMenuItem.FlatAppearanceMouseDownBackColor;
                this.FlatAppearance.MouseOverBackColor = clsProjectTemplate.objNrkLeftMenuItem.FlatAppearanceMouseOverBackColor;
            }
            else
            {
                this.BackColor = myBackColorSelected;
                this.ForeColor = myBackColorSelected;
                this.FlatAppearance.MouseDownBackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColorSelected;
                this.FlatAppearance.MouseOverBackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColorSelected;
            }
            this.Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!mblnIsSelected)
                this.ForeColor = clsProjectTemplate.objNrkLeftMenuItem.ForeColorOnMouseEnter;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!mblnIsSelected)
                this.ForeColor = clsProjectTemplate.objNrkLeftMenuItem.ForeColor;
        }
    }
}
