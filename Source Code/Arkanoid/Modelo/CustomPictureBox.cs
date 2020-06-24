using System.Windows.Forms;

namespace Arkanoid
{
    public class CustomPictureBox : PictureBox
    {
        public int Hits { get; set; }

        public CustomPictureBox() : base() { }
    }
}
