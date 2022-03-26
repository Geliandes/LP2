namespace pIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double peso, altura;

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido");
                txtPeso.Focus();
            }

            else
                if (peso <= 0)
                MessageBox.Show("Peso deve ser maior que zero");
        }

        private void mskboxAltura_Validated(object sender, EventArgs e)
        {


                if (!Double.TryParse(mskboxAltura.Text, out altura))
                {
                    MessageBox.Show("Altura inválida");
                    mskboxAltura.Focus();
                }

            else
                    if (altura <= 0)
                    MessageBox.Show("Altura deve ser maior que zero");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc;
            
            imc = peso / Math.Pow(altura, 2);
            imc = Math.Round(imc,1);

            if(imc < 18.5)
                MessageBox.Show("IMC: " + Convert.ToString(imc) + " | Classificação: Magreza | Obesidade Grau 0");
            else
                if(imc < 25)
                MessageBox.Show("IMC: " + Convert.ToString(imc) + " | Classificação: Normal | Obesidade Grau 0");
            else
                if (imc < 30)
                MessageBox.Show("IMC: " + Convert.ToString(imc) + " | Classificação: Sobrepeso | Obesidade Grau I");
            else
                if (imc < 40)
                MessageBox.Show("IMC: " + Convert.ToString(imc) + " | Classificação: Obesidade | Obesidade Grau II");
            else
                MessageBox.Show("IMC: " + Convert.ToString(imc) + " | Classificação: Obsidade Grave | Obesidade Grau III");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitulo.BackColor = Color.Transparent;
            lblPeso.BackColor = Color.Transparent;
            lblAltura.BackColor = Color.Transparent;
        }
    }
}