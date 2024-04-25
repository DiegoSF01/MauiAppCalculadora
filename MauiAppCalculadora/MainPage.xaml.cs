using CoreImage;

namespace MauiAppCalculadora
{
    public partial class MainPage : ContentPage
    {
        double numero_pedido = 0;
        double numero_resultado = 0;
        string para_aparecer_no_visor = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" ||
               para_aparecer_no_visor == "-" ||
               para_aparecer_no_visor == "x" ||
               para_aparecer_no_visor == "/")
            {
                para_aparecer_no_visor = "";
            }
        }

        private void zerar_Clicked(object sender, EventArgs e)
        {
            para_aparecer_no_visor = "";
            numero_pedido = 0;
            numero_resultado = 0;

        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {
            numero_pedido = numero_pedido * -1;
        }

        private void porcento_Clicked(object sender, EventArgs e)
        {

            numero_resultado = numero_pedido / 100;
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {

        }

        private void num7_Clicked(object sender, EventArgs e)
        {

        }

        private void num8_Clicked(object sender, EventArgs e)
        {

        }

        private void num9_Clicked(object sender, EventArgs e)
        {

        }

        private void num4_Clicked(object sender, EventArgs e)
        {

        }

        private void num5_Clicked(object sender, EventArgs e)
        {

        }

        private void num6_Clicked(object sender, EventArgs e)
        {

        }

        private void subtracao_Clicked(object sender, EventArgs e)
        {

        }

        private void num1_Clicked(object sender, EventArgs e)
        {

        }

        private void num2_Clicked(object sender, EventArgs e)
        {

        }

        private void num3_Clicked(object sender, EventArgs e)
        {

        }

        private void adicao_Clicked(object sender, EventArgs e)
        {

        }

        private void num0_Clicked(object sender, EventArgs e)
        {

        }

        private void ponto_Clicked(object sender, EventArgs e)
        {

        }

        private void igual_Clicked(object sender, EventArgs e)
        {

        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {

        }
    }

}
