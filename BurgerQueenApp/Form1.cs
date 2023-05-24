namespace BurgerQueenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildForm(Form childForm)
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
            ChildForm(new Form2());
        }

        private void listOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void addExtraProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form5());
        }
    }
}