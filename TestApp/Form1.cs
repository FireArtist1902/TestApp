using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace TestApp
{
    public partial class Form1 : Form
    {

        List<User> Teachers;

        List<User> Students;

        private bool IsExist(User user, List<User> users)
        {
            foreach (var items in users)
            {
                if (user.Login == items.Login && user.Password == items.Password && user.IsStudent == items.IsStudent && user.IsTeacher == items.IsTeacher)
                {
                    return true;
                }
            }
            return false;
        }
        public Form1()
        {
            InitializeComponent();
            string fileName = @"C:\Users\Вадим\source\repos\TestApp\TestApp\Teachers.json";
            string jsonString = File.ReadAllText(fileName);
            Teachers = JsonSerializer.Deserialize<List<User>>(jsonString)!;
            fileName = @"C:\Users\Вадим\source\repos\TestApp\TestApp\Students.json";
            jsonString = File.ReadAllText(fileName);
            Students = JsonSerializer.Deserialize<List<User>>(jsonString);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text != "" && PasswordTB.Text != "" && (TeacherRB.Checked != false || StudentRB.Checked != false))
            {
                User user = new User() { Login = LoginTB.Text, Password = PasswordTB.Text, IsStudent = StudentRB.Checked, IsTeacher = TeacherRB.Checked };
                if (user.IsTeacher)
                {
                    if (!IsExist(user, Teachers))
                    {
                        Teachers.Add(user);
                        string json = JsonSerializer.Serialize(Teachers);
                        File.WriteAllText(@"C:\Users\Вадим\source\repos\TestApp\TestApp\Teachers.json", json);
                        TestSelection test = new TestSelection(user);
                        test.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        TestSelection test = new TestSelection(user);
                        test.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    if (!IsExist(user, Students))
                    {
                        Students.Add(user);
                        string json = JsonSerializer.Serialize(Students);
                        File.WriteAllText(@"C:\Users\Вадим\source\repos\TestApp\TestApp\Students.json", json);
                        TestSelection test = new TestSelection(user);
                        test.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        TestSelection test = new TestSelection(user);
                        test.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не всі поля заповнені");
            }
        }
    }
}