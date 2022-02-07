namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double Primero;
        double Segundo;
        string Operador;
        
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClaseSuma sumobj = new Clases.ClaseSuma();
        Clases.ClaseResta restobj = new Clases.ClaseResta();
        Clases.ClaseMultiplicacion multobj = new Clases.ClaseMultiplicacion();
        Clases.ClaseDivision divobj = new Clases.ClaseDivision();

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void botonsuma_Click(object sender, EventArgs e)
        {
            Operador = "+";
            Primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonresta_Click(object sender, EventArgs e)
        {
            Operador = "-";
            Primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonmultiplicar_Click(object sender, EventArgs e)
        {
            Operador = "*";
            Primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botondividir_Click(object sender, EventArgs e)
        {
            Operador = "/";
            Primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void botonlimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonigual_Click(object sender, EventArgs e)
        {
            Segundo = double.Parse(pantalla.Text);

            double sum;
            double rest;
            double mult;
            double div;

            switch (Operador)
            {
                case "+":
                    sum = sumobj.suma((Primero), (Segundo));
                    pantalla.Text = sum.ToString();
                    break;

                case "-":
                    rest = restobj.resta((Primero), (Segundo));
                    pantalla.Text = rest.ToString();
                    break;

                case "*":
                    mult = multobj.multiplicacion((Primero), (Segundo));
                    pantalla.Text = mult.ToString();
                    break;

                case "/":
                    div = divobj.division((Primero), (Segundo));
                    pantalla.Text = div.ToString();
                    break;

            }
                
        }

        private void botonborrar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
                pantalla.Text = "";
            else
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
        }
    }
}