using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_GUI {
    public partial class RemoveArray1 : UserControl {
        public RemoveArray1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                // Get current array of int from TextBox1-Form1
                // as string and convert to int of array again
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                int[] ExcistArr = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

                // Remove the first item of array
                ExcistArr = ExcistArr.Skip(1).ToArray();

                // Output the array as string
                myForm1TextBox.Text = string.Join(",", ExcistArr);
            } 

            catch(Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            try {
                // Get current array of int from TextBox1-Form1
                // as string and convert to int of array again
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                int[] ExcistArr = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

                // Get value from numericUpDown1
                int val = Convert.ToInt32(numericUpDown1.Value);

                // ExcistArr = ExcistArr.Where(valParam => valParam != val).ToArray();

                /*
                 * Method 1
                 * Removing last item array of first sub array
                 * newArr = newArr.Take(newArr.Length - 1).ToArray();
                 * 
                 * 
                 * Method 2
                 * Removing first array item of lasr sub array
                 * restOfArr = restOfArr.Skip(1).ToArray();
                 */

                //newArr.CopyTo(ExcistArr, 0);
                //restOfArr.CopyTo(ExcistArr, val);

                //int[] newArr = ExcistArr.Take(val).ToArray();
                //int[] restOfArr = ExcistArr.Skip(val).ToArray();
                //newArr = newArr.Take(newArr.Length - 1).ToArray();
                //restOfArr = restOfArr.Skip(1).ToArray();
                //newArr.CopyTo(ExcistArr, 0);
                //restOfArr.CopyTo(ExcistArr, val);


                //int[] leftArr = new int[val];
                //int[] rightArr = new int[ExcistArr.Length - val];
                //leftArr = ExcistArr.Take(val - 1).ToArray();
                //rightArr = ExcistArr.Skip(val).ToArray();

                //leftArr.CopyTo(ExcistArr, 0);
                //rightArr.CopyTo(ExcistArr, val);

                int[] FirstArr = ExcistArr.Take(val).ToArray();
                int[] SecondArr = ExcistArr.Skip(val).ToArray();

                // Method 1 Remove first item of SecondArr
                SecondArr = SecondArr.Skip(1).ToArray();

                // Method 2 Remove last item of FirstArr
                // FirstArr = FirstArr.Take(FirstArr.Length - 1).ToArray();

                int[] NewArr = new int[FirstArr.Length + SecondArr.Length];

                FirstArr.CopyTo(NewArr, 0);
                SecondArr.CopyTo(NewArr, val);

                // Output the array as string
                myForm1TextBox.Text = string.Join(",", NewArr);
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

                // Remove last item of array
                ExcistArr = ExcistArr.Take(ExcistArr.Length - 1).ToArray();

                // Output the array as string
                myForm1TextBox.Text = string.Join(",", ExcistArr);
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            // Clear textBox1 from the current array
            TextBox myForm1TextBox = (Parent.Controls["textBox1"] as TextBox);
            myForm1TextBox.Text = String.Empty;
        }
    }
}
