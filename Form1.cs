namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            labelTimer.Text = seconds.ToString();
            timer1.Interval = 1000; // 1 ¬í
            btnStart.Click += btnStart_Click;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            seconds = 100;
            labelTimer.Text = seconds.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            labelTimer.Text = seconds.ToString();

            if (seconds <= 0)
            {
                timer1.Stop();
                MessageBox.Show("®É¶¡¨ì!");
            }
        }
    }
}
