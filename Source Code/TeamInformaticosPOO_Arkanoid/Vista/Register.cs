using Arkanoid.Controlador;
using System;
using System.Windows.Forms;

namespace Arkanoid.Vista
{
    public partial class Register : Form
    {
        public delegate void GetNickname(string text);
        public GetNickname get_nickname;

        public Register()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (textBox1.Text)
                {
                    case string aux when aux.Length > 17:
                        throw new ExceededMaxCharactersException("No se puede introducir mas de 17 Caracteres");
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("Tienes que escribir un nombre!");
                    default:
                        get_nickname?.Invoke(textBox1.Text);
                        break;
                }
            }
            catch(EmptyNicknameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExceededMaxCharactersException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
