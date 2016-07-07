using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NerkSoft.FrameWork.MetroUI
{
    public class MyListItem
    {
        public int intValue { get; set; }
        public string strValue { get; set; }
        public string strText { get; set; }

        public MyListItem(int value, string texto)
        {
            this.intValue = value;
            this.strText = texto;
        }

        public MyListItem(string value, string texto)
        {
            this.strValue = value;
            this.strText = texto;
        }
    }


    public class clsProjectTemplate
    {

        public class objFont
        {
            public static string Fuente = "Segoe UI";
        }

        public class objNerkButton
        {
            public static Color BackColor = Color.FromArgb(255, 250, 250, 250);
            public static Color FlatAppearanceBorderColor = Color.FromArgb(255, 1, 101, 187);  //Color.FromArgb(255, 250, 250, 250);
            public static Color FlatAppearanceMouseDownBackColor = Color.FromArgb(255, 250, 250, 250);
            public static Color FlatAppearanceMouseOverBackColor = Color.FromArgb(255, 250, 250, 250);
            public static int FlatAppearanceBorderSize = 1;

            public static Color ForeColor = Color.FromArgb(255, 1, 101, 187);
        }

        public class objNrkLeftMenuItem
        {
            public static Color BackColor = Color.FromArgb(255, 55, 57, 66);//Color.FromArgb(255, 60, 60, 60);
            public static Color BackColorSelected = Color.FromArgb(255, 232, 235, 241);
            public static Color FlatAppearanceBorderColor = Color.FromArgb(255, 32, 33, 38);
            public static Color FlatAppearanceMouseDownBackColor = Color.FromArgb(255, 32, 33 , 38); //Color.FromArgb(255, 67, 67, 67);
            public static Color FlatAppearanceMouseOverBackColor = Color.FromArgb(255, 32, 33, 38);//Color.FromArgb(255, 67, 67, 67);
            public static int FlatAppearanceBorderSize = 0;

            public static Color ForeColor = Color.FromArgb(255, 255, 255, 255);
            public static Color ForeColorSelected = Color.Black;

            public static Color ForeColorOnMouseEnter = Color.FromArgb(255, 255, 255, 255);
        }

        public class objNerkGrid
        {
            public static Color AlternatingRowsDefaultCellStyleBackColor = Color.Green;
            public static Color AlternatingRowsDefaultCellStyleSelectionBackColor = Color.FromArgb(255, 192, 192);
            public static Color AlternatingRowsDefaultCellStyleSelectionForeColor = Color.Black;
        }

        public class objMain
        {
            public static string Title = "NerkSoft Point Of Sale 1.0";
            public static Color BackColor = Color.White; //Color.FromArgb(255, 242, 242, 242);//Color.White; 
            public static Color ForeColor = Color.FromArgb(255, 0, 147, 225);

            public static Color BackColorFrame = Color.FromArgb(255, 113, 177, 209);//Color.FromArgb(255, 0,0,0);
            public static Color ForeColorFrame = Color.FromArgb(255, 255, 255, 255);

            public static Color HeaderBackColor = Color.White; //Color.FromArgb(255, 0, 114, 198);//Color.FromArgb(255, 53, 107, 161);
            public static Color HeaderForeColor = Color.Black; //Color.FromArgb(255, 255, 255, 255);//Color.FromArgb(255, 53, 107, 161);

            public static Color NavBarBackColor = Color.FromArgb(255, 72, 158, 231); //Color.FromArgb(255, 0, 114, 198);//Color.FromArgb(255, 53, 107, 161);
            public static Color NavBarForeColor = Color.White; //Color.FromArgb(255, 255, 255, 255);//Color.FromArgb(255, 53, 107, 161);

            
        }

        public class objModulo
        {
            //public static Color BackColor = Color.FromArgb(255, 242, 242, 242); es el mismo de objMain
            public static Color Separator1BackColor = Color.FromArgb(255, 214, 214, 214);
            public static Color SeccionBackColor = Color.FromArgb(255, 234, 234, 234);
            public static Color Separator2BackColor = Color.FromArgb(255, 214, 214, 214);
            public static Color MenuBackColor = Color.FromArgb(255, 55, 57, 66);//Color.FromArgb(255, 60, 60, 60);
            public static Color MenuForeColor = Color.FromArgb(255, 255, 255, 255);//Color.FromArgb(255, 60, 60, 60);
        }        

        public class objNrkTextBox
        {
            public static Color ColorLeave = Color.FromArgb(255, 217, 217, 217);
            public static Color ColorEnter = Color.FromArgb(255, 32, 134, 191);

            public static Color BackColorEnter = Color.FromArgb(255, 32, 134, 191); // Color.White;
            public static Color ForeColorEnter = Color.Black;

            public static Color BackColorLeave = Color.White;
            public static Color ForeColorLeave = Color.Black;
        }

        public class objMainFrame
        {
            public static Color BackColor = Color.FromArgb(255, 113, 177, 209);
            public static Color ForeColor = Color.FromArgb(255, 255, 255, 255); 
        }

        public class objNerkComboBox
        {
            public static Color ColorLeave = Color.FromArgb(255, 217, 217, 217);
            public static Color ColorEnter = Color.FromArgb(255, 32, 134, 191);
            public static Color ColorError = Color.FromArgb(255, 206, 53, 44);

            public static Color BackColorEnter = Color.White;
            public static Color BackColorLeave = Color.White;

            public static Color FlechitaEnter = Color.White; // Color.FromArgb(255, 32, 134, 191);
            public static Color FlechitaLeave = Color.Black; // Color.FromArgb(255, 217, 217, 217);
        }

        public class objColors
        {
            public class Default
            {
                public static Color BackColor = Color.FromArgb(255, 255, 255, 255);
                public static Color ForeColor = Color.FromArgb(255, 38, 38, 38);

                public static Color BorderColor = Color.FromArgb(255, 217, 217, 217);

                public static Color HoverBackColor = Color.FromArgb(255, 255, 255, 255);
                public static Color HoverBorderColor = Color.FromArgb(255, 255, 255, 255);
            }

            public class Primary
            {
                public static Color BackColor = Color.FromArgb(255, 66, 139, 202);
                public static Color ForeColor = Color.FromArgb(255, 255, 255, 255);

                public static Color BorderColor = Color.FromArgb(255, 53, 126, 189);

                public static Color HoverBackColor = Color.FromArgb(255, 50, 118, 177);
                public static Color HoverBorderColor = Color.FromArgb(255, 40, 94, 142);
            }
            public class Success
            {
                public static Color BackColor = Color.FromArgb(255, 92, 184, 92);
                public static Color ForeColor = Color.FromArgb(255, 255, 255, 255);

                public static Color BorderColor = Color.FromArgb(255, 76, 174, 76);

                public static Color HoverBackColor = Color.FromArgb(255, 71, 164, 71);
                public static Color HoverBorderColor = Color.FromArgb(255, 57, 132, 57);
            }

            public class Info
            {
                public static Color BackColor = Color.FromArgb(255, 91, 192, 222);
                public static Color ForeColor = Color.FromArgb(255, 255, 255, 255);

                public static Color BorderColor = Color.FromArgb(255, 70, 184, 218);

                public static Color HoverBackColor = Color.FromArgb(255, 57, 179, 215);
                public static Color HoverBorderColor = Color.FromArgb(255, 38, 154, 188);
            }

            public class Warning
            {
                public static Color BackColor = Color.FromArgb(255, 240, 173, 78);
                public static Color ForeColor = Color.FromArgb(255, 255, 255, 255);

                public static Color BorderColor = Color.FromArgb(255, 238, 162, 54);

                public static Color HoverBackColor = Color.FromArgb(255, 237, 156, 40);
                public static Color HoverBorderColor = Color.FromArgb(255, 213, 133, 18);
            }

            public class Danger
            {
                public static Color BackColor = Color.FromArgb(255, 217, 83, 79);
                public static Color ForeColor = Color.FromArgb(255, 255, 255, 255);

                public static Color BorderColor = Color.FromArgb(255, 212, 63, 58);

                public static Color HoverBackColor = Color.FromArgb(255, 210, 50, 45);
                public static Color HoverBorderColor = Color.FromArgb(255, 172, 41, 37);
            }

            public class MsgError
            {
                public static Color BackColor = Color.Red;
                public static Color ForeColor = Color.White;
            }

            public class MsgSuccess
            {
                public static Color BackColor = Color.LimeGreen;
                public static Color ForeColor = Color.White;
            }
        }



        public class objNrkProgressBar
        {
            public enum enumTextStyleType
            {
                None,
                Percentage,
                Text,
                Value,
                ValueOverMaximum
            }

            public static Color ForeColor = Color.FromArgb(255, 0, 174, 235);
            public static Color BackColor = Color.FromArgb(255, 255, 255, 255);
            public static System.Windows.Forms.Orientation Orientation = System.Windows.Forms.Orientation.Horizontal;
            public static enumTextStyleType TextStyle = enumTextStyleType.None;
            public static int BorderSize = 1;
            public static Color BorderColor = Color.FromArgb(255, 1, 101, 187); //Color.FromArgb(255, 255, 255, 255);
        }


    }
}
