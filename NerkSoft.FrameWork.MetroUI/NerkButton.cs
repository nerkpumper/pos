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
    public partial class NerkButton : Button
    {
        public enum enumTipoBoton
        {
            Default,
            Primary,
            Success,
            Info,
            Danger,
            Warning
        }

        private bool mblnIsSelectableByTab = false;
        private bool mblnIsSelected = false;
        private enumTipoBoton menumTipoBoton;


        public NerkButton()
        {
            InitializeComponent();

            this.TabStop = true;
            this.SetStyle(ControlStyles.Selectable, true);
            //if (this.IsCustom) return;

            this.Font = new Font("Segoe UI", (float)10);
            

            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.BackColor = Color.FromArgb(255, 255, 255, 255);
            this.ForeColor = Color.FromArgb(255, 38, 38, 38);

            this.FlatAppearance.BorderColor = Color.FromArgb(255, 217, 217, 217);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255, 255);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255, 255);
            this.FlatAppearance.BorderSize = 1;

            this.Cursor = Cursors.Hand;

            this.ForeColor = clsProjectTemplate.objNerkButton.ForeColor;

            this.ImageAlign = ContentAlignment.MiddleRight;
            this.TextAlign = ContentAlignment.MiddleCenter;

            this.AutoSize = false;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;            
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (base.ContainsFocus)
            {
                Pen pen = new Pen(Color.White, 30);
                Point p = base.Location;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                Rectangle rectangle = new Rectangle(5, 5, this.Width - 10, this.Height - 10);
                ControlPaint.DrawFocusRectangle(pevent.Graphics, rectangle, Color.White, Color.White);
                pen.Dispose();
            }
        }


        public void IniciaControl()
        {
            this.TabStop = true;
            this.SetStyle(ControlStyles.Selectable, true);
            //if (this.IsCustom) return;

            //this.Font = new Font("Segoe UI", (float)11.7);

            //this.TabStop = true;
            //this.SetStyle(ControlStyles.Selectable, false);

            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.BackColor = Color.FromArgb(255, 255, 255, 255);
            this.ForeColor = Color.FromArgb(255, 38, 38, 38);

            this.FlatAppearance.BorderColor = Color.FromArgb(255, 217, 217, 217);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255, 255);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255, 255);
            this.FlatAppearance.BorderSize = 1;


            this.Cursor = Cursors.Hand;

            this.ForeColor = clsProjectTemplate.objNerkButton.ForeColor;

            this.ImageAlign = ContentAlignment.MiddleRight;
            this.TextAlign = ContentAlignment.MiddleCenter;

            this.AutoSize = false;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ApplyStyle(this.menumTipoBoton);
            //MessageBox.Show("InitControl para: " + this.Name + "   style:  " + this.menumTipoBoton );

        }

        

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.IniciaControl();
            
        }

        protected override void OnClick(EventArgs e)
        {
            if (this.mblnIsSelected) return;

            base.OnClick(e);
        }

        public bool IsSelected
        {
            get { return mblnIsSelected; }
            set
            {
                mblnIsSelected = value;

                if (mblnIsSelected)
                {
                    this.FlatAppearance.BorderColor = clsProjectTemplate.objNerkButton.BackColor;
                    this.BackColor = clsProjectTemplate.objNrkLeftMenuItem.BackColorSelected;
                }
                else
                {
                    this.BackColor = clsProjectTemplate.objNerkButton.BackColor;
                    this.FlatAppearance.BorderColor = clsProjectTemplate.objNerkButton.FlatAppearanceBorderColor;
                }

                Invalidate();
            }
        }

        private void ApplyStyle(enumTipoBoton tipo)
        {
            switch (tipo)
            {
                case enumTipoBoton.Default:
                    //this.BackColor = clsProjectTemplate.objNerkButton.BackColor;
                    //this.FlatAppearance.BorderColor = clsProjectTemplate.objNerkButton.FlatAppearanceBorderColor;
                    //this.FlatAppearance.MouseDownBackColor = clsProjectTemplate.objNerkButton.FlatAppearanceMouseDownBackColor;
                    //this.FlatAppearance.MouseOverBackColor = clsProjectTemplate.objNerkButton.FlatAppearanceMouseOverBackColor;
                    //this.FlatAppearance.BorderSize = clsProjectTemplate.objNerkButton.FlatAppearanceBorderSize;
                    //this.ForeColor = clsProjectTemplate.objNerkButton.ForeColor;

                    this.BackColor = Color.FromArgb(255, 255, 255, 255);
                    this.ForeColor = Color.FromArgb(255, 38, 38, 38);

                    this.FlatAppearance.BorderColor = Color.FromArgb(255, 217, 217, 217);
                    this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255, 255);
                    this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255, 255);
                    this.FlatAppearance.BorderSize = 1;

                    break;
                case enumTipoBoton.Danger:
                    this.BackColor = Color.FromArgb(255, 206, 53, 44);
                    this.ForeColor = Color.White;

                    this.FlatAppearance.BorderColor = Color.FromArgb(255, 206, 53, 44);
                    this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 154, 22, 22);
                    this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 206, 53, 44);
                    this.FlatAppearance.BorderSize = 1;

                    break;
                case enumTipoBoton.Success:
                    this.BackColor = Color.FromArgb(255, 96, 169, 23);
                    this.ForeColor = Color.White;

                    this.FlatAppearance.BorderColor = Color.FromArgb(255, 96, 169, 23);
                    this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 18, 128, 35);
                    this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 96, 169, 23);
                    this.FlatAppearance.BorderSize = 1;

                    break;

                case enumTipoBoton.Primary:
                    this.BackColor = Color.FromArgb(255, 32, 134, 191);
                    this.ForeColor = Color.White;

                    this.FlatAppearance.BorderColor = Color.FromArgb(255, 32, 134, 191);
                    this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 27, 110, 174);
                    this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 32, 134, 191);
                    this.FlatAppearance.BorderSize = 1;

                    break;
                case enumTipoBoton.Info:
                    this.BackColor = Color.FromArgb(255, 89, 205, 226);
                    this.ForeColor = Color.White;

                    this.FlatAppearance.BorderColor = Color.FromArgb(255, 89, 205, 226);
                    this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 27, 161, 226);
                    this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 89, 205, 226);
                    this.FlatAppearance.BorderSize = 1;

                    break;
                case enumTipoBoton.Warning:
                    this.BackColor = Color.FromArgb(255, 250, 104, 0);
                    this.ForeColor = Color.White;

                    this.FlatAppearance.BorderColor = Color.FromArgb(255, 250, 104, 0);
                    this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 191, 90, 21);
                    this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 250, 104, 0);
                    this.FlatAppearance.BorderSize = 1;

                    break;
                default:
                    this.BackColor = Color.FromArgb(255, 255, 255, 255);
                    this.ForeColor = Color.FromArgb(255, 38, 38, 38);

                    this.FlatAppearance.BorderColor = Color.FromArgb(255, 217, 217, 217);
                    this.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 255, 255);
                    this.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 255, 255);
                    this.FlatAppearance.BorderSize = 1;

                    break;
            }
            //this.Font = new Font("Segoe UI", (float)11.7);
            this.Invalidate();
        }

        [Description("Es Seleccionable por Tabulador?"), Category("NerkSoft")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        /// <summary>
        /// Es Seleccionable por Tabulador?
        /// </summary>
        public bool IsSelectableByTab
        {
            get { return this.mblnIsSelectableByTab; }
            set
            {
                mblnIsSelectableByTab = value;

                if (mblnIsSelectableByTab)
                {
                    this.TabStop = true;
                    this.SetStyle(ControlStyles.Selectable, true);
                }
                else
                {
                    this.TabStop = false;
                    this.SetStyle(ControlStyles.Selectable, false);
                }
            }
        }


        private bool _iscustom = false;
        [Browsable(true),
        Category("NerkSoft"),
        Description("Define si el control sigue el template de colores.")]
        public bool IsCustom
        {
            get { return _iscustom; }
            set
            {
                _iscustom = value;
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Define el tipo de boton.")]
        public enumTipoBoton ButtonStyle
        {
            get { return this.menumTipoBoton; }
            set
            {
                this.menumTipoBoton = value;
                this.ApplyStyle(this.menumTipoBoton);
            }
        }
    }
}
