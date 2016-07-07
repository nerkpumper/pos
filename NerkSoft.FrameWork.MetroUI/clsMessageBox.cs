using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NerkSoft.FrameWork.MetroUI
{
    public class clsMessageBox
    {
        public enum enumMsgBoxRespuestas
        {
            Ninguno,
            Yes,
            No
        }

        //public static enumMsgBoxRespuestas Show(Control c, string pstrMsg)
        //{
        //    enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

        //    NerkMsgBox frm = new NerkMsgBox();
           
        //    frm.strMsg = pstrMsg;
        //    frm.ShowYESNO();

        //    frm.AllowTransparency = true;
            
        //    frm.Width = c.Width;
            
        //    frm.Top = c.Height / 2 - frm.Height / 2;
                        
        //    frm.ShowDialog();           

        //    result = frm.menumRespuesta;

        //    frm = null;

        //    return result;
        //}

        public static enumMsgBoxRespuestas Ask (string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowYESNO(NerkMsgBox.enumTipoMsgBox.Default);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas AskPrimary(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowYESNO(NerkMsgBox.enumTipoMsgBox.Primary);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas AskDanger( string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowYESNO(NerkMsgBox.enumTipoMsgBox.Danger);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas AskSuccess(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowYESNO(NerkMsgBox.enumTipoMsgBox.Success);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas AskWarning(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowYESNO(NerkMsgBox.enumTipoMsgBox.Warning);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }
        

        //-  --   -  --   No Ask

        public static enumMsgBoxRespuestas Show(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowOK(NerkMsgBox.enumTipoMsgBox.Default);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas Primary(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowOK(NerkMsgBox.enumTipoMsgBox.Primary);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas Danger(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowOK(NerkMsgBox.enumTipoMsgBox.Danger);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas Success(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowOK(NerkMsgBox.enumTipoMsgBox.Success);

            frm.AllowTransparency = true;
                        
            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;            
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }

        public static enumMsgBoxRespuestas Warning(string pstrMsg)
        {
            enumMsgBoxRespuestas result = enumMsgBoxRespuestas.Ninguno;

            NerkMsgBox frm = new NerkMsgBox();

            frm.strMsg = pstrMsg;
            frm.ShowOK(NerkMsgBox.enumTipoMsgBox.Warning);

            frm.AllowTransparency = true;

            frm.Width = Screen.PrimaryScreen.WorkingArea.Width;
            frm.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - frm.Height / 2;

            frm.ShowDialog();

            result = frm.menumRespuesta;

            frm = null;

            return result;
        }
    }
}
