using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef2
{
    public partial class DialogWindow : Form
    {
        Form2 gemiddelde = new Form2();

        public DialogWindow()
        {
            InitializeComponent();
        }
        public double waarde { get; set;  }

        private void button1_Click(object sender, EventArgs e)
        {
            // ik paars het om het waarde te kunnen oppaken.
            this.waarde = double.Parse(textBox1.Text);

        }
    }

    

}