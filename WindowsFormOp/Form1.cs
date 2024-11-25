namespace WindowsFormOp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��Ǩ�ͺ��� input �繵���Ţ�������
            if (double.TryParse(textBox1.Text, out double radius))
            {
                if (radius < 0)
                {
                    label1.Text = "��سҡ�͡����շ���繺ǡ";
                }
                else
                {
                    // �ӹǳ��鹷���������ͺǧ
                    double area = Math.PI * radius * radius;
                    double circumference = 2 * Math.PI * radius;

                    // �ʴ����Ѿ��� Label1
                    label1.Text = $"��鹷��ǧ���: {area:F2} ˹���\n����ͺǧ: {circumference:F2} ˹���";
                }
            }
            else
            {
                // �ʴ���ͤ�������� input ���١��ͧ
                label1.Text = "��سҡ�͡����շ���繵���Ţ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
