using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerkSoft.Pos.Main
{
    public class clsViewManager
    {
        public static NerkSoft.FrameWork.MetroUI.NerkFormModulo ViewManager = null;
        public static NerkSoft.FrameWork.MetroUI.NerkFormSeccion POS = null;

        public static void Show(string viewName)
        {
            try
            {                
                NerkSoft.FrameWork.MetroUI.NerkFormSeccion form = getView(viewName);

                if (form == null) return;

                form.TopLevel = false;

                if (ViewManager.getSeccion.Controls.Count > 0)
                    ViewManager.getSeccion.Controls.Clear();

                form.Parent = ViewManager.getSeccion;
                ViewManager.getSeccion.Controls.Add(form);

                form.Dock = DockStyle.Fill;


                form.Show();
            }
            catch(Exception ex)
            {

            }
            
        }


        public static NerkSoft.FrameWork.MetroUI.NerkFormSeccion getView(string viewName)
        {
            NerkSoft.FrameWork.MetroUI.NerkFormSeccion result = null;

            switch (viewName)
            {
                case "frmDashboard":
                    result = new Dashboard.frmDashboard();
                    break;
                case "frmPOS":
                    result = new POS.frmPOS();
                    break;
                default:
                    //result = new FrameWork.MetroUI.NerkFormSeccion();
                    break;
            }


            return result;
        }
    }
}
