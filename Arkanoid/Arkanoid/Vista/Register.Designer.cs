using System.ComponentModel;

namespace Arkanoid
{
    partial class Register
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.tlpRegister = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.TxtPlayer = new System.Windows.Forms.TextBox();
            this.tlpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRegister
            // 
            this.tlpRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpRegister.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegister.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("tlpRegister.BackgroundImage")));
            this.tlpRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpRegister.ColumnCount = 1;
            this.tlpRegister.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRegister.Controls.Add(this.lblRegister, 0, 0);
            this.tlpRegister.Controls.Add(this.TxtPlayer, 0, 1);
            this.tlpRegister.Controls.Add(this.BtnRegister, 0, 2);
            this.tlpRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegister.Location = new System.Drawing.Point(0, 0);
            this.tlpRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpRegister.Name = "tlpRegister";
            this.tlpRegister.RowCount = 3;
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.74775F));
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.0991F));
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpRegister.Size = new System.Drawing.Size(819, 824);
            this.tlpRegister.TabIndex = 5;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRegister.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnRegister.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("BtnRegister.BackgroundImage")));
            this.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.BtnRegister.Location = new System.Drawing.Point(236, 708);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(347, 73);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.UseWaitCursor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegister.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(3, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(813, 274);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Crear Jugador";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPlayer
            // 
            this.TxtPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPlayer.Location = new System.Drawing.Point(214, 456);
            this.TxtPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPlayer.Name = "TxtPlayer";
            this.TxtPlayer.Size = new System.Drawing.Size(391, 27);
            this.TxtPlayer.TabIndex = 6;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(819, 824);
            this.tlpRegister.ResumeLayout(false);
            this.tlpRegister.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TableLayoutPanel tlpRegister;
        private System.Windows.Forms.TextBox TxtPlayer;
        private System.Windows.Forms.Button BtnRegister;
    }
}