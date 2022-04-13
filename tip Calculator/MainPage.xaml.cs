using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tip_Calculator
{
    
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private  void my_entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry entry = sender as Entry;
            String val = entry.Text;
           
        }

//Need to do error handleing such as user entering non numeric data and need to change the keyboard
        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                decimal price = decimal.Parse(dinner_entry.Text, NumberStyles.Currency);
                decimal result = price * (decimal)0.10;
                decimal total = price + result;
                tip_entry.Text = string.Format("{0:C}", result);
                total_entry.Text = string.Format("{0:C}", total);
            }
            catch (Exception)
            {
                await DisplayAlert("Warning", "Invalid input: must enter a numeric value!", "OK");
                dinner_entry.Text = " ";
              
              
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(dinner_entry.Text, NumberStyles.Currency);
            decimal result = price * (decimal)0.15;
            decimal total = price + result;
            tip_entry.Text = string.Format("{0:C}", result);
            total_entry.Text = string.Format("{0:C}", total);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(dinner_entry.Text, NumberStyles.Currency);
            decimal result = price * (decimal)0.20;
            decimal total = price + result;
            tip_entry.Text = string.Format("{0:C}", result);
            total_entry.Text = string.Format("{0:C}", total);
        }
    }
}
