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
    public partial class NerkNotify : UserControl
    {
        public event EventHandler<NotifyEventArgs> closeNotify;

        public enum enumTipoNotify
        {
            Default,
            Primary,
            Success,
            Danger,
            Warning
        }

        private enumTipoNotify menumTipoNotify;
        public NerkNotify()
        {
            InitializeComponent();
        }

        public void OnCloseNotify(string notifyName)
        {
            EventHandler<NotifyEventArgs> handler = closeNotify;
            if (handler != null) handler(this, new NotifyEventArgs(notifyName));
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.BackColor = Color.White;
            //this.pnlLeft.Visible = false;
            //this.pnlRight.Visible = false;
            //this.pnlBottom.Visible = false;            
                        
            ApplyStyle(this.menumTipoNotify);
        }

        private void ApplyStyle(enumTipoNotify tipo)
        {
            switch (tipo)
            {
                case enumTipoNotify.Default:

                    this.BackColor = clsProjectTemplate.objColors.Default.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;
                    this.lblClose.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;
                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;                    

                    break;
                case enumTipoNotify.Danger:

                    this.BackColor = clsProjectTemplate.objColors.Danger.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Danger.ForeColor;
                    this.lblClose.ForeColor = clsProjectTemplate.objColors.Danger.ForeColor;
                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Danger.ForeColor;
                    
                    break;
                case enumTipoNotify.Success:

                    this.BackColor = clsProjectTemplate.objColors.Success.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Success.ForeColor;
                    this.lblClose.ForeColor = clsProjectTemplate.objColors.Success.ForeColor;
                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Success.ForeColor;
                   
                    break;

                case enumTipoNotify.Primary:

                    this.BackColor = clsProjectTemplate.objColors.Primary.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Primary.ForeColor;
                    this.lblClose.ForeColor = clsProjectTemplate.objColors.Primary.ForeColor;
                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Primary.ForeColor;
                   
                    break;

                case enumTipoNotify.Warning:

                    this.BackColor = clsProjectTemplate.objColors.Warning.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Warning.ForeColor;
                    this.lblClose.ForeColor = clsProjectTemplate.objColors.Warning.ForeColor;
                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Warning.ForeColor;
                    
                    break;
                default:

                    this.BackColor = clsProjectTemplate.objColors.Default.BackColor;

                    this.lblTitle.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;
                    this.lblClose.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;
                    this.lblMsg.ForeColor = clsProjectTemplate.objColors.Default.ForeColor;      
                    
                    break;
            }
            //this.Font = new Font(clsProjectTemplate.NerkFont.Fuente, (float)11.7);
            this.Invalidate();
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Define el tipo del Notificación.")]
        public enumTipoNotify NotifyStyle
        {
            get { return this.menumTipoNotify; }
            set
            {
                this.menumTipoNotify= value;
                this.ApplyStyle(this.menumTipoNotify);
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Define el Titulo.")]
        public string Title
        {
            get { return this.lblTitle.Text; }
            set
            {
                this.lblTitle.Text = value;                
            }
        }

        [Browsable(true),
        Category("NerkSoft"),
        Description("Define el Texto.")]
        public string Msg
        {
            get { return this.lblMsg.Text; }
            set
            {
                this.lblMsg.Text = value;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            EventHandler<NotifyEventArgs> handler = closeNotify;
            if (handler != null) handler(this, new NotifyEventArgs(this.Name));
        }
    }

    public class NotifyEventArgs: EventArgs
    {
        public string NombreNotificacion { get; set; }
        public NotifyEventArgs(string pnombre)
        {
            this.NombreNotificacion = pnombre;
        }
    }
}
