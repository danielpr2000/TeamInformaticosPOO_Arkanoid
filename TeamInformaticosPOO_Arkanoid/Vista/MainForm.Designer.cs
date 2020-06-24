namespace Arkanoid.Vista
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnStartGame = new System.Windows.Forms.Button();
            this.bttnViewTop = new System.Windows.Forms.Button();
            this.bttnExitApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bttnStartGame, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bttnViewTop, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bttnExitApplication, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bttnStartGame
            // 
            this.bttnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnStartGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnStartGame.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("bttnStartGame.BackgroundImage")));
            this.bttnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnStartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnStartGame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnStartGame.ForeColor = System.Drawing.Color.Transparent;
            this.bttnStartGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttnStartGame.Location = new System.Drawing.Point(163, 299);
            this.bttnStartGame.Name = "bttnStartGame";
            this.bttnStartGame.Size = new System.Drawing.Size(154, 68);
            this.bttnStartGame.TabIndex = 0;
            this.bttnStartGame.UseVisualStyleBackColor = false;
            this.bttnStartGame.Click += new System.EventHandler(this.BttnStartGame_Click);
            // 
            // bttnViewTop
            // 
            this.bttnViewTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnViewTop.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("bttnViewTop.BackgroundImage")));
            this.bttnViewTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnViewTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnViewTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewTop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.bttnViewTop.Location = new System.Drawing.Point(323, 299);
            this.bttnViewTop.Name = "bttnViewTop";
            this.bttnViewTop.Size = new System.Drawing.Size(154, 68);
            this.bttnViewTop.TabIndex = 0;
            this.bttnViewTop.UseVisualStyleBackColor = true;
            this.bttnViewTop.Click += new System.EventHandler(this.BttnViewTop_Click);
            // 
            // bttnExitApplication
            // 
            this.bttnExitApplication.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnExitApplication.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("bttnExitApplication.BackgroundImage")));
            this.bttnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnExitApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnExitApplication.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.bttnExitApplication.Location = new System.Drawing.Point(483, 299);
            this.bttnExitApplication.Name = "bttnExitApplication";
            this.bttnExitApplication.Size = new System.Drawing.Size(154, 68);
            this.bttnExitApplication.TabIndex = 0;
            this.bttnExitApplication.UseVisualStyleBackColor = true;
            this.bttnExitApplication.Click += new System.EventHandler(this.BttnExitApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(163, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 68);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "TeamInformaticosPOO_Arkanoid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnExitApplication;
        private System.Windows.Forms.Button bttnStartGame;
        private System.Windows.Forms.Button bttnViewTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}

