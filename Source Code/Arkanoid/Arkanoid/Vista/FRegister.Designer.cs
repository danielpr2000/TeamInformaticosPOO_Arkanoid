using System.ComponentModel;

namespace Arkanoid
{
    partial class FRegister
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FRegister));
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TxtNick = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("BtnRegister.BackgroundImage")));
            this.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegister.Location = new System.Drawing.Point(206, 298);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRegister.Size = new System.Drawing.Size(224, 65);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click_1);
            // 
            // TxtNick
            // 
            this.TxtNick.Location = new System.Drawing.Point(206, 99);
            this.TxtNick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNick.Name = "TxtNick";
            this.TxtNick.Size = new System.Drawing.Size(225, 27);
            this.TxtNick.TabIndex = 1;
            // 
            // FRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 468);
            this.Controls.Add(this.TxtNick);
            this.Controls.Add(this.BtnRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRegister";
            this.Text = "FRegister";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox TxtNick;

        #endregion
    }
}