namespace Oef2
{
    public partial class GemiddeldeMDI : Form
    {

        KindForm Gemiddelde = new KindForm();
        public GemiddeldeMDI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ik laat deze form een mdi container worden
            this.IsMdiContainer = true;
            // ik attriubeer form 1 als Parent van form 2 
           Gemiddelde.MdiParent = this;
            // Form tonen als mijn eerste form toon om die tegelijkertijd gaat tonen
            Gemiddelde.Show();
            

        }

    } 
        
    }
