namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 form = new Form2();
        Form3 igra = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e) => Application.Exit();

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            igra.Show();
        }
    }
}