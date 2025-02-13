using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using NumberGuessClient.NumberGuessServiceReference;
namespace NumberGuessUI
{
    public partial class Form1 : Form
    {
        //private NumberGuessServiceClient client;
        private int secretNumber;
        private int attempts;
        public Form1()
        {
            InitializeComponent();
            //client = new NumberGuessServiceClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int lower, upper;
            if (int.TryParse(txtLowerLimit.Text, out lower) && int.TryParse(txtUpperLimit.Text, out upper))
            {
                //secretNumber = client.SecretNumber(lower, upper);
                attempts = 0;
                lblAttempts.Text = "Attempts: 0";
                lblTheNumberIs.Text = "The number is...";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for limits.");
            }
        }
    }
}
