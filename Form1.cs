namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // �O���ثe����ơA��l�� 100
        private int seconds = 100;
        public Form1()
        {
            InitializeComponent();
            // ��ܪ�l��Ʀb���ҤW
            labelTimer.Text = seconds.ToString();
            // 1 ��
            timer1.Interval = 1000;
            // ���U���s�I���ƥ�
            btnStart.Click += btnStart_Click;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // �]�w��Ƭ� 100
            seconds = 100;
            // ��s��ܪ����
            labelTimer.Text = seconds.ToString();
            // �Ұʭp�ɾ�
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // �C���� 1 ��
            seconds--;
            // ��s��ܪ����
            labelTimer.Text = seconds.ToString();
            // �p�G��Ƥw�� 0�A�N����p�ɨ���ܰT����
            if (seconds <= 0)
            {
                // ����p�ɾ�
                timer1.Stop();
                // ��ܹ�ܮ�
                MessageBox.Show("�ɶ���!");
            }
        }
    }
}
