namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(mtbPeso.Text);
            altura = Convert.ToDouble(mtbAltura.Text);
            var (descricaoIMC, resultadoIMC) = CalcularImc(peso, (altura/100));

            labelResult.Text = $"{descricaoIMC}\nSeu IMC: {resultadoIMC}";
        }

        private (string,double) CalcularImc(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            
            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };
            return (resultado, imc);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            mtbPeso.Text = "";
            mtbAltura.Clear();
            labelResult.Text = String.Empty;

            mtbPeso.Focus();
        }
    }
}