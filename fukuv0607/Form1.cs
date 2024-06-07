namespace fukuv0607
{
    public partial class Form1 : Form
    {
        double vx = -4;
        double vy = -4;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += (int)vx;
            label1.Top += (int)vy;

            if (label1.Left <= 0)
            {
                vx = -vx;
            }

            if (label1.Top <= 0)
            {
                vy = -vy;
            }

            if (label1.Left >= 740)
            {
                vx = -vx;
            }

            if (label1.Top >= 400)
            {
                vy = -vy;
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vy = -vy;
        }


    }
}