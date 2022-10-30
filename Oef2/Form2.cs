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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogWindow window = new DialogWindow();
            window.ShowDialog();

            // als de vennster ok is dan gaat je de waarde die in het venster staat toevoegen aan mijn lijst van waarde
            if (window.DialogResult == DialogResult.OK)
            {

                AddToYourList(window.waarde);
                window.Dispose();

            }

        }



        public void AddToYourList(double waarde)
        {
            listBox1.Items.Add(waarde);
        }

        public void BerekendeGemiddelde(double waarde)
        {


            double total = 0;


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                total = total + double.Parse(listBox1.Items[i].ToString());
            }

            total = (total / listBox1.Items.Count);


            Gemiddelde.Text = total.ToString(); 




        }
    }
}


