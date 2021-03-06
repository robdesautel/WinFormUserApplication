﻿using AdventureWorksEntity.Model;
using System;
using System.Windows.Forms;
using UserValidation.PasswordInteraction;

namespace WinFormExampleUsage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {

            string salt = "";
            using (var context = new Entities())
            {
                var getEmailAddressBusinessID = new Repository.PersonRepository.EmailAddress(context);
                var getSalt = new Repository.PersonRepository.Password(context);
                salt = getSalt.GetSaltByBussinessEntityID(getEmailAddressBusinessID
                                                          .GetEmailAddressBusinessEntityIDByEmail(
                                                           this.userEmailAddress.Text));
            }

            var userValidation = new UserLogin();

            var hasEmail = userValidation.isUserName(this.userEmailAddress.Text);
            var isPassword = userValidation.IsPasswordCorrect(this.userPassword.Text, this.userEmailAddress.Text);
            if (hasEmail && isPassword)
            {
                this.Hide();
                var employeeForm = new NewEmployee(this);
                employeeForm.Show();

            }
            else
            { 
                MessageBox.Show("Invalid User Email or Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }


        }
    }
}
