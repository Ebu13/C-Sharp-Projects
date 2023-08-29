using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // Event handler for numeric buttons (0-9)
        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Append the clicked number to the label
            Calculate.AppendNumberToLabel(lblanswer, sender);
        }

        // Event handler for the delete button
        private void btndel_Click(object sender, EventArgs e)
        {
            // Delete the last character from the label
            Calculate.Delete(lblanswer);
        }

        // Event handler for the clear button
        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear the label
            Calculate.Clear(lblanswer);
        }

        // Event handler for operator buttons (+, -, *, /)
        private void btnOperator_Click(object sender, EventArgs e)
        {
            // Append the clicked operator to the label
            Calculate.AddProcess(lblanswer, sender);
        }

        // Event handler for the equals button
        private void btnequals_Click(object sender, EventArgs e)
        {
            // Calculate the expression and update the label with the result
            Calculate.Calc(lblanswer);
        }
    }
}