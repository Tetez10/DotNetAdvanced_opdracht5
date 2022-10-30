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
            // ik attriubeer form 1 als Parent van form 2 
           Gemiddelde.MdiParent = this;
            // Form tonen als mijn eerste form toon om die tegelijkertijd gaat tonen
            Gemiddelde.Show();
            

        }


        // Form1.IsMdiContainer should be true






    } 
        
    }
