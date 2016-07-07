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

                    this.BackColor = Color.FromArgb(255, 213, 213, 213);
                    
                    this.lblTitle.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    this.lblClose.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    this.lblMsg.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    

                    break;
                case enumTipoNotify.Danger:

                    this.BackColor = Color.FromArgb(255, 206, 53, 44);
                    
                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblClose.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    
                    break;
                case enumTipoNotify.Success:

                    this.BackColor = Color.FromArgb(255, 96, 169, 23);
                    
                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblClose.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);
                   
                    break;

                case enumTipoNotify.Primary:

                    this.BackColor = Color.FromArgb(255, 29, 161, 226);
                    
                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblClose.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);
                   
                    break;

                case enumTipoNotify.Warning:

                    this.BackColor = Color.FromArgb(255, 250, 104, 0);
                   
                    this.lblTitle.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblClose.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    this.lblMsg.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    
                    break;
                default:

                    this.BackColor = Color.FromArgb(255, 213, 213, 213);
                    
                    this.lblTitle.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    this.lblClose.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    this.lblMsg.ForeColor = Color.FromArgb(255, 0, 0, 0);
                    
                    break;
            }
            //this.Font = new Font("Segoe UI", (float)11.7);
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
