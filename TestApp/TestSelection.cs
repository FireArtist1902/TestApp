using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestApp
{
    public partial class TestSelection : Form
    {
        List<string> subjects;
        List<string> grades;
        List<string> tests;
        int selected;
        int gradeSelected;



        public TestSelection(User user)
        {
            InitializeComponent();
            subjects = Directory.GetDirectories("Subjects").ToList<string>();
            if (user.IsTeacher)
            {
                TeacherGB.Enabled = true;
                TeacherGB.Visible = true;
            }
            else
            {
                TeacherGB.Enabled = false;
                TeacherGB.Visible = false;
            }
            foreach (var item in subjects)
            {
                string temp = item.Remove(0, 9);
                SubjectsCB.Items.Add(temp);
            }
        }

        public void Refresh()
        {
            subjects.Clear();
            SubjectsCB.Items.Clear();
            subjects = Directory.GetDirectories("Subjects").ToList<string>();
            foreach (var item in subjects)
            {
                string temp = item.Remove(0, 9);
                SubjectsCB.Items.Add(temp);
            }
            GradesCB.Items.Clear();
            grades.Clear();

            grades = Directory.GetDirectories(@$"Subjects\{SubjectsCB.Items[selected]}").ToList<string>();
            foreach (var item in grades)
            {
                string temp = item.Remove(0, 9 + SubjectsCB.Items[selected].ToString().Length);
                GradesCB.Items.Add(temp);
            }

            TestsCB.Items.Clear();
            tests.Clear();
            tests = Directory.GetFiles(@$"Subjects\{SubjectsCB.Items[selected]}\{GradesCB.Items[gradeSelected]}").ToList<string>();
            foreach (var item in tests)
            {
                string temp = item.Remove(0, 9 + SubjectsCB.Items[selected].ToString().Length + 3);
                string temp1 = temp.Remove(temp.Length - 5);
                TestsCB.Items.Add(temp1);
            }
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
            Refresh();
        }

        private void SubjectsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectsCB.SelectedIndex != -1)
            {
                selected = SubjectsCB.SelectedIndex;
                GradesCB.Enabled = true;
                grades = Directory.GetDirectories(@$"Subjects\{SubjectsCB.Items[selected]}").ToList<string>();
                foreach (var item in grades)
                {
                    string temp = item.Remove(0, 10 + SubjectsCB.Items[selected].ToString().Length);
                    GradesCB.Items.Add(temp);
                }
                AddGradeBtn.Enabled = true;
            }
            else
            {
                AddGradeBtn.Enabled = false;
            }
        }

        private void GradesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GradesCB.SelectedIndex != -1)
            {

                gradeSelected = GradesCB.SelectedIndex;
                TestsCB.Enabled = true;
                tests = Directory.GetFiles(@$"Subjects\{SubjectsCB.Items[selected]}\{GradesCB.Items[gradeSelected]}").ToList<string>();
                foreach (var item in tests)
                {
                    string temp = item.Remove(0, 9 + SubjectsCB.Items[selected].ToString().Length + 3);
                    string temp1 = temp.Remove(temp.Length - 5);
                    TestsCB.Items.Add(temp1);
                }
                CreateTestBtn.Enabled = true;
                ImportTestBtn.Enabled = true;
            }
            else
            {
                CreateTestBtn.Enabled = false;
                ImportTestBtn.Enabled = false;
            }
        }

        private void AddGradeBtn_Click(object sender, EventArgs e)
        {
            AddForm Add = new AddForm(SubjectsCB.Items[selected].ToString());
            Add.ShowDialog();
            Refresh();
        }

        private void CreateTestBtn_Click(object sender, EventArgs e)
        {
            TestCreation test = new TestCreation(SubjectsCB.Text, GradesCB.Text);
            test.ShowDialog();
        }

        private void TestsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectsCB.SelectedIndex != -1)
            {
                CompleteTestBtn.Enabled = true;
            }
            else
            {
                CompleteTestBtn.Enabled = false;
            }
        }

        private void ImportTestBtn_Click(object sender, EventArgs e)
        {
            OpenFile.ShowDialog();
        }

        private void OpenFile_FileOk(object sender, CancelEventArgs e)
        {
            string name = OpenFile.SafeFileName;
            FileStream file = File.Create($@"Subjects\{SubjectsCB.Items[selected]}\{GradesCB.Items[gradeSelected]}\{name}");
            file.Close();
            File.Copy(OpenFile.FileName, $@"Subjects\{SubjectsCB.Items[selected]}\{GradesCB.Items[gradeSelected]}\{name}", true);
            Refresh();
        }

        private void CompleteTestBtn_Click(object sender, EventArgs e)
        {
            PassingTest passing = new PassingTest(SubjectsCB.Items[selected].ToString(), GradesCB.Items[gradeSelected].ToString(), TestsCB.Items[TestsCB.SelectedIndex].ToString());
            passing.ShowDialog();
        }
    }
}
