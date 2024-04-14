using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class TestSelection : Form
    {
        List<string> subjects;
        List<string> grades;
        List<string> tests;
        int selected;
        public TestSelection(User user)
        {
            InitializeComponent();
            subjects = Directory.GetDirectories("Subjects").ToList<string>();
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
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
            Refresh();
        }

        private void SubjectsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = SubjectsCB.SelectedIndex;
            GradesCB.Enabled = true;
            grades = Directory.GetDirectories(@$"Subjects\{SubjectsCB.Items[selected]}").ToList<string>();
            foreach (var item in grades)
            {
                string temp = item.Remove(0, 10 + SubjectsCB.Items[selected].ToString().Length);
                GradesCB.Items.Add(temp);
            }
        }

        private void GradesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestsCB.Enabled = true;
            tests = Directory.GetDirectories(@$"Subjects\{SubjectsCB.Items[selected]}\{GradesCB.Items[GradesCB.SelectedIndex]}").ToList<string>();
            foreach(var item in tests)
            {
                string temp = item.Remove(0, 9 + SubjectsCB.Items[selected].ToString().Length);
                GradesCB.Items.Add(temp);
            }
        }

        private void AddGradeBtn_Click(object sender, EventArgs e)
        {
            AddForm Add = new AddForm(SubjectsCB.Items[selected].ToString());
            Add.ShowDialog();
            Refresh();
        }

        private void DeleteTestBtn_Click(object sender, EventArgs e)
        {
            tests.Remove(TestsCB.Items[TestsCB.SelectedIndex].ToString());
        }
    }
}
