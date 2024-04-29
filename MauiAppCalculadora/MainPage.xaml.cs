﻿namespace MauiAppCalculadora
{
    public partial class MainPage : ContentPage
    {
        
        double memoria_pre = 0;
        double memoria_pos = 0;
        string para_aparecer_no_visor = "";
        string? operacao = null;

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
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_pre = 0;
            memoria_pos = 0;
            operacao = null;
        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();
        }

        private void porcento_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor / 100;
            visor.Text = valor.ToString();
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = para_aparecer_no_visor;
        }

        private void num7_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num7.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num8_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num8.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num9_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor  += num9.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num4_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num4.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num5_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num5.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num6_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num6.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void subtracao_Clicked(object sender, EventArgs e)
        {
            memoria_pre = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "-";
            operacao = "-";
            visor.Text = para_aparecer_no_visor;
        }

        private void num1_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num1.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num2_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num2.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num3_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num3.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void adicao_Clicked(object sender, EventArgs e)
        {
            memoria_pre = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "+";
            operacao = "+";
            visor.Text = para_aparecer_no_visor;
        }

        private void num0_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num0.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void ponto_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += ponto.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void igual_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_pos = Convert.ToDouble(visor.Text);

                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = memoria_pre + memoria_pos;

                    break;
                }

                visor.Text = resultado.ToString();

            }catch(Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {

        }
    }

}
