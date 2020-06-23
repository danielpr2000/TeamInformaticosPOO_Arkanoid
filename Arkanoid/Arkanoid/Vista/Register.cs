using System;
using System.Windows.Forms;

namespace Arkanoid.Vista
{
    
    public partial class Register : UserControl
    {
        public  delegate string GetNickname(string nickn);

        public GetNickname nick;


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(TxtPlayer.Text.Length != 0)
            nick?.Invoke(TxtPlayer.Text);
        }
    }
}