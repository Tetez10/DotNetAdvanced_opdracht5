namespace Oef1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }

        
        private void redCtrlRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;

        }

        private void greenCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;

        }

        private void blueCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor =  Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font  = new Font("verdana", 10);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font  = new Font("verdana", 12);

        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font  = new Font("verdana", 14);

        }
    }
}