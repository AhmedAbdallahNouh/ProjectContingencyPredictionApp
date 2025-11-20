using System;
using System.Windows.Forms;

namespace ProjectContingencyPredictionApp
{
	public partial class TimeForm : Form
	{
		public decimal CostFactorsSum { get; set; }
		public TimeForm(decimal costSum)
		{
			InitializeComponent();
			CostFactorsSum = costSum;

			//textBox1.Text = "0.1026";
			//textBox1.ReadOnly = true;

			//firsttxtbx.Text = "0.0423";
			//firsttxtbx.ReadOnly = true;

			//textBox9.Text = "0.0203";
			//textBox9.ReadOnly = true;

			//textBox12.Text = "0.0175";
			//textBox12.ReadOnly = true;

			//textBox27.Text = "0.0175";
			//textBox27.ReadOnly = true;

			
			//textBox15.Text = "0.0097";
			//textBox15.ReadOnly = true;

			//textBox18.Text = "0.0111";
			//textBox18.ReadOnly = true;

		}

		private void totla_land_size_Click(object sender, EventArgs e)
		{

		}

		private void TimeForm_Load(object sender, EventArgs e)
		{

		}

		private void next_to_risk_Click(object sender, EventArgs e)
		{
			int index = 1;
			decimal timeFactorsSum = 0;

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
							timeFactorsSum += sumOf3inputs;
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

			var costTimeFactorSum = timeFactorsSum + CostFactorsSum;
			RiskForm timeForm = new RiskForm(costTimeFactorSum);
			timeForm.Show();
			this.Hide();
		}

		private void distance_mall_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
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

		private void label42_Click(object sender, EventArgs e)
		{

		}

		private void label41_Click(object sender, EventArgs e)
		{

		}

		private void label40_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void firsttxtbx_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged_1(object sender, EventArgs e)
		{

		}
	}

}
