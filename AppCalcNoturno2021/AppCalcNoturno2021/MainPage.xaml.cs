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
    }
}
