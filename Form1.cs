using System.Drawing.Text;

namespace ConcertTickets
{
    public partial class Form1 : Form
    {
        int amount;
        int cost;
        public Form1()
        {
            // To initialize the combobox component
            InitializeComponent();

            cboxType.Items.Add("Regular ($50.00)");
            cboxType.Items.Add("Premium ($150.00)");
            cboxType.Items.Add("Pit ($300.00)");
            cboxType.SelectedIndex = 0;

            numAmount.Minimum = 1;
            numAmount.Maximum = 10;
            numAmount.Value = 1;
            numAmount.Increment = 1;

            amount = (int)numAmount.Value;
            UpdateCost();
            UpdateTotal();

            numAmount.ValueChanged += numAmount_ValueChanged;
            cboxType.SelectedIndexChanged += cboxType_SelectedIndexChanged;
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            amount = (int)numAmount.Value;
            UpdateTotal();
        }

        private void cboxType_SelectedIndexChanged(object sencer, EventArgs e)
        {
            UpdateCost();
            UpdateTotal();
        }

        private void UpdateCost()
        {
            string choice = cboxType.SelectedItem.ToString();
            if (choice.Contains("Regular"))
            {
                cost = 50;
            }
            else if (choice.Contains("Premium"))
            {
                cost = 150;
            }
            else if (choice.Contains("Pit"))
            {
                cost = 300;
            }
        }

        private void UpdateTotal()
        {
            txtTotal.Text = (amount * cost).ToString("C2");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your purchase of, " + (amount * cost).ToString("C2") + "\nCan't wait to see you at the concert!");
        }
    }
}
