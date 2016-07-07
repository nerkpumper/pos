namespace NerkSoft.FrameWork.MetroUI
{
    partial class NerkTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NerkTextBox));
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.picDerecha = new System.Windows.Forms.PictureBox();
            this.picIzquierda = new System.Windows.Forms.PictureBox();
            this.ttMsgr = new System.Windows.Forms.ToolTip();
            this.tmrMueveImgDerecha = new System.Windows.Forms.Timer();
            this.tmrAnimacionImgDerecha = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.picDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzquierda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.White;
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(2, 2);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(30);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(101, 16);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Click += new System.EventHandler(this.OnEnter);
            this.txtTexto.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.txtTexto.Enter += new System.EventHandler(this.OnEnter);
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.txtTexto.Leave += new System.EventHandler(this.OnLeave);
            this.txtTexto.MouseEnter += new System.EventHandler(this.NrkTextBox_MouseEnter);
            this.txtTexto.MouseLeave += new System.EventHandler(this.NrkTextBox_MouseLeave);
            // 
            // picDerecha
            // 
            this.picDerecha.BackColor = System.Drawing.Color.Transparent;
            this.picDerecha.Image = ((System.Drawing.Image)(resources.GetObject("picDerecha.Image")));
            this.picDerecha.Location = new System.Drawing.Point(246, 2);
            this.picDerecha.Name = "picDerecha";
            this.picDerecha.Size = new System.Drawing.Size(16, 16);
            this.picDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDerecha.TabIndex = 1;
            this.picDerecha.TabStop = false;
            this.ttMsgr.SetToolTip(this.picDerecha, "Este campo es obligatorio");
            this.picDerecha.Click += new System.EventHandler(this.picDerecha_Click);
            this.picDerecha.MouseEnter += new System.EventHandler(this.NrkTextBox_MouseEnter);
            this.picDerecha.MouseLeave += new System.EventHandler(this.NrkTextBox_MouseLeave);
            // 
            // picIzquierda
            // 
            this.picIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.picIzquierda.Image = global::NerkSoft.FrameWork.MetroUI.NrkRecursos.requerido16;
            this.picIzquierda.Location = new System.Drawing.Point(160, 2);
            this.picIzquierda.Name = "picIzquierda";
            this.picIzquierda.Size = new System.Drawing.Size(16, 16);
            this.picIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIzquierda.TabIndex = 2;
            this.picIzquierda.TabStop = false;
            this.picIzquierda.Click += new System.EventHandler(this.picIzquierda_Click);
            // 
            // ttMsgr
            // 
            this.ttMsgr.IsBalloon = true;
            this.ttMsgr.ShowAlways = true;
            this.ttMsgr.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tmrMueveImgDerecha
            // 
            this.tmrMueveImgDerecha.Tick += new System.EventHandler(this.tmrMueveImgDerecha_Tick);
            // 
            // tmrAnimacionImgDerecha
            // 
            this.tmrAnimacionImgDerecha.Interval = 1000;
            this.tmrAnimacionImgDerecha.Tick += new System.EventHandler(this.tmrAnimacionImgDerecha_Tick);
            // 
            // NrkTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picIzquierda);
            this.Controls.Add(this.picDerecha);
            this.Controls.Add(this.txtTexto);
            this.Name = "NrkTextBox";
            this.Size = new System.Drawing.Size(336, 20);
            this.Load += new System.EventHandler(this.NSTextBox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NSTextBox_Paint);
            this.MouseEnter += new System.EventHandler(this.NrkTextBox_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NrkTextBox_MouseLeave);
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this.picDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzquierda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.PictureBox picDerecha;
        private System.Windows.Forms.PictureBox picIzquierda;
        private System.Windows.Forms.ToolTip ttMsgr;
        private System.Windows.Forms.Timer tmrMueveImgDerecha;
        private System.Windows.Forms.Timer tmrAnimacionImgDerecha;
    }
}
