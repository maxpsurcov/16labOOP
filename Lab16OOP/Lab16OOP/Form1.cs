using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16OOP
{
    public partial class Form1 : Form
    {
        private List<Fraction> fractions;
        public Form1()
        {
            InitializeComponent();

            fractions = new List<Fraction>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int numerator = int.Parse(numeratorTextBox.Text);
            int denominator = int.Parse(denominatorTextBox.Text);
            Fraction fraction = new Fraction(numerator, denominator);
            fractions.Add(fraction);
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            fractionsListBox.Items.Clear();
            foreach (Fraction fraction in fractions)
            {
                fractionsListBox.Items.Add(fraction.ToString());
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            fractions.Sort((a, b) => a.ToDouble().CompareTo(b.ToDouble()));
            UpdateListBox();
        }

        private void addFractionsButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            Fraction result = fractions[index1].Add(fractions[index2]);
            fractions.RemoveAt(index2);
            fractions[index1] = result;
            UpdateListBox();
        }

        private void subtractFractionsButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            Fraction result = fractions[index1].Subtract(fractions[index2]);
            fractions.RemoveAt(index2);
            fractions[index1] = result;
            UpdateListBox();
        }

        private void multiplyFractionsButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            Fraction result = fractions[index1].Multiply(fractions[index2]);
            fractions.RemoveAt(index2);
            fractions[index1] = result;
            UpdateListBox();
        }

        private void divideFractionsButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            Fraction result = fractions[index1].Divide(fractions[index2]);
            fractions.RemoveAt(index2);
            fractions[index1] = result;
            UpdateListBox();
        }

        private void reduceButton_Click(object sender, EventArgs e)
        {
            int index = fractionsListBox.SelectedIndex;
            if (index < 0) return;
            fractions[index].Reduce();
            UpdateListBox();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            int index = fractionsListBox.SelectedIndex;
            if (index < 0) return;
            int n = int.Parse(powerTextBox.Text);
            Fraction result = fractions[index].Power(n);
            fractions[index] = result;
            UpdateListBox();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            bool result = fractions[index1] == fractions[index2];
            MessageBox.Show(result.ToString());
        }

        private void notEqualButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            bool result = fractions[index1] != fractions[index2];
            MessageBox.Show(result.ToString());
        }

        private void greaterThanButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            bool result = fractions[index1] > fractions[index2];
            MessageBox.Show(result.ToString());
        }

        private void lessThanButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            bool result = fractions[index1] < fractions[index2];
            MessageBox.Show(result.ToString());
        }

        private void greaterThanOrEqualButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            bool result = fractions[index1] >= fractions[index2];
            MessageBox.Show(result.ToString());
        }

        private void lessThanOrEqualButton_Click(object sender, EventArgs e)
        {
            int index1 = fractionsListBox.SelectedIndex;
            int index2 = fractionsListBox.SelectedIndex + 1;
            if (index1 < 0 || index2 >= fractions.Count) return;
            bool result = fractions[index1] <= fractions[index2];
            MessageBox.Show(result.ToString());
        }
    }
    
}
