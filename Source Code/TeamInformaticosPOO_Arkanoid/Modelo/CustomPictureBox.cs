using System.Windows.Forms;

namespace Arkanoid.Modelo
{
    public class CustomPictureBox : PictureBox
    {
        public int Hits { get; set; }

        public CustomPictureBox() : base() { }
    }
}
