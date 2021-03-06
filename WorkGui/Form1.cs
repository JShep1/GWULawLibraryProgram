﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FileSplit;
using classesForLibraryExcel;
using System.Collections;
using LibraryProject;


namespace WindowsFormsApplication1{
      
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String studentDataFile = "";
        public String reqCourseFile = "";
        public String getStudFile (){
            return studentDataFile;
        }
        public string getCourseFile() {
            return reqCourseFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentDataFile == "" || reqCourseFile == "")
            {
                System.Windows.Forms.MessageBox.Show("Please select the proper files before generating a spreadsheet.");
                return;
            }
            if (!(studentDataFile.Contains(".txt")) || !(reqCourseFile.Contains(".txt")))
            {
                System.Windows.Forms.MessageBox.Show("Files are not properly formatted. Simple text files (.txt) are accepted.");
                return;
            }
            requiredClasses obj = new requiredClasses(this.textBox2.Text, this.textBox1.Text);
            MainClass.Start(obj);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                studentDataFile = openFileDialog1.FileName;
                this.textBox1.Text = studentDataFile;
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                reqCourseFile = openFileDialog1.FileName;
                this.textBox2.Text = reqCourseFile;
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
