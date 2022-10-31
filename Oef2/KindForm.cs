using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Oef2
{
    public partial class KindForm : Form
    {
        public KindForm()
        {
            InitializeComponent();
        }
        double GemiddeldeBerekening = 0;
        double waarde = 0;

        private void KindForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {          
            //we gaan een een box gaan aantonen en die waarde binnen gaan gebruiken voor het gemiddelde
            waarde = double.Parse(Interaction.InputBox("geef een waarde   =  "));
            //Items gaan uitprinten in mijn ListBox
            listBox1.Items.Add(waarde);
            // we plaatsen onze bereking op 0 
            GemiddeldeBerekening = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                GemiddeldeBerekening += Convert.ToInt32(listBox1.Items[i] +  "   ");
            }
            // berekening gemiddelde van mijn list
            GemiddeldeBerekening = GemiddeldeBerekening / listBox1.Items.Count;
            // berekening laten uitprinten in mijn textbox van gemiddelde
            textBox1.Text = GemiddeldeBerekening.ToString();            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
