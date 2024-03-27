using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Broker_Petrol
{
    public partial class Form2 : Form
    {
        static Label errorField;

        public Form2()
        {
            InitializeComponent();
            errorField = errorMessageField;
        }

        //Validate the credentials that user entered
        static bool userValidation(int id, string password)
        {         
            bool result = false;

            // The only accepted credentials are as follows since there is no registration and database features
            // Employee ID = 123456
            // Password = admin123

            if (id == 123456 && password == "admin123")
            {
                result = true;
                //Navigate to the simulation page
                Form3 simulationPage = new Form3();
                simulationPage.Show();
            }  
            else
            {
                //If either entered credentials do not match the credentials shown above,
                //display an error message
                errorField.Text = "Incorrect employee id or password";
            }

            return result;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeIdInput = Convert.ToInt32(employeeIdField.Text);
                string employeePasswordInput = employeePasswordField.Text;
                

                if (userValidation(employeeIdInput, employeePasswordInput))
                {
                    //Hide this form (page)
                    this.Hide(); 
                }
            }
            catch (FormatException) 
            {
                //if the user enters numbers, symbols or leave the employee id field blank 
                errorField.Text = "Employee id must be numbers only";
            }       
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
