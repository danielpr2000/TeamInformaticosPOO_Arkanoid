namespace Arkanoid
{
    partial class ControlArkanoid
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerPb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerPb)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPb
            // 
            this.playerPb.Location = new System.Drawing.Point(299, 375);
            this.playerPb.Name = "playerPb";
            this.playerPb.Size = new System.Drawing.Size(157, 34);
            this.playerPb.TabIndex = 0;
            this.playerPb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ControlArkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerPb);
            this.Name = "ControlArkanoid";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ControlArkanoid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlArkanoid_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlArkanoid_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.playerPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPb;
        private System.Windows.Forms.Timer timer1;
    }
}
