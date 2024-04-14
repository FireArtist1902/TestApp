﻿namespace TestApp
{
    partial class TestCreation
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
            TaskTB = new TextBox();
            PossibleTB = new TextBox();
            SubmitAnswerBTN = new Button();
            pictureBox1 = new PictureBox();
            AddImageBtn = new Button();
            Files = new FileSystemWatcher();
            SubmitCorrectBtn = new Button();
            CorrectTB = new TextBox();
            IsMultipleCB = new CheckBox();
            AddNewBtn = new Button();
            EndBtn = new Button();
            Score = new NumericUpDown();
            label1 = new Label();
            TestNameTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Files).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Score).BeginInit();
            SuspendLayout();
            // 
            // TaskTB
            // 
            TaskTB.Location = new Point(12, 12);
            TaskTB.Multiline = true;
            TaskTB.Name = "TaskTB";
            TaskTB.PlaceholderText = "Запитання/завдання";
            TaskTB.Size = new Size(497, 129);
            TaskTB.TabIndex = 0;
            TaskTB.TextChanged += textBox1_TextChanged;
            // 
            // PossibleTB
            // 
            PossibleTB.Location = new Point(12, 159);
            PossibleTB.Name = "PossibleTB";
            PossibleTB.PlaceholderText = "Варіант відповіді";
            PossibleTB.Size = new Size(182, 27);
            PossibleTB.TabIndex = 1;
            // 
            // SubmitAnswerBTN
            // 
            SubmitAnswerBTN.Location = new Point(209, 157);
            SubmitAnswerBTN.Name = "SubmitAnswerBTN";
            SubmitAnswerBTN.Size = new Size(112, 29);
            SubmitAnswerBTN.TabIndex = 2;
            SubmitAnswerBTN.Text = "Підтвердити";
            SubmitAnswerBTN.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(530, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 129);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AddImageBtn
            // 
            AddImageBtn.AutoSize = true;
            AddImageBtn.Location = new Point(628, 159);
            AddImageBtn.Name = "AddImageBtn";
            AddImageBtn.Size = new Size(160, 30);
            AddImageBtn.TabIndex = 4;
            AddImageBtn.Text = "Додати зображення";
            AddImageBtn.UseVisualStyleBackColor = true;
            // 
            // Files
            // 
            Files.EnableRaisingEvents = true;
            Files.SynchronizingObject = this;
            // 
            // SubmitCorrectBtn
            // 
            SubmitCorrectBtn.Location = new Point(209, 203);
            SubmitCorrectBtn.Name = "SubmitCorrectBtn";
            SubmitCorrectBtn.Size = new Size(112, 29);
            SubmitCorrectBtn.TabIndex = 6;
            SubmitCorrectBtn.Text = "Підтвердити";
            SubmitCorrectBtn.UseVisualStyleBackColor = true;
            // 
            // CorrectTB
            // 
            CorrectTB.Location = new Point(12, 204);
            CorrectTB.Name = "CorrectTB";
            CorrectTB.PlaceholderText = "Правильний варіант";
            CorrectTB.Size = new Size(182, 27);
            CorrectTB.TabIndex = 5;
            // 
            // IsMultipleCB
            // 
            IsMultipleCB.AutoSize = true;
            IsMultipleCB.Location = new Point(343, 159);
            IsMultipleCB.Name = "IsMultipleCB";
            IsMultipleCB.Size = new Size(258, 24);
            IsMultipleCB.TabIndex = 7;
            IsMultipleCB.Text = "Декілька правильних відповідей";
            IsMultipleCB.UseVisualStyleBackColor = true;
            // 
            // AddNewBtn
            // 
            AddNewBtn.AutoSize = true;
            AddNewBtn.Location = new Point(351, 202);
            AddNewBtn.Name = "AddNewBtn";
            AddNewBtn.Size = new Size(200, 30);
            AddNewBtn.TabIndex = 8;
            AddNewBtn.Text = "Додати ще одне завдання";
            AddNewBtn.UseVisualStyleBackColor = true;
            // 
            // EndBtn
            // 
            EndBtn.AutoSize = true;
            EndBtn.Location = new Point(581, 202);
            EndBtn.Name = "EndBtn";
            EndBtn.Size = new Size(121, 30);
            EndBtn.TabIndex = 9;
            EndBtn.Text = "Завершити";
            EndBtn.UseVisualStyleBackColor = true;
            // 
            // Score
            // 
            Score.Location = new Point(12, 248);
            Score.Name = "Score";
            Score.Size = new Size(150, 27);
            Score.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 255);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 11;
            label1.Text = "Бал за правильну відповідь";
            // 
            // TestNameTB
            // 
            TestNameTB.Location = new Point(491, 255);
            TestNameTB.Multiline = true;
            TestNameTB.Name = "TestNameTB";
            TestNameTB.PlaceholderText = "Назва тесту";
            TestNameTB.Size = new Size(339, 52);
            TestNameTB.TabIndex = 12;
            TestNameTB.TextChanged += textBox1_TextChanged_1;
            // 
            // TestCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(842, 319);
            Controls.Add(TestNameTB);
            Controls.Add(label1);
            Controls.Add(Score);
            Controls.Add(EndBtn);
            Controls.Add(AddNewBtn);
            Controls.Add(IsMultipleCB);
            Controls.Add(SubmitCorrectBtn);
            Controls.Add(CorrectTB);
            Controls.Add(AddImageBtn);
            Controls.Add(pictureBox1);
            Controls.Add(SubmitAnswerBTN);
            Controls.Add(PossibleTB);
            Controls.Add(TaskTB);
            Name = "TestCreation";
            Text = "Створення тесту";
            Load += TestCreation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Files).EndInit();
            ((System.ComponentModel.ISupportInitialize)Score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskTB;
        private TextBox PossibleTB;
        private Button SubmitAnswerBTN;
        private PictureBox pictureBox1;
        private Button AddImageBtn;
        private FileSystemWatcher Files;
        private Button AddNewBtn;
        private CheckBox IsMultipleCB;
        private Button SubmitCorrectBtn;
        private TextBox CorrectTB;
        private Button EndBtn;
        private TextBox TestNameTB;
        private Label label1;
        private NumericUpDown Score;
    }
}