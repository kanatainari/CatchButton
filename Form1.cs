namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_true_Click(object sender, EventArgs e)
        {

        }

        private void Button_true_MouseEnter(object sender, EventArgs e)
        {
            Random rd = new Random();

            int maxX = this.ClientSize.Width - Button_true.Width;
            int maxY = this.ClientSize.Height - Button_true.Height;

            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            Button_true.Location = new Point(nextX, nextY);

            this.Text = $"(버튼 위치 : {nextX}, {nextY})";
        }
    }
}
