using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePrecentageValue.Text);

                
                GloblaConfig.Connection.CreatePrize(model);
              
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePrecentageValue.Text = "0";


            }

            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePrecentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizeProcentageValid = double.TryParse(prizePrecentageValue.Text, out prizePrecentage);

            if (prizeAmountValid == false || prizeProcentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePrecentage <= 0)
            {
                output = false;
            }

            if (prizePrecentage < 0 || prizePrecentage > 100)
            {
                output = false;
            }



            return output;
        }


    }
}
