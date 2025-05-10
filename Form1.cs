namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // 記錄目前的秒數，初始為 100
        private int seconds = 100;
        public Form1()
        {
            InitializeComponent();
            // 顯示初始秒數在標籤上
            labelTimer.Text = seconds.ToString();
            // 1 秒
            timer1.Interval = 1000;
            // 註冊按鈕點擊事件
            btnStart.Click += btnStart_Click;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 設定秒數為 100
            seconds = 100;
            // 更新顯示的秒數
            labelTimer.Text = seconds.ToString();
            // 啟動計時器
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 每次減 1 秒
            seconds--;
            // 更新顯示的秒數
            labelTimer.Text = seconds.ToString();
            // 如果秒數已到 0，就停止計時並顯示訊息框
            if (seconds <= 0)
            {
                // 停止計時器
                timer1.Stop();
                // 顯示對話框
                MessageBox.Show("時間到!");
            }
        }
    }
}
