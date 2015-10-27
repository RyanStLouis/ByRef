/*
 * Created by: Ryan St. Louis
 * Created on: 27-10-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#4-02
 * This program displays rounds the number with decimals.
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

namespace ByRef
{
    public partial class frmByRef : Form
    {
        private void RoundNumber(ref Label answer, double number)
        {
            answer.Text = Convert.ToString(Math.Round(number, 1));
        }

        public frmByRef()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double numberInput;

            numberInput = Convert.ToDouble(this.txtAnswer.Text);

            RoundNumber(ref this.lblAnswer, numberInput);
        }
    }
}
