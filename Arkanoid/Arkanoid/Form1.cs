using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        private MainMenu menu;
        private Register register;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            menu = new MainMenu();
            register = new Register();
           
            
            menu.Dock = DockStyle.Fill;
            menu.Width = Width;
            menu.Height = Height;

            register.Dock = DockStyle.Fill;
            register.Width = Width;
            register.Height = Height;

            Controls.Add(register);
            
            register.Hide();
            
            Controls.Add(menu);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            register.OnClickbtnRegister += OnClickToRegister;
        }

        private void OnClickToMainMenu(object sender, EventArgs e)
        {
            menu.Show();
            register.Hide();
        }
        private void OnClickToRegister(object sender, EventArgs e)
        {
            register.Show();
            menu.Hide();
            
        }
    }
}
           