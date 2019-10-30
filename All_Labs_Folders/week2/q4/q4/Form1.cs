using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Hyundai Creta");
            comboBox1.Items.Add("Mercedes CLA Class");
            comboBox1.Items.Add("Audi A6");
            comboBox1.Items.Add("Maruti Alto");
            comboBox2.Items.Add("Black");
            comboBox2.Items.Add("White");
            comboBox2.Items.Add("Red");
            comboBox2.Items.Add("Blue");

            listBox1.Items.Add("Model 1");
            listBox1.Items.Add("Model 2");
            listBox1.Items.Add("Model 3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string message = "Thank you for purchasing "+comboBox1.SelectedItem.ToString()+" "+comboBox2.SelectedItem.ToString()+" "+listBox1.SelectedItem.ToString()+" costing Rs."+textBox1.Text;
            string title = "Thanks!";
            MessageBox.Show(message, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Car Name";
            comboBox2.Text = "Color";
            textBox1.Text = "Price";
            listBox1.ClearSelected();
        }
    }
}
