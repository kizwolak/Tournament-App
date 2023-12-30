using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentApp;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            bool placeNumberValidNumber = int.TryParse(PlaceNumberInput.Text, out placeNumber);

            if (!placeNumberValidNumber == false)
            {
                output = false;
            }
            if (placeNumber < 1) 
            {
                output = false;
            }
            if (PlaceNumberInput.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountInput.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageInput.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 || prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void PrizeAmoun_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrizeHeader_Click(object sender, EventArgs e)
        {

        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(PlaceNameInput.Text, PlaceNumberInput.Text, PrizeAmountInput.Text, PrizePercentageInput.Text);


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
