using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Array_GUI {
    public partial class InsertArray1 : UserControl {
        public InsertArray1() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            // Enable
            numericUpDown1.Enabled = true;
            numericUpDown1.ReadOnly = false;
            button1.Enabled = true;

            // Disable
            numericUpDown2.Enabled = false;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.Enabled = false;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.Enabled = false;
            numericUpDown4.ReadOnly = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            // Enable
            numericUpDown2.Enabled = true;
            numericUpDown2.ReadOnly = false;
            numericUpDown3.Enabled = true;
            numericUpDown3.ReadOnly = false;
            button2.Enabled = true;

            // Disable
            numericUpDown1.Enabled = false;
            numericUpDown1.ReadOnly = true;
            numericUpDown4.Enabled = false;
            numericUpDown4.ReadOnly = true;
            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            // Enable
            numericUpDown4.Enabled = true;
            numericUpDown4.ReadOnly = false;
            button3.Enabled = true;

            // Disable
            numericUpDown1.Enabled = false;
            numericUpDown1.ReadOnly = true;
            numericUpDown2.Enabled = false;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.Enabled = false;
            numericUpDown3.ReadOnly = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {          
            try {
                // Get current array of int from TextBox1-Form1
                // as string and convert to int of array again
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                int[] ExcistArr = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

                // Convert the Input to a single item array
                int val = Convert.ToInt32(numericUpDown1.Value);
                int[] NewArr = new int[1];
                NewArr[0] = val;

                // Create array with size textBox1 + numericUpDown1 value
                int[] ModifiedArr = new int[NewArr.Length + ExcistArr.Length];

                // Insert the first array from arr[0] the rest will be added from arr[NewArr.Length]
                NewArr.CopyTo(ModifiedArr, 0);
                ExcistArr.CopyTo(ModifiedArr, NewArr.Length);

                // Output the new Array and reset the Input
                myForm1TextBox.Text = string.Join(",", ModifiedArr);
                numericUpDown1.ResetText();
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                // Get current array of int from TextBox1-Form1
                // as string and convert to int of array again
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                int[] ExcistArr = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

                // Position to insert array
                int nPosition = Convert.ToInt32(numericUpDown2.Value);

                // Split ExcistArr into two Smaller arrays
                int[] FirstArr = ExcistArr.Take(nPosition).ToArray();
                int[] SecondArr = ExcistArr.Skip(nPosition).ToArray();

                // Convert the Input to a single object array
                int val = Convert.ToInt32(numericUpDown3.Value);
                int[] NewArr = new int[1];
                NewArr[0] = val;

                // Create array with size FirstArr + NewArr + SecondArr
                int[] ModifiedArr = new int[FirstArr.Length + NewArr.Length + SecondArr.Length];

                // Insert FirstArr then the Input then the rest SecondArr
                FirstArr.CopyTo(ModifiedArr, 0);
                NewArr.CopyTo(ModifiedArr, nPosition);
                SecondArr.CopyTo(ModifiedArr, FirstArr.Length + NewArr.Length);

                // Output the new Array and reset the Input
                myForm1TextBox.Text = string.Join(",", ModifiedArr);
                numericUpDown3.ResetText();
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                // Get current array of int from TextBox1-Form1
                // as string and convert to int of array again
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                int[] ExcistArr = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

                // Convert the Input to a single item array
                int val = Convert.ToInt32(numericUpDown4.Value);
                int[] NewArr = new int[1];
                NewArr[0] = val;

                // Create array with size textBox1 + numericUpDown4 value
                int[] ModifiedArr = new int[NewArr.Length + ExcistArr.Length];

                // Insert the first item to arr[0] the rest will be added at arr[ExcistArr.Length]
                // Notice the difference beetween line 83-84 and line 146-147
                ExcistArr.CopyTo(ModifiedArr, 0);
                NewArr.CopyTo(ModifiedArr, ExcistArr.Length);

                // Output the new Array and reset the Input
                myForm1TextBox.Text = string.Join(",", ModifiedArr);
                numericUpDown4.ResetText();
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void InsertArray1_Load(object sender, EventArgs e) {
            // Default radio button is selected
            radioButton1.Checked = checked(true);
        }
    }
}
