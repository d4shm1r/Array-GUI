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
    public partial class sortArray1 : UserControl {
        public sortArray1() {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            // Sort Algortithms Choose one
            // Sort Methods From Smallest to largest or vice versa
            // TODO button1 button2 and sorting methods


            var selektedItem = comboBox1.SelectedItem;
            label2.Text = selektedItem.ToString();

            TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
            int[] arrToBeSorted = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

            switch (selektedItem.ToString()) {
                case "Bubble Sort":
                    BubbleSort(arrToBeSorted);
                    break;
                case "Merge Sort":
                    MergeSort(arrToBeSorted);
                    break;
                case "Quick Sort":
                    QuickSort();
                    break;
                case "Insertion Sort":
                    InsertionSort();
                    break;
                case "Selection Sort":
                    SelectionSort();
                    break;
            }

            myForm1TextBox.Text = string.Join(",", arrToBeSorted);
        }

        public void BubbleSort(int[] arr) {
            int tempMemory;

            for (int i = 1; i <= arr.Length - 2; i++) {
                for (int j = 0; j <= arr.Length - 2; j++) {
                    int curentNumber = arr[j];
                    int nextNumber = arr[j + 1];


                    if (curentNumber > nextNumber) {
                        tempMemory = nextNumber;
                        nextNumber = curentNumber;
                        curentNumber = tempMemory;
                    }
                }
            }
        }

        public void MergeSort(int[] arr) {

        }

        public void QuickSort() {

        }

        public void InsertionSort() {

        }

        public void SelectionSort() {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }
    }
}
