using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Application purpose: to convert values of one currency to another currency.
/// Additional features: displays current date and time, users photo and users name.
/// Author: Lukas Jehle (Massey student ID #20009320)
/// Project start date: 23 March 2021
/// Project completion date: 29 March 2021
/// </summary>



namespace Assignment1
{
    public partial class currencyConversionForm : Form
    {
        public currencyConversionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Displays current date and time
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            labelDateTime.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        // Views/hides the users photo
        private void checkBoxPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPhoto.Checked)
            {
                usersPhoto.Visible = true;
            }
            else
            {
                usersPhoto.Visible = false;
            }
        }

        // Returns from currency as per user selected radioButtonFrom
        private string FromCurrency()
        {
            if (radioButtonFromAED.Checked) { return "United Arab Emirates Dirham"; }
            else if (radioButtonFromAUD.Checked) { return "Australian Dollar"; }
            else if (radioButtonFromCAD.Checked) { return "Canadian Dollar"; }
            else if (radioButtonFromEUR.Checked) { return "Euro"; }
            else if (radioButtonFromINR.Checked) { return "Indian Rupee"; }
            else if (radioButtonFromNZD.Checked) { return "New Zealand Dollar"; }
            else if (radioButtonFromRMB.Checked) { return "Chinese Yuan"; }
            else if (radioButtonFromUSD.Checked) { return "US Dollar"; }
            else if (radioButtonFromYEN.Checked) { return "Japanese Yen"; }
            else return "";
        }

        // Returns to currency as per user selected radioButtonTo
        private string ToCurrency()
        {
            if (radioButtonToAED.Checked) { return "United Arab Emirates Dirham"; }
            else if (radioButtonToAUD.Checked) { return "Australian Dollar"; }
            else if (radioButtonToCAD.Checked) { return "Canadian Dollar"; }
            else if (radioButtonToEUR.Checked) { return "Euro"; }
            else if (radioButtonToINR.Checked) { return "Indian Rupee"; }
            else if (radioButtonToNZD.Checked) { return "New Zealand Dollar"; }
            else if (radioButtonToRMB.Checked) { return "Chinese Yuan"; }
            else if (radioButtonToUSD.Checked) { return "US Dollar"; }
            else if (radioButtonToYEN.Checked) { return "Japanese Yen"; }
            else return "";
        }


        //Returns amount of currency user wishes to convert to
        private static decimal ConvertMoney(decimal amount, string fromCurrency, string toCurrency)
        {
            // Determine currency conversion rate of original currency
            decimal fromConversion = 0;
            if (fromCurrency == "United Arab Emirates Dirham")  { fromConversion=2.69m; }
            else if (fromCurrency == "Australian Dollar")       { fromConversion =0.93m; }
            else if (fromCurrency == "Canadian Dollar")         { fromConversion=0.94m; }
            else if (fromCurrency == "Euro")                    { fromConversion =0.59m; }
            else if (fromCurrency == "Indian Rupee")            { fromConversion =47.51m; }
            else if (fromCurrency == "New Zealand Dollar")      { fromConversion =1.00m; }
            else if (fromCurrency == "Chinese Yuan")            { fromConversion=4.63m; }
            else if (fromCurrency == "US Dollar")               { fromConversion =0.73m; }
            else if (fromCurrency == "Japanese Yen")            { fromConversion =77.98m; }


            // Determine currency conversion rate to be converted to
            decimal toConversion = 0;
            if (toCurrency == "United Arab Emirates Dirham")    { toConversion = 2.69m; }
            else if (toCurrency == "Australian Dollar")         { toConversion = 0.93m; }
            else if (toCurrency == "Canadian Dollar")           { toConversion = 0.94m; }
            else if (toCurrency == "Euro")                      { toConversion = 0.59m; }
            else if (toCurrency == "Indian Rupee")              { toConversion = 47.51m; }
            else if (toCurrency == "New Zealand Dollar")        { toConversion = 1.00m; }
            else if (toCurrency == "Chinese Yuan")              { toConversion = 4.63m; }
            else if (toCurrency == "US Dollar")                 { toConversion = 0.73m; }
            else if (toCurrency == "Japanese Yen")              { toConversion = 77.98m; }

            if (amount !=0 && fromConversion!=0 && toConversion!=0) { return amount * toConversion / fromConversion; }
            else { return 0; }
            
        }

        // Prints conversion in labelResult when user clicks "buttonConfirm" button
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            decimal conversionAmount = Math.Round(numericUpDownAmountToConvert.Value,2);
            string currentDate = DateTime.Now.ToShortDateString();
            string currentTime = DateTime.Now.ToShortTimeString();
            decimal convertedAmount = Math.Round(ConvertMoney(conversionAmount, FromCurrency(), ToCurrency()), 2);
            labelResult.Text = "Hello " + userName + "!\n\n" +
            "Your " + conversionAmount.ToString("N2") + " " + FromCurrency() + " can convert to " + convertedAmount.ToString("N2") + " " + ToCurrency() + " at " + currentDate +
            "\n" + currentTime + "!";
        }
    }
}
