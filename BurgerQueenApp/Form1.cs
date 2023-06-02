namespace BurgerQueenApp
{

    public partial class Form1 : Form
    {   
        public static List<Order> finishedOrders = new List<Order>(); 
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Order> finishedOrders)
        {
            
            InitializeComponent();
        }
        public void OpenForm(Form childForm)
        {
            this.Width = childForm.Width + 100;
            this.Width = childForm.Height + 150;
            bool situation = false;
            foreach (Form form in this.MdiChildren)
            {

                if (form.Text == childForm.Text)
                {
                    situation = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (situation == false)
            {
                childForm.MdiParent = this;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }

        }
        
        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2());
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
                     
            Form3 form = new Form3();
            OpenForm(form);

        }

        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4());
        }

        private void addExtraProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5());
        }
    }
}