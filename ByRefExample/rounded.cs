/*
 * Created by: Perry Martin
 * Created on: 27-10-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#4-02
 * This program displays rounded number
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByRefExample
{
    public partial class frmRounded : Form
    {
        private void RoundNumber(ref Label answer, double number)
        {
            answer.Text = Convert.ToString(Math.Round(number, 1));
        }
    
        public frmRounded()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Double numberInput;

            numberInput = Convert.ToDouble(this.txtNumRound.Text);

            RoundNumber(ref this.lblAnswer, numberInput);
        }
    }
}
