using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A26 田原 伊久弥";
        }

        private void Button_Clicked(object sender, EventArgs e)   
        {

            string height = heighit.Text;
            string weight = weighit.Text;
            try
            {
                double h = double.Parse(height);
                double w = double.Parse(weight);

                if (h > 3)
                {
                    h = h / 100;

                }
                if (w > 500)
                {
                    w = w / 1000;
                }

                double bmi = Math.Round(w / (h * h), 1);

                if (bmi < 18.5) {
                    result.Text = "低体重（痩せ）"+ "  BMI" + bmi;
                }
                else if(bmi < 25)
                {
                    result.Text = "普通体重" + "  BMI" + bmi;
                }
                else if (bmi < 30)
                {
                    result.Text = "肥満（1度）" + "  BMI" + bmi;
                }
                else if (bmi < 35)
                {
                    result.Text = "肥満（2度）" + "  BMI" + bmi;
                }
                else if (bmi < 40)
                {
                    result.Text = "肥満（3度）" + "  BMI" + bmi;
                }
                else
                {
                    result.Text = "肥満（4度）" + "  BMI" + bmi;
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "数値を入力してください";
            }

        }
    }
}
