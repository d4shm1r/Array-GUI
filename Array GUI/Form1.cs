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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            createArray11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e) {
            insertArray11.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e) {
            sortArray11.BringToFront();
        }
        private void button4_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            // Default Window to front
            createArray11.BringToFront();
        }
    }
}
