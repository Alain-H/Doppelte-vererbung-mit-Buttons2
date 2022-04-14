using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doppelte_vererbung_mit_Buttons
{
    public partial class Form1 : Form
    {
        Form2 f2;
        string my_name = "Hoch";
        
        public string F1
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== my_name)
            {
                f2 = new Form2(this);
                f2.label2.Text = " Hallo " + textBox1.Text;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Falsche Eingabe !!!");
            }
        }
    }
}
