using System;

using System.Windows.Forms;

namespace ProjectContingencyPredictionApp
{
	public partial class CostForm : Form
	{
		
		public CostForm()
		{
			InitializeComponent();

			textBox1.Text = "0.0545";
			textBox1.ReadOnly = true;
			
			firsttxtbx.Text = "0.0351";
			firsttxtbx.ReadOnly = true;

			textBox9.Text = "0.0367";
			textBox9.ReadOnly = true;

			textBox12.Text = "0.0187";
			textBox12.ReadOnly = true;

			textBox27.Text = "0.0502";
			textBox27.ReadOnly = true;

			textBox15.Text = "0.0189";
			textBox15.ReadOnly = true;

			textBox18.Text = "0.0451";
			textBox18.ReadOnly = true;

			textBox21.Text = "0.0814";
			textBox21.ReadOnly = true;

			
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Gross_Area_Click(object sender, EventArgs e)
		{

		}


		private void btn_next_to_time_factor_Click(object sender, EventArgs e)
		{
			int index = 1;
			decimal costFactorsSum = 0;

			decimal value1 = 0;
			decimal value2 = 0;
			decimal value3 = 0;


			// Assuming your textboxes are named textBox1, textBox2, ..., textBox12
			foreach (Control control in this.Controls)
			{
				if (control is TextBox textBox)
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
							decimal sumOf3inputs = (value1 * value2 * value3);
							costFactorsSum += sumOf3inputs;
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

			TimeForm timeForm = new TimeForm(costFactorsSum);
			timeForm.Show();
			this.Hide();

			//ResultForm resultForm = new ResultForm(costFactorsSum);
			//resultForm.Show();
			//this.Hide();

		}

		private void CostForm_Load(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox12_TextChanged(object sender, EventArgs e)
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

		private void label1_Click(object sender, EventArgs e)
		{

		}









		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			// Recalculate visible height and adjust the scroll bar

		}

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void label25_Click(object sender, EventArgs e)
		{

		}
	}
}
