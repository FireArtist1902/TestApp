using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class PassingTest : Form
    {
        List<Test> test;

        decimal point = 0;

        int index = 0;

        private void Testing()
        {
            Scores.Text = test[index].Point.ToString();
            List<string> answers = new List<string>();
            foreach (var item in test[index].Answers)
            {
                answers.Add(item);

            }
            foreach (var item in test[index].CorrectAnswers)
            {
                answers.Add(item);
            }
            Random random = new Random();
            for (int i = answers.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                string temp = answers[j];
                answers[j] = answers[i];
                answers[i] = temp;
            }
            TaskLb.Text = test[index].Task;
            if (test[index].IsMultiple)
            {
                ListAns.Enabled = false;
                ListAns.Visible = false;
                AnsCB.Enabled = true;
                AnsCB.Visible = true;

                foreach (var item in answers)
                {
                    AnsCB.Items.Add(item);
                }
            }
            else
            {
                ListAns.Enabled = true;
                ListAns.Visible = true;
                AnsCB.Enabled = false;
                AnsCB.Visible = false;
                foreach (var item in answers)
                {
                    ListAns.Items.Add(item);
                }
            }
        }

        public PassingTest(string subject, string grade, string testName)
        {
            InitializeComponent();
            string path = $@"Subjects\{subject}\{grade}\{testName}.json";
            using (StreamReader sr = File.OpenText(path))
            {
                string json = sr.ReadToEnd();
                test = JsonSerializer.Deserialize<List<Test>>(json);

            }
        }

        private void AnsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListAns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassingTest_Load(object sender, EventArgs e)
        {
            Testing();
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {

            if (test[index].IsMultiple)
            {
                List<string> answ = AnsCB.CheckedItems.Cast<string>().ToList();
                if (answ == test[index].CorrectAnswers)
                {
                    point += test[index].Point;
                }

            }
            else
            {
                if (ListAns.Items[ListAns.SelectedIndex] == test[index].CorrectAnswers[0])
                {
                    point += test[index].Point;
                }
            }

            if (index != test.Count - 1)
            {
                index++;
                Testing();
            }
            else
            {
                MessageBox.Show($"Ваш результат: {point}", "", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
