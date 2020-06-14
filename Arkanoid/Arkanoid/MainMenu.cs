using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class MainMenu : UserControl
    {
        public delegate void EventUserControlMainMenu(object sender, EventArgs e);

        public EventUserControlMainMenu OnClickbtnRegister;
        public EventUserControlMainMenu OnClickbtnStart;

    public MainMenu()
        {
            InitializeComponent();
        }

    private void btnStart_Click(object sender, EventArgs e)
    {
         if (OnClickbtnStart != null)
         {
             OnClickbtnStart(this, e);
         }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
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