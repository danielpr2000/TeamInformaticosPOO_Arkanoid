using System;
using System.Windows.Forms;
using Arkanoid.Controlador;

namespace Arkanoid
{
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        public delegate void GetNickname(string text);

        public GetNickname gn;


        private void BtnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (TxtNick.Text)
                {
                    case string aux when aux.Length > 15:
                        throw new ExceededMaxCharactersException("No se puede introducir un nick de mas de 15 car");
                    case string aux when aux.Trim().Length == 0:
                        throw new EmptyNicknameException("No puede dejar campos vacios");
                    default:
                        gn?.Invoke(TxtNick.Text);
                        break;
                }
            }
            catch (EmptyNicknameException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExceededMaxCharactersException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}