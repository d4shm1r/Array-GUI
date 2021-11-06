using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Array_GUI {
    public partial class sortArray1 : UserControl {
        public sortArray1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                // This increases the array

                // Get current array of int from TextBox1-Form1
                // as string and convert to int of array again
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                int[] arrToBeSorted = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

                // Declare object s to access Class Sorting
                Sorting s = new Sorting();

                // Combobox items that will be used to switch statement
                var strItem = comboBox1.SelectedItem.ToString();


                switch (strItem) {
                    case "Bubble Sort":
                        s.BubbleSort(arrToBeSorted);
                        break;
                    case "Merge Sort":
                        s.MergeSort();
                        break;
                    case "Quick Sort":
                        s.QuickSort();
                        break;
                    case "Insertion Sort":
                        s.InsertionSort();
                        break;
                    case "Selection Sort":
                        s.SelectionSort();
                        break;
                }

                // Output the sorted array
                myForm1TextBox.Text = string.Join(",", arrToBeSorted).ToString();
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                // This decreases the array

                // Get current array of int from TextBox1-Form1
                // as string and convert to int of array again
                TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
                int[] arrToBeSorted = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

                // Declare object s to access Class Sorting
                Sorting s = new Sorting();

                // Combobox items that will be used to switch statement
                var strItem = comboBox1.SelectedItem.ToString();

                switch (strItem) {
                    case "Bubble Sort":
                        s.InverseBubbleSort(arrToBeSorted);
                        break;
                    case "Merge Sort":
                        s.InverseMergeSort();
                        break;
                    case "Quick Sort":
                        s.InverseQuickSort();
                        break;
                    case "Insertion Sort":
                        s.InverseInsertionSort();
                        break;
                    case "Selection Sort":
                        s.InverseSelectionSort();
                        break;
                }

                // Output the sorted array
                myForm1TextBox.Text = string.Join(",", arrToBeSorted).ToString();
            }

            catch (Exception exp) {
                MessageBox.Show(exp.Message);
            }
        }

        private void sortArray1_Load(object sender, EventArgs e) {

        }
    }
}
