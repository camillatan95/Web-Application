using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label15_Click(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void label14_Click(object sender, EventArgs e)
        {
        }
        private void label11_Click(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void label10_Click(object sender, EventArgs e)
        {
        }
        private void label13_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int lcp;
            int mcp;
            int lpp;
            int mpp;
            int bw;
            int discountnum;
            double subtotal;
            double discountedprice;
            double salestax;
            double grandtotal;
            discountnum = 4; //the value of discount is always $4
            if (checkBox1.Checked)
            {
                lcp = Convert.ToInt32(textBox1.Text);
            }
            else { lcp = 0; }
             if (checkBox2.Checked)
            {
                mcp = Convert.ToInt32(textBox2.Text);
            }
            else { mcp = 0; }
            if (checkBox3.Checked)
            {
                lpp = Convert.ToInt32(textBox3.Text);
            }
            else { lpp = 0; }
            if (checkBox4.Checked)
            {
                mpp = Convert.ToInt32(textBox4.Text);
            }
            else { mpp = 0; }
            if (checkBox5.Checked)
            {
                bw = Convert.ToInt32(textBox5.Text);
            }
            else { bw = 0; }
            subtotal = lcp * 9 + mcp * 7.5 + lpp * 10.5 + mpp * 8.5 + bw * 6;
            label1.Text = "Subtotal ................... $" + subtotal;
            if (mcp + mpp >= 3)
            {
                label2.Text = "Discount ................... $" + discountnum;
                discountedprice = subtotal - discountnum;
                label3.Text = "Discounted Price ................... $" + discountedprice;
                salestax = discountedprice * 0.07;
                label4.Text = "Sales Tax ................... $" + salestax;
                grandtotal = discountedprice * 1.07; // we could also calculate grand total by adding dicounted price and sales tax together
                label5.Text = "Total ................... $" + grandtotal;
            }
            else
            {
                label2.Text = "Discount ................... $0";
                label3.Text = "Discounted Price ................... $" + subtotal;
                salestax = subtotal * 0.07;
                label4.Text = "Sales Tax ................... $" + salestax;
                grandtotal = subtotal * 1.07;
                label5.Text = "Total ...................$ " + grandtotal;
            }
        }
        
    }
}
