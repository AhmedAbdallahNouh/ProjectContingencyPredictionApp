using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectContingencyPredictionApp
{
	public partial class ResultForm : Form
	{
		public ResultForm(decimal totalSum)
		{
			InitializeComponent();
			//totalSum = Math.Round(totalSum);
			decimal roundedValue = Math.Round(totalSum, 4);

			var formattedPercentage = (roundedValue * 100);
			formattedPercentage = Math.Round(formattedPercentage, 2);

			lblResult.Text = $"The Perdicted Project Contingency for ICLP is [{roundedValue}] as a Percentage is [{formattedPercentage} % ] ";
			//label2.Text = $"";

		}

		private void ResultForm_Load(object sender, EventArgs e)
		{

		}

		private void lblResult_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			CostForm costForm = new CostForm();
			costForm.Show();
			this.Hide();
		}
	}

}
