using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homeworkTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button[] buttons = { button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13 };

            foreach (Button button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("�ХμƦr���J�n�ഫ���ū�");
            }
            else if (radioButton1.Checked == true)
            {
                double result1 = double.Parse(textBox1.Text) * 9 / 5 + 32;
                label1.Text = $"���G�G{textBox1.Text}�J = {result1}�K";
            }
            else if (radioButton2.Checked == true)
            {
                double result2 = (double.Parse(textBox1.Text) - 32) * 5 / 9;
                label1.Text = $"���G�G{textBox1.Text}�K = {result2}�J";
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("�ФĿ�n�ഫ������");
            }
        }
    }
}
