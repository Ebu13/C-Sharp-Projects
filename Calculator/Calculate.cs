using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Calculator
{
    internal static class Calculate
    {
        // Appends the clicked number to the label
        internal static void AppendNumberToLabel(Label label, object button)
        {
            if (button is Button btn && int.TryParse(btn.Text, out int number))
            {
                // If the current label text is "0", replace it with the number; otherwise, append the number
                label.Text = label.Text == "0" ? number.ToString() : label.Text + number.ToString();
            }
        }

        // Clears the label
        internal static void Clear(Label lblanswer)
        {
            lblanswer.Text = "0";
        }

        // Deletes the last character from the label
        internal static void Delete(Label lblanswer)
        {
            if (lblanswer.Text.Length > 0)
                lblanswer.Text = lblanswer.Text[..^1];

            // If the label is empty after deletion, set it to "0"
            if (string.IsNullOrEmpty(lblanswer.Text))
                lblanswer.Text = "0";
        }

        // Appends the clicked operator to the label if no operator is already at the end
        internal static void AddProcess(Label lblanswer, object sender)
        {
            Button operatorButton = (Button)sender;
            string operatorSymbol = operatorButton.Text;

            if (!(lblanswer.Text.EndsWith("*") || lblanswer.Text.EndsWith("/")
                || lblanswer.Text.EndsWith("+") || lblanswer.Text.EndsWith("-")))
            {
                lblanswer.Text += operatorSymbol;
            }
        }

        // Evaluates the expression in the label and displays the result
        internal static void Calc(Label lblanswer)
        {
            if (!(lblanswer.Text.EndsWith("*") || lblanswer.Text.EndsWith("/")
                || lblanswer.Text.EndsWith("+") || lblanswer.Text.EndsWith("-")))
            {
                try
                {
                    // Evaluate the expression using DataTable.Compute and update the label with the result
                    double result = Calculate.EvaluateExpression(lblanswer.Text);
                    lblanswer.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        // Evaluates a mathematical expression and returns the result
        internal static double EvaluateExpression(string expression) {
            return Convert.ToDouble(new System.Data.DataTable().Compute(expression, ""));
        }
    }
}
