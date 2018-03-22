using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: Tolulope Adebayo
 * Created on: 22-March-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates the factorial of a number given by the user
*/

namespace FactorialDoWhileToluA
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Identify all Constants and variables 
            Double factorialNumber;
            Double factorialAnswer;
            int factorialCounter;
            // Clear Items From the list Box
            this.lstFactorialNumber.Items.Clear();
            // initialize the Factorial answer to 1
            factorialAnswer = 1;
            // Get Number From The User
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);
            // Set Factorial Counter To 0
            factorialCounter = 0;
            // Multiply The Counter by the next incremented number unril it reaches the users Number
            do
            {
                // Add Increment by 1
                factorialCounter = factorialCounter + 1;
                // list the Factorial numbers for the user to see
                this.lstFactorialNumber.Items.Add(factorialCounter);
                //multipily the answer by the counter
                factorialAnswer = factorialAnswer * factorialCounter;
            } while (factorialNumber != factorialCounter);
            //Convert factorial answer to a string and add it to a label
            this.lblAnswer.Text = this.txtNumber.Text + "!=" + Convert.ToString(factorialAnswer);



        }
    }
}
