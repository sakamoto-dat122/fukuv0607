namespace fukuv0607
{
    public partial class Form1 : Form
    {
        double vx = -4;
        double vy = -4;
        int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var fpos = PointToClient(MousePosition);
            //label1.Text = $"{fpos.X},{fpos.Y}";
            label4.Left = fpos.X;
            label4.Top = fpos.Y;

            label1.Left += (int)vx;
            label1.Top += (int)vy;

            if (label1.Left <= 0)
            {
                vx = Math.Abs(vx);
            }

            if (label1.Top <= 0)
            {
                vy = Math.Abs(1.1 * vy);
                a++;
                label3.Text = $"{a}";

            }

            if (label1.Left + label1.Width > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }

            if (label1.Top + label1.Height > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
                //Application.Exit();
            }

            if((label1.Left<fpos.X) && (label1.Top<fpos.Y) &&
                (label1.Right>fpos.X) && (label1.Bottom>fpos.Y))
            {
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            //label1.Text = "��{���l";
            vy = -Math.Abs(vy);
        }
    }
}