using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NerkSoft.FrameWork.MetroUI
{
    public class clsUtilerias
    {
        public class Formatos
        {
            public const string Fecha = "dd/MM/yyyy";
            public const string Hora = "hh:mm:ss";
            public const string HoraMinutos = "hh:mm";
            public const string Moneda = "###,##0.00";
            public const string CeroIndexCombo = "[CeroItem]";
        }

        public static void LlenarComboTiendas(ComboBox pobj, int pintTiendaActiva, List<MyListItem> plstTiendas)
        {
            List<MyListItem> lst = new List<MyListItem>();
            lst.Add(new MyListItem(0, "(Seleccione una Tienda)"));
            foreach (MyListItem i in plstTiendas)
            {
                if (i.intValue != pintTiendaActiva && i.intValue > 0)
                    lst.Add(i);
            }

            pobj.DataSource = lst;
            pobj.ValueMember = "intValue";
            pobj.DisplayMember = "strText";
        }



        public static string QuitarApostrofes(string cadena)
        {
            return cadena.Replace("'", "´");
        }

        public static void ObtenerCantidadProducto(ref int cantidad, ref string codigo)
        {
            string cant;
            string codigoaux = codigo;

            try
            {
                if (codigo.IndexOf("*") == codigo.Length)
                {
                    cantidad = 1;
                    codigo = codigo.Replace("*", "");
                    return;
                }

                if (codigo.Contains("*"))
                {
                    cant = codigo.Substring(0, codigo.IndexOf("*"));

                    if (clsUtilerias.IsNumeric(cant))
                    {
                        cantidad = Convert.ToInt32(cant);
                    }
                    else
                        cantidad = 1;

                    codigo = codigo.Substring(codigo.IndexOf("*") + 1);
                }
                else
                {
                    cantidad = 1;

                }
            }
            catch (Exception ex)
            {
                cantidad = 1;
                codigo = codigoaux;
            }
        }

        public static string GetString(int veces, string cadena)
        {
            string result = "";

            for (int x = 0; x < veces; x++)
            {
                result += cadena;
            }

            return result;
        }

        public static bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static byte[] imageToByteArray(System.Drawing.Image imageIn, System.Drawing.Imaging.ImageFormat formatImg)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, formatImg);
            return ms.ToArray();
        }
    }
}
