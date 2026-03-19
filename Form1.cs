namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 100;

        // 게임 상태
        Size originalSize = new Size(729, 218);
        Font originalFont = new Font("맑은 고딕", 48, FontStyle.Bold);

        // 랜덤 생성기는 필드로 하나만 생성 (시드 중복 방지)
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Button_true_Click(object sender, EventArgs e)
        {
            MessageBox.Show("축하합니다! 버튼을 잡았어요!");

            Button_true.BackColor = Color.Lime;
            Button_true.Refresh();

            score = score + 10;
            LabelScore.Text = $"점수: {score}";

            await Task.Delay(100);
            Button_true.BackColor = SystemColors.Control;

            int newWidth = (int)(Button_true.Width * 0.9);
            int newHeight = (int)(Button_true.Height * 0.9);

            if (newWidth < 10) newWidth = 10;
            if (newHeight < 10) newHeight = 10;

            Button_true.Size = new Size(newWidth, newHeight);

            float currentFontSize = Button_true.Font.Size;
            float newFontSize = currentFontSize * 0.9f;

            if (newFontSize < 5f) newFontSize = 5f;

            Button_true.Font = new Font(Button_true.Font.FontFamily, newFontSize, Button_true.Font.Style);
        }

        private void Button_true_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - Button_true.Width;
            int maxY = this.ClientSize.Height - Button_true.Height;

            int nextX = rd.Next(0, Math.Max(1, maxX));
            int nextY = rd.Next(0, Math.Max(1, maxY));

            Button_true.Location = new Point(nextX, nextY);

            this.Text = $"(버튼 위치 : {nextX}, {nextY})";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Tomato;
            this.Refresh();
            if (score > 0)
            {
                score = score - 10;
                LabelScore.Text = $"점수: {score}";
            }

            System.Threading.Thread.Sleep(100);
            this.BackColor = SystemColors.Control;

            if (score <= 0)
            {
                DialogResult result = MessageBox.Show("점수가 0점이 되었습니다. 재도전하시겠습니까?", "게임 오버", MessageBoxButtons.RetryCancel);

                if (result == DialogResult.Retry)
                {
                    score = 100;
                    LabelScore.Text = $"점수: {score}";
                    Button_true.Size = originalSize;
                    Button_true.Font = originalFont;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
