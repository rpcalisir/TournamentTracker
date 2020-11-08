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
using TrackerLibrary.Connector;
using TrackerLibrary.Helper;
using TrackerLibrary.Interface;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }
        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Prize prize = new Prize(txtPlaceName.Text,
                                        txtPlaceNumber.Text,
                                        txtPrizeAmount.Text,
                                        txtPrizePercentage.Text);
                //To clear out the form
                txtPlaceName.Text = "";
                txtPlaceNumber.Text = "";
                txtPrizeAmount.Text = "0";
                txtPrizePercentage.Text = "0";

                foreach (IDataConnection db in GlobalConfigHelper.Connections)
                {
                    db.CreatePrize(prize);
                }

                //SqlConnector sqlConnector = new SqlConnector();
                //sqlConnector.CreatePrize(prize);
            }
            else
            {
                MessageBox.Show("Form is not valid. Please try again!");
            }
        }

        private bool ValidateForm()
        {
            bool result = true;
            bool isValidPlaceNumber = int.TryParse(txtPlaceNumber.Text, out int placeNumber);

            if (!isValidPlaceNumber)
            {
                MessageBox.Show("Place number is not a valid number");
                result = false;
            }
            if(placeNumber <0)
            {
                MessageBox.Show("Place number is negative");
                result = false;
            }

            if(txtPlaceName.Text.Length == 0)
            {
                MessageBox.Show("Place name is empty");
                result = false;
            }

            bool isPrizeAmountValid = decimal.TryParse(txtPrizeAmount.Text, out decimal prizeAmount);
            if (!isPrizeAmountValid)
            {
                MessageBox.Show("Prize amount is not valid");
                result = false;
            }


            bool isPrizePercentageValid = int.TryParse(txtPrizePercentage.Text, out int prizePercentage);
            if (!isPrizePercentageValid)
            {
                MessageBox.Show("Prize percentage is not valid");
                result = false;
            }

            if (prizeAmount <= 0)
            {
                MessageBox.Show("Prize amount is negative");
                result = false;
            }
            if (prizePercentage <= 0 || prizePercentage>100)
            {
                MessageBox.Show("Prize percentage is not between 0-100");
                result = false;
            }

            return result;
        }
    }
}
