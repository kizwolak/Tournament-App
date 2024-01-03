using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
            List<PersonModel> persons = new List<PersonModel>();
            persons = GlobalConfig.Connection.FetchPersons();


            if (persons.Count > 0)
            {
                foreach (PersonModel person in persons)
                {
                    TeamPlayersListBox.Items.Add($"{ person.FirstName } { person.LastName }");
                }
            }
        }

        private bool ValidateNewPlayerForm()
        {
            bool output = true;
            string email = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            int phoneNumber = 0;
            bool phoneNumberValidNumber = int.TryParse(PlayerPhoneInput.Text, out phoneNumber);

            if (!phoneNumberValidNumber)
            {
                output = false;
            }

            if (!Regex.IsMatch(PlayerEmailInput.Text, email)) {
                output = false;
            }
            
            return output;
        }

        private void CreateTeamNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewPlayerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PlayerEmail_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateNewPlayerForm())
            {
                PersonModel model = new PersonModel(
                    FirstNameInput.Text,
                    LastNameInput.Text,
                    PlayerEmailInput.Text,
                    PlayerPhoneInput.Text);

                GlobalConfig.Connection.CreatePerson(model);

                FirstNameInput.Text = "";
                LastNameInput.Text = "";
                PlayerEmailInput.Text = "";
                PlayerPhoneInput.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void RemovePlayerTeamButton_Click(object sender, EventArgs e)
        {

        }
    }
}
