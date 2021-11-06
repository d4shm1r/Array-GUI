using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_GUI {
    class Sorting {
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

        public void MergeSort() {

        }

        public void InverseMergeSort() {

        }

        public void QuickSort() {

        }

        public void InverseQuickSort() {

        }

        public void InsertionSort() {

        }

        public void InverseInsertionSort() {

        }

        public void SelectionSort() {

        }

        public void InverseSelectionSort() {

        }
    }
}
