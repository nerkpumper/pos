using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerkSoft.FrameWork.MetroUI
{
    public class clsNotifyManager
    {
        private Control _container;
        private int _startTop;
        List<NerkNotify> lstNotificaciones = new List<NerkNotify>();
        private int noNotitas = 0;
        //private Timer timer;

        public clsNotifyManager()
        {
            //this.timer = new Timer();
            //this.timer.Interval = 10000;
            //this.timer.Tick += timer_Tick;
            //this.timer.Enabled = false;
            this._startTop = 10;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.RemoveFirst();
        }

        /// <summary>
        /// Control que contendrá las notificaciones
        /// </summary>
        public Control Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        /// <summary>
        /// Establece el inicio de las notificaciones
        /// </summary>
        public int StartTop
        {
            get { return this._startTop; }
            set { this._startTop = value; }
        }

        public void Add(string title, string caption)
        {
            this.Add(title, caption, NerkNotify.enumTipoNotify.Default);
        }

        public void Danger(string title, string caption)
        {
            this.Add(title, caption, NerkNotify.enumTipoNotify.Danger);
        }

        public void Primary(string title, string caption)
        {
            this.Add(title, caption, NerkNotify.enumTipoNotify.Primary);
        }

        public void Success(string title, string caption)
        {
            this.Add(title, caption, NerkNotify.enumTipoNotify.Success);
        }

        public void Warning(string title, string caption)
        {
            this.Add(title, caption, NerkNotify.enumTipoNotify.Warning);
        }

        private void Add(string title, string caption, NerkSoft.FrameWork.MetroUI.NerkNotify.enumTipoNotify tipo)
        {
            NerkNotify n = new NerkNotify();

            n.Title = title;
            n.Msg = caption;
            n.NotifyStyle = tipo;
            n.Visible = false;
            n.Name = "noti" + (noNotitas++).ToString();
            //n.Msg = n.Name;

            lstNotificaciones.Add(n);
            this._container.Controls.Add(n);
            n.closeNotify += n_closeNotify;

            n.BringToFront();

            ShowNotify();

            //if (this.lstNotificaciones.Count > 0 && !this.timer.Enabled)
            //{
            //    this.timer.Enabled = true;
            //}
        }

        void n_closeNotify(object sender, NotifyEventArgs e)
        {
            try
            {
                int heigthNotify = this.lstNotificaciones[0].Height;                
                int offsetAnimation = 10;
                int offsety = 3;
                
                int index = 0;

                for (int i = 0; i < this.lstNotificaciones.Count; i++)
                {
                    if (lstNotificaciones[i].Name == e.NombreNotificacion)
                    {
                        index = i;
                        break;
                    }
                }

                this.lstNotificaciones[index].Visible = false;

                for (int y = 1; y < heigthNotify; y += offsetAnimation)
                {

                    for (int i = index + 1; i < this.lstNotificaciones.Count; i++)
                    {
                        this.lstNotificaciones[i].Top -= offsetAnimation;
                    }
                    //n.Msg = n.Top.ToString();                    
                    Application.DoEvents();
                }

                for (int i = index + 1; i < this.lstNotificaciones.Count; i++)
                {
                    this.lstNotificaciones[i].Top -= offsety;
                }

                this.lstNotificaciones[index].Dispose();
                this.lstNotificaciones.RemoveAt(index);


            }
            catch
            {

            }
        }

        private void ShowNotify()
        {
            int heigthNotify = 0;
            int offsety = 3;
            int offsetRight = 5;
            int noNotify = 0;
            int offsetx = 2;


            foreach (NerkNotify n in this.lstNotificaciones)
            {
                n.Top = _startTop + (heigthNotify * noNotify) + (noNotify * offsety);
                //n.Msg = n.Top.ToString();

                if (!n.Visible)
                {
                    //SoundPlayer simpleSound = new SoundPlayer("Resources\notify.wav");
                    //SoundPlayer simpleSound = NrkRecursos.notify;
                    //simpleSound.Play();

                    try
                    {
                        System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
                        System.IO.Stream s = a.GetManifestResourceStream("NerkSoft.FrameWork.MetroUI.NrkRecursos.notify.wav");
                        SoundPlayer player = new SoundPlayer(s);
                        player.Play();
                    }
                    catch (Exception ex)
                    {

                    }

                    n.Left = _container.Width;
                    n.Visible = true;

                    for (int x = 0; x <= n.Width; x += offsetx)
                    {
                        n.Left -= offsetx;

                    }

                    n.Left = _container.Width - n.Width - offsetRight;
                }

                if (heigthNotify == 0)
                {
                    heigthNotify = n.Height;
                }
                noNotify++;
            }
        }

        private void AnimateUp()
        {
            try
            {
                int heigthNotify = this.lstNotificaciones[0].Height;
                int noNotify = 0;
                int offsetAnimation = 10;
                int offsety = 3;

                for (int y = 1; y < heigthNotify; y += offsetAnimation)
                {
                    foreach (NerkNotify n in this.lstNotificaciones)
                    {
                        n.Top -= offsetAnimation;
                        //n.Msg = n.Top.ToString();
                        noNotify++;
                    }
                    Application.DoEvents();
                }

                foreach (NerkNotify n in this.lstNotificaciones)
                {
                    n.Top -= offsety;
                    //n.Msg = n.Top.ToString();                    
                }
                Application.DoEvents();


            }
            catch
            {

            }


        }

        public void RemoveFirst()
        {
            if (this.lstNotificaciones.Count > 0)
            {
                this.lstNotificaciones[0].Visible = false;
                this.lstNotificaciones[0].Dispose();
                this.lstNotificaciones.RemoveAt(0);
                AnimateUp();
            }

            //if (this.lstNotificaciones.Count == 0 && this.timer.Enabled)
            //{
            //    this.timer.Enabled=true;
            //}
        }

    }
}
