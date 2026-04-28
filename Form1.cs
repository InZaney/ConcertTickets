using System.Drawing.Text;

namespace ConcertTickets
{
    public partial class Form1 : Form
    {
        int amount;
        int cost;
        public Form1()
        {
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

    }
}
