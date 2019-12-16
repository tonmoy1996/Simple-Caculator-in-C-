using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double? save;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_dot.Text;
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_sum.Text;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_sub.Text;
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_multi.Text;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn_div.Text;
        }

        private void btneql_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("no data");
            }
            else
            {

                Calcuate(textBox1.Text);
            }
        }
        public void Calcuate(string eq)
        {

            double result = Convert.ToDouble(new DataTable().Compute(eq, null));
            textBox1.Text = result.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void btn_m1_Click(object sender, EventArgs e)
        {
           
            if (save != null)
            {
                textBox1.Text += save.ToString();
            }
            else
            {
                try
                {
                    save = Convert.ToDouble(textBox1.Text);
                }
                catch (Exception exception)
                {


                }
            }
        }

        private void btn_m2_Click(object sender, EventArgs e)
        {
            save = null;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("no data");
            }
            else
            {
                string back = "";
                StringBuilder s = new StringBuilder(textBox1.Text);


                s.Remove(0, textBox1.Text.Length - (textBox1.Text.Length - 1));
                back = s.ToString();
                textBox1.Text = back;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;
           
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {

            

                switch (e.KeyChar.ToString())
                {

                    case "1":

                        btn1.PerformClick();
                        break;



                    case "2":

                        btn2.PerformClick();
                        break;
                    case "3":

                        btn3.PerformClick();
                        break;
                    case "4":

                        btn4.PerformClick();
                        break;
                    case "5":

                        btn5.PerformClick();
                        break;
                    case "6":

                        btn6.PerformClick();
                        break;

                    case "7":

                        btn7.PerformClick();
                        break;
                    case "8":

                        btn8.PerformClick();
                        break;
                    case "9":

                        btn9.PerformClick();
                        break;
                    case "0":

                        btn0.PerformClick();
                        break;

                    case "+":

                        btn_sum.PerformClick();
                        break;

                    case "-":

                        btn_sub.PerformClick();
                        break;

                    case "*":

                        btn_multi.PerformClick();
                        break;

                    case "/":

                        btn_div.PerformClick();
                        break;


                    case "ENTER":

                        btneql.PerformClick();
                        break;



                }
            



        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
           




        }

       

        }



        

}





        
    
