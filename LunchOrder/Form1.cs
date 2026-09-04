namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //COLE MORRIS   

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

     //COLE MORRIS   
        private void ClearTotals()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        //COLE MORRIS   

        private void ClearAddOns()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        //COLE MORRIS   

        private void MainCourse_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();

            if (radioButton1.Checked)
            {
                checkBox1.Text = "Lettuce, tomato, and onions";
                checkBox2.Text = "Ketchup, mustard, and mayo";
                checkBox3.Text = "French fries";
            }

            else if (radioButton2.Checked)
            {
                checkBox1.Text = "Pepperoni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";
            }

            else if (radioButton3.Checked)
            {

                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";
            }
        }

        //COLE MORRIS   

        private void AddOn_CheckChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        //COLE MORRIS   

        private void Calculate()
        {
            float subTotal = 0;
            if (radioButton1.Checked)
            {
                subTotal = 6.95f;
            }

            else if (radioButton2.Checked)
            {
                subTotal = 5.95f;
            }

            else if (radioButton3.Checked)
            {
                subTotal = 4.95f;
            }

            if (checkBox1.Checked)
            {
                subTotal += 0.75f;
            }

            if (checkBox2.Checked)
            {
                subTotal += 0.75f;
            }

            if (checkBox3.Checked)
            {
                subTotal += 0.75f;
            }

            float tax = subTotal * .0775f;
            float total = subTotal + tax;

            textBox1.Text = subTotal.ToString("C");
            textBox2.Text = tax.ToString("C");
            textBox3.Text = total.ToString("C");
        }

        //COLE MORRIS   

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
