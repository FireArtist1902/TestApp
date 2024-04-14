namespace TestApp
{
    partial class TestSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubjectsCB = new ComboBox();
            GradesCB = new ComboBox();
            TestsCB = new ComboBox();
            TeacherGB = new GroupBox();
            DeleteTestBtn = new Button();
            CreateTestBtn = new Button();
            ImportTestBtn = new Button();
            AddGradeBtn = new Button();
            AddSubjectBtn = new Button();
            TeacherGB.SuspendLayout();
            SuspendLayout();
            // 
            // SubjectsCB
            // 
            SubjectsCB.FormattingEnabled = true;
            SubjectsCB.Location = new Point(12, 12);
            SubjectsCB.Name = "SubjectsCB";
            SubjectsCB.Size = new Size(151, 28);
            SubjectsCB.TabIndex = 0;
            SubjectsCB.Text = "Предмет";
            SubjectsCB.SelectedIndexChanged += SubjectsCB_SelectedIndexChanged;
            // 
            // GradesCB
            // 
            GradesCB.Enabled = false;
            GradesCB.FormattingEnabled = true;
            GradesCB.Location = new Point(180, 12);
            GradesCB.Name = "GradesCB";
            GradesCB.Size = new Size(151, 28);
            GradesCB.TabIndex = 1;
            GradesCB.Text = "Клас";
            GradesCB.SelectedIndexChanged += GradesCB_SelectedIndexChanged;
            // 
            // TestsCB
            // 
            TestsCB.Enabled = false;
            TestsCB.FormattingEnabled = true;
            TestsCB.Location = new Point(362, 12);
            TestsCB.Name = "TestsCB";
            TestsCB.Size = new Size(151, 28);
            TestsCB.TabIndex = 2;
            TestsCB.Text = "Тести";
            // 
            // TeacherGB
            // 
            TeacherGB.Controls.Add(DeleteTestBtn);
            TeacherGB.Controls.Add(CreateTestBtn);
            TeacherGB.Controls.Add(ImportTestBtn);
            TeacherGB.Controls.Add(AddGradeBtn);
            TeacherGB.Controls.Add(AddSubjectBtn);
            TeacherGB.Location = new Point(12, 46);
            TeacherGB.Name = "TeacherGB";
            TeacherGB.Size = new Size(501, 125);
            TeacherGB.TabIndex = 3;
            TeacherGB.TabStop = false;
            // 
            // DeleteTestBtn
            // 
            DeleteTestBtn.AutoSize = true;
            DeleteTestBtn.Location = new Point(350, 73);
            DeleteTestBtn.Name = "DeleteTestBtn";
            DeleteTestBtn.Size = new Size(136, 30);
            DeleteTestBtn.TabIndex = 5;
            DeleteTestBtn.Text = "Видалити тест";
            DeleteTestBtn.UseVisualStyleBackColor = true;
            DeleteTestBtn.Click += DeleteTestBtn_Click;
            // 
            // CreateTestBtn
            // 
            CreateTestBtn.AutoSize = true;
            CreateTestBtn.Location = new Point(178, 73);
            CreateTestBtn.Name = "CreateTestBtn";
            CreateTestBtn.Size = new Size(136, 30);
            CreateTestBtn.TabIndex = 4;
            CreateTestBtn.Text = "Створити тест";
            CreateTestBtn.UseVisualStyleBackColor = true;
            CreateTestBtn.Click += CreateTestBtn_Click;
            // 
            // ImportTestBtn
            // 
            ImportTestBtn.AutoSize = true;
            ImportTestBtn.Location = new Point(6, 73);
            ImportTestBtn.Name = "ImportTestBtn";
            ImportTestBtn.Size = new Size(136, 30);
            ImportTestBtn.TabIndex = 3;
            ImportTestBtn.Text = "Імпортувати тест";
            ImportTestBtn.UseVisualStyleBackColor = true;
            // 
            // AddGradeBtn
            // 
            AddGradeBtn.AutoSize = true;
            AddGradeBtn.Location = new Point(178, 16);
            AddGradeBtn.Name = "AddGradeBtn";
            AddGradeBtn.Size = new Size(132, 30);
            AddGradeBtn.TabIndex = 1;
            AddGradeBtn.Text = "Додати клас";
            AddGradeBtn.UseVisualStyleBackColor = true;
            AddGradeBtn.Click += AddGradeBtn_Click;
            // 
            // AddSubjectBtn
            // 
            AddSubjectBtn.AutoSize = true;
            AddSubjectBtn.Location = new Point(6, 16);
            AddSubjectBtn.Name = "AddSubjectBtn";
            AddSubjectBtn.Size = new Size(132, 30);
            AddSubjectBtn.TabIndex = 0;
            AddSubjectBtn.Text = "Додати предмет";
            AddSubjectBtn.UseVisualStyleBackColor = true;
            AddSubjectBtn.Click += AddSubjectBtn_Click;
            // 
            // TestSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(TeacherGB);
            Controls.Add(TestsCB);
            Controls.Add(GradesCB);
            Controls.Add(SubjectsCB);
            Name = "TestSelection";
            TeacherGB.ResumeLayout(false);
            TeacherGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox SubjectsCB;
        private ComboBox GradesCB;
        private ComboBox TestsCB;
        private GroupBox TeacherGB;
        private Button AddGradeBtn;
        private Button AddSubjectBtn;
        private Button DeleteTestBtn;
        private Button CreateTestBtn;
        private Button ImportTestBtn;
    }
}