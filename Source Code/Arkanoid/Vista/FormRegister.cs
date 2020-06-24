using Arkanoid.Controlador;
using System;
using System.Windows.Forms;

namespace Arkanoid.Vista
{
    public partial class FormRegister : Form
    {
        public delegate void GetNickname(string text);
        public GetNickname gn;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (textBox1.Text)
                {
                    case string aux when aux.Length > 15:
                        throw new ExceededMaxCharactersException("No se puede introducir un nick de mas de 15 car");
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("No puede dejar campos vacios");
                    default:
                        gn?.Invoke(textBox1.Text);
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
