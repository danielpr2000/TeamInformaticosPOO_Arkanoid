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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tlpRegister = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.tlpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegister.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tlpRegister.SetColumnSpan(this.btnRegister, 2);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRegister.Location = new System.Drawing.Point(150, 529);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(416, 59);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.UseWaitCursor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(406, 340);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(262, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(3, 205);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(352, 294);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Usuario";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpRegister
            // 
            this.tlpRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpRegister.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegister.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("tlpRegister.BackgroundImage")));
            this.tlpRegister.ColumnCount = 2;
            this.tlpRegister.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRegister.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRegister.Controls.Add(this.btnRegister, 0, 2);
            this.tlpRegister.Controls.Add(this.lblUsername, 0, 1);
            this.tlpRegister.Controls.Add(this.txtUsername, 1, 1);
            this.tlpRegister.Controls.Add(this.lblRegister, 0, 0);
            this.tlpRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegister.Location = new System.Drawing.Point(0, 0);
            this.tlpRegister.Name = "tlpRegister";
            this.tlpRegister.RowCount = 3;
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.74775F));
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.0991F));
            this.tlpRegister.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRegister.Size = new System.Drawing.Size(717, 618);
            this.tlpRegister.TabIndex = 5;
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.tlpRegister.SetColumnSpan(this.lblRegister, 2);
            this.lblRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegister.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(3, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(711, 205);
            this.lblRegister.TabIndex = 5;
            this.lblRegister.Text = "Registrarse";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpRegister);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(717, 618);
            this.tlpRegister.ResumeLayout(false);
            this.tlpRegister.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TableLayoutPanel tlpRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
    }
}