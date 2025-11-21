using System;
using System.Windows.Forms;

namespace ProjectContingencyPredictionApp
{
	public partial class RiskForm : Form
	{
		public decimal CostTimeFactorsSum { get; set; }

		public RiskForm(decimal costTimeSum)
		{
			InitializeComponent();
			CostTimeFactorsSum = costTimeSum;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btn_next_Click(object sender, EventArgs e)
		{
			int index = 1;
			decimal riskFactorsSum = 0;

			decimal value1 = 0;
			decimal value2 = 0;
			decimal value3 = 0;

			// Assuming your textboxes are named textBox1, textBox2, ..., textBox12
			foreach (Control control in this.Controls)
			{
				if (control is System.Windows.Forms.TextBox textBox)
				{
					if (decimal.TryParse(textBox.Text, out decimal value))
					{
						if (index == 1)
						{
							value1 = value;
						}

						if (index == 2)
						{
							value2 = value;
						}
						if (index == 3)
						{
							value3 = value;
							var sumOf3inputs = (value1 * value2 * value3);
							riskFactorsSum += sumOf3inputs;
							index = 0; // Reset Index
						}

						index++;

					}
					else
					{
						// Handle invalid input (e.g., display an error message)
						MessageBox.Show("Please enter valid values in all inputs.");
						return;
					}
				}
			}

			var totalSum = riskFactorsSum + CostTimeFactorsSum;
			ResultForm timeForm = new ResultForm(totalSum);
			timeForm.Show();
			this.Hide();
		}

		private void RiskForm_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox12_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox27_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox36_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox15_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox18_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox21_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox24_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox30_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox33_TextChanged(object sender, EventArgs e)
		{

		}

		private void label24_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}
	}

}
