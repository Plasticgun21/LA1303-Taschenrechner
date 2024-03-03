namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Total;
        double num1;
        double num2;
        string calc;
        int result;

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calc = "/";
            num1 = double.Parse(txtBox.Text);
            txtBox.Clear();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "4"; 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "9";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            calc = "+";
            num1 = double.Parse(txtBox.Text);
            txtBox.Clear();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            calc = "-";
            num1 = double.Parse(txtBox.Text);
            txtBox.Clear();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            calc = "*";
            num1 = double.Parse(txtBox.Text);
            txtBox.Clear();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            calc = txtBox.Text + ".";
            num1 = double.Parse(txtBox.Text);
            txtBox.Clear();
        }
        
        private void btn12_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtBox.Text);
            if (calc.Equals("+"))
                result = (int)(num1 + num2);

            if (calc.Equals("-"))
                result = (int)(num1 - num2);

            if (calc.Equals("*"))
                result = (int)(num1 * num2);

            if (calc.Equals("/"))
                result = (int)(num1 / num2);

            txtBox.Text = result + "";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            num1 = (0);
            num2 = (0);

        }


       
    }
}
