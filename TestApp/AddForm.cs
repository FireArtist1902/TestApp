using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class AddForm : Form
    {
        bool isSubject = false;
        string subjectName;
        public AddForm()
        {
            InitializeComponent();
            isSubject = true;
        }

        public AddForm(string subject)
        {
            InitializeComponent();
            subjectName = subject;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory($@"C:\Users\Вадим\source\repos\TestApp\TestApp\bin\Debug\net6.0-windows\Subjects");
            if (isSubject)
            {
                Directory.CreateDirectory(Name.Text);
            }
            else
            {
                if (subjectName != null)
                {
                    Directory.SetCurrentDirectory(subjectName);
                    Directory.CreateDirectory(Name.Text);
                }
            }
            Close();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Directory.SetCurrentDirectory($@"C:\Users\Вадим\source\repos\TestApp\TestApp\bin\Debug\net6.0-windows");
        }
    }
}
