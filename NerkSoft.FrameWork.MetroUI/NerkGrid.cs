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
    public partial class NerkGrid : DataGridView
    {
        public NerkGrid()
        {
            InitializeComponent();
            this.BackgroundColor = Color.DarkGray;
            this.borderColor = Color.MediumSpringGreen;            
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.AlternatingRowsDefaultCellStyle.Font = new Font(clsProjectTemplate.objFont.Fuente, (float)8);
            this.RowsDefaultCellStyle.Font = new Font(clsProjectTemplate.objFont.Fuente, (float)8);
            this.ColumnHeadersDefaultCellStyle.Font = new Font(clsProjectTemplate.objFont.Fuente, (float)8, FontStyle.Bold);

            this.EnableHeadersVisualStyles = true;
                        
            this.GridColor = Color.FromArgb(255, 217, 217, 217);
            this.BackgroundColor = Color.FromArgb(255, 255, 255, 255);

            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255,255,255);  //Color.FromArgb(255, 238, 238, 238);
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black; 

            
            //this.AlternatingRowsDefaultCellStyle.SelectionBackColor = clsProjectTemplate.objNerkGrid.AlternatingRowsDefaultCellStyleSelectionBackColor;
            //this.AlternatingRowsDefaultCellStyle.SelectionForeColor = clsProjectTemplate.objNerkGrid.AlternatingRowsDefaultCellStyleSelectionForeColor;

            this.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 28, 183, 236);             
            this.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 28, 183, 236);   
            this.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
                        
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 82, 103, 122);
            this.RowHeadersDefaultCellStyle.BackColor = Color.White;

            //this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 192, 192);
            //this.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            //this.BackgroundColor = Color.LightCyan;            
            //this.EnableHeadersVisualStyles = false;

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeColumns = true;
            AllowUserToResizeRows = false;

            this.RowHeadersVisible = false;

            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private Color borderColor;

        public Color BorderColor
        {

            get { return this.borderColor; }

            set { this.borderColor = value; }

        }

        public void NextRow()
        {
            int current = 0;
            try
            {
                current = this.CurrentRow.Index;

                if (current == this.Rows.Count - 1) return;


                this.Rows[current].Selected = false;
            }
            catch
            {
                current = 0;
            }

            if (current < this.Rows.Count - 1)
            {
                this.ClearSelection();
                this.Rows[current + 1].Selected = true;
                for (int i = 0; i < this.Columns.Count; i++ )
                {
                    if (this.Rows[current + 1].Cells[i].Visible)                    
                    {
                        this.CurrentCell = this.Rows[current + 1].Cells[i];
                        break;
                    }
                }
                    
            }
        }

        public void PreviusRow()
        {
            int current = 0;
            try
            {
                current = this.CurrentRow.Index;

                if (current == 0) return;

                this.Rows[current].Selected = false;
            }
            catch
            {
                current = 0;
            }

            if (current > 0)
            {
                this.ClearSelection();
                this.Rows[current - 1].Selected = true;
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    if (this.Rows[current + 1].Cells[i].Visible)
                    {
                        this.CurrentCell = this.Rows[current - 1].Cells[i];
                        break;
                    }
                }
                
            }
        }

        public DataTable FiltrarDT(DataTable pdt, string pstrFiltro)
        {
            

            DataRow[] rows;
            DataTable dtNew;

            if (this.Rows.Count == 0) return new DataTable();

            dtNew = pdt.Clone();

            rows = pdt.Select(pstrFiltro);

            foreach(DataRow dr in rows)
            {
                dtNew.ImportRow(dr);
            }

            return dtNew;
        }
    }
}
