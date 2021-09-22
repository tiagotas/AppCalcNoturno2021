using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalcNoturno2021
{
    public partial class MainPage : ContentPage
    {
        string operacao = null; // guarda qual operação o usuário quer fazer (adição, sub, etc)

        double memoria_pre_operacao = 0;  // guarda o numero antes da pessoa clicar na operação

        double memoria_pos_operacao = 0;  // guarda o numero depois que a pessoa clicou na operação


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "7";
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            visor.Text += "8";
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            visor.Text += "6";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            visor.Text += "3";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            visor.Text += "1";

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            visor.Text += "2";
        }

        private void Button_Clicked_Multiplicacao(object sender, EventArgs e)
        {
            memoria_pre_operacao = Convert.ToDouble(visor.Text);
            operacao = "*";
            visor.Text = String.Empty;
        }

        private void Button_Clicked_Subtracao(object sender, EventArgs e)
        {
            memoria_pre_operacao = Convert.ToDouble(visor.Text);
            operacao = "-";
            visor.Text = String.Empty;
        }

        private void Button_Clicked_Adicao(object sender, EventArgs e)
        {
            memoria_pre_operacao = Convert.ToDouble(visor.Text);
            operacao = "+";
            visor.Text = String.Empty;
        }

        private void Button_Clicked_Ponto(object sender, EventArgs e)
        {
            if (!visor.Text.Contains("."))
            {
                visor.Text += ".";
            }
        }

        private void Button_Clicked_Igual(object sender, EventArgs e)
        {
            memoria_pos_operacao = Convert.ToDouble(visor.Text);

            double resultado = 0;

            switch(operacao)
            {
                case "+":
                    //visor.Text = (memoria_pre_operacao + memoria_pos_operacao).ToString();
                    resultado = memoria_pre_operacao + memoria_pos_operacao;
                break;
                
                case "-":
                    resultado = memoria_pre_operacao - memoria_pos_operacao;
                break;

                case "*":
                    resultado = memoria_pre_operacao * memoria_pos_operacao;
                break;

                case "/":
                    resultado = memoria_pre_operacao / memoria_pos_operacao;
               break;
            }

            visor.Text = resultado.ToString();
        }

        private void Button_Clicked_0(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void Button_Clicked_Zerar(object sender, EventArgs e)
        {
            visor.Text = String.Empty;

            operacao = null;
            memoria_pre_operacao = 0;
            memoria_pos_operacao = 0;
        }

        private void Button_Clicked_Inversor(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text);

            visor.Text = (valor_visor * -1).ToString();
        }

        private void Button_Clicked_Porcentagem(object sender, EventArgs e)
        {
            try
            {
                double valor_visor = Convert.ToDouble(visor.Text);

                visor.Text = (valor_visor / 100).ToString();

            } catch(Exception ex)
            {
                visor.Text = ex.Message;
            }
        }

        private void Button_Clicked_Div(object sender, EventArgs e)
        {
            try
            {
                memoria_pre_operacao = Convert.ToDouble(visor.Text);
                operacao = "/";
                visor.Text = String.Empty;

            } catch(Exception ex)
            {
                visor.Text = ex.Message;
            }

        }
    }
}
