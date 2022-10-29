namespace Oef2
{
    public partial class Form1 : Form
    {

        Form2 Gemiddelde = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          this.IsMdiContainer = true;
           Gemiddelde.MdiParent = this;
            Gemiddelde.Show();
            

        }


        // Form1.IsMdiContainer should be true






    } 
        
    }
