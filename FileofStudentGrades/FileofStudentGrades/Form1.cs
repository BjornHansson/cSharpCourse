using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileofStudentGrades
{
    public partial class Form1 : Form
    {
        StreamWriter fileWriter;
        FileStream output;
        StreamReader fileReader;
        String dataCache = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileChooser = new SaveFileDialog();
            fileChooser.Filter = "txt files (*.txt)|*.txt";
            DialogResult result = fileChooser.ShowDialog();
            string fileName;

            if (result == DialogResult.Cancel)
                return;

            fileName = fileChooser.FileName;

            if (fileName == "" | fileName == null)
            {
                MessageBox.Show("Error in filename");
            }
            else
            {
                try
                {
                    output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                    fileWriter = new StreamWriter(output);

                    fileWriter.WriteLine(allGradesTextBox.Text);

                    fileWriter.Close();
                    output.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "txt files (*.txt)|*.txt";
            DialogResult result = fileChooser.ShowDialog();
            string fileName;

            if (result == DialogResult.Cancel)
                return;

            fileName = fileChooser.FileName;

            try
            {
                output = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                fileReader = new StreamReader(output);

                string inputLine;
                string[] fields;

                while (fileReader.EndOfStream != true)
                {
                    inputLine = fileReader.ReadLine();

                    if (!string.IsNullOrEmpty(inputLine))
                    {
                        fields = inputLine.Split(' ');
                        allGradesTextBox.Text += fields[1] + ", ";
                        allGradesTextBox.Text += fields[2] + ", ";
                        allGradesTextBox.Text += fields[3] + ", ";
                        allGradesTextBox.Text += "\r\n";
                    }
                }
                dataCache += allGradesTextBox.Text;

                statusLabel.Text = "File loaded";

                fileReader.Close();
                output.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (dataCache != "")
            {
                dataCache += "\r\n";
            }
            dataCache += lastNameBox.Text + ", ";
            dataCache += firstNameBox.Text + ": ";
            dataCache += idBox.Text + " ";
            dataCache += classBox.Text + " ";
            dataCache += gradeBox.Text;

            allGradesTextBox.Text = dataCache;
            statusLabel.Text = "Entry saved";

            lastNameBox.Text = "";
            firstNameBox.Text = "";
            idBox.Text = "";
            classBox.Text = "";
            gradeBox.Text = "";
        }
    }
}
