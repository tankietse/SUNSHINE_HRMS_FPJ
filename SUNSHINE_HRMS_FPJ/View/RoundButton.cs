using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SUNSHINE_HRMS_FPJ
{

    public class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(path);
            base.OnPaint(pevent);
        }
    }
}