using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SunShine_HRMs
{

    public class RoundButton : Button
    {
        // Khai báo một thuộc tính để lưu bán kính của nút
        private int _radius;

        // Tạo một hàm khởi tạo để thiết lập các thuộc tính mặc định cho nút
        public RoundButton()
        {
            // Thiết lập bán kính mặc định là 40
            _radius = 40;

            // Thiết lập kích thước của nút theo bán kính
            this.Size = new Size(2 * _radius, 2 * _radius);

            // Thiết lập kiểu vẽ của nút là OwnerDraw để có thể ghi đè phương thức OnPaint
            this.FlatStyle = FlatStyle.Flat;

            // Thiết lập màu nền của nút là xanh lá cây
            this.BackColor = Color.Green;

            // Thiết lập màu viền của nút là trắng
            this.FlatAppearance.BorderColor = Color.White;

            // Thiết lập độ rộng của viền là 3
            this.FlatAppearance.BorderSize = 3;

            // Thiết lập không hiển thị viền khi nhấn chuột vào nút
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        // Tạo một thuộc tính để truy cập hoặc thay đổi bán kính của nút
        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                // Cập nhật lại kích thước của nút khi thay đổi bán kính
                this.Size = new Size(2 * _radius, 2 * _radius);
                // Vẽ lại nút khi thay đổi bán kính
                this.Invalidate();
            }
        }

        // Ghi đè phương thức OnPaint để vẽ nút theo hình tròn
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Lấy đối tượng Graphics từ tham số e để vẽ nút
            Graphics g = e.Graphics;

            // Tạo một đối tượng GraphicsPath để vẽ một đường cong bao quanh nút
            GraphicsPath path = new GraphicsPath();

            // Thêm một hình tròn vào đường cong với tâm là tâm của nút và bán kính là bán kính của nút
            path.AddEllipse(this.ClientRectangle);

            // Thiết lập thuộc tính Region của nút để cắt bỏ phần ngoài đường cong
            this.Region = new Region(path);

            // Tạo một đối tượng Pen để vẽ viền cho nút với màu và độ rộng đã thiết lập trước đó
            Pen pen = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize);

            // Vẽ viền cho nút bằng cách vẽ một hình tròn với tâm là tâm của nút và bán kính là bán kính của nút trừ đi một nửa độ rộng của viền
            g.DrawEllipse(pen, this.ClientRectangle.X + pen.Width / 2, this.ClientRectangle.Y + pen.Width / 2, this.ClientRectangle.Width - pen.Width, this.ClientRectangle.Height - pen.Width);

            // Tạo một đối tượng Brush để tô màu cho nút với màu đã thiết lập trước đó
            Brush brush = new SolidBrush(this.BackColor);

            // Tô màu cho nút bằng cách tô một hình tròn với tâm là tâm của nút và bán kính là bán kính của nút trừ đi độ rộng của viền
            g.FillEllipse(brush, this.ClientRectangle.X + pen.Width, this.ClientRectangle.Y + pen.Width, this.ClientRectangle.Width - 2 * pen.Width, this.ClientRectangle.Height - 2 * pen.Width);

            // Vẽ chữ cho nút bằng cách sử dụng phương thức DrawString của đối tượng Graphics
            // Thiết lập kiểu chữ, màu chữ và căn giữa chữ theo tâm của nút
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, format);
        }
    }
}