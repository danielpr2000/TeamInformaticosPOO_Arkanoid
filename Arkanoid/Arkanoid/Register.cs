using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Register : UserControl
    {
        public delegate void EventUserControlRegister(object sender, EventArgs e);

        public Register.EventUserControlRegister OnClickbtnRegister;

       
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
             if (OnClickbtnRegister != null)
                   {
                        OnClickbtnRegister(this, e);
                    }
        }
    }
}