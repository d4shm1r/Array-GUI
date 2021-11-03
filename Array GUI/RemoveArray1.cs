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

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            TextBox myForm1TextBox = (Parent.Controls["textBox1"] as TextBox);
            myForm1TextBox.Text = String.Empty;
        }
    }
}
