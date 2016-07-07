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
    public partial class NerkLabel : Label
    {
        

        public NerkLabel()
        {
            InitializeComponent();
            this.Font = new Font("Segoe UI", (float)10);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            
            this.AutoSize = false;            
            
        }

        
      
    }
}
