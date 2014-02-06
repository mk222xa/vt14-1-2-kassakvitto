using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1DV406L1._2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                double userInput;
                Double.TryParse(UserInputTextBox.Text, out userInput);

                var receipt = new Model.Receipt(userInput);
                receipt.Calculate(userInput);

                Subtotal.Text = String.Format("Totalt: {0:c}", receipt.Subtotal);
                Subtotal.Visible = true;

                DiscountRate.Text = String.Format("Rabattsats: {0:p0}", receipt.DiscountRate);
                DiscountRate.Visible = true;

                MoneyOff.Text = String.Format("Rabatt: {0:C}", receipt.MoneyOff);
                MoneyOff.Visible = true;

                Total.Text = String.Format("Att betala: {0:c2}", receipt.Total);
                Total.Visible = true;
            }
        }
    }
}