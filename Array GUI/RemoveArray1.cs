﻿using System;
using System.Data;
using System.Linq;
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

                // Get value from numericUpDown1
                int val = Convert.ToInt32(numericUpDown1.Value);

                // Divide ExcistArr into two sub arrays
                int[] FirstArr = ExcistArr.Take(val).ToArray();
                int[] SecondArr = ExcistArr.Skip(val).ToArray();

                // Method 1: Remove first item of SecondArr
                SecondArr = SecondArr.Skip(1).ToArray();

                // Method 2: Remove last item of FirstArr
                // FirstArr = FirstArr.Take(FirstArr.Length - 1).ToArray();

                // New array with size of FirstArr + SecondArr items
                int[] NewArr = new int[FirstArr.Length + SecondArr.Length];

                // Join two subArrays into one array NewArr
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

        private void RemoveArray1_Load(object sender, EventArgs e) {

        }
    }
}
