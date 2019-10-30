using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Object[] ItemObject = new System.Object[10];
            for (int i = 0; i < 10; i++)
            {
                ItemObject[i] = "Level " + (i+1);
            }
            comboBox1.Items.AddRange(ItemObject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salary = 0;
            int.TryParse(textBox1.Text, out salary);
            if (comboBox1.SelectedIndex == 0) label3.Text = (salary*0.1).ToString();
            else if(comboBox1.SelectedIndex >= 1 && comboBox1.SelectedIndex< 4) label3.Text = (salary * 0.09).ToString();
            else if(comboBox1.SelectedIndex >= 4 && comboBox1.SelectedIndex < 7) label3.Text = (salary * 0.07).ToString();
            else label3.Text = (salary * 0.05).ToString();
        }
    }
}
