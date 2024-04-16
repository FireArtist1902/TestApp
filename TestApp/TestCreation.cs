using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class TestCreation : Form
    {
        private List<string> answers = new List<string>();
        private List<string> correctAnswers = new List<string>();
        List<Test> tests = new List<Test>();
        bool isClose = false;

        string subject;
        string grade;
        public TestCreation(string subject, string grade)
        {
            InitializeComponent();
            this.subject = subject;
            this.grade = grade;
        }

        private void SubmitAnswerBTN_Click(object sender, EventArgs e)
        {
            answers.Add(PossibleTB.Text);
            NumAnswers.Text = answers.Count.ToString();
            PossibleTB.Text = "";
        }

        private void SubmitCorrectBtn_Click(object sender, EventArgs e)
        {
            if (correctAnswers.Count == 1 && !IsMultipleCB.Checked)
            {
                MessageBox.Show("Щоб додати 2 або більше правильних відповідей ввімкніть відповідний прапорець", "Не можливо додати", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                correctAnswers.Add(CorrectTB.Text);
                NumCorrectAnswers.Text = correctAnswers.Count.ToString();
                CorrectTB.Text = "";
            }
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            if (TaskTB.Text != "" || correctAnswers.Count != 0)
            {
                Test test = new Test() { Task = TaskTB.Text, Answers = answers.ToList<string>(), CorrectAnswers = correctAnswers.ToList<string>(), Image = pictureBox1.Image, IsMultiple = IsMultipleCB.Checked, Point = Score.Value };
                tests.Add(test);
            }
            else
            {
                MessageBox.Show("Ви не заповнили всі обов'язкові поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TaskTB.Text = "";
            CorrectTB.Text = "";
            PossibleTB.Text = "";
            NumAnswers.Text = "0";
            NumCorrectAnswers.Text = "0";
            correctAnswers.Clear();
            answers.Clear();
            pictureBox1.Image = null;
            Score.Value = 0;
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            if (TestNameTB.Text != "")
            {
                string json = JsonSerializer.Serialize(tests);
                using (StreamWriter sw = File.CreateText($@"Subjects\{subject}\{grade}\{TestNameTB.Text}.json"))
                {
                    sw.Write(json);
                }
            }
            this.Close();
            Refresh();
        }

        private void TestCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void TestCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
