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

    public partial class NerkPanel : Panel
    {
        public enum enumTipoPanel
        {
            Default,
            Primary,
            Success,
            Danger,
            Warning
        }

        private bool misCollapsed;        
         
        private enumTipoPanel menumTipoPanel;
        private int mMaximunHeigth;
        private bool misToogling = false;
        private bool mallowCollapse = true;



        public NerkPanel()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.BackColor = Color.White;
            this.mMaximunHeigth = this.mMaximunHeigth == 0 ? this.Height : this.mMaximunHeigth;

            SetCollapsedLabel();
            ApplyStyle(this.menumTipoPanel);
        }

        private void SetCollapsedLabel()
        {
            if (this.misCollapsed)
            {
                this.lblCollapse.Text = "+";
            }
            else
            {
                this.lblCollapse.Text = "-";
            }
        }

        private void NerkPanel_Resize(object sender, EventArgs e)
        {            
            if (!misToogling && !misCollapsed) this.mMaximunHeigth = this.Height;
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            if(this.mallowCollapse) toogleCollapsed();
        }

        private void toogleCollapsed()
        {
            //this.lblTitle.Text = this.Height.ToString() + " - " + this.mMaximunHeigth.ToString() + " - " + this.misToogling.ToString();
            if (misCollapsed)
            {
                this.misToogling = true;
                this.Height = this.mMaximunHeigth;
                this.misToogling = false;

                this.misCollapsed = false;
            }
            else
            {
                this.misToogling = true;                
                this.Height = this.pnlHeading.Height;
                this.misToogling = false;

                this.misCollapsed = true;
            }

            SetCollapsedLabel();
        }

        private void toogleCollapsed(bool piscollapsed)
        {
            
            if (!piscollapsed)
            {
                this.misToogling = true;
                this.Height = this.mMaximunHeigth;
                this.misToogling = false;
            }
            else
            {                
                this.misToogling = true;
                this.Height = this.pnlHeading.Height;
                this.misToogling = false;
            }

            SetCollapsedLabel();
        }

        protected void doTootleCollapsed()
        {
            if (misCollapsed)
            {                
                this.Height = this.pnlHeading.Height;
            }
            else
            {
                this.Height = this.mMaximunHeigth;
            }
        }

        private void ApplyStyle(enumTipoPanel tipo)
        {
            switch (tipo)
            {
                case enumTipoPanel.Default:

                    this.pnlHeading.BackColor = clsProjectTemplate.objColors.Default.BackColor;
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;
                    this.lblCollapse.ForeColor = this.lblTitle.ForeColor;

                    break;
                case enumTipoPanel.Danger:

                    this.pnlHeading.BackColor = clsProjectTemplate.objColors.Danger.BackColor;
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Danger.ForeColor;
                    this.lblCollapse.ForeColor = this.lblTitle.ForeColor;

                    break;
                case enumTipoPanel.Success:

                    this.pnlHeading.BackColor = clsProjectTemplate.objColors.Success.BackColor;
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Success.ForeColor;
                    this.lblCollapse.ForeColor = this.lblTitle.ForeColor;

                    break;

                case enumTipoPanel.Primary:

                    this.pnlHeading.BackColor = clsProjectTemplate.objColors.Primary.BackColor;
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Primary.ForeColor;
                    this.lblCollapse.ForeColor = this.lblTitle.ForeColor;

                    break;

                case enumTipoPanel.Warning:

                    this.pnlHeading.BackColor = clsProjectTemplate.objColors.Warning.BackColor;
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Warning.ForeColor;
                    this.lblCollapse.ForeColor = this.lblTitle.ForeColor;

                    break;
                default:

                     this.pnlHeading.BackColor = clsProjectTemplate.objColors.Default.BackColor;
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;
                    this.lblCollapse.ForeColor = this.lblTitle.ForeColor;

                    break;
            }
            //this.Font = new Font(clsProjectTemplate.NerkFont.Fuente, (float)11.7);
            this.Invalidate();
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Define el tipo del Panel.")]
        public enumTipoPanel PanelStyle
        {
            get { return this.menumTipoPanel; }
            set
            {
                this.menumTipoPanel = value;
                this.ApplyStyle(this.menumTipoPanel);
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Establece si esta colapsado el panel")]
        public bool IsCollapsed
        {
            get { return this.misCollapsed; }
            set
            {
                this.misCollapsed = value;
                //doTootleCollapsed();
                toogleCollapsed(value);
                this.Invalidate();
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Establece la altura heading del panel")]
        public int HeadingHeight
        {
            get { return this.pnlHeading.Height; }
            set
            {
                this.pnlHeading.Height = value;
                toogleCollapsed(this.misCollapsed);
                this.Invalidate();
            }
        }


        [Browsable(true),
        Category("NerkSoft"),
        Description("Define el Maximo de Altura")]
        public int SizeMaxHeigth
        {
            get { return this.mMaximunHeigth; }
            set
            {
                this.mMaximunHeigth = value;
                this.Invalidate();
            }
        }


        

        [Browsable(true),
        Category("NerkSoft"),
        Description("Establece la fuente de el Heading")]
        public Font HeadingFont
        {
            get { return this.lblTitle.Font; }
            set
            {
                this.lblTitle.Font = value;
                this.lblCollapse.Font = value;
                this.Invalidate();
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Indica si se puede colapsar o no")]
        public bool AllowCollapse
        {
            get { return this.mallowCollapse; }
            set
            {
                if (misCollapsed)
                    IsCollapsed = false;

                this.mallowCollapse = value;

                if (!this.mallowCollapse)
                {
                    lblCollapse.Visible = false;
                    lblTitle.Cursor = Cursors.Default;
                }
                else
                {
                    lblCollapse.Visible = true;
                    lblTitle.Cursor = Cursors.Hand;
                }
                
                this.Invalidate();
            }
        }
    }
}
