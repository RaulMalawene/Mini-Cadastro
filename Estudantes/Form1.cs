namespace Estudantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(nt1.Text);
            double nota2 = double.Parse(nt2.Text);

            double media = nota1 + nota2 / 2;
           
         

            ListViewItem lstvItemEstudantes = new ListViewItem();
            lstvItemEstudantes.Text = cd.Text;
            lstvItemEstudantes.SubItems.Add(nm.Text.ToUpper());
            
            lstvItemEstudantes.SubItems.Add(nt1.Text);
            lstvItemEstudantes.SubItems.Add(nt2.Text);
            lstvItemEstudantes.SubItems.Add(media + "");
            lstvEstudantes.Items.Add(lstvItemEstudantes);


        }
    }
}
