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

        List<int> WaardeLijst = new List<int>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDialog window = new UserDialog();
            DialogResult result = window.ShowDialog();

            // als de vennster ok is dan gaat je de waarde die in het venster staat toevoegen aan mijn lijst van waarde
            if(window.DialogResult == DialogResult.OK)
            {
                AddToYourList(window.waarde);
            }


            }

        public void AddToYourList(int waarde)
        {
            WaardeLijst.items.Add(waarde);
        }




        } }


