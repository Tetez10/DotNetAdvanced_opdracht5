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
        int GemiddeldeBerekening = 0;

        private void KindForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double waarde = int.Parse(Interaction.InputBox("geef een waarde   =  "));
            //Items gaan uitprinten in mijn ListBox
            listBox1.Items.Add(waarde);
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
