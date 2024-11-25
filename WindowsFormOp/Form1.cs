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
            // ตรวจสอบว่า input เป็นตัวเลขหรือไม่
            if (double.TryParse(textBox1.Text, out double radius))
            {
                if (radius < 0)
                {
                    label1.Text = "กรุณากรอกรัศมีที่เป็นบวก";
                }
                else
                {
                    // คำนวณพื้นที่และเส้นรอบวง
                    double area = Math.PI * radius * radius;
                    double circumference = 2 * Math.PI * radius;

                    // แสดงผลลัพธ์ใน Label1
                    label1.Text = $"พื้นที่วงกลม: {area:F2} หน่วย\nเส้นรอบวง: {circumference:F2} หน่วย";
                }
            }
            else
            {
                // แสดงข้อความเมื่อ input ไม่ถูกต้อง
                label1.Text = "กรุณากรอกรัศมีที่เป็นตัวเลข";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
