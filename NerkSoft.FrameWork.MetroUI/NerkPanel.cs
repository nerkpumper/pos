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
            toogleCollapsed();
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

                    this.pnlHeading.BackColor = Color.FromArgb(255, 213, 213, 213);
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    this.lblCollapse.ForeColor = Color.FromArgb(255, 0, 0, 0);

                    break;
                case enumTipoPanel.Danger:

                    this.pnlHeading.BackColor = Color.FromArgb(255, 206, 53, 44);
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblCollapse.ForeColor = Color.FromArgb(255, 255, 255, 255);

                    break;
                case enumTipoPanel.Success:

                    this.pnlHeading.BackColor = Color.FromArgb(255, 96, 169, 23);
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblCollapse.ForeColor = Color.FromArgb(255, 255, 255, 255);

                    break;

                case enumTipoPanel.Primary:

                    this.pnlHeading.BackColor = Color.FromArgb(255, 29, 161, 226);
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblCollapse.ForeColor = Color.FromArgb(255, 255, 255, 255);

                    break;

                case enumTipoPanel.Warning:

                    this.pnlHeading.BackColor = Color.FromArgb(255, 250, 104, 0);
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblCollapse.ForeColor = Color.FromArgb(255, 255, 255, 255);

                    break;
                default:

                    this.pnlHeading.BackColor = Color.FromArgb(255, 213, 213, 213);
                    this.pnlLeft.BackColor = this.pnlHeading.BackColor;
                    this.pnlRight.BackColor = this.pnlHeading.BackColor;
                    this.pnlBottom.BackColor = this.pnlHeading.BackColor;

                    this.lblTitle.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    this.lblCollapse.ForeColor = Color.FromArgb(255, 0, 0, 0);

                    break;
            }
            //this.Font = new Font("Segoe UI", (float)11.7);
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
    }
}
