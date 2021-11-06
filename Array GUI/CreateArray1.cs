using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Array_GUI {
    public partial class CreateArray1 : UserControl {
        public CreateArray1() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            // Enable
            textBox1.Enabled = true;
            textBox1.ReadOnly = false;
            button1.Enabled = true;

            // Disable
            numericUpDown1.Enabled = false;
            numericUpDown1.ReadOnly = true;
            button2.Enabled = false;
            button3.Enabled = false;
            listBox1.SelectionMode = SelectionMode.None;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            // Enable
            numericUpDown1.Enabled = true;
            numericUpDown1.ReadOnly = false;
            button2.Enabled = true;
            button3.Enabled = true;
            listBox1.SelectionMode = SelectionMode.One;

            // Disable
            textBox1.Enabled = false;
            textBox1.ReadOnly = true;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                // Convert input of user to an array of integers
                string ArrayText = textBox1.Text;
                int[] arr = ArrayText.Split(',').Select(int.Parse).ToArray();

                // Output to the textBox1-Form1
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                myForm1TextBox.Text = string.Join(",", arr);

                // Clear the textBox1-CreateArray1
                textBox1.Text = string.Empty;
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                // Convert Input to array of integers
                string ValueText = numericUpDown1.Text;
                int arrItem = Convert.ToInt32(ValueText);

                // Add items to listBox1
                listBox1.Items.Add(arrItem.ToString());

                // Clear the Input
                numericUpDown1.Text = string.Empty;
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                // Convert listBox items to array of integers
                int[] listArr = new int[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++) {
                    listArr[i] = Convert.ToInt32(listBox1.Items[i]);
                }

                // Output the array to the TextBox1-Form1
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                myForm1TextBox.Text = string.Join(",", listArr);

                // Clear numericUpDown1
                numericUpDown1.Text = string.Empty;

                // Clear the listBox
                listBox1.Items.Clear();
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void CreateArray1_Load(object sender, EventArgs e) {
            // Default radio button is selected
            radioButton1.Checked = checked(true);
        }
    }
}
