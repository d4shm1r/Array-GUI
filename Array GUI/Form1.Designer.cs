
namespace Array_GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sortArray11 = new Array_GUI.sortArray1();
            this.insertArray11 = new Array_GUI.InsertArray1();
            this.createArray11 = new Array_GUI.CreateArray1();
            this.removeArray11 = new Array_GUI.RemoveArray1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 450);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 167);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(559, 20);
            this.textBox1.TabIndex = 2;
            // 
            // sortArray11
            // 
            this.sortArray11.Location = new System.Drawing.Point(192, 79);
            this.sortArray11.Name = "sortArray11";
            this.sortArray11.Size = new System.Drawing.Size(596, 359);
            this.sortArray11.TabIndex = 5;
            // 
            // insertArray11
            // 
            this.insertArray11.Location = new System.Drawing.Point(192, 79);
            this.insertArray11.Name = "insertArray11";
            this.insertArray11.Size = new System.Drawing.Size(596, 359);
            this.insertArray11.TabIndex = 4;
            // 
            // createArray11
            // 
            this.createArray11.Location = new System.Drawing.Point(192, 79);
            this.createArray11.Name = "createArray11";
            this.createArray11.Size = new System.Drawing.Size(596, 359);
            this.createArray11.TabIndex = 3;
            // 
            // removeArray11
            // 
            this.removeArray11.Location = new System.Drawing.Point(192, 79);
            this.removeArray11.Name = "removeArray11";
            this.removeArray11.Size = new System.Drawing.Size(596, 359);
            this.removeArray11.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeArray11);
            this.Controls.Add(this.sortArray11);
            this.Controls.Add(this.insertArray11);
            this.Controls.Add(this.createArray11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private CreateArray1 createArray11;
        private InsertArray1 insertArray11;
        private sortArray1 sortArray11;
        private RemoveArray1 removeArray11;
    }
}

