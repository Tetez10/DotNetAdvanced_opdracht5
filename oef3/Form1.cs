using System.Windows.Forms;

namespace oef3
{
    public partial class Form1 : Form
    {
        private int breedte = 0;
        private int hoogte = 0;
        public static List<int> LijstKleurR = new List<int>();
        public static List<int> LijstKleurG = new List<int>();
        public static List<int> LijstKleurB = new List<int>();
        public static List<int> LijstKleurA = new List<int>();
        public static int teller;
        public static int RijenTeller;
        public static int ColTeller;
        public static List<TextBox> TbList = new List<TextBox>();
        public static TextBox CTBox = new TextBox();
        public static int CurrentBox;
        private int X = 0;
        private int Y = 28;
        private color color1;
        public Form1()
        {
            InitializeComponent();
        }
        public void Calculate()
        {
            int berekendeTeller = 1;


            if (teller == 1)
            {
                berekendeTeller = 1;

            }
            else if (teller >= 2)
            {
                berekendeTeller = (int)Math.Ceiling(Math.Sqrt(teller));
            }

            breedte = (this.Size.Width - 19) / berekendeTeller;
            hoogte = (this.Size.Height - 76) / berekendeTeller;

            if (ColTeller < berekendeTeller)
            {
                X = (this.Size.Width - 19) * RijenTeller / berekendeTeller;
                Y = (this.Size.Height - 76) * ColTeller /  berekendeTeller + 28;
            }

            ColTeller++;

            if (ColTeller == berekendeTeller)
            {
                RijenTeller++;
                ColTeller = 0;
            }

        }

        private void adDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int counted = teller;
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            teller++;
            ColTeller = 0;
            RijenTeller = 0;
            for (int i = 0; i < teller; i++)
            {
                LijstKleurA.Add(255);
                LijstKleurR.Add(164);
                LijstKleurG.Add(245);
                LijstKleurB.Add(66);


                Calculate();
                TextBox Rechthoek = new TextBox();
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(X, Y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(LijstKleurA[i], LijstKleurR[i], LijstKleurG[i], LijstKleurB[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                TbList.Add(Rechthoek);

            }
        }

        private void verwijderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int afteller = teller;
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(afteller);
                afteller--;
            }
            teller--;

            ColTeller = 0;
            RijenTeller = 0;

            for (int i = 0; i < teller; i++)
            {
                Calculate();
                TextBox Rechthoek = new TextBox();
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(X, Y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(LijstKleurA[i], LijstKleurR[i], LijstKleurG[i], LijstKleurB[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                TbList.Add(Rechthoek);
            }
        }
        public void TextBox_MouseHover(object sender, EventArgs e)
        {

            if (color1 != null)
            {
                color1.Visible = false;
            }

            CTBox  = (TextBox)sender;
            ColorDialog colorDialog = new ColorDialog();
            color1.Location = new Point(CTBox.Location.X + this.Location.X, CTBox.Location.Y + this.Location.Y);
            color1.Visible = true;
            color1 = color1;
            CurrentBox = TbList.IndexOf(CTBox);

        }
    }
}

