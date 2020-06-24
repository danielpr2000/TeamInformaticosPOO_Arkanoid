namespace Arkanoid
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnStartGame = new System.Windows.Forms.Button();
            this.bttnViewTop = new System.Windows.Forms.Button();
            this.bttnExitApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bttnStartGame, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnViewTop, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bttnExitApplication, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bttnStartGame
            // 
            this.bttnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnStartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnStartGame.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnStartGame.Location = new System.Drawing.Point(323, 183);
            this.bttnStartGame.Name = "bttnStartGame";
            this.bttnStartGame.Size = new System.Drawing.Size(154, 84);
            this.bttnStartGame.TabIndex = 0;
            this.bttnStartGame.Text = "Iniciar juego";
            this.bttnStartGame.UseVisualStyleBackColor = true;
            this.bttnStartGame.Click += new System.EventHandler(this.BttnStartGame_Click);
            // 
            // bttnViewTop
            // 
            this.bttnViewTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnViewTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnViewTop.Location = new System.Drawing.Point(323, 273);
            this.bttnViewTop.Name = "bttnViewTop";
            this.bttnViewTop.Size = new System.Drawing.Size(154, 84);
            this.bttnViewTop.TabIndex = 0;
            this.bttnViewTop.Text = "Ver top";
            this.bttnViewTop.UseVisualStyleBackColor = true;
            this.bttnViewTop.Click += new System.EventHandler(this.BttnViewTop_Click);
            // 
            // bttnExitApplication
            // 
            this.bttnExitApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnExitApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnExitApplication.Location = new System.Drawing.Point(323, 363);
            this.bttnExitApplication.Name = "bttnExitApplication";
            this.bttnExitApplication.Size = new System.Drawing.Size(154, 84);
            this.bttnExitApplication.TabIndex = 0;
            this.bttnExitApplication.Text = "Salir";
            this.bttnExitApplication.UseVisualStyleBackColor = true;
            this.bttnExitApplication.Click += new System.EventHandler(this.BttnExitApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(163, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 84);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttnStartGame;
        private System.Windows.Forms.Button bttnViewTop;
        private System.Windows.Forms.Button bttnExitApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

