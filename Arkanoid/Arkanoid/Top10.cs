using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Top10 : UserControl
    {
        public Top10()
        {
            InitializeComponent();
        }

        private void Top10_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery("SELECT * FROM SCORE;");

                Dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema");
            }
        }
    }
}