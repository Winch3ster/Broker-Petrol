using System;
using System.Drawing;
using System.Windows.Forms;

namespace Broker_Petrol
{

    //Main menu of the application
    public partial class Form1 : Form
    {
        public static Form1 Form1Instance;

        public Form1()
        {
            Form1Instance = this;
            InitializeComponent();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            //If the sign in button is clicked, hide this page and open up the sign in page
            Hide();
            Form2 signInPage = new Form2();
            signInPage.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Display the current time on the user's device in the main menu
            DateTime currentTime = DateTime.Now;
            timePlaceHolder.Text = DateTime.Now.ToLongTimeString();

            //if the current time is between 7 a.m. to 7 p.m.
            if (currentTime.Hour > 6 && currentTime.Hour < 20)
            {
                //Set the day icon to sunny
                daySymbol.BackgroundImage = Properties.Resources.sunny_inverted;
                daySymbol.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else //if the current time is between 7 p.m. to 7 a.m.
            {
                //Set the day icon to crescent
                daySymbol.BackgroundImage = Properties.Resources.night_inverted;
                daySymbol.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Start the timer to update the time display (every 20 miliseconds )
            timer1.Start();
        }

        private void LearnMore_Click(object sender, EventArgs e)
        {
            //Browse the website via user's default web browser
            System.Diagnostics.Process.Start("https://www.playgroundequipment.com/how-fast-is-the-planet-dying-26-eye-opening-statistics/");
        }


        //When the cursor hovers over the learn more and sign in buttons, change the buttons' color
        private void button2_MouseHover(object sender, EventArgs e)
        {
            signInButton.ForeColor = Color.Black;
        }

        private void signInButton_MouseLeave(object sender, EventArgs e)
        {
            signInButton.ForeColor = Color.White;
        }
    }
}
