using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMuaBanXeMay.WF
{
    public partial class Form_NhapSLPT : Form
    {
        private ComboBox numberComboBox;
        private Button selectButton;

        public int SelectedValue { get; private set; }  // Property to store the selected value

        public Form_NhapSLPT(int N)
        {

            // Set form to appear in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Form Configuration
            this.Text = "Chọn số lượng cần mua";
            this.Width = 300;
            this.Height = 200;

            // Initialize the ComboBox
            numberComboBox = new ComboBox();
            numberComboBox.Top = 20;
            numberComboBox.Left = 50;
            numberComboBox.Width = 200;

            // Populate ComboBox with numbers from 1 to N
            for (int i = 1; i <= N; i++)
            {
                numberComboBox.Items.Add(i);
            }

            // Initialize the Select Button
            selectButton = new Button();
            selectButton.Text = "Xác nhận";
            selectButton.Top = 60;
            selectButton.Left = 50;
            selectButton.Width = 200;
            selectButton.Click += new EventHandler(SelectButton_Click);

            // Add ComboBox and Button to the form
            this.Controls.Add(numberComboBox);
            this.Controls.Add(selectButton);
        }

        // Event handler for the Select Button click
        private void SelectButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (numberComboBox.SelectedItem != null)
            {
                SelectedValue = (int)numberComboBox.SelectedItem;

                this.DialogResult = DialogResult.OK;  // Set dialog result to OK
                this.Close();  // Close the form and return control to the caller
            }
            else
            {
                MessageBox.Show("Please select a number.", "No Selection");
            }
        }
    }
}