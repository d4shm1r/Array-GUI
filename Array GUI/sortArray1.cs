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
        bool btn1Click = false;
        bool btn2Click = false;
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

            if (selektedItem.ToString() == "Bubble Sort") {
                BubbleSort(arrToBeSorted);
            }

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
                    if (arr[j] > arr[j + 1]) {
                        tempMemory = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tempMemory;
                    }
                }
            }
        }
        public void InverseBubbleSort(int[] arr) {
            int tempMemory;

            for (int i = 1; i <= arr.Length - 2; i++) {
                for (int j = 0; j <= arr.Length - 2; j++) {
                    if (arr[j] < arr[j + 1]) {
                        tempMemory = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tempMemory;
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
            // This increases the array
            btn1Click = true;
            btn2Click = false;

            TextBox myForm1TextBox = (ParentForm.Controls["textBox1"] as TextBox);
            int[] arrToBeSorted = myForm1TextBox.Text.Split(',').Select(int.Parse).ToArray();

            var strItem = comboBox1.SelectedItem;
            if (btn1Click && (strItem.ToString() == "Bubble Sort")) {
                BubbleSort(arrToBeSorted);
            } else {
                InverseBubbleSort(arrToBeSorted);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            // This decreases the array
            btn1Click = false;
            btn2Click = true;
        }
    }
}
